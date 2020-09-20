using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using YiSha.Util;

namespace YiSha.Model.Param.OrderManage
{
    /// <summary>
    /// 创 建：admin
    /// 日 期：2020-09-20 17:56
    /// 描 述：系统出货打印单实体查询类
    /// </summary>
    public class OrderPrintIssueListParam
    {
        /// <summary>
        /// 客户
        /// </summary>
        public string CustName { get; set;}
        /// <summary>
        /// 联系人
        /// </summary>
        public string LinkName { get; set; }
        /// <summary>
        /// 联系电话
        /// </summary>
        public string LinkPhone { get; set; }
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
