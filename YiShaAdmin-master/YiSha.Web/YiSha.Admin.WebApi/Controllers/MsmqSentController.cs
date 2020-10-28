using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

using System.IO;
using System.Net;
using System.Reflection;
using System.Text;
using YiSha.Util;
using YiSha.Model.Param;

namespace YiSha.Admin.WebApi.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [Route("[controller]/[action]")]
    [ApiController]
    [AuthorizeFilter]
    public class MsmqSentController : Controller
    {

        private readonly IConfiguration _iConfiguration;
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="iConfiguration"></param>
        public MsmqSentController(IConfiguration iConfiguration)
        {
            _iConfiguration = iConfiguration;
        }
        /// <summary>
        /// 发送消息   Msmq/SentMsmq
        /// </summary>
        /// <param name="entity">实体数据</param>
        /// <returns></returns>
        [HttpPost]
        public async Task<string> Sent([FromBody] MsmqMsg entity)
        {
            string postHost = CoomHelper.GetConfig("SystemConfig:MsmqWeb"); //"http://msmq.puosen.cn";
            string postUrl = string.Format("{0}/services/msmq.ashx", postHost);
            string json = JsonHelper.SerializeObject(entity);
            string return_msg = await PostData(postUrl, json);
            return return_msg;
        }

        /// <summary>
        ///post提交数据
        /// </summary>
        /// <param name="posturl">post url</param>
        /// <param name="postData">post 数据</param>
        /// <returns></returns>
        public async Task<string> PostData(string posturl, string postData)
        {
            string return_msg = "";
            Stream outstream = null;
            Stream instream = null;
            StreamReader sr = null;
            HttpWebRequest request = null;
            Encoding encoding = Encoding.UTF8;
            byte[] data = encoding.GetBytes(postData);
            // 准备请求...
            try
            {
                // 设置参数
                request = WebRequest.Create(posturl) as HttpWebRequest;

                CookieContainer cookieContainer = new CookieContainer();
                request.CookieContainer = cookieContainer;
                request.AllowAutoRedirect = true;
                request.Method = "POST";
                request.ContentType = "application/json;charset=UTF-8";
                request.ContentLength = data.Length;
                outstream = request.GetRequestStream();
                await outstream.WriteAsync(data, 0, data.Length);
                outstream.Close();
                //发送请求并获取相应回应数据 GetResponse
                var res = await request.GetResponseAsync();
                //直到request.GetResponse()程序才开始向目标网页发送Post请求
                instream = (res as HttpWebResponse).GetResponseStream();
                sr = new StreamReader(instream, encoding);
                //返回结果网页（html）代码
                return_msg = await sr.ReadToEndAsync();


            }
            catch (Exception ex)
            {
                return_msg = "fail";
            }
            return return_msg;
        }

    }
}
