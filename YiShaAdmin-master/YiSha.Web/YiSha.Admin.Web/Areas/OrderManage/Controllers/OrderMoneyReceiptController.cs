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

namespace YiSha.Admin.Web.Areas.OrderManage.Controllers
{
    /// <summary>
    /// 创 建：admin
    /// 日 期：2020-10-28 18:08
    /// 描 述：订单收据控制器类
    /// </summary>
    [Area("OrderManage")]
    public class OrderMoneyReceiptController :  BaseController
    {
        private OrderMoneyReceiptBLL orderMoneyReceiptBLL = new OrderMoneyReceiptBLL();

        #region 视图功能
        [AuthorizeFilter("order:ordermoneyreceipt:view")]
        public ActionResult OrderMoneyReceiptIndex()
        {
            return View();
        }

        public ActionResult OrderMoneyReceiptForm()
        {
            return View();
        }

        /// <summary>
        /// 打印收据
        /// </summary>
        /// <returns></returns>
        public async Task<IActionResult> OrderMoneyReceiptPrint()
        {
            string ids = Request.Query["ids"];

            OrderMoneyReceiptEntity model = new OrderMoneyReceiptEntity();
            TData<OrderMoneyReceiptEntity> data=await orderMoneyReceiptBLL.GetEntity(long.Parse(ids));
            if (data.Data != null)
            {
                model = data.Data;
            }

            return View(model);
        }

        #endregion

        #region 获取数据
        [HttpGet]
        [AuthorizeFilter("order:ordermoneyreceipt:search")]
        public async Task<ActionResult> GetListJson(OrderMoneyReceiptListParam param)
        {
            OperatorInfo opuser =await Operator.Instance.Current();
            TData<List<OrderMoneyReceiptEntity>> obj = await orderMoneyReceiptBLL.GetList(param,opuser);
            return Json(obj);
        }

        [HttpGet]
        [AuthorizeFilter("order:ordermoneyreceipt:search")]
        public async Task<ActionResult> GetPageListJson(OrderMoneyReceiptListParam param, Pagination pagination)
        {
            OperatorInfo opuser = await Operator.Instance.Current();
            TData<List<OrderMoneyReceiptEntity>> obj = await orderMoneyReceiptBLL.GetPageList(param, pagination, opuser);
            return Json(obj);
        }

        [HttpGet]
        public async Task<ActionResult> GetFormJson(long id)
        {
            TData<OrderMoneyReceiptEntity> obj = await orderMoneyReceiptBLL.GetEntity(id);
            return Json(obj);
        }
        #endregion

        #region 提交数据
        [HttpPost]
        [AuthorizeFilter("order:ordermoneyreceipt:add,order:ordermoneyreceipt:edit")]
        public async Task<ActionResult> SaveFormJson(OrderMoneyReceiptEntity entity)
        {
            TData<string> obj = await orderMoneyReceiptBLL.SaveForm(entity);
            return Json(obj);
        }

        [HttpPost]
        [AuthorizeFilter("order:ordermoneyreceipt:delete")]
        public async Task<ActionResult> DeleteFormJson(string ids)
        {
            TData obj = await orderMoneyReceiptBLL.DeleteForm(ids);
            return Json(obj);
        }
        #endregion
    }
}
