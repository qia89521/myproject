using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using YiSha.Util;
using YiSha.Util.Model;

namespace YiSha.Model.Param.OrderManage
{
    /// <summary>
    /// web api设备出货单实体查询类
    /// </summary>
    public class WebApi_OrderTerIssueListParam
    {
        /// <summary>
        /// 工具栏参数
        /// </summary>
        public OrderTerIssueListParam ListParam { get; set; }
        /// <summary>
        /// 分页参数
        /// </summary>
        public Pagination Pagination { get; set; }
        /// <summary>
        /// api token
        /// </summary>
        public string ApiToken { get; set; }
    }

    /// <summary>
    /// web api设备出货单实体查询类
    /// </summary>
    public class WebApi_OrderTerIssueChartParam
    {
        /// <summary>
        /// 工具栏参数
        /// </summary>
        public OrderTerIssueListParam ListParam { get; set; }
        /// <summary>
        /// api token
        /// </summary>
        public string ApiToken { get; set; }
    }

    /// <summary>
    /// 创 建：admin
    /// 日 期：2020-10-28 18:08
    /// 描 述：订单收据实体新增或者修改类
    /// </summary>
    public class OrderTerIssueParam
    {
        /*
       Id: "",
      ApiToken: "",

      MaterielId: '',
      MaterielTxt: '',

      SaleId: "",
      SaleTxt: "",

      SaleNum: 1,
      SalePrice: 0,
      SrcPrice: 0,
      BuyDay: '',
      FactMoney: 0,
      //收件人信息
      TakeType: 0,
      ReciveName: '',
      RecivePhone: '',
      ReciveZone: '',
      ReciveAddre: '',
      //财务审核
      ShenHeManTxt: "",
      ShenHeManId: 0,
      ShenHeMsg: '',
      //售后发货
      SentManTxt: "",
      SentManId: 0,

      SentDay: '',
      ExpressCompany: '',
      ExpressNumber: '',
      Remark: '',
     
         */
        public string Id { get; set; }
        public string ApiToken { get; set; }

        public string MaterielId { get; set; }
        public string MaterielTxt { get; set; }

        public string SaleId { get; set; }
        public string SaleTxt { get; set; }

        public string SaleNum { get; set; }
        public string SalePrice { get; set; }
        public string SrcPrice { get; set; }
        public string BuyDay { get; set; }
        public string FactMoney { get; set; }
        public string TakeType { get; set; }
        public string ReciveName { get; set; }
        public string RecivePhone { get; set; }
        public string ReciveZone { get; set; }
        public string ReciveAddre { get; set; }

        public string ShenHeManTxt { get; set; }
        public string ShenHeManId { get; set; }
        public string ShenHeMsg { get; set; }

        public string SentManTxt { get; set; }
        public string SentManId { get; set; }
        public string SentDay { get; set; }
        public string ExpressCompany { get; set; }
        public string ExpressNumber { get; set; }
        public string Remark { get; set; }

    }

    /// <summary>
    /// 创 建：admin
    /// 日 期：2020-08-25 17:33
    /// 描 述：设备出货单实体查询类
    /// </summary>
    public class OrderTerIssueListParam
    {
        /// <summary>
        /// 分组方式 day,month 天和月分组
        /// </summary>
        public string GroupFlag { get; set; }
        /// <summary>
        /// 销售人
        /// </summary>
        public string SaleTxt { get; set; }
        /// <summary>
        /// 开始日期
        /// </summary>
        public string StartTime { get; set; }
        /// <summary>
        /// 结束日期
        /// </summary>
        public string EndTime { get; set; }
        /// <summary>
        /// 审核步骤 0:草稿,1:财务审核,2:售后发货,3:流程结束
        /// </summary>
        public int Step { get; set; }
        /// <summary>
        /// 0未审核,1:审核通过,2拒绝
        /// </summary>
        public int ShenHeStatus { get; set; }
        /// <summary>
        ///0未发货1已发货
        /// </summary>
        public int IsSent { get; set; }
    }
}
