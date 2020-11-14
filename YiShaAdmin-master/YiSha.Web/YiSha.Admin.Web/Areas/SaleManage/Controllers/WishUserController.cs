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
using YiSha.Entity.SaleManage;
using YiSha.Business.SaleManage;
using YiSha.Model.Param.SaleManage;
using YiSha.Web.Code;

namespace YiSha.Admin.Web.Areas.SaleManage.Controllers
{
    /// <summary>
    /// 创 建：admin
    /// 日 期：2020-09-01 15:48
    /// 描 述：意向用户控制器类
    /// </summary>
    [Area("SaleManage")]
    public class WishUserController :  BaseController
    {
        private WishUserBLL wishUserBLL = new WishUserBLL();

        #region 视图功能
        [AuthorizeFilter("sale:wishuser:view")]
        public ActionResult WishUserIndex()
        {
            return View();
        }

        public ActionResult WishUserForm()
        {
            return View();
        }
        #endregion

        #region 获取数据
        [HttpGet]
        [AuthorizeFilter("sale:wishuser:search")]
        public async Task<ActionResult> GetListJson(WishUserListParam param)
        {
            OperatorInfo user = await Operator.Instance.Current();
            TData<List<WishUserEntity>> obj = await wishUserBLL.GetList(param,user);
            return Json(obj);
        }

        [HttpGet]
        [AuthorizeFilter("sale:wishuser:search")]
        public async Task<ActionResult> GetPageListJson(WishUserListParam param, Pagination pagination)
        {
            OperatorInfo user = await Operator.Instance.Current();
            TData<List<WishUserEntity>> obj = await wishUserBLL.GetPageList(param, pagination,user);
            return Json(obj);
        }

        [HttpGet]
        public async Task<ActionResult> GetFormJson(long id)
        {
            TData<WishUserEntity> obj = await wishUserBLL.GetEntity(id);
            return Json(obj);
        }
        #endregion

        #region 提交数据
        [HttpPost]
        [AuthorizeFilter("sale:wishuser:add,sale:wishuser:edit")]
        public async Task<ActionResult> SaveFormJson(WishUserEntity entity)
        {
            TData<string> obj = await wishUserBLL.SaveForm(entity);
            return Json(obj);
        }

        [HttpPost]
        [AuthorizeFilter("sale:wishuser:delete")]
        public async Task<ActionResult> DeleteFormJson(string ids)
        {
            TData obj = await wishUserBLL.DeleteForm(ids);
            return Json(obj);
        }
        #endregion
    }
}
