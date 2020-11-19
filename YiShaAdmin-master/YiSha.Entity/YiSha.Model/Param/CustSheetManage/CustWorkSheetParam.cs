using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using YiSha.Util;

namespace YiSha.Model.Param.CustSheetManage
{
    /// <summary>
    /// 创 建：admin
    /// 日 期：2020-11-19 15:30
    /// 描 述：维修工单处理实体查询类
    /// </summary>
    public class CustWorkSheetListParam
    {
        /// <summary>
        /// 开始日期
        /// </summary>
        public string StartTime { get; set; }

        /// <summary>
        /// 结束日期
        /// </summary>
        public string EndTime { get; set; }
        /// <summary>
        /// 设备名称
        /// </summary>
        public string TerName { get; set; }
        /// <summary>
        /// 设备编号
        /// </summary>
        public string TerNumber { get; set; }
        /// <summary>
        /// 流程步骤
        /// </summary>
        public int Step { get; set; }
    }
}
