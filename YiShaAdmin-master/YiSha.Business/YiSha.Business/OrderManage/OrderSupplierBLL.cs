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
    /// 日 期：2020-09-09 22:53
    /// 描 述：供应商业务类
    /// </summary>
    public class OrderSupplierBLL
    {
        private OrderSupplierService orderSupplierService = new OrderSupplierService();

        #region 获取数据
        public async Task<TData<List<OrderSupplierEntity>>> GetList(OrderSupplierListParam param)
        {
            TData<List<OrderSupplierEntity>> obj = new TData<List<OrderSupplierEntity>>();
            obj.Data = await orderSupplierService.GetList(param);
            obj.Total = obj.Data.Count;
            obj.Tag = 1;
            return obj;
        }

        public async Task<TData<List<OrderSupplierEntity>>> GetPageList(OrderSupplierListParam param, Pagination pagination)
        {
            TData<List<OrderSupplierEntity>> obj = new TData<List<OrderSupplierEntity>>();
            obj.Data = await orderSupplierService.GetPageList(param, pagination);
            obj.Total = pagination.TotalCount;
            obj.Tag = 1;
            return obj;
        }

        public async Task<TData<OrderSupplierEntity>> GetEntity(long id)
        {
            TData<OrderSupplierEntity> obj = new TData<OrderSupplierEntity>();
            obj.Data = await orderSupplierService.GetEntity(id);
            if (obj.Data != null)
            {
                obj.Tag = 1;
            }
            return obj;
        }
        #endregion

        #region 提交数据
        public async Task<TData<string>> SaveForm(OrderSupplierEntity entity)
        {
            TData<string> obj = new TData<string>();
            await orderSupplierService.SaveForm(entity);
            obj.Data = entity.Id.ParseToString();
            obj.Tag = 1;
            return obj;
        }

        public async Task<TData> DeleteForm(string ids)
        {
            TData obj = new TData();
            await orderSupplierService.DeleteForm(ids);
            obj.Tag = 1;
            return obj;
        }
        #endregion

        #region 私有方法
        #endregion
    }
}
