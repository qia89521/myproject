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
                       
                        List<OrderTerIssueEntity> list = list_product.Data;

                        #region 封装数据
                        printModel.PrintDay = CoomHelper.GetValue(list[0].SentDay, DateTime.Now.ToString("yyyy-MM-dd"));
                        //创建打印单号
                        printModel.PrintOrderNumber = await CreatePrintOrderNumber(printModel.PrintDay, config);

                        //封装数据
                        PackageData(printModel, config, list);
                        #endregion
                    }
                    
                }
            }
            return printModel;

        }

        /// <summary>
        /// 获取重新打印配置数据
        /// </summary>
        /// <param name="printOrderNumber">打印单号</param>
        /// <returns></returns>
        public async Task<Response_OrderPrintIssue> GetRePrintData(string printOrderNumber)
        {
            Response_OrderPrintIssue printModel = new Response_OrderPrintIssue();
            //读取单号配置
            TData<SysIssueConfigEntity> config = await sysIssueConfigBLL.GetFristModel();
            if (config != null)
            {
                TData<OrderPrintIssueEntity> orderPrintIssue =await GetEntityByPrintOrderNumber(printOrderNumber);

                List<string> ids_list = orderPrintIssue.Data.OrderTerIssueIds.Split(',').ToList<string>();

                if (ids_list.Count > 0)
                {
                    TData<List<OrderTerIssueEntity>> list_product = await orderTerIssueBLL.GetListByIds(ids_list);
                    if (list_product != null && list_product.Data.Count() > 0)
                    {

                        List<OrderTerIssueEntity> list = list_product.Data;

                        #region 封装数据
                        printModel.PrintDay = CoomHelper.GetValue(list[0].SentDay, DateTime.Now.ToString("yyyy-MM-dd"));
                        //创建打印单号
                        printModel.PrintOrderNumber = printOrderNumber;
                        //封装数据
                        PackageData(printModel, config, list);
                        #endregion
                    }

                }
            }
            return printModel;

        }


        /// <summary>
        /// 填充数据
        /// </summary>
        /// <param name="printModel">打印实体</param>
        /// <param name="config">打印配置</param>
        /// <param name="list">出货数据列表</param>
        private void PackageData(Response_OrderPrintIssue printModel,TData<SysIssueConfigEntity> config, List<OrderTerIssueEntity> list)
        {
            printModel.Title = CoomHelper.GetValue(config.Data.Title, "普沃森（广州）科技销售单");
            printModel.CustName = CoomHelper.GetValue(list[0].ReciveName, "");
            printModel.LinkName = CoomHelper.GetValue(list[0].ReciveName, "");
            printModel.LinkPhone = CoomHelper.GetValue(list[0].RecivePhone, "");
            printModel.ReciveAddress = CoomHelper.GetValue(list[0].ReciveAddress, "");
            printModel.Remark = CoomHelper.GetValue(list[0].Remark, "");

            printModel.ListProduct = list;
            printModel.SysIssueConfig = config.Data;
        }

        /// <summary>
        /// 创建打印订单号
        /// </summary>
        /// <param name="printDay">打印日期</param>
        /// <returns></returns>
        private async Task<string> CreatePrintOrderNumber(string printDay, TData<SysIssueConfigEntity> config)
        {
            //WJR20201009-
            string cur_day = DateTime.Now.ToString("yyyy-MM-dd");
            string numberPre = CoomHelper.GetValue(config.Data.NumberPre, "WJR");
            cur_day = printDay.Replace("-", "");
            numberPre += cur_day;
            if (!numberPre.EndsWith("-"))
            {
                numberPre += "-";
            }
            int count = await GetPrintDayCount(printDay) + 1;
            string count_str = count.ToString();
            if (count < 10)
            {
                count_str = "0" + count;
            }
            string printOrderNumber = string.Format("{0}{1}", numberPre, count_str);

            return printOrderNumber;
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
