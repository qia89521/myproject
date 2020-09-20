using System;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;
using YiSha.Util;

namespace YiSha.Entity.OrderManage
{
    /// <summary>
    /// 创 建：admin
    /// 日 期：2020-09-20 17:56
    /// 描 述：系统出货打印单实体类
    /// </summary>
    [Table("order_print_issue")]
    public class OrderPrintIssueEntity : BaseModifyEntity
    {
        /// <summary>
        /// 打印单号
        /// </summary>
        /// <returns></returns>
        public string PrintOrderNumber { get; set; }
        /// <summary>
        /// 客户名称
        /// </summary>
        /// <returns></returns>
        public string CustName { get; set; }
        /// <summary>
        /// 联系人
        /// </summary>
        /// <returns></returns>
        public string LinkName { get; set; }
        /// <summary>
        /// 打单日期 打单日期yyyy-mm-dd
        /// </summary>
        /// <returns></returns>
        public string PrintDay { get; set; }
        /// <summary>
        /// 出货单id串 逗号分隔
        /// </summary>
        public string OrderTerIssueIds { get; set; }
    }
}
