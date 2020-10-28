using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using YiSha.Business.SystemManage;
using YiSha.Entity.SystemManage;
using YiSha.Util.Model;

namespace YiSha.Admin.WebApi.Controllers
{
    /// <summary>
    /// 公众号微信控制器
    /// </summary>
    [Route("[controller]/[action]")]
    [ApiController]
    [AuthorizeFilter]
    public class SysAppConfigController : Controller
    {
        SysAppConfigBLL wXCoomBll = new SysAppConfigBLL();
        /// <summary>
        /// 系统配置
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public async Task<TData<SysAppConfigEntity>> GetAppConfig()
        {
            //appid, secret,code
            TData<SysAppConfigEntity> entity =await wXCoomBll.GetEntity();
            return entity;
        }
    }
}
