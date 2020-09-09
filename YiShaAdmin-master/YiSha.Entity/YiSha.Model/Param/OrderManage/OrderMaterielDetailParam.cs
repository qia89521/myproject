using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using YiSha.Util;

namespace YiSha.Model.Param.OrderManage
{
    /// <summary>
    /// 创 建：admin
    /// 日 期：2020-09-08 18:14
    /// 描 述：物料明细实体查询类
    /// </summary>
    public class OrderMaterielDetailListParam
    {
        /// <summary>
        /// 新增还是减少 
        /// </summary>
        public string Flag { get; set; }

        /// <summary>
        /// 物料ID
        /// </summary>
        /// <returns></returns>
        public long MaterielId { get; set; }

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
