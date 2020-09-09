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
    /// 日 期：2020-09-08 18:14
    /// 描 述：物料明细控制器类
    /// </summary>
    [Area("OrderManage")]
    public class OrderMaterielDetailController :  BaseController
    {
        private OrderMaterielDetailBLL orderMaterielDetailBLL = new OrderMaterielDetailBLL();

        #region 视图功能
        [AuthorizeFilter("order:ordermaterieldetail:view")]
        public ActionResult OrderMaterielDetailIndex()
        {
            return View();
        }

        public ActionResult OrderMaterielDetailForm()
        {
            return View();
        }
        #endregion

        #region 获取数据
        [HttpGet]
        [AuthorizeFilter("order:ordermaterieldetail:search")]
        public async Task<ActionResult> GetListJson(OrderMaterielDetailListParam param)
        {
            TData<List<OrderMaterielDetailEntity>> obj = await orderMaterielDetailBLL.GetList(param);
            return Json(obj);
        }

        [HttpGet]
        [AuthorizeFilter("order:ordermaterieldetail:search")]
        public async Task<ActionResult> GetPageListJson(OrderMaterielDetailListParam param, Pagination pagination)
        {
            TData<List<OrderMaterielDetailEntity>> obj = await orderMaterielDetailBLL.GetPageList(param, pagination);
            return Json(obj);
        }

        [HttpGet]
        public async Task<ActionResult> GetFormJson(long id)
        {
            TData<OrderMaterielDetailEntity> obj = await orderMaterielDetailBLL.GetEntity(id);
            return Json(obj);
        }
        #endregion

        #region 提交数据
        [HttpPost]
        [AuthorizeFilter("order:ordermaterieldetail:add,order:ordermaterieldetail:edit")]
        public async Task<ActionResult> SaveFormJson(OrderMaterielDetailEntity entity)
        {
            TData<string> obj = await orderMaterielDetailBLL.SaveForm(entity);
            return Json(obj);
        }

        [HttpPost]
        [AuthorizeFilter("order:ordermaterieldetail:delete")]
        public async Task<ActionResult> DeleteFormJson(string ids)
        {
            TData obj = await orderMaterielDetailBLL.DeleteForm(ids);
            return Json(obj);
        }
        #endregion
    }
}
