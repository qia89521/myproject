using System;
using System.Collections.Generic;
using System.Text;

namespace YiSha.Model.Param.WXManage
{
    /// <summary>
    /// 微信 获取 session key参数实体
    /// </summary>
    public class WXSessionKeyParam
    {
        //appid, secret,code
        /// <summary>
        /// 小程序appid
        /// </summary>
        public string AppId { get; set; }
        /// <summary>
        /// 小程序密钥
        /// </summary>
        public string Secret { get; set; }
        /// <summary>
        /// 小程序 code
        /// </summary>
        public string Code { get; set; }
    }
}
