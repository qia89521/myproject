using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using YiSha.Business.TerManage;
using YiSha.Entity.TerManage;
using YiSha.Util.Model;

namespace YiSha.Admin.WebApi.Controllers
{
    /// <summary>
    /// 设备状态控制器
    /// </summary>
    [Route("[controller]/[action]")]
    [ApiController]
    [AuthorizeFilter]
    public class TerStatusController : Controller
    {
        TerStatusBLL terStatusBll = new TerStatusBLL();
        
        /// <summary>
        /// 保存状态信息
        /// </summary>
        /// <param name="entity">实体数据</param>
        /// <returns></returns>
        [HttpPost]
        public async Task<TData<string>> SaveForm([FromBody] TerStatusEntity entity)
        {
            TData<string> obj = await terStatusBll.SaveForm(entity);
            return obj;
        }
    }
}
