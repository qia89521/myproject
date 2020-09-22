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
using YiSha.Business.SystemManage;
using YiSha.Entity.SystemManage;
using YiSha.Model.Result.OrderManage;

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
        private OrderTerIssueBLL orderTerIssueBLL = new OrderTerIssueBLL();
        private SysIssueConfigBLL sysIssueConfigBLL = new SysIssueConfigBLL();


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

        public async Task<TData<OrderPrintIssueEntity>> GetEntityByPrintOrderNumber(string printOrderNumber)
        {
            TData<OrderPrintIssueEntity> obj = new TData<OrderPrintIssueEntity>();
            obj.Data = await orderPrintIssueService.GetEntityByPrintOrderNumber(printOrderNumber);
            if (obj.Data != null)
            {
                obj.Tag = 1;
            }
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

        /// <summary>
        /// 获取打印配置数据
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public async Task<Response_OrderPrintIssue> GetPrintData(string ids)
        {
            Response_OrderPrintIssue printModel = new Response_OrderPrintIssue();
            //读取单号配置
            TData<SysIssueConfigEntity> config =await sysIssueConfigBLL.GetFristModel();
            if (config != null)
            {
                List<string> ids_list = ids.Split(',').ToList<string>();
                if (ids_list.Count > 0)
                {
                    TData<List<OrderTerIssueEntity>> list_product = await orderTerIssueBLL.GetListByIds(ids_list);
                    if (list_product != null && list_product.Data.Count() > 0)
                    {
                        string cur_day = DateTime.Now.ToString("yyyy-MM-dd");

                        List<OrderTerIssueEntity> list = list_product.Data;

                        #region 封装数据
                        printModel.Title = CoomHelper.GetValue(config.Data.Title, "普沃森（广州）科技销售单");
                        printModel.PrintDay = CoomHelper.GetValue(list[0].SentDay, cur_day);

                        cur_day = printModel.PrintDay.Replace("-","");
                        //WJR20201009-
                        string numberPre = CoomHelper.GetValue(config.Data.NumberPre, "WJR");
                        numberPre += cur_day;
                        if (!numberPre.EndsWith("-"))
                        {
                            numberPre += "-";
                        }
                        int count =await GetPrintDayCount(printModel.PrintDay)+1;
                        string count_str = count.ToString();
                        if (count < 10)
                        {
                            count_str = "0" + count;
                        }
                        printModel.PrintOrderNumber = string.Format("{0}{1}", numberPre, count_str);
                        printModel.CustName= CoomHelper.GetValue(list[0].ReciveName, "");
                        printModel.LinkName = CoomHelper.GetValue(list[0].ReciveName, "");
                        printModel.LinkPhone = CoomHelper.GetValue(list[0].RecivePhone, "");
                        printModel.ReciveAddress = CoomHelper.GetValue(list[0].ReciveAddress, "");
                        printModel.Remark = CoomHelper.GetValue(list[0].Remark, "");

                        printModel.ListProduct = list_product.Data;
                        printModel.SysIssueConfig = config.Data;

                        #endregion
                    }
                    
                }
            }
            return printModel;

        }

        #endregion

        #region 提交数据
        public async Task<TData<string>> SaveForm(OrderPrintIssueEntity entity)
        {
            TData<string> obj = new TData<string>();

            TData<OrderPrintIssueEntity> old_entity =await GetEntityByPrintOrderNumber(entity.PrintOrderNumber);
            if (old_entity.Tag == 1 && old_entity.Data != null)
            {
                obj.Data = old_entity.Data.Id.ParseToString();
                obj.Tag = 1;
            }
            else
            {
                await orderPrintIssueService.SaveForm(entity);
                obj.Data = entity.Id.ParseToString();
                obj.Tag = 1;
            }
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
