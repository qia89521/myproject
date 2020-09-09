using System;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;
using YiSha.Util;

namespace YiSha.Entity.OrderManage
{
    /// <summary>
    /// 创 建：admin
    /// 日 期：2020-08-25 17:43
    /// 描 述：订单用户收益实体类
    /// </summary>
    [Table("order_user_profit")]
    public class OrderUserProfitEntity : BaseModifyEntity
    {
        /// <summary>
        /// 业务id
        /// </summary>
        /// <returns></returns>
        [JsonConverter(typeof(StringJsonConverter))]
        public long? BusyniessId { get; set; }
        /// <summary>
        /// 来源表
        /// </summary>
        /// <returns></returns>
        public string BusyniessTable { get; set; }
        /// <summary>
        /// 新增金额
        /// </summary>
        /// <returns></returns>
        public decimal? ChangeMoney { get; set; }
        /// <summary>
        /// 原来金额
        /// </summary>
        /// <returns></returns>
        public decimal? SrcMoney { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        /// <returns></returns>
        public string Remark { get; set; }
        /// <summary>
        /// 用户Id
        /// </summary>
        [JsonConverter(typeof(StringJsonConverter))]
        public long UserId { get; set; }
        /// <summary>
        /// 用户姓名
        /// </summary>
        public string UserName { get; set; }
        /// <summary>
        ///变化方式 -减少 +新增
        /// </summary>
        public string ChangeType { get; set; }
    }
}
