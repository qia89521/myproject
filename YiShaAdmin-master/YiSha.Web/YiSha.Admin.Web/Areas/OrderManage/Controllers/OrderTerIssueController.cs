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
using YiSha.Web.Code;
using YiSha.Model.Result.OrderManage;

namespace YiSha.Admin.Web.Areas.OrderManage.Controllers
{
    /// <summary>
    /// 创 建：admin
    /// 日 期：2020-08-25 17:33
    /// 描 述：设备出货单控制器类
    /// </summary>
    [Area("OrderManage")]
    public class OrderTerIssueController :  BaseController
    {
        private OrderTerIssueBLL orderTerIssueBLL = new OrderTerIssueBLL();
        private OrderPrintIssueBLL orderPrintIssueBLL = new OrderPrintIssueBLL();

        #region 视图功能
        [AuthorizeFilter("order:orderterissue:view")]
        public ActionResult OrderTerIssueIndex()
        {
            return View();
        }

        public async Task<IActionResult> OrderTerIssueForm()
        {
            ViewBag.OperatorInfo = await Operator.Instance.Current();
            return View();
        }

        /// <summary>
        /// 打印界面
        /// </summary>
        /// <returns></returns>
        public async Task<IActionResult> OrderTerIssuePrint()
        {
            string ids = Request.Query["ids"];

            Response_OrderPrintIssue data = await orderPrintIssueBLL.GetPrintData(ids);
            //ViewBag.Response_OrderPrintIssue = data;

            return View(data);
        }
        #endregion

        #region 获取数据
        [HttpGet]
        [AuthorizeFilter("order:orderterissue:search")]
        public async Task<ActionResult> GetListJson(OrderTerIssueListParam param)
        {
            TData<List<OrderTerIssueEntity>> obj = await orderTerIssueBLL.GetList(param);
            return Json(obj);
        }

        [HttpGet]
        [AuthorizeFilter("order:orderterissue:search")]
        public async Task<ActionResult> GetPageListJson(OrderTerIssueListParam param, Pagination pagination)
        {
            TData<List<OrderTerIssueEntity>> obj = await orderTerIssueBLL.GetPageList(param, pagination);
            return Json(obj);
        }

        [HttpGet]
        public async Task<ActionResult> GetFormJson(long id)
        {
            TData<OrderTerIssueEntity> obj = await orderTerIssueBLL.GetEntity(id);
            return Json(obj);
        }
        #endregion

        #region 提交数据
        [HttpPost]
        [AuthorizeFilter("order:orderterissue:add,order:orderterissue:edit")]
        public async Task<ActionResult> SaveFormJson(OrderTerIssueEntity entity)
        {
            TData<string> obj = await orderTerIssueBLL.SaveForm(entity);
            return Json(obj);
        }

        [HttpPost]
        [AuthorizeFilter("order:orderterissue:delete")]
        public async Task<ActionResult> DeleteFormJson(string ids)
        {
            TData obj = await orderTerIssueBLL.DeleteForm(ids);
            return Json(obj);
        }
        #endregion
    }
}
