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
    /// 日 期：2020-08-25 17:33
    /// 描 述：设备出货单业务类
    /// </summary>
    public class OrderTerIssueBLL
    {
        private OrderTerIssueService orderTerIssueService = new OrderTerIssueService();

        #region 获取数据
        public async Task<TData<List<OrderTerIssueEntity>>> GetList(OrderTerIssueListParam param)
        {
            TData<List<OrderTerIssueEntity>> obj = new TData<List<OrderTerIssueEntity>>();
            obj.Data = await orderTerIssueService.GetList(param);
            obj.Total = obj.Data.Count;
            obj.Tag = 1;
            return obj;
        }

        public async Task<TData<List<OrderTerIssueEntity>>> GetPageList(OrderTerIssueListParam param, Pagination pagination)
        {
            TData<List<OrderTerIssueEntity>> obj = new TData<List<OrderTerIssueEntity>>();
            obj.Data = await orderTerIssueService.GetPageList(param, pagination);
            obj.Total = pagination.TotalCount;
            obj.Tag = 1;
            return obj;
        }

        public async Task<TData<OrderTerIssueEntity>> GetEntity(long id)
        {
            TData<OrderTerIssueEntity> obj = new TData<OrderTerIssueEntity>();
            obj.Data = await orderTerIssueService.GetEntity(id);
            if (obj.Data != null)
            {
                obj.Tag = 1;
            }
            return obj;
        }
        #endregion

        #region 提交数据
        public async Task<TData<string>> SaveForm(OrderTerIssueEntity entity)
        {
            TData<string> obj = new TData<string>();
            await orderTerIssueService.SaveForm(entity);
            obj.Data = entity.Id.ParseToString();
            obj.Tag = 1;
            return obj;
        }

        public async Task<TData> DeleteForm(string ids)
        {
            TData obj = new TData();
            await orderTerIssueService.DeleteForm(ids);
            obj.Tag = 1;
            return obj;
        }
        #endregion

        #region 私有方法
        #endregion
    }
}
