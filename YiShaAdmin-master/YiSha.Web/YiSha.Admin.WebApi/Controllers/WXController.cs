using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using YiSha.Business.SmsManage;
using YiSha.Business.WXManage;
using YiSha.Model.Param.WXManage;
using YiSha.Util.Model;

namespace YiSha.Admin.WebApi.Controllers
{
    /// <summary>
    /// 公众号微信控制器
    /// </summary>
    [Route("[controller]/[action]")]
    [ApiController]
    [AuthorizeFilter]
    public class WXController : Controller
    {
        WXCoomBll wXCoomBll = new WXCoomBll();

        /// <summary>
        /// 获取seesion 信息
        /// </summary>
        /// <param name="entity">实体数据</param>
        /// <returns></returns>
        [HttpPost]
        public async Task<string> GetSessionKey([FromBody] WXSessionKeyParam entity)
        {
            //appid, secret,code
            string obj = await wXCoomBll.GetSessionKey(entity);
            return obj;
        }
        /// <summary>
        /// 发送短信
        /// </summary>
        /// <param name="phone">手机号</param>
        /// <returns></returns>
        [HttpPost]
        public async Task<TData<string>> SentSms([FromQuery] string phone)
        {
            //appid, secret,code
            TData<string> obj = await new SmsCodeBLL().SentSms(phone);
            return obj;
        }


        /// <summary>
        /// 检测短信
        /// </summary>
        /// <param name="phone">手机号</param>
        ///  <param name="code">验证码</param>
        /// <returns></returns>
        [HttpPost]
        public TData<string> CheckSms([FromQuery] string phone, [FromQuery] string code)
        {
            //appid, secret,code
            TData<string> obj = new SmsCodeBLL().CheckSms(phone,code);
            return obj;
        }
    }
}
