using System;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;
using YiSha.Util;

namespace YiSha.Entity.OrderManage
{
    /// <summary>
    /// 创 建：admin
    /// 日 期：2020-09-09 22:53
    /// 描 述：供应商实体类
    /// </summary>
    [Table("order_supplier")]
    public class OrderSupplierEntity : BaseModifyEntity
    {
        /// <summary>
        /// 供应商名称
        /// </summary>
        /// <returns></returns>
        public string SupplierName { get; set; }
        /// <summary>
        /// 供应商联系电话
        /// </summary>
        /// <returns></returns>
        public string SupplierLink { get; set; }
        /// <summary>
        /// 供应商地址
        /// </summary>
        /// <returns></returns>
        public string SupplierAddress { get; set; }
        /// <summary>
        /// 供应商联系人
        /// </summary>
        /// <returns></returns>
        public string SupplierMan { get; set; }
    }
}
