using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using YiSha.Util;

namespace YiSha.Model.Param.SaleManage
{
    /// <summary>
    /// 创 建：admin
    /// 日 期：2020-09-01 15:48
    /// 描 述：意向用户实体查询类
    /// </summary>
    public class WishUserListParam
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
        /// 开始日期
        /// </summary>
        public string StartTime { get; set; }

        /// <summary>
        /// 结束日期
        /// </summary>
        public string EndTime { get; set; }
    }
}
