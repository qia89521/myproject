using System;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;
using YiSha.Util;

namespace YiSha.Entity.OrderManage
{
    /// <summary>
    /// 创 建：admin
    /// 日 期：2020-09-08 18:14
    /// 描 述：物料明细实体类
    /// </summary>
    [Table("order_materiel_detail")]
    public class OrderMaterielDetailEntity : BaseModifyEntity
    {
        /// <summary>
        /// 原数量
        /// </summary>
        /// <returns></returns>
        public int? SrcNum { get; set; }
        /// <summary>
        /// 变化量
        /// </summary>
        /// <returns></returns>
        public int? ChangeNum { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        /// <returns></returns>
        public string Remark { get; set; }
        /// <summary>
        /// 物料ID
        /// </summary>
        /// <returns></returns>
        [JsonConverter(typeof(StringJsonConverter))]
        public long? MaterielId { get; set; }
        /// <summary>
        /// 物料名称
        /// </summary>
        [NotMapped]
        public string MaterielName { get; set; }

        /// <summary>
        ///业务id
        /// </summary>
        /// <returns></returns>
        [JsonConverter(typeof(StringJsonConverter))]
        public long? BusyniessId { get; set; }
        /// <summary>
        /// 业务表
        /// </summary>
        public string BusyniessTable { get; set; }

        /// <summary>
        /// 当前库存
        /// </summary>
        [NotMapped]
        public int? CurTotal {
            get {
                return this.SrcNum + this.ChangeNum;
            }
        }
    }
}
