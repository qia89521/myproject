using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using YiSha.Util;

namespace YiSha.Model.Param.TerManage
{
    /// <summary>
    /// 创 建：admin
    /// 日 期：2020-08-13 15:30
    /// 描 述：设备部件实体查询类
    /// </summary>
    public class PartsListParam
    {
        /// <summary>
        /// 部件名称
        /// </summary>
        public string PartName { get; set; }
    }
}
