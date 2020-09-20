using System;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;
using YiSha.Util;

namespace YiSha.Entity.OrderManage
{
    /// <summary>
    /// 创 建：admin
    /// 日 期：2020-09-08 18:11
    /// 描 述：OrderManage实体类
    /// </summary>
    [Table("order_materiel")]
    public class OrderMaterielEntity : BaseModifyEntity
    {
        /// <summary>
        /// 物品名称
        /// </summary>
        /// <returns></returns>
        public string MaterielName { get; set; }
        /// <summary>
        /// 当前库存
        /// </summary>
        /// <returns></returns>
        public int? MaterielTotal { get; set; }
        /// <summary>
        /// 型号
        /// </summary>
        /// <returns></returns>
        public string MaterielType { get; set; }
        /// <summary>
        /// 描述
        /// </summary>
        /// <returns></returns>
        public string MaterielDesc { get; set; }
        /// <summary>
        /// 单位
        /// </summary>
        /// <returns></returns>
        public string MaterielUnite { get; set; }
    }
}
