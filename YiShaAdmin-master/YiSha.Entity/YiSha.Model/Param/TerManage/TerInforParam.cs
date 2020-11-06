using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using YiSha.Util;
using YiSha.Util.Model;
using YiSha.Web.Code;

namespace YiSha.Model.Param.TerManage
{
    /// <summary>
    /// web api设备信息查询类
    /// </summary>
    public class WebApi_TerInforListParam {
        /// <summary>
        /// 工具栏参数
        /// </summary>
        public TerInforListParam ListParam { get;set;}
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
    /// 创 建：admin
    /// 日 期：2020-08-14 16:05
    /// 描 述：设备信息实体查询类
    /// </summary>
    public class TerInforListParam
    {

        /// <summary>
        /// 设备名称
        /// </summary>
        public string TerName { get; set; }
        /// <summary>
        /// 设备编号
        /// </summary>
        public string TerNumber { get; set; }

        /// <summary>
        /// 开始日期
        /// </summary>
        public string StartTime { get; set; }

        /// <summary>
        /// 结束日期
        /// </summary>
        public string EndTime { get; set; }

    }
}
