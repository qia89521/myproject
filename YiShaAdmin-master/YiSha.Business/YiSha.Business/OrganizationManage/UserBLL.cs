using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using YiSha.Business.Cache;
using YiSha.Business.SystemManage;
using YiSha.Cache.Factory;
using YiSha.Entity;
using YiSha.Entity.OrganizationManage;
using YiSha.Entity.SystemManage;
using YiSha.Enum;
using YiSha.Enum.OrganizationManage;
using YiSha.Model;
using YiSha.Model.Param;
using YiSha.Model.Param.OrganizationManage;
using YiSha.Model.Result.OrganizationManage;
using YiSha.Service.OrganizationManage;
using YiSha.Util;
using YiSha.Util.Extension;
using YiSha.Util.Model;
using YiSha.Web.Code;

namespace YiSha.Business.OrganizationManage
{
    public class UserBLL
    {
        private UserService userService = new UserService();
        private UserBelongService userBelongService = new UserBelongService();
        private DepartmentService departmentService = new DepartmentService();

        private DepartmentBLL departmentBLL = new DepartmentBLL();
        private RoleBLL roleBLL = new RoleBLL();

        #region 获取数据
        public async Task<TData<List<UserEntity>>> GetList(UserListParam param, OperatorInfo opuser)
        {
            TData<List<UserEntity>> obj = new TData<List<UserEntity>>();
            obj.Data = await userService.GetList(param, opuser);
            obj.Tag = 1;
            return obj;
        }

        /// <summary>
        /// 获取角色代码获取用户列表
        /// </summary>
        /// <param name="roleCode">角色代码</param>
        /// <returns></returns>
        public async Task<TData<List<UserEntity>>> GetListByRoleCode(string roleCode)
        {
            TData<List<UserEntity>> obj = new TData<List<UserEntity>>();
            obj.SetDefault();
            List<UserEntity> list = await userService.GetListByRoleCode(roleCode);
            if (list.Count > 0)
            {
                obj.Data = list;
                obj.Tag = 1;
                obj.Refresh();
            }
            else
            {
                obj.Message = "没有配置数据";
            }
            return obj;
        }

        public async Task<TData<List<UserEntity>>> GetPageList(UserListParam param, Pagination pagination, OperatorInfo opuser, PlatformEnum platformEnum = PlatformEnum.Web)
        {
            TData<List<UserEntity>> obj = new TData<List<UserEntity>>();
            if (platformEnum == PlatformEnum.Web)
            {
                if (param?.DepartmentId != null)
                {
                    param.ChildrenDepartmentIdList = await departmentBLL.GetChildrenDepartmentIdList(null, param.DepartmentId.Value);
                }
                else
                {
                    OperatorInfo user = await Operator.Instance.Current();
                    param.ChildrenDepartmentIdList = await departmentBLL.GetChildrenDepartmentIdList(null, user.DepartmentId.Value);
                }
            }
            obj.Data = await userService.GetPageList(param, pagination, opuser);
            if (platformEnum == PlatformEnum.Web)
            {
                List<UserBelongEntity> userBelongList = await userBelongService.GetList(new UserBelongEntity { UserIds = obj.Data.Select(p => p.Id.Value).ParseToStrings<long>() });
                List<DepartmentEntity> departmentList = await departmentService.GetList(new DepartmentListParam { Ids = userBelongList.Select(p => p.BelongId.Value).ParseToStrings<long>() });
                foreach (UserEntity user in obj.Data)
                {
                    user.DepartmentName = departmentList.Where(p => p.Id == user.DepartmentId).Select(p => p.DepartmentName).FirstOrDefault();
                }
            }
            else
            {
                foreach (UserEntity user in obj.Data)
                {
                    List<UserBelongEntity> userBelongList = await userBelongService.GetList(new UserBelongEntity { UserId = user.Id });
                    List<UserBelongEntity> roleBelongList = userBelongList.Where(p => p.BelongType == UserBelongTypeEnum.Role.ParseToInt()).ToList();
                    if (roleBelongList.Count > 0)
                    {
                        user.RoleIds = string.Join(",", roleBelongList.Select(p => p.BelongId).ToList());
                        await GetRoleCodes(user);
                    }
                }
            }
            obj.PageTotal = pagination.TotalPage;
            obj.Total = pagination.TotalCount;
            obj.Tag = 1;
            return obj;
        }
        /// <summary>
        /// 查看用户信息
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public async Task<TData<ViewUserInfor>> ViewUserEntity(long id)
        {
            TData<ViewUserInfor> obj = new TData<ViewUserInfor>();
            obj.SetDefault();
            try
            {
                TData<UserEntity> user = await GetEntity(id);
                if (user.Tag == 1)
                {
                    ViewUserInfor viewObj = new ViewUserInfor();
                    ClassValueCopierHelper.Copy(viewObj, user.Data);

                    obj.Data = viewObj;
                    obj.Tag = 1;
                    LogHelper.Info("【ViewUserEntity】 viewObj:" + JsonHelper.SerializeObject(viewObj));
                }
                else
                {
                    obj.Message = "用户不存在";
                }
            }
            catch (Exception ex)
            {
                LogHelper.Info("【ViewUserEntity】 ex:" + ex.ToString());
            }
            return obj;
        }

        public async Task<UserEntity> GetUserEnity(long id)
        {
            UserEntity entity = await userService.GetEntity(id);
            if (entity != null)
            {
                await GetUserBelong(entity);
            }
            return entity;
        }

        public async Task<TData<UserEntity>> GetEntity(long id)
        {
            TData<UserEntity> obj = new TData<UserEntity>();

            UserEntity entity = await userService.GetEntity(id);
            if (entity != null)
            {
                obj.Data = entity;

                await GetUserBelong(obj.Data);


                if (obj.Data.DepartmentId > 0)
                {
                    DepartmentEntity departmentEntity = await departmentService.GetEntity(obj.Data.DepartmentId.Value);
                    if (departmentEntity != null)
                    {
                        obj.Data.DepartmentName = departmentEntity.DepartmentName;
                    }
                }

                obj.Tag = 1;
            }
            else
            {
                obj.Message = "用户不存在";
            }
            return obj;
        }

        public async Task<TData<UserEntity>> CheckLogin(string userName, string password, int platform)
        {
            return await CheckLogin(userName, password, "", "", "", 0, platform);
        }


        public async Task<TData<UserEntity>> CheckLogin(string userName, string password,
            string openid, string wx_nikename, string head_img, int sex,
            int platform)
        {
            TData<UserEntity> obj = new TData<UserEntity>();
            if (userName.IsEmpty() || password.IsEmpty())
            {
                obj.Message = "用户名或密码不能为空";
                return obj;
            }
            UserEntity user = await userService.CheckLogin(userName);
            if (user != null)
            {
                if (user.UserStatus == (int)StatusEnum.Yes)
                {
                    if (user.Password == EncryptUserPassword(password, user.Salt))
                    {
                        //登录成功业务逻辑
                        await LoginSucessFullLogic(user, platform);
                        #region 更新用户头像和昵称信息
                        if (string.IsNullOrEmpty(user.OpenId))
                        {
                            user.OpenId = openid;
                            user.WxNickName = wx_nikename;
                            user.Gender = sex;
                            user.Portrait = head_img;

                            // await UpdateUser(user);
                        }
                        #endregion

                        obj.Data = user;
                        obj.Message = "登录成功";
                        obj.Tag = 1;
                    }
                    else
                    {
                        obj.Message = "密码不正确，请重新输入";
                    }
                }
                else
                {
                    obj.Message = "账号被禁用，请联系管理员";
                }
            }
            else
            {
                obj.Message = "账号不存在，请重新输入";
            }
            return obj;
        }

        /// <summary>
        /// 用户登录
        /// </summary>
        /// <param name="openid">当前用户openid</param>
        /// <param name="platform">登录方式</param>
        /// <returns></returns>
        public async Task<TData<UserEntity>> CheckLogin(string openid, int platform)
        {
            TData<UserEntity> obj = new TData<UserEntity>();

            UserEntity user = await userService.CheckBindOpenId(openid);
            if (user != null && user.Id > 0)
            {
                if (user.UserStatus == (int)StatusEnum.Yes)
                {
                    //登录成功业务逻辑
                    await LoginSucessFullLogic(user, platform);
                    obj.Data = user;
                    obj.Message = "登录成功";
                    obj.ErrorCode = "ok";
                    obj.Tag = 1;
                }
                else
                {
                    obj.ErrorCode = "fail";
                    obj.Message = "账号被禁用，请联系管理员";
                }
            }
            else
            {

                obj.ErrorCode = "ok";
                obj.Message = "用户没有绑定微信";
            }
            return obj;

        }
        #endregion

        #region 提交数据
        /// <summary>
        /// 用户注册
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public async Task<TData<string>> ModifyPwd(UserModifyPwdParam entity)
        {
            TData<string> obj = new TData<string>();
            try
            {
                obj.SetDefault();
                UserEntity userParent = await userService.GetEntity(long.Parse(entity.UserId));
                // LogHelper.Info("【RegUser】 entity:" + JsonHelper.SerializeObject(entity));
                if (userParent != null)
                {

                    LogHelper.Info("【RegUser】 Salt:" + userParent.Salt);
                    if (userParent.Password == EncryptUserPassword(entity.OldPwd, userParent.Salt))
                    {
                        userParent.Salt = GetPasswordSalt();
                        //LogHelper.Info("【RegUser】 Password ==");
                        userParent.Password = EncryptUserPassword(entity.NewPwd, userParent.Salt);
                        //LogHelper.Info("【RegUser】 EncryptUserPassword ==");
                        await userService.ResetPassword(userParent);
                        obj.Tag = 1;
                        obj.Message = "修改成功";
                    }
                    else
                    {
                        obj.Message = "旧密码错误，不能修改";
                    }
                }
                else
                {
                    obj.Message = "用户不存在";
                }
            }
            catch (Exception ex)
            {
                LogHelper.Info("【RegUser】 ex:" + ex.ToString());
            }
            return obj;
        }

        /// <summary>
        /// 用户注册
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public async Task<TData<string>> RegUser(RegUserParam entity)
        {
            TData<string> obj = new TData<string>();
            try
            {
                obj.SetDefault();

                UserEntity userParent = await GetUserEnity(long.Parse(entity.TJCode));
                LogHelper.Info("【RegUser】 userParent:" + JsonHelper.SerializeObject(userParent));
                if (userParent != null)
                {

                    TData<DepartmentEntity> department = await new DepartmentBLL().GetDefaultEndtity();
                    LogHelper.Info("【RegUser】 department:" + JsonHelper.SerializeObject(department));
                    if (department.Tag == 1)
                    {
                        TData<RoleEntity> roleEntity = await new RoleBLL().GetUserRole();
                        LogHelper.Info("【RegUser】 roleEntity:" + JsonHelper.SerializeObject(roleEntity));
                        if (roleEntity.Tag == 1)
                        {
                            UserEntity userEntity = new UserEntity();
                            ClassValueCopierHelper.Copy(userEntity, entity);

                            userEntity.DepartmentId = department.Data.Id;
                            userEntity.RoleIds = roleEntity.Data.Id + "";

                            userEntity.ParentId = userParent.Id;
                            userEntity.ParentTxt = userParent.ParentTxt;
                            userEntity.UserStatus = 1;

                            LogHelper.Info("【RegUser】 userEntity:" + JsonHelper.SerializeObject(userEntity));
                            obj = await SaveForm(userEntity);
                        }
                        else
                        {
                            obj.Message = roleEntity.Message;
                        }
                    }
                    else
                    {
                        obj.Message = department.Message;
                    }
                }
                else
                {
                    obj.Message = "推荐码不存在";
                }
            }
            catch (Exception ex)
            {
                LogHelper.Info("【RegUser】 ex:" + ex.ToString());
            }
            return obj;
        }


        public async Task<TData<string>> SaveForm(UserEntity entity)
        {
            TData<string> obj = new TData<string>();
            if (userService.ExistUserName(entity))
            {
                obj.Message = "用户名已经存在！";
                return obj;
            }
            if (entity.Id.IsNullOrZero())
            {
                entity.Salt = GetPasswordSalt();
                entity.Password = EncryptUserPassword(entity.Password, entity.Salt);
            }
            if (!entity.Birthday.IsEmpty())
            {
                entity.Birthday = entity.Birthday.ParseToDateTime().ToString("yyyy-MM-dd");
            }
            //设置grandparent
            if (entity.ParentId > 0)
            {
                var grandEntity = await GetEntity((long)entity.ParentId);
                if (grandEntity.Data != null && grandEntity.Data.Id > 0)
                {
                    entity.GrandParentId = grandEntity.Data.Id;
                    entity.GrandParentTxt = grandEntity.Data.RealName;
                }
            }
            if (entity.IsNullOrZero())
            {
                entity.ResetToken();
            }

            await userService.SaveForm(entity);

            await RemoveCacheById(entity.Id.Value);

            obj.Data = entity.Id.ParseToString();
            obj.Message = "注册成功";
            obj.Tag = 1;
            return obj;
        }

        public async Task<TData> DeleteForm(string ids)
        {
            TData obj = new TData();
            if (string.IsNullOrEmpty(ids))
            {
                obj.Message = "参数不能为空";
                return obj;
            }
            await userService.DeleteForm(ids);

            await RemoveCacheById(ids);

            obj.Tag = 1;
            return obj;
        }

        public async Task<TData<long>> ResetPassword(UserEntity entity)
        {
            TData<long> obj = new TData<long>();
            if (entity.Id > 0)
            {
                UserEntity dbUserEntity = await userService.GetEntity(entity.Id.Value);
                if (dbUserEntity.Password == entity.Password)
                {
                    obj.Message = "密码未更改";
                    return obj;
                }
                entity.Salt = GetPasswordSalt();
                entity.Password = EncryptUserPassword(entity.Password, entity.Salt);
                await userService.ResetPassword(entity);

                await RemoveCacheById(entity.Id.Value);

                obj.Data = entity.Id.Value;
                obj.Tag = 1;
            }
            return obj;
        }

        public async Task<TData<long>> ChangePassword(ChangePasswordParam param)
        {
            TData<long> obj = new TData<long>();
            if (param.Id > 0)
            {
                if (string.IsNullOrEmpty(param.Password) || string.IsNullOrEmpty(param.NewPassword))
                {
                    obj.Message = "新密码不能为空";
                    return obj;
                }
                UserEntity dbUserEntity = await userService.GetEntity(param.Id.Value);
                if (dbUserEntity.Password != EncryptUserPassword(param.Password, dbUserEntity.Salt))
                {
                    obj.Message = "旧密码不正确";
                    return obj;
                }
                dbUserEntity.Salt = GetPasswordSalt();
                dbUserEntity.Password = EncryptUserPassword(param.NewPassword, dbUserEntity.Salt);
                await userService.ResetPassword(dbUserEntity);

                await RemoveCacheById(param.Id.Value);

                obj.Data = dbUserEntity.Id.Value;
                obj.Tag = 1;
            }
            return obj;
        }

        /// <summary>
        /// 用户自己修改自己的信息
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public async Task<TData<long>> ChangeUser(UserEntity entity)
        {
            TData<long> obj = new TData<long>();
            if (entity.Id > 0)
            {
                await userService.ChangeUser(entity);

                await RemoveCacheById(entity.Id.Value);

                obj.Data = entity.Id.Value;
                obj.Tag = 1;
            }
            return obj;
        }

        public async Task<TData> UpdateUser(UserEntity entity)
        {
            TData obj = new TData();
            await userService.UpdateUser(entity);

            obj.Tag = 1;
            return obj;
        }



        public async Task<TData> ImportUser(ImportParam param, List<UserEntity> list)
        {
            TData obj = new TData();
            if (list.Any())
            {
                foreach (UserEntity entity in list)
                {
                    UserEntity dbEntity = await userService.GetEntity(entity.UserName);
                    if (dbEntity != null)
                    {
                        entity.Id = dbEntity.Id;
                        if (param.IsOverride == 1)
                        {
                            await userService.SaveForm(entity);
                            await RemoveCacheById(entity.Id.Value);
                        }
                    }
                    else
                    {
                        await userService.SaveForm(entity);
                        await RemoveCacheById(entity.Id.Value);
                    }
                }
                obj.Tag = 1;
            }
            else
            {
                obj.Message = " 未找到导入的数据";
            }
            return obj;
        }

        #endregion

        #region 私有方法

        /// <summary>
        /// 登录成功业务逻辑
        /// </summary>
        /// <param name="user">登录用户实体</param>
        /// <param name="platform">登录方式</param>
        private async Task LoginSucessFullLogic(UserEntity user, int platform)
        {
            user.LoginCount++;
            user.IsOnline = 1;

            #region 设置日期
            if (user.FirstVisit == GlobalConstant.DefaultTime)
            {
                user.FirstVisit = DateTime.Now;
            }
            if (user.PreviousVisit == GlobalConstant.DefaultTime)
            {
                user.PreviousVisit = DateTime.Now;
            }
            if (user.LastVisit != GlobalConstant.DefaultTime)
            {
                user.PreviousVisit = user.LastVisit;
            }
            user.LastVisit = DateTime.Now;
            #endregion

            switch (platform)
            {
                case (int)PlatformEnum.Web:
                    if (GlobalContext.SystemConfig.LoginMultiple)
                    {
                        #region 多次登录用同一个token
                        if (string.IsNullOrEmpty(user.WebToken))
                        {
                            user.WebToken = SecurityHelper.GetGuid();
                        }
                        #endregion
                    }
                    else
                    {
                        user.WebToken = SecurityHelper.GetGuid();
                    }
                    break;

                case (int)PlatformEnum.WebApi:
                    user.ApiToken = SecurityHelper.GetGuid();
                    break;
            }
            await GetUserBelong(user);
        }

        /// <summary>
        /// 密码MD5处理
        /// </summary>
        /// <param name="password"></param>
        /// <param name="salt"></param>
        /// <returns></returns>
        private string EncryptUserPassword(string password, string salt)
        {
            string md5Password = SecurityHelper.MD5Encrypt(password);
            string encryptPassword = SecurityHelper.MD5Encrypt(md5Password + salt);
            return encryptPassword;
        }

        /// <summary>
        /// 密码盐
        /// </summary>
        /// <returns></returns>
        private string GetPasswordSalt()
        {
            return new Random().Next(1, 100000).ToString();
        }

        /// <summary>
        /// 移除缓存里面的token
        /// </summary>
        /// <param name="id"></param>
        private async Task RemoveCacheById(string ids)
        {
            foreach (long id in ids.Split(',').Select(p => long.Parse(p)))
            {
                await RemoveCacheById(id);
            }
        }

        private async Task RemoveCacheById(long id)
        {
            var dbEntity = await userService.GetEntity(id);
            if (dbEntity != null)
            {
                CacheFactory.Cache.RemoveCache(dbEntity.WebToken);
            }
        }

        /// <summary>
        /// 获取用户的职位和角色
        /// </summary>
        /// <param name="user"></param>
        private async Task GetUserBelong(UserEntity user)
        {
            List<UserBelongEntity> userBelongList = await userBelongService.GetList(new UserBelongEntity { UserId = user.Id });

            List<UserBelongEntity> roleBelongList = userBelongList.Where(p => p.BelongType == UserBelongTypeEnum.Role.ParseToInt()).ToList();
            if (roleBelongList.Count > 0)
            {
                user.RoleIds = string.Join(",", roleBelongList.Select(p => p.BelongId).ToList());
            }

            List<UserBelongEntity> positionBelongList = userBelongList.Where(p => p.BelongType == UserBelongTypeEnum.Position.ParseToInt()).ToList();
            if (positionBelongList.Count > 0)
            {
                user.PositionIds = string.Join(",", positionBelongList.Select(p => p.BelongId).ToList());
            }

            //获取角色代码
            await GetRoleCodes(user);
        }

        /// <summary>
        /// 获取用户角色对应的角色编码
        /// </summary>
        /// <param name="user"></param>
        private async Task GetRoleCodes(UserEntity user)
        {
            var rolses = await roleBLL.GetList(user.RoleIds);

            if (rolses.Total > 0)
            {
                user.RoleCodes = string.Join(",", rolses.Data.Select(p => p.RoleCode).ToList());
                user.RoleTxts = string.Join(",", rolses.Data.Select(p => p.RoleName).ToList());
            }
        }
        #endregion
    }
}
