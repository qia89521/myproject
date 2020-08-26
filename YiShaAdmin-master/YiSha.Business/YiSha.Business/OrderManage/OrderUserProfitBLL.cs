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
    /// 日 期：2020-08-25 17:43
    /// 描 述：订单用户收益业务类
    /// </summary>
    public class OrderUserProfitBLL
    {
        private OrderUserProfitService orderUserProfitService = new OrderUserProfitService();

        #region 获取数据
        public async Task<TData<List<OrderUserProfitEntity>>> GetList(OrderUserProfitListParam param)
        {
            TData<List<OrderUserProfitEntity>> obj = new TData<List<OrderUserProfitEntity>>();
            obj.Data = await orderUserProfitService.GetList(param);
            obj.Total = obj.Data.Count;
            obj.Tag = 1;
            return obj;
        }

        public async Task<TData<List<OrderUserProfitEntity>>> GetPageList(OrderUserProfitListParam param, Pagination pagination)
        {
            TData<List<OrderUserProfitEntity>> obj = new TData<List<OrderUserProfitEntity>>();
            obj.Data = await orderUserProfitService.GetPageList(param, pagination);
            obj.Total = pagination.TotalCount;
            obj.Tag = 1;
            return obj;
        }

        public async Task<TData<OrderUserProfitEntity>> GetEntity(long id)
        {
            TData<OrderUserProfitEntity> obj = new TData<OrderUserProfitEntity>();
            obj.Data = await orderUserProfitService.GetEntity(id);
            if (obj.Data != null)
            {
                obj.Tag = 1;
            }
            return obj;
        }
        #endregion

        #region 提交数据
        public async Task<TData<string>> SaveForm(OrderUserProfitEntity entity)
        {
            TData<string> obj = new TData<string>();
            await orderUserProfitService.SaveForm(entity);
            obj.Data = entity.Id.ParseToString();
            obj.Tag = 1;
            return obj;
        }

        public async Task<TData> DeleteForm(string ids)
        {
            TData obj = new TData();
            await orderUserProfitService.DeleteForm(ids);
            obj.Tag = 1;
            return obj;
        }
        #endregion

        #region 私有方法
        #endregion
    }
}
