using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using YiSha.Business.TerManage;
using YiSha.Model.Param.TerManage;
using YiSha.Util.Model;

namespace YiSha.Admin.WebApi.Controllers
{
    [Route("[controller]/[action]")]
    [ApiController]
    [AuthorizeFilter]
    public class TerController : Controller
    {

        TerInforBLL terInforBLL = new TerInforBLL();

        /// <summary>
        /// 保存终端位置状态信息
        /// </summary>
        /// <param name="entity">实体数据</param>
        /// <returns></returns>
        [HttpPost]
        public async Task<TData<string>> SaveForm([FromBody] TerPositionParam entity)
        {
            TData<string> obj = await terInforBLL.ModifyPosition(entity.number,entity.fistLongitude,entity.fistLatitude);
            return obj;
        }
    }
}
