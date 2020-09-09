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
    /// 日 期：2020-09-09 22:52
    /// 描 述：物料进货单控制器类
    /// </summary>
    [Area("OrderManage")]
    public class OrderTerInputController :  BaseController
    {
        private OrderTerInputBLL orderTerInputBLL = new OrderTerInputBLL();

        #region 视图功能
        [AuthorizeFilter("order:orderterinput:view")]
        public ActionResult OrderTerInputIndex()
        {
            return View();
        }

        public ActionResult OrderTerInputForm()
        {
            return View();
        }
        #endregion

        #region 获取数据
        [HttpGet]
        [AuthorizeFilter("order:orderterinput:search")]
        public async Task<ActionResult> GetListJson(OrderTerInputListParam param)
        {
            TData<List<OrderTerInputEntity>> obj = await orderTerInputBLL.GetList(param);
            return Json(obj);
        }

        [HttpGet]
        [AuthorizeFilter("order:orderterinput:search")]
        public async Task<ActionResult> GetPageListJson(OrderTerInputListParam param, Pagination pagination)
        {
            TData<List<OrderTerInputEntity>> obj = await orderTerInputBLL.GetPageList(param, pagination);
            return Json(obj);
        }

        [HttpGet]
        public async Task<ActionResult> GetFormJson(long id)
        {
            TData<OrderTerInputEntity> obj = await orderTerInputBLL.GetEntity(id);
            return Json(obj);
        }
        #endregion

        #region 提交数据
        [HttpPost]
        [AuthorizeFilter("order:orderterinput:add,order:orderterinput:edit")]
        public async Task<ActionResult> SaveFormJson(OrderTerInputEntity entity)
        {
            TData<string> obj = await orderTerInputBLL.SaveForm(entity);
            return Json(obj);
        }

        [HttpPost]
        [AuthorizeFilter("order:orderterinput:delete")]
        public async Task<ActionResult> DeleteFormJson(string ids)
        {
            TData obj = await orderTerInputBLL.DeleteForm(ids);
            return Json(obj);
        }
        #endregion
    }
}
