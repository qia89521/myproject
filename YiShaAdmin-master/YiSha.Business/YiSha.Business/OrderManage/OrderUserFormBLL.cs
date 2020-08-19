using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using YiSha.Util;
using YiSha.Util.Extension;
using YiSha.Util.Model;
using YiSha.Entity.OrderManage;
using YiSha.Model.Param.OrderManage;
using YiSha.Service.OrderManage;

namespace YiSha.Business.OrderManage
{
    /// <summary>
    /// 创 建：admin
    /// 日 期：2020-08-19 23:55
    /// 描 述：用户缴费订单记录业务类
    /// </summary>
    public class OrderUserFormBLL
    {
        private OrderUserFormService orderUserFormService = new OrderUserFormService();

        #region 获取数据
        public async Task<TData<List<OrderUserFormEntity>>> GetList(OrderUserFormListParam param)
        {
            TData<List<OrderUserFormEntity>> obj = new TData<List<OrderUserFormEntity>>();
            obj.Data = await orderUserFormService.GetList(param);
            obj.Total = obj.Data.Count;
            obj.Tag = 1;
            return obj;
        }

        public async Task<TData<List<OrderUserFormEntity>>> GetPageList(OrderUserFormListParam param, Pagination pagination)
        {
            TData<List<OrderUserFormEntity>> obj = new TData<List<OrderUserFormEntity>>();
            obj.Data = await orderUserFormService.GetPageList(param, pagination);
            obj.Total = pagination.TotalCount;
            obj.Tag = 1;
            return obj;
        }

        public async Task<TData<OrderUserFormEntity>> GetEntity(long id)
        {
            TData<OrderUserFormEntity> obj = new TData<OrderUserFormEntity>();
            obj.Data = await orderUserFormService.GetEntity(id);
            if (obj.Data != null)
            {
                obj.Tag = 1;
            }
            return obj;
        }
        #endregion

        #region 提交数据
        public async Task<TData<string>> SaveForm(OrderUserFormEntity entity)
        {
            TData<string> obj = new TData<string>();
            await orderUserFormService.SaveForm(entity);
            obj.Data = entity.Id.ParseToString();
            obj.Tag = 1;
            return obj;
        }

        public async Task<TData> DeleteForm(string ids)
        {
            TData obj = new TData();
            await orderUserFormService.DeleteForm(ids);
            obj.Tag = 1;
            return obj;
        }
        #endregion

        #region 私有方法
        #endregion
    }
}
