using System;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;
using YiSha.Util;

namespace YiSha.Entity.OrderManage
{
    /// <summary>
    /// 创 建：admin
    /// 日 期：2020-08-19 23:55
    /// 描 述：用户缴费订单记录实体类
    /// </summary>
    [Table("order_user_form")]
    public class OrderUserFormEntity : BaseModifyEntity
    {
        /// <summary>
        /// 缴费人Id
        /// </summary>
        /// <returns></returns>
        public string BuyId { get; set; }
        /// <summary>
        /// 缴费人姓名
        /// </summary>
        /// <returns></returns>
        [NotMapped]
        public string BuyTxt { get; set; }
        /// <summary>
        /// 缴费金额
        /// </summary>
        /// <returns></returns>
        public decimal? TotalMoney { get; set; }
        /// <summary>
        /// 当前排序
        /// </summary>
        /// <returns></returns>
        public int OrderIndex { get; set; }
        /// <summary>
        /// 缴费日期
        /// </summary>
        /// <returns></returns>
        public string BuyDate { get; set; }
        /// <summary>
        /// 失效日期
        /// </summary>
        /// <returns></returns>
        public string ValidateDate { get; set; }
        /// <summary>
        /// 缴费方式
        /// </summary>
        /// <returns></returns>
        public string BuyType { get; set; }
        /// <summary>
        /// 缴费账号
        /// </summary>
        /// <returns></returns>
        public string BuyCardNo { get; set; }
        /// <summary>
        /// 收款账号
        /// </summary>
        /// <returns></returns>
        public string MchNo { get; set; }
    }
}
