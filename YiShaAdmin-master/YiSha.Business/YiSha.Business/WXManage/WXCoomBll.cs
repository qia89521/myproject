using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Threading.Tasks;
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
        public async Task<string> GetSessionKey(WXSessionKeyParam entity)
        {
            StringBuilder url = new StringBuilder();
            url.AppendFormat("https://api.weixin.qq.com/sns/jscode2session");
            //?appid="+appid+"&secret="+secret+"&js_code="+code+"&grant_type=authorization_code";
            url.AppendFormat("?appid={0}", entity.AppId);
            url.AppendFormat("&secret={0}", entity.Secret);
            url.AppendFormat("&js_code={0}", entity.Code);
            url.AppendFormat("&grant_type=authorization_code");

            string content =await HttpGet(url.ToString());

            return content;
        }


        /// <summary>
        ///post 提交数据到服务器
        /// </summary>
        /// <param name="postUrl">post地址</param>
        /// <param name="json">Json数据</param>
        /// <returns></returns>
        private async Task<string> HttpGet(string postUrl, int timeout = 10 * 1000)
        {
            string result_msg = "";
            try
            {
                string formUrl = postUrl;

                // 设置提交的相关参数 
                HttpWebRequest request = WebRequest.Create(formUrl) as HttpWebRequest;
                Encoding myEncoding = Encoding.UTF8;
                request.Method = "GET";
                request.KeepAlive = false;
                request.Timeout = timeout;
                request.AllowAutoRedirect = true;
                request.ContentType = "text/html;charset=UTF-8";
                request.UserAgent = "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.1; SV1; .NET CLR 2.0.50727; .NET CLR  3.0.04506.648; .NET CLR 3.5.21022; .NET CLR 3.0.4506.2152; .NET CLR 3.5.30729)";

                using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
                {
                    using (Stream responseStream = response.GetResponseStream())
                    {
                        using (StreamReader reader = new System.IO.StreamReader(responseStream, Encoding.GetEncoding("UTF-8")))
                        {
                            result_msg = await reader.ReadToEndAsync();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                result_msg = ex.ToString();
            }
            return result_msg;
        }



    }
}
