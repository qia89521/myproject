using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using YiSha.Business.OrderManage;
using YiSha.Entity.OrderManage;
using YiSha.Model.Param.OrderManage;
using YiSha.Util;
using YiSha.Util.Model;

namespace YiSha.Admin.WebApi.Controllers
{
    /// <summary>
    /// 物料管理控制器
    /// </summary>
    [Route("[controller]/[action]")]
    [ApiController]
    [AuthorizeFilter]
    public class OrderMaterielController : Controller
    {
        /// <summary>
        /// 获取物料数据列表
        /// </summary>
        /// <param name="param">查询参数</param>
        /// <returns></returns>
        [HttpPost]
        public async Task<TData<List<OrderMaterielEntity>>> GetListJson(
            OrderMaterielListParam param)
        {
            TData<List<OrderMaterielEntity>> obj = new TData<List<OrderMaterielEntity>>();
            try
            {
                obj = await new OrderMaterielBLL().GetList(param);

            }
            catch (Exception ex)
            {
                LogHelper.Info("GetPageListJson ex:" + ex.ToString());
            }

            return obj;
        }

    }
}
