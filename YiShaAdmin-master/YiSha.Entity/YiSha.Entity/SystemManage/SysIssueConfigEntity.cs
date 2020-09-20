using System;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;
using YiSha.Util;

namespace YiSha.Entity.SystemManage
{
    /// <summary>
    /// 创 建：admin
    /// 日 期：2020-09-20 17:55
    /// 描 述：出货打印单配置实体类
    /// </summary>
    [Table("sys_issue_config")]
    public class SysIssueConfigEntity : BaseModifyEntity
    {
        /// <summary>
        /// 标题
        /// </summary>
        /// <returns></returns>
        public string Title { get; set; }
        /// <summary>
        /// 单号前缀
        /// </summary>
        /// <returns></returns>
        public string NumberPre { get; set; }
        /// <summary>
        /// 开户行
        /// </summary>
        /// <returns></returns>
        [JsonConverter(typeof(StringJsonConverter))]
        public long SysBankCardId { get; set; }
        /// <summary>
        /// 开户行名称
        /// </summary>
        /// <returns></returns>
        [NotMapped]
        public string SysBankName { get; set; }
        /// <summary>
        /// 银行卡户主名称
        /// </summary>
        /// <returns></returns>
        [NotMapped]
        public string SysBankMan { get; set; }
        /// <summary>
        /// 开户银行账号
        /// </summary>
        /// <returns></returns>
        [NotMapped]
        public string SysBankCardNo { get; set; }
    }
}
