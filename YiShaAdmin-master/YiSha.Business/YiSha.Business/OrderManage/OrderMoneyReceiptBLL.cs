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
    /// 日 期：2020-10-28 18:08
    /// 描 述：订单收据业务类
    /// </summary>
    public class OrderMoneyReceiptBLL
    {
        private OrderMoneyReceiptService orderMoneyReceiptService = new OrderMoneyReceiptService();

        #region 获取数据
        public async Task<TData<List<OrderMoneyReceiptEntity>>> GetList(OrderMoneyReceiptListParam param)
        {
            TData<List<OrderMoneyReceiptEntity>> obj = new TData<List<OrderMoneyReceiptEntity>>();
            obj.Data = await orderMoneyReceiptService.GetList(param);
            obj.Total = obj.Data.Count;
            obj.Tag = 1;
            return obj;
        }

        public async Task<TData<List<OrderMoneyReceiptEntity>>> GetPageList(OrderMoneyReceiptListParam param, Pagination pagination)
        {
            TData<List<OrderMoneyReceiptEntity>> obj = new TData<List<OrderMoneyReceiptEntity>>();
            obj.Data = await orderMoneyReceiptService.GetPageList(param, pagination);
            obj.Total = pagination.TotalCount;
            obj.Tag = 1;
            return obj;
        }

        public async Task<TData<OrderMoneyReceiptEntity>> GetEntity(long id)
        {
            TData<OrderMoneyReceiptEntity> obj = new TData<OrderMoneyReceiptEntity>();
            obj.Data = await orderMoneyReceiptService.GetEntity(id);
            if (obj.Data != null)
            {
                obj.Tag = 1;
            }
            return obj;
        }
        #endregion

        #region 提交数据
        public async Task<TData<string>> SaveForm(OrderMoneyReceiptEntity entity)
        {
            TData<string> obj = new TData<string>();
            if (string.IsNullOrEmpty(entity.PrintNumber))
            {
                string cur_day = DateTime.Now.ToString("yyyy-MM-dd");
                int count = await GetCount(cur_day, cur_day);

                entity.PrintNumber = CreatePrintNumber(entity.NumberPre,count);
            }

            await orderMoneyReceiptService.SaveForm(entity);
            obj.Data = entity.Id.ParseToString();
            obj.Tag = 1;
            return obj;
        }

        public async Task<TData> DeleteForm(string ids)
        {
            TData obj = new TData();
            await orderMoneyReceiptService.DeleteForm(ids);
            obj.Tag = 1;
            return obj;
        }

        public async Task<int> GetCount(string stime, string etime)
        {
            int count = 0;
            object obj_count = await orderMoneyReceiptService.GetCount(stime, etime);
            if (obj_count != null)
            {
                int.TryParse(obj_count.ToString(), out count);
            }
            return count;
        }

        #endregion

        #region 私有方法
        /// <summary>
        /// 创建打印订单号
        /// </summary>
        /// <param name="count">目前总数量</param>
        /// <returns></returns>
        private string CreatePrintNumber(string print_pre_number, int count)
        {
            //WJR20201009-
            string cur_day = DateTime.Now.ToString("yyyy-MM-dd");
            string numberPre = CoomHelper.GetValue(print_pre_number, "WJR");
            numberPre += cur_day;
            if (!numberPre.EndsWith("-"))
            {
                numberPre += "-";
            }
            string count_str = (count + 1).ToString();
            if (count < 10)
            {
                count_str = "0" + count;
            }
            string printOrderNumber = string.Format("{0}{1}", numberPre, count_str);

            return printOrderNumber;
        }

        #endregion
    }
}
