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
    /// 日 期：2020-08-19 23:55
    /// 描 述：用户缴费订单记录控制器类
    /// </summary>
    [Area("OrderManage")]
    public class OrderUserFormController :  BaseController
    {
        private OrderUserFormBLL orderUserFormBLL = new OrderUserFormBLL();

        #region 视图功能
        [AuthorizeFilter("order:orderuserform:view")]
        public ActionResult OrderUserFormIndex()
        {
            return View();
        }

        public ActionResult OrderUserFormForm()
        {
            return View();
        }
        #endregion

        #region 获取数据
        [HttpGet]
        [AuthorizeFilter("order:orderuserform:search")]
        public async Task<ActionResult> GetListJson(OrderUserFormListParam param)
        {
            TData<List<OrderUserFormEntity>> obj = await orderUserFormBLL.GetList(param);
            return Json(obj);
        }

        [HttpGet]
        [AuthorizeFilter("order:orderuserform:search")]
        public async Task<ActionResult> GetPageListJson(OrderUserFormListParam param, Pagination pagination)
        {
            TData<List<OrderUserFormEntity>> obj = await orderUserFormBLL.GetPageList(param, pagination);
            return Json(obj);
        }

        [HttpGet]
        public async Task<ActionResult> GetFormJson(long id)
        {
            TData<OrderUserFormEntity> obj = await orderUserFormBLL.GetEntity(id);
            return Json(obj);
        }
        #endregion

        #region 提交数据
        [HttpPost]
        [AuthorizeFilter("order:orderuserform:add,order:orderuserform:edit")]
        public async Task<ActionResult> SaveFormJson(OrderUserFormEntity entity)
        {
            TData<string> obj = await orderUserFormBLL.SaveForm(entity);
            return Json(obj);
        }

        [HttpPost]
        [AuthorizeFilter("order:orderuserform:delete")]
        public async Task<ActionResult> DeleteFormJson(string ids)
        {
            TData obj = await orderUserFormBLL.DeleteForm(ids);
            return Json(obj);
        }
        #endregion
    }
}
