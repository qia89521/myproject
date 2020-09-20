using NPOI.OpenXmlFormats.Dml.Diagram;
using System;
using System.Collections.Generic;
using System.Text;
using YiSha.Entity.OrderManage;
using YiSha.Entity.SystemManage;

namespace YiSha.Model.Result.OrderManage
{
    /// <summary>
    /// 打印出货单相应数据
    /// </summary>
    public class Response_OrderPrintIssue
    {
        /// <summary>
        /// 打印标题
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// 打单日期
        /// </summary>
        public string PrintDay { get; set; }
        /// <summary>
        /// 单号
        /// </summary>
        public string PrintOrderNumber { get; set; }
        /// <summary>
        /// 客户名称
        /// </summary>
        public string CustName { get; set; }
        /// <summary>
        /// 联系人
        /// </summary>
        public string LinkName { get; set; }
        /// <summary>
        /// 联系电话
        /// </summary>
        public string LinkPhone { get; set; }
        /// <summary>
        /// 收货地址
        /// </summary>
        public string ReciveAddress { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }
        /// <summary>
        /// 总金额
        /// </summary>
        public decimal? TotalMoney
        {
            get {
                decimal? money = 0;
                if (this.ListProduct != null)
                {
                    foreach (OrderTerIssueEntity m in this.ListProduct)
                    {
                        money += m.TotalPrice;
                    }
                }

                return money;
            }
        
        }
        /// <summary>
        /// 实付总金额
        /// </summary>
        public decimal? FactMoney
        {
            get
            {
                decimal? money = 0;
                if (this.ListProduct != null)
                {
                    foreach (OrderTerIssueEntity m in this.ListProduct)
                    {
                        money += m.FactMoney;
                    }
                }
                return money;
            }

        }
        /// <summary>
        /// 余额
        /// </summary>
        public decimal? YuMoney
        {
            get
            {
                return this.TotalMoney - this.FactMoney;
            }

        }
        /// <summary>
        /// 商品列表
        /// </summary>
        public List<OrderTerIssueEntity> ListProduct { get; set; }
        /// <summary>
        /// 打印单实体
        /// </summary>
        public SysIssueConfigEntity SysIssueConfig { get; set; }

    }
}
