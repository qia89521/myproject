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
    /// 日 期：2020-09-09 22:52
    /// 描 述：物料进货单业务类
    /// </summary>
    public class OrderTerInputBLL
    {
        private OrderTerInputService orderTerInputService = new OrderTerInputService();

        #region 获取数据
        public async Task<TData<List<OrderTerInputEntity>>> GetList(OrderTerInputListParam param)
        {
            TData<List<OrderTerInputEntity>> obj = new TData<List<OrderTerInputEntity>>();
            obj.Data = await orderTerInputService.GetList(param);
            obj.Total = obj.Data.Count;
            obj.Tag = 1;
            return obj;
        }

        public async Task<TData<List<OrderTerInputEntity>>> GetPageList(OrderTerInputListParam param, Pagination pagination)
        {
            TData<List<OrderTerInputEntity>> obj = new TData<List<OrderTerInputEntity>>();
            obj.Data = await orderTerInputService.GetPageList(param, pagination);
            obj.Total = pagination.TotalCount;
            obj.Tag = 1;
            return obj;
        }

        public async Task<TData<OrderTerInputEntity>> GetEntity(long id)
        {
            TData<OrderTerInputEntity> obj = new TData<OrderTerInputEntity>();
            obj.Data = await orderTerInputService.GetEntity(id);
            if (obj.Data != null)
            {
                obj.Tag = 1;
            }
            return obj;
        }
        #endregion

        #region 提交数据
        public async Task<TData<string>> SaveForm(OrderTerInputEntity entity)
        {
            TData<string> obj = new TData<string>();
            await orderTerInputService.SaveForm(entity);
            obj.Data = entity.Id.ParseToString();
            obj.Tag = 1;
            return obj;
        }

        public async Task<TData> DeleteForm(string ids)
        {
            TData obj = new TData();
            await orderTerInputService.DeleteForm(ids);
            obj.Tag = 1;
            return obj;
        }
        #endregion

        #region 私有方法
        #endregion
    }
}
