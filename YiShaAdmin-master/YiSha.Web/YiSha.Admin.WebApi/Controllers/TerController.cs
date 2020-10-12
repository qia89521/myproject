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
    /// <summary>
    /// 终端信息控制器
    /// </summary>
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
            TData<string> obj = await terInforBLL.ModifyPosition(entity.number,entity.fistLongitude,entity.fistLatitude,entity.address);
            return obj;
        }

        /// <summary>
        /// 保存终端位置状态信息
        /// </summary>
        /// <param name="number">设备编号</param>
        /// <returns></returns>
        [HttpPost]
        public async Task<TData<string>> CheckNumber(String number)
        {
            TData<string> obj = await terInforBLL.CheckNumber(number);
            return obj;
        }
    }
}
