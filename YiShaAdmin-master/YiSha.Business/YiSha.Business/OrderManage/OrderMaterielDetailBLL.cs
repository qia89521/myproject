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
    /// 日 期：2020-09-08 18:14
    /// 描 述：物料明细业务类
    /// </summary>
    public class OrderMaterielDetailBLL
    {
        private OrderMaterielDetailService orderMaterielDetailService = new OrderMaterielDetailService();

        #region 获取数据
        public async Task<TData<List<OrderMaterielDetailEntity>>> GetList(OrderMaterielDetailListParam param)
        {
            TData<List<OrderMaterielDetailEntity>> obj = new TData<List<OrderMaterielDetailEntity>>();
            obj.Data = await orderMaterielDetailService.GetList(param);
            obj.Total = obj.Data.Count;
            obj.Tag = 1;
            return obj;
        }

        public async Task<TData<List<OrderMaterielDetailEntity>>> GetPageList(OrderMaterielDetailListParam param, Pagination pagination)
        {
            TData<List<OrderMaterielDetailEntity>> obj = new TData<List<OrderMaterielDetailEntity>>();
            obj.Data = await orderMaterielDetailService.GetPageList(param, pagination);
            obj.Total = pagination.TotalCount;
            obj.Tag = 1;
            return obj;
        }

        public async Task<TData<OrderMaterielDetailEntity>> GetEntity(long id)
        {
            TData<OrderMaterielDetailEntity> obj = new TData<OrderMaterielDetailEntity>();
            obj.Data = await orderMaterielDetailService.GetEntity(id);
            if (obj.Data != null)
            {
                obj.Tag = 1;
            }
            return obj;
        }
        #endregion

        #region 提交数据
        public async Task<TData<string>> SaveForm(OrderMaterielDetailEntity entity)
        {
            TData<string> obj = new TData<string>();
            await orderMaterielDetailService.SaveForm(entity);
            obj.Data = entity.Id.ParseToString();
            obj.Tag = 1;
            return obj;
        }

        public async Task<TData> DeleteForm(string ids)
        {
            TData obj = new TData();
            await orderMaterielDetailService.DeleteForm(ids);
            obj.Tag = 1;
            return obj;
        }
        #endregion

        #region 私有方法
        #endregion
    }
}
