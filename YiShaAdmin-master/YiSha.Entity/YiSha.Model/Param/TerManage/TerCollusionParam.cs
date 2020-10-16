using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using YiSha.Util;

namespace YiSha.Model.Param.TerManage
{
    /// <summary>
    /// 创 建：admin
    /// 日 期：2020-10-14 10:04
    /// 描 述：设备串货提醒实体查询类
    /// </summary>
    public class TerCollusionListParam
    {
        /// <summary>
        /// 串货人名称
        /// </summary>
        public string SaleTxt { get; set; }
        /// <summary>
        /// 设备编号
        /// </summary>
        public string TerNumber { get; set; }
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
