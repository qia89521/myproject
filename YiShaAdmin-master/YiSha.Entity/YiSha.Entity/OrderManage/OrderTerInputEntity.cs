﻿using System;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;
using YiSha.Util;

namespace YiSha.Entity.OrderManage
{
    /// <summary>
    /// 创 建：admin
    /// 日 期：2020-09-09 22:52
    /// 描 述：物料进货单实体类
    /// </summary>
    [Table("order_ter_input")]
    public class OrderTerInputEntity : BaseModifyEntity
    {
        /// <summary>
        /// 物料ID
        /// </summary>
        /// <returns></returns>
        [JsonConverter(typeof(StringJsonConverter))]
        public long? MaterielId { get; set; }
        /// <summary>
        /// 物料名称
        /// </summary>
        /// <returns></returns>
        [NotMapped]
        public string MaterielTxt { get; set; }
        /// <summary>
        /// 购买人
        /// </summary>
        /// <returns></returns>
        [JsonConverter(typeof(StringJsonConverter))]
        public long? BuyId { get; set; }
        /// <summary>
        /// 购买姓名
        /// </summary>
        /// <returns></returns>
        public string BuyTxt { get; set; }
        /// <summary>
        /// 设备量
        /// </summary>
        /// <returns></returns>
        public int? BuyNum { get; set; }
        /// <summary>
        /// 进货价
        /// </summary>
        /// <returns></returns>
        public decimal? BuyPrice { get; set; }

        /// <summary>
        /// 总价
        /// </summary>
        /// <returns></returns>
        public decimal? TotalPrice
        {
            get
            {
                return this.BuyNum * this.BuyPrice;
            }
        }

        /// <summary>
        /// 供应商
        /// </summary>
        /// <returns></returns>
        [JsonConverter(typeof(StringJsonConverter))]
        public long? SupplierId { get; set; }

        /// <summary>
        /// 供应商姓名
        /// </summary>
        /// <returns></returns>
        [NotMapped]
        public string SupplierTxt { get; set; }

        /// <summary>
        /// 审核状态 0创建 1审核中 2审核通过 3拒绝
        /// </summary>
        /// <returns></returns>
        public int ShenHeStatus { get; set; }
        /// <summary>
        /// 审核信息
        /// </summary>
        /// <returns></returns>
        public string ShenHeMsg { get; set; }
        /// <summary>
        /// 收款凭证截图
        /// </summary>
        /// <returns></returns>
        [NotMapped]
        public string PayMoneyImg { get; set; }
        /// <summary>
        /// 审核人Id
        /// </summary>
        /// <returns></returns>
        [JsonConverter(typeof(StringJsonConverter))]
        public long? ShenHeManId { get; set; }
        /// <summary>
        /// 审核人姓名
        /// </summary>
        /// <returns></returns>
        [NotMapped]
        public string ShenHeManTxt { get; set; }
    }
}