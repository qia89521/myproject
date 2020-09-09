using System;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;
using YiSha.Util;

namespace YiSha.Entity.OrderManage
{
    /// <summary>
    /// 创 建：admin
    /// 日 期：2020-08-25 17:33
    /// 描 述：设备出货单实体类
    /// </summary>
    [Table("order_ter_issue")]
    public class OrderTerIssueEntity : BaseModifyEntity
    {
        /// <summary>
        /// 销售人
        /// </summary>
        /// <returns></returns>
        [JsonConverter(typeof(StringJsonConverter))]
        public long SaleId { get; set; }
        /// <summary>
        /// 销售人名称
        /// </summary>
        /// <returns></returns>
        public string SaleTxt { get; set; }
        /// <summary>
        /// 设备量
        /// </summary>
        /// <returns></returns>
        public string SaleNum { get; set; }
        /// <summary>
        /// 销售价
        /// </summary>
        /// <returns></returns>
        public decimal? SalePrice { get; set; }
        /// <summary>
        /// 拿货价
        /// </summary>
        /// <returns></returns>
        public decimal? SrcPrice { get; set; }
        /// <summary>
        /// 出货区域
        /// </summary>
        /// <returns></returns>
        public string Zone { get; set; }
    }
}
