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
using YiSha.Model.Result.OrderManage;

namespace YiSha.Admin.Web.Areas.OrderManage.Controllers
{
    /// <summary>
    /// 创 建：admin
    /// 日 期：2020-09-20 17:56
    /// 描 述：系统出货打印单控制器类
    /// </summary>
    [Area("OrderManage")]
    public class OrderPrintIssueController :  BaseController
    {
        private OrderPrintIssueBLL orderPrintIssueBLL = new OrderPrintIssueBLL();

        #region 视图功能
        [AuthorizeFilter("order:orderprintissue:view")]
        public IActionResult OrderPrintIssueIndex()
        {
            return View();
        }

        public ActionResult OrderPrintIssueForm()
        {
            return View();
        }
        #endregion

        #region 获取数据
        [HttpGet]
        [AuthorizeFilter("order:orderprintissue:search")]
        public async Task<ActionResult> GetListJson(OrderPrintIssueListParam param)
        {
            TData<List<OrderPrintIssueEntity>> obj = await orderPrintIssueBLL.GetList(param);
            return Json(obj);
        }

        [HttpGet]
        [AuthorizeFilter("order:orderprintissue:search")]
        public async Task<ActionResult> GetPageListJson(OrderPrintIssueListParam param, Pagination pagination)
        {
            TData<List<OrderPrintIssueEntity>> obj = await orderPrintIssueBLL.GetPageList(param, pagination);
            return Json(obj);
        }

        [HttpGet]
        public async Task<ActionResult> GetFormJson(long id)
        {
            TData<OrderPrintIssueEntity> obj = await orderPrintIssueBLL.GetEntity(id);
            return Json(obj);
        }
        #endregion

        #region 提交数据
        [HttpPost]
        [AuthorizeFilter("order:orderprintissue:add,order:orderprintissue:edit")]
        public async Task<ActionResult> SaveFormJson(OrderPrintIssueEntity entity)
        {
            TData<string> obj = await orderPrintIssueBLL.SaveForm(entity);
            return Json(obj);
        }

        [HttpPost]
        [AuthorizeFilter("order:orderprintissue:delete")]
        public async Task<ActionResult> DeleteFormJson(string ids)
        {
            TData obj = await orderPrintIssueBLL.DeleteForm(ids);
            return Json(obj);
        }
        #endregion
    }
}
