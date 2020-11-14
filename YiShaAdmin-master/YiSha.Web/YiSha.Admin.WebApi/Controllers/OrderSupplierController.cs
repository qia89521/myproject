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
    /// 供应商理控制器
    /// </summary>
    [Route("[controller]/[action]")]
    [ApiController]
    [AuthorizeFilter]
    public class OrderSupplierController : Controller
    {
        /// <summary>
        /// 获取物料数据列表
        /// </summary>
        /// <param name="param">查询参数</param>
        /// <returns></returns>
        [HttpPost]
        public async Task<TData<List<OrderSupplierEntity>>> GetListJson(
            OrderSupplierListParam param)
        {
            TData<List<OrderSupplierEntity>> obj = new TData<List<OrderSupplierEntity>>();
            try
            {
                obj = await new OrderSupplierBLL().GetList(param);

            }
            catch (Exception ex)
            {
                LogHelper.Info("GetPageListJson ex:" + ex.ToString());
            }

            return obj;
        }

    }
}
