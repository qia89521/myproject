﻿using System;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;
using YiSha.Util;

namespace YiSha.Entity.OrderManage
{
    /// <summary>
    /// 创 建：admin
    /// 日 期：2020-10-28 18:08
    /// 描 述：订单收据实体类
    /// </summary>
    [Table("order_money_receipt")]
    public class OrderMoneyReceiptEntity : BaseModifyEntity
    {
        /// <summary>
        /// 标题
        /// </summary>
        /// <returns></returns>
        public string Title { get; set; }
        /// <summary>
        /// 交款人
        /// </summary>
        /// <returns></returns>
        public string PayManName { get; set; }
        /// <summary>
        /// 交款项目
        /// </summary>
        /// <returns></returns>
        public string PayManItme { get; set; }
        /// <summary>
        /// 总金额
        /// </summary>
        /// <returns></returns>
        public decimal? TotalMoney { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        /// <returns></returns>
        public string Remark { get; set; }
        /// <summary>
        /// 收款单位公章
        /// </summary>
        /// <returns></returns>
        public string CompanyImg { get; set; }
        /// <summary>
        /// 对接业务员
        /// </summary>
        /// <returns></returns>
        [JsonConverter(typeof(StringJsonConverter))]
        public long? SaleManId { get; set; }
    }
}
