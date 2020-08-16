using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using YiSha.Util;

namespace YiSha.Model.Param.TerManage
{
    /// <summary>
    /// 创 建：admin
    /// 日 期：2020-08-14 16:16
    /// 描 述：设备状态实体查询类
    /// </summary>
    public class TerStatusListParam
    {
        /// <summary>
        /// 锁定状态
        /// </summary>
        public string CloseStatus { get; set; }
        /// <summary>
        /// 运行状态
        /// </summary>
        public string RunStatus { get; set; }
        /// <summary>
        /// 银离子可用百分比
        /// </summary>
        public string SilverRate { get; set; }
        /// <summary>
        /// 设备名称
        /// </summary>
        public string TerName { get; set; }
        /// <summary>
        /// 设备编号
        /// </summary>
        public string TerNumber { get; set; }
    }
}
