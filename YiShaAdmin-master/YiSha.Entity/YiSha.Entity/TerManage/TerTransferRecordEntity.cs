using System;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;
using YiSha.Util;

namespace YiSha.Entity.TerManage
{
    /// <summary>
    /// 创 建：admin
    /// 日 期：2020-08-18 17:28
    /// 描 述：设备转让记录实体类
    /// </summary>
    [Table("ter_transfer_record")]
    public class TerTransferRecordEntity : BaseCreateEntity
    {
        /// <summary>
        /// 接收者id
        /// </summary>
        /// <returns></returns>
        [JsonConverter(typeof(StringJsonConverter))]
        public long? ReceiverId { get; set; }
        /// <summary>
        /// 接收者名称
        /// </summary>
        /// <returns></returns>
        public string ReceiverTxt { get; set; }
        /// <summary>
        /// 转让者id
        /// </summary>
        /// <returns></returns>
        [JsonConverter(typeof(StringJsonConverter))]
        public long? SentId { get; set; }
        /// <summary>
        /// 转让者名称
        /// </summary>
        /// <returns></returns>
        public string SendTxt { get; set; }
        /// <summary>
        /// 转让设备Id
        /// </summary>
        /// <returns></returns>
        [JsonConverter(typeof(StringJsonConverter))]
        public long? TerId { get; set; }
        /// <summary>
        /// 转让设备编号
        /// </summary>
        /// <returns></returns>
        public string TerNumber { get; set; }
    }
}
