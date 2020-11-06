using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using YiSha.Util;
using YiSha.Util.Model;

namespace YiSha.Model.Param.OrderManage
{
    /// <summary>
    /// web api 订单收据查询参数类
    /// </summary>
    public class WebApi_OrderMoneyReceiptListParam
    {
        /// <summary>
        /// 工具栏参数
        /// </summary>
        public OrderMoneyReceiptListParam ListParam { get; set; }
        /// <summary>
        /// 分页参数
        /// </summary>
        public Pagination Pagination { get; set; }
        /// <summary>
        /// api token
        /// </summary>
        public string ApiToken { get; set; }
    }


    /// <summary>
    /// 创 建：admin
    /// 日 期：2020-10-28 18:08
    /// 描 述：订单收据实体查询类
    /// </summary>
    public class OrderMoneyReceiptListParam
    {
        /// <summary>
        /// 标题
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// 付款人
        /// </summary>
        public string PayManName { get; set;}
        /// <summary>
        /// 销售员
        /// </summary>
        public string SaleManTxt { get; set; }
        /// <summary>
        /// 开始日期
        /// </summary>
        public string StartTime { get; set; }
        /// <summary>
        /// 结束日期
        /// </summary>
        public string EndTime { get; set; }
    }


}
