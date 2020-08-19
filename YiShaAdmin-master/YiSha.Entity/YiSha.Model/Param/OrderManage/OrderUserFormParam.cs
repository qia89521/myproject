using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using YiSha.Util;

namespace YiSha.Model.Param.OrderManage
{
    /// <summary>
    /// 创 建：admin
    /// 日 期：2020-08-19 23:55
    /// 描 述：用户缴费订单记录实体查询类
    /// </summary>
    public class OrderUserFormListParam
    {
        /// <summary>
        /// 购买人
        /// </summary>
        public string BuyTxt{ get; set; }

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
