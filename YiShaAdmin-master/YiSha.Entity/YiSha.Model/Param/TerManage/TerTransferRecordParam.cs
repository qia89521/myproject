using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using YiSha.Util;

namespace YiSha.Model.Param.TerManage
{
    /// <summary>
    /// 创 建：admin
    /// 日 期：2020-08-18 17:28
    /// 描 述：设备转让记录实体查询类
    /// </summary>
    public class TerTransferRecordListParam
    {
        /// <summary>
        /// 设备id
        /// </summary>
        public long TerId { get; set; }
    }
}
