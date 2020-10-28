using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
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
        public string GetSessionKey([FromBody] WXSessionKeyParam entity)
        {
            //appid, secret,code
            string obj = wXCoomBll.GetSessionKey(entity);
            return obj;
        }
    }
}
