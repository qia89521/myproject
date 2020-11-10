using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using YiSha.Util;
using YiSha.Util.Model;

namespace YiSha.Model.Param.OrderManage
{
    /// <summary>
    /// web api设备出货单实体查询类
    /// </summary>
    public class WebApi_OrderTerIssueListParam
    {
        /// <summary>
        /// 工具栏参数
        /// </summary>
        public OrderTerIssueListParam ListParam { get; set; }
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
    /// web api设备出货单实体查询类
    /// </summary>
    public class WebApi_OrderTerIssueChartParam
    {
        /// <summary>
        /// 工具栏参数
        /// </summary>
        public OrderTerIssueListParam ListParam { get; set; }
        /// <summary>
        /// api token
        /// </summary>
        public string ApiToken { get; set; }
    }

    /// <summary>
    /// 创 建：admin
    /// 日 期：2020-08-25 17:33
    /// 描 述：设备出货单实体查询类
    /// </summary>
    public class OrderTerIssueListParam
    {
        /// <summary>
        /// 分组方式 day,month 天和月分组
        /// </summary>
        public string GroupFlag { get; set; }
        /// <summary>
        /// 销售人
        /// </summary>
        public string SaleTxt { get; set; }
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
