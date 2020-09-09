using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;
using YiSha.Util;
using YiSha.Util.Model;
using YiSha.Entity;
using YiSha.Model;
using YiSha.Admin.Web.Controllers;
using YiSha.Entity.OrderManage;
using YiSha.Business.OrderManage;
using YiSha.Model.Param.OrderManage;

namespace YiSha.Admin.Web.Areas.OrderManage.Controllers
{
    /// <summary>
    /// 创 建：admin
    /// 日 期：2020-09-09 22:53
    /// 描 述：供应商控制器类
    /// </summary>
    [Area("OrderManage")]
    public class OrderSupplierController :  BaseController
    {
        private OrderSupplierBLL orderSupplierBLL = new OrderSupplierBLL();

        #region 视图功能
        [AuthorizeFilter("order:ordersupplier:view")]
        public ActionResult OrderSupplierIndex()
        {
            return View();
        }

        public ActionResult OrderSupplierForm()
        {
            return View();
        }
        #endregion

        #region 获取数据
        [HttpGet]
        [AuthorizeFilter("order:ordersupplier:search")]
        public async Task<ActionResult> GetListJson(OrderSupplierListParam param)
        {
            TData<List<OrderSupplierEntity>> obj = await orderSupplierBLL.GetList(param);
            return Json(obj);
        }

        [HttpGet]
        [AuthorizeFilter("order:ordersupplier:search")]
        public async Task<ActionResult> GetPageListJson(OrderSupplierListParam param, Pagination pagination)
        {
            TData<List<OrderSupplierEntity>> obj = await orderSupplierBLL.GetPageList(param, pagination);
            return Json(obj);
        }

        [HttpGet]
        public async Task<ActionResult> GetFormJson(long id)
        {
            TData<OrderSupplierEntity> obj = await orderSupplierBLL.GetEntity(id);
            return Json(obj);
        }
        #endregion

        #region 提交数据
        [HttpPost]
        [AuthorizeFilter("order:ordersupplier:add,order:ordersupplier:edit")]
        public async Task<ActionResult> SaveFormJson(OrderSupplierEntity entity)
        {
            TData<string> obj = await orderSupplierBLL.SaveForm(entity);
            return Json(obj);
        }

        [HttpPost]
        [AuthorizeFilter("order:ordersupplier:delete")]
        public async Task<ActionResult> DeleteFormJson(string ids)
        {
            TData obj = await orderSupplierBLL.DeleteForm(ids);
            return Json(obj);
        }
        #endregion
    }
}
