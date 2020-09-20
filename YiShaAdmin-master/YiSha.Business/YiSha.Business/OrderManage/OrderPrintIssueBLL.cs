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
    /// 日 期：2020-09-20 17:56
    /// 描 述：系统出货打印单业务类
    /// </summary>
    public class OrderPrintIssueBLL
    {
        private OrderPrintIssueService orderPrintIssueService = new OrderPrintIssueService();

        #region 获取数据
        public async Task<TData<List<OrderPrintIssueEntity>>> GetList(OrderPrintIssueListParam param)
        {
            TData<List<OrderPrintIssueEntity>> obj = new TData<List<OrderPrintIssueEntity>>();
            obj.Data = await orderPrintIssueService.GetList(param);
            obj.Total = obj.Data.Count;
            obj.Tag = 1;
            return obj;
        }

        public async Task<TData<List<OrderPrintIssueEntity>>> GetPageList(OrderPrintIssueListParam param, Pagination pagination)
        {
            TData<List<OrderPrintIssueEntity>> obj = new TData<List<OrderPrintIssueEntity>>();
            obj.Data = await orderPrintIssueService.GetPageList(param, pagination);
            obj.Total = pagination.TotalCount;
            obj.Tag = 1;
            return obj;
        }

        public async Task<TData<OrderPrintIssueEntity>> GetEntity(long id)
        {
            TData<OrderPrintIssueEntity> obj = new TData<OrderPrintIssueEntity>();
            obj.Data = await orderPrintIssueService.GetEntity(id);
            if (obj.Data != null)
            {
                obj.Tag = 1;
            }
            return obj;
        }
        /// <summary>
        /// 获取当日打印订单数量
        /// </summary>
        /// <param name="printDay">打印日期</param>
        /// <returns></returns>
        public async Task<int> GetPrintDayCount(string printDay)
        {
            int count = await orderPrintIssueService.GetPrintDayCount(printDay);

            return count;
        }

        #endregion

        #region 提交数据
        public async Task<TData<string>> SaveForm(OrderPrintIssueEntity entity)
        {
            TData<string> obj = new TData<string>();
            await orderPrintIssueService.SaveForm(entity);
            obj.Data = entity.Id.ParseToString();
            obj.Tag = 1;
            return obj;
        }

        public async Task<TData> DeleteForm(string ids)
        {
            TData obj = new TData();
            await orderPrintIssueService.DeleteForm(ids);
            obj.Tag = 1;
            return obj;
        }
        #endregion

        #region 私有方法
        #endregion
    }
}
