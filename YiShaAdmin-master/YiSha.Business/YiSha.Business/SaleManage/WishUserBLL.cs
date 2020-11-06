using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using YiSha.Util;
using YiSha.Util.Extension;
using YiSha.Util.Model;
using YiSha.Entity.SaleManage;
using YiSha.Model.Param.SaleManage;
using YiSha.Service.SaleManage;
using YiSha.Web.Code;

namespace YiSha.Business.SaleManage
{
    /// <summary>
    /// 创 建：admin
    /// 日 期：2020-09-01 15:48
    /// 描 述：意向用户业务类
    /// </summary>
    public class WishUserBLL
    {
        private WishUserService wishUserService = new WishUserService();

        #region 获取数据
        public async Task<TData<List<WishUserEntity>>> GetList(WishUserListParam param,OperatorInfo opuser)
        {
            TData<List<WishUserEntity>> obj = new TData<List<WishUserEntity>>();
            obj.Data = await wishUserService.GetList(param, opuser);
            obj.Total = obj.Data.Count;
            obj.Tag = 1;
            return obj;
        }

        public async Task<TData<List<WishUserEntity>>> GetPageList(WishUserListParam param, Pagination pagination,OperatorInfo opuser)
        {
            TData<List<WishUserEntity>> obj = new TData<List<WishUserEntity>>();
            obj.Data = await wishUserService.GetPageList(param, pagination, opuser);
            obj.Total = pagination.TotalCount;
            obj.PageTotal = pagination.TotalPage;
            obj.Tag = 1;
            return obj;
        }

        public async Task<TData<WishUserEntity>> GetEntity(long id)
        {
            TData<WishUserEntity> obj = new TData<WishUserEntity>();
            obj.Data = await wishUserService.GetEntity(id);
            if (obj.Data != null)
            {
                obj.Tag = 1;
            }
            return obj;
        }
        #endregion

        #region 提交数据
        public async Task<TData<string>> SaveForm(WishUserEntity entity)
        {
            TData<string> obj = new TData<string>();
            if (entity.MobilePhone.IsEmpty() || entity.RealName.IsEmpty())
            {
                obj.Message = "手机号和姓名不能为空";
                return obj;
            }

            WishUserEntity user = await wishUserService.GetEntityByPhone(entity.MobilePhone);
            if (user != null&&user.Id>0)
            {
                obj.Message = "您已经登记,不需要重复录入";
            }
            else
            {
                await wishUserService.SaveForm(entity);
                obj.Data = entity.Id.ParseToString();
                obj.Tag = 1;
            }

            return obj;
        }

        public async Task<TData> DeleteForm(string ids)
        {
            TData obj = new TData();
            await wishUserService.DeleteForm(ids);
            obj.Tag = 1;
            return obj;
        }
        #endregion

        #region 私有方法
        #endregion
    }
}
