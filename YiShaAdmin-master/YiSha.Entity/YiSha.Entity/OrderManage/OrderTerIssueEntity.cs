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
        public int SaleNum { get; set; }
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
        /// 实收款
        /// </summary>
        /// <returns></returns>
        public decimal? FactMoney { get; set; }
        /// <summary>
        /// 差价
        /// </summary>
        /// <returns></returns>
        [NotMapped]
        public decimal? DiffPrice { get; set; }
        /// <summary>
        /// 出货区域
        /// </summary>
        /// <returns></returns>
        public string Zone { get; set; }

        /// <summary>
        /// 收件人
        /// </summary>
        /// <returns></returns>
        public string ReciveName { get; set; }
        /// <summary>
        /// 收件人手机号
        /// </summary>
        /// <returns></returns>
        public string RecivePhone { get; set; }
        /// <summary>
        /// 收件地址
        /// </summary>
        /// <returns></returns>
        public string ReciveAddress { get; set; }

        /// <summary>
        /// 审核人id
        /// </summary>
        [JsonConverter(typeof(StringJsonConverter))]
        public long? ShenHeManId { get; set; }
        /// <summary>
        /// 审核人姓名
        /// </summary>
        [NotMapped]
        public string ShenHeManTxt { get; set; }
        /// <summary>
        /// 审核状态 0未审核,1:审核通过,2拒绝
        /// </summary>
        /// <returns></returns>
        public int ShenHeStatus { get; set; }
        /// <summary>
        /// 审核信息
        /// </summary>
        /// <returns></returns>
        public string ShenHeMsg { get; set; }
        /// <summary>
        /// 支付凭证
        /// </summary>
        public string PayMoneyImg { get; set; }

        /// <summary>
        /// 是否发货 0未发货 1已发货 2自提
        /// </summary>
        /// <returns></returns>
        public int IsSent { get; set; }

        /// <summary>
        ///步骤  0:草稿,1:财务审核,2:售后发货,3:流程结束
        /// </summary>
        /// <returns></returns>
        public int Step { get; set; }
        /// <summary>
        ///提货方式 0:快递1:自提
        /// </summary>
        /// <returns></returns>
        public int TakeType { get; set; }
        
        /// <summary>
        /// 发货人Id
        /// </summary>
        [JsonConverter(typeof(StringJsonConverter))]
        public long? SentManId { get; set; }
        /// <summary>
        /// 发货人姓名
        /// </summary>
        [NotMapped]
        public string SentManTxt { get; set; }
        /// <summary>
        /// 快递公司
        /// </summary>
        /// <returns></returns>
        public string ExpressCompany { get; set; }
        /// <summary>
        /// 快递单号
        /// </summary>
        /// <returns></returns>
        public string ExpressNumber { get; set; }
        /// <summary>
        /// 备注 
        /// </summary>
        /// <returns></returns>
        public string Remark { get; set; }

        /// <summary>
        /// 物料id     
        /// </summary>
        [JsonConverter(typeof(StringJsonConverter))]
        public long? MaterielId { get; set; }

        /// <summary>
        /// 物料名称  
        /// </summary>
        [NotMapped]
        public string MaterielTxt { get; set; }

    }
}
