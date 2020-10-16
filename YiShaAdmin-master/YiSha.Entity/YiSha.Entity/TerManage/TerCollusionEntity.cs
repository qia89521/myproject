using System;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;
using YiSha.Util;

namespace YiSha.Entity.TerManage
{
    /// <summary>
    /// 创 建：admin
    /// 日 期：2020-10-14 10:04
    /// 描 述：设备串货提醒实体类
    /// </summary>
    [Table("ter_collusion")]
    public class TerCollusionEntity : BaseModifyEntity
    {
        /// <summary>
        /// 串货人
        /// </summary>
        /// <returns></returns>
        [JsonConverter(typeof(StringJsonConverter))]
        public long? SaleId { get; set; }

        /// <summary>
        /// 串货人名称
        /// </summary>
        /// <returns></returns>
        [NotMapped]
        public string SaleTxt { get; set; }

        /// <summary>
        /// 设备Id
        /// </summary>
        /// <returns></returns>
        [JsonConverter(typeof(StringJsonConverter))]
        public long? TerId { get; set; }
        /// <summary>
        /// 设备编号
        /// </summary>
        /// <returns></returns>
        [NotMapped]
        public string TerNumber { get; set; }
        /// <summary>
        /// 设备名称
        /// </summary>
        /// <returns></returns>
        [NotMapped]
        public string TerName { get; set; }
        /// <summary>
        /// 串货地域
        /// </summary>
        /// <returns></returns>
        public string Zone { get; set; }
        /// <summary>
        /// 代理地域
        /// </summary>
        /// <returns></returns>
        public string DelegetZone { get; set; }
    }
}
