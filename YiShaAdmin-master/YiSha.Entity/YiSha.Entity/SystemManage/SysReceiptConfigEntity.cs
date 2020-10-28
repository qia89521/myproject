using System;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;
using YiSha.Util;

namespace YiSha.Entity.SystemManage
{
    /// <summary>
    /// 创 建：admin
    /// 日 期：2020-10-28 18:04
    /// 描 述：系统收据配置实体类
    /// </summary>
    [Table("sys_receipt_config")]
    public class SysReceiptConfigEntity : BaseModifyEntity
    {
        /// <summary>
        /// 名称简称
        /// </summary>
        /// <returns></returns>
        public string Title { get; set; }
        /// <summary>
        /// 公章
        /// </summary>
        /// <returns></returns>
        public string CompanyImg { get; set; }
        /// <summary>
        /// 单号前缀
        /// </summary>
        /// <returns></returns>
        public string NumberPre { get; set; }
    }
}
