using System;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;
using YiSha.Util;

namespace YiSha.Entity.SaleManage
{
    /// <summary>
    /// 创 建：admin
    /// 日 期：2020-09-01 15:48
    /// 描 述：意向用户实体类
    /// </summary>
    [Table("wish_user")]
    public class WishUserEntity : BaseModifyEntity
    {
        /// <summary>
        /// 用户姓名
        /// </summary>
        /// <returns></returns>
        public string RealName { get; set; }
        /// <summary>
        /// 用户手机号
        /// </summary>
        /// <returns></returns>
        public string MobilePhone { get; set; }
        /// <summary>
        /// 推荐人id
        /// </summary>
        /// <returns></returns>
        [JsonConverter(typeof(StringJsonConverter))]
        public long? TuiJianUserId { get; set; }
        /// <summary>
        /// 推荐人姓名
        /// </summary>
        /// <returns></returns>
        public string TuiJianUserTxt { get; set; }
        /// <summary>
        /// 来源 用户来源方式
        /// </summary>
        /// <returns></returns>
        public string SrcFlag { get; set; }
    }
}
