using System;
using System.Collections.Generic;
using System.Text;
using YiSha.Model.Param.WXManage;
using YiSha.Util;

namespace YiSha.Business.WXManage
{
    /// <summary>
    /// 微信小程序通用接口处理
    /// </summary>
    public class WXCoomBll
    {
        /// <summary>
        /// 获取公众号凭证信息
        /// </summary>
        /// <param name="appid">小程序appid</param>
        /// <param name="searcate">小程序密钥</param>
        /// <param name="code">获取code</param>
        /// <returns></returns>
        public string GetSessionKey(WXSessionKeyParam entity)
        {
            StringBuilder url = new StringBuilder();
            url.AppendFormat("https://api.weixin.qq.com/sns/jscode2session");
            //?appid="+appid+"&secret="+secret+"&js_code="+code+"&grant_type=authorization_code";
            url.AppendFormat("?appid={0}", entity.AppId);
            url.AppendFormat("&secret={0}", entity.Secret);
            url.AppendFormat("&js_code={0}", entity.Code);
            url.AppendFormat("&grant_type=authorization_code");

            string content = HttpHelper.HttpGet(url.ToString());

            return content.ToString();
        }
    }
}
