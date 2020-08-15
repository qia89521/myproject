﻿using System;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;
using YiSha.Util;

namespace YiSha.Entity.TerManage
{
    /// <summary>
    /// 创 建：admin
    /// 日 期：2020-08-14 16:16
    /// 描 述：设备状态实体类
    /// </summary>
    [Table("ter_status")]
    public class TerStatusEntity : BaseModifyEntity
    {
        /// <summary>
        /// 锁定状态
        /// </summary>
        /// <returns></returns>
        public string CloseStatus { get; set; }
        /// <summary>
        /// 运行状态
        /// </summary>
        /// <returns></returns>
        public string RunStatus { get; set; }
        /// <summary>
        /// 银离子可用百分比
        /// </summary>
        /// <returns></returns>
        public string SilverRate { get; set; }
        /// <summary>
        /// 故障代码
        /// </summary>
        /// <returns></returns>
        public string ErrorCode { get; set; }
        /// <summary>
        /// 故障消息
        /// </summary>
        /// <returns></returns>
        public string ErrorMsg { get; set; }
        /// <summary>
        /// 终端设备id
        /// </summary>
        /// <returns></returns>
        public string TerId { get; set; }
    }
}