using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using YiSha.Util;

namespace YiSha.Model.Param.OrderManage
{
    /// <summary>
    /// 创 建：admin
    /// 日 期：2020-09-09 22:52
    /// 描 述：物料进货单实体查询类
    /// </summary>
    public class OrderTerInputListParam
    {
        
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
