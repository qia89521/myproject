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
    /// 日 期：2020-08-25 17:43
    /// 描 述：订单用户收益控制器类
    /// </summary>
    [Area("OrderManage")]
    public class OrderUserProfitController :  BaseController
    {
        private OrderUserProfitBLL orderUserProfitBLL = new OrderUserProfitBLL();

        #region 视图功能
        [AuthorizeFilter("order:orderuserprofit:view")]
        public ActionResult OrderUserProfitIndex()
        {
            return View();
        }

        public ActionResult OrderUserProfitForm()
        {
            return View();
        }
        #endregion

        #region 获取数据
        [HttpGet]
        [AuthorizeFilter("order:orderuserprofit:search")]
        public async Task<ActionResult> GetListJson(OrderUserProfitListParam param)
        {
            TData<List<OrderUserProfitEntity>> obj = await orderUserProfitBLL.GetList(param);
            return Json(obj);
        }

        [HttpGet]
        [AuthorizeFilter("order:orderuserprofit:search")]
        public async Task<ActionResult> GetPageListJson(OrderUserProfitListParam param, Pagination pagination)
        {
            TData<List<OrderUserProfitEntity>> obj = await orderUserProfitBLL.GetPageList(param, pagination);
            return Json(obj);
        }

        [HttpGet]
        public async Task<ActionResult> GetFormJson(long id)
        {
            TData<OrderUserProfitEntity> obj = await orderUserProfitBLL.GetEntity(id);
            return Json(obj);
        }
        #endregion

        #region 提交数据
        [HttpPost]
        [AuthorizeFilter("order:orderuserprofit:add,order:orderuserprofit:edit")]
        public async Task<ActionResult> SaveFormJson(OrderUserProfitEntity entity)
        {
            TData<string> obj = await orderUserProfitBLL.SaveForm(entity);
            return Json(obj);
        }

        [HttpPost]
        [AuthorizeFilter("order:orderuserprofit:delete")]
        public async Task<ActionResult> DeleteFormJson(string ids)
        {
            TData obj = await orderUserProfitBLL.DeleteForm(ids);
            return Json(obj);
        }
        #endregion
    }
}
