using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using YiSha.Util;
using YiSha.Util.Model;

namespace YiSha.Model.Param.OrderManage
{
    /// <summary>
    /// web api物料进货单 查询类
    /// </summary>
    public class WebApi_OrderTerInputListParam
    {
        /// <summary>
        /// 工具栏参数
        /// </summary>
        public OrderTerInputListParam ListParam { get; set; }
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
    /// web api设备进货报表查询类
    /// </summary>
    public class WebApi_OrderTerInputChartParam
    {
        /// <summary>
        /// 工具栏参数
        /// </summary>
        public OrderTerInputListParam ListParam { get; set; }
        /// <summary>
        /// api token
        /// </summary>
        public string ApiToken { get; set; }
    }


    /// <summary>
    /// 创 建：admin
    /// 日 期：2020-09-09 22:52
    /// 描 述：物料进货单实体查询类
    /// </summary>
    public class OrderTerInputListParam
    {
        /// <summary>
        /// 0未审核,1:审核通过,2拒绝
        /// </summary>
        public int ShenHeStatus { get; set; }
        /// <summary>
        /// 0创建1审核中2审核通过3拒绝
        /// </summary>
        public int Step { get; set; }
        /// <summary>
        /// 分组方式 day,month 天和月分组
        /// </summary>
        public string GroupFlag { get; set; }
        /// <summary>
        /// 物料名称
        /// </summary>
        public string MaterielTxt { get; set; }
        /// <summary>
        /// 购买人
        /// </summary>
        public string BuyTxt { get; set; }
        /// <summary>
        /// 开始日期
        /// </summary>
        public string StartTime { get; set; }

        /// <summary>
        /// 结束日期
        /// </summary>
        public string EndTime { get; set; }
    }


    /// <summary>
    /// 创 建：admin
    /// 日 期：2020-10-28 18:08
    /// 描 述：进货审批或者修改类
    /// </summary>
    public class OrderTerInputParam
    {
        /*
       //基本信息
          Id: "",
      ApiToken: "",

      MaterielId: '',
      MaterielTxt: '',

      BuyId: "",
      BuyTxt: "",

      SupplierTxt: 1,
      SupplierId: 0,

      BuyNum: 1,
      BuyPrice: 0,

      //财务审核
      ShenHeManTxt: "",
      ShenHeManId: 0,
      ShenHeMsg: '',
     
         */
        public string Id { get; set; }
        public string ApiToken { get; set; }

        public string MaterielId { get; set; }
        public string MaterielTxt { get; set; }

        public string BuyId { get; set; }
        public string BuyTxt { get; set; }

        public string SupplierTxt { get; set; }
        public string SupplierId { get; set; }

        public string BuyNum { get; set; }
        public string BuyPrice { get; set; }

        public string ShenHeManTxt { get; set; }
        public string ShenHeManId { get; set; }
        public string ShenHeMsg { get; set; }
        public string ShenHeStatus { get; set;}
    }
}
