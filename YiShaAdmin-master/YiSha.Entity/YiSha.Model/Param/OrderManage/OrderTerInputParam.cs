using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using YiSha.Util;
using YiSha.Util.Model;

namespace YiSha.Model.Param.OrderManage
{
    /// <summary>
    /// web api物料进货单 查询类
    /// </summary>
    public class WebApi_OrderTerInputListParam
    {
        /// <summary>
        /// 工具栏参数
        /// </summary>
        public OrderTerInputListParam ListParam { get; set; }
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
    /// web api设备进货报表查询类
    /// </summary>
    public class WebApi_OrderTerInputChartParam
    {
        /// <summary>
        /// 工具栏参数
        /// </summary>
        public OrderTerInputListParam ListParam { get; set; }
        /// <summary>
        /// api token
        /// </summary>
        public string ApiToken { get; set; }
    }


    /// <summary>
    /// 创 建：admin
    /// 日 期：2020-09-09 22:52
    /// 描 述：物料进货单实体查询类
    /// </summary>
    public class OrderTerInputListParam
    {
        /// <summary>
        /// 分组方式 day,month 天和月分组
        /// </summary>
        public string GroupFlag { get; set; }
        /// <summary>
        /// 物料名称
        /// </summary>
        public string MaterielTxt { get; set; }
        /// <summary>
        /// 购买人
        /// </summary>
        public string BuyTxt { get; set; }
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
