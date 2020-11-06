using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using YiSha.Business.OrganizationManage;
using YiSha.Entity.OrganizationManage;
using YiSha.Enum;
using YiSha.Model.Param.OrganizationManage;
using YiSha.Model.Result.OrganizationManage;
using YiSha.Model.Result.SystemManage;
using YiSha.Util;
using YiSha.Util.Model;
using YiSha.Web.Code;

namespace YiSha.Admin.WebApi.Controllers
{
    /// <summary>
    /// 系统用户控制器
    /// </summary>
    [Route("[controller]/[action]")]
    [ApiController]
    [AuthorizeFilter]
    public class UserController : ControllerBase
    {
        private UserBLL userBLL = new UserBLL();

        #region 获取数据    
        /// <summary>
        /// 获取分页数据列表
        /// </summary>
        /// <param name="listParam">小程序列表参数</param>
        /// <returns></returns>
        [HttpPost]
        public async Task<TData<List<UserEntity>>> GetPageListJson([FromBody] WebApi_TerInforListParam listParam)
        {
            TData<List<UserEntity>> obj = new TData<List<UserEntity>>();
            obj.SetDefault();
            try
            {
                LogHelper.Info("【GetPageListJson】 listParam："+JsonHelper.SerializeObject(listParam));
                OperatorInfo opuser = await Web.Code.Operator.Instance.Current(listParam.ApiToken);

                obj = await userBLL.GetPageList(listParam.ListParam, listParam.Pagination, opuser, PlatformEnum.WebApi);
            }
            catch(Exception ex)
            {
                LogHelper.Info("【GetPageListJson】 ex：" + ex.ToString());
            }
            return obj;
        }

        #endregion

        #region 提交数据
        /// <summary>
        /// 用户登录
        /// </summary>
        /// <param name="entity">登录信息实体</param>
        /// <returns></returns>
        [HttpPost]
        public async Task<TData<OperatorInfo>> Login([FromBody] UserCheckLoginParam entity)
        {
            //string userName, string password,
            // string openid, string wx_nikename, string head_img, int sex,
            TData<OperatorInfo> obj = new TData<OperatorInfo>();
            TData<UserEntity> userObj =
                await userBLL.CheckLogin(entity.UserName, entity.Password, entity.Openid,
                entity.WxNikeName,
                entity.Headimg, entity.Sex,
                (int)PlatformEnum.WebApi);
            if (userObj.Tag == 1)
            {
                await new UserBLL().UpdateUser(userObj.Data);
                await Operator.Instance.AddCurrent(userObj.Data.ApiToken);
                obj.Data = await Operator.Instance.Current(userObj.Data.ApiToken);
            }
            obj.Tag = userObj.Tag;
            obj.Message = userObj.Message;
            return obj;
        }

        /// <summary>
        /// 用户登录
        /// </summary>
        /// <param name="entity">登录信息实体</param>
        /// <returns></returns>
        [HttpPost]
        public async Task<TData<OperatorInfo>> CheckOpenId([FromBody] UserCheckLoginParam entity)
        {
            //string userName, string password,
            // string openid, string wx_nikename, string head_img, int sex,
            TData<OperatorInfo> obj = new TData<OperatorInfo>();
            TData<UserEntity> userObj =
                await userBLL.CheckLogin(entity.Openid, (int)PlatformEnum.WebApi);
            if (userObj.Tag == 1)
            {
                await new UserBLL().UpdateUser(userObj.Data);
                await Operator.Instance.AddCurrent(userObj.Data.ApiToken);
                obj.Data = await Operator.Instance.Current(userObj.Data.ApiToken);
            }
            obj.ErrorCode = userObj.ErrorCode;
            obj.Tag = userObj.Tag;
            obj.Message = userObj.Message;
            //LogHelper.Info("【CheckOpenId2】 Data："+JsonHelper.SerializeObject(obj.Data));
            return obj;
        }

        /// <summary>
        /// 用户退出登录
        /// </summary>
        /// <param name="token"></param>
        /// <returns></returns>
        [HttpPost]
        public TData LoginOff([FromQuery] string token)
        {
            var obj = new TData();
            Operator.Instance.RemoveCurrent(token);
            obj.Message = "登出成功";
            return obj;
        }

        /// <summary>
        /// 用户注册
        /// </summary>
        /// <param name="entity">登录信息实体</param>
        /// <returns></returns>
        [HttpPost]
        public async Task<TData<string>> RegUser([FromBody] RegUserParam entity)
        {
            TData<string> obj = await new UserBLL().RegUser(entity);
            return obj;
        }

        /// <summary>
        /// 查看个人信息
        /// </summary>
        /// <param name="id">用户id</param>
        /// <returns></returns>
        [HttpPost]
        public async Task<TData<ViewUserInfor>> ViewUser([FromQuery] long id)
        {
            TData<ViewUserInfor> obj = await new UserBLL().ViewUserEntity(id);
            return obj;
        }

        /// <summary>
        /// 修改密码
        /// </summary>
        /// <param name="entity">登录信息实体</param>
        /// <returns></returns>
        [HttpPost]
        public async Task<TData<string>> ModifyPwd([FromBody] UserModifyPwdParam entity)
        {
            TData<string> obj = await new UserBLL().ModifyPwd(entity);
            return obj;
        }
        #endregion
    }
}