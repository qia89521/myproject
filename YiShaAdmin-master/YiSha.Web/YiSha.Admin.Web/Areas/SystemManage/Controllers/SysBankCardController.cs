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
using YiSha.Entity.SystemManage;
using YiSha.Business.SystemManage;
using YiSha.Model.Param.SystemManage;

namespace YiSha.Admin.Web.Areas.SystemManage.Controllers
{
    /// <summary>
    /// 创 建：admin
    /// 日 期：2020-08-20 09:48
    /// 描 述：收款银行卡管理控制器类
    /// </summary>
    [Area("SystemManage")]
    public class SysBankCardController :  BaseController
    {
        private SysBankCardBLL sysBankCardBLL = new SysBankCardBLL();

        #region 视图功能
        [AuthorizeFilter("system:sysbankcard:view")]
        public ActionResult SysBankCardIndex()
        {
            return View();
        }
        [AuthorizeFilter("system:sysbankcard:view")]
        public ActionResult SysBankCardIndexSelect()
        {
            return View();
        }

        public ActionResult SysBankCardForm()
        {
            return View();
        }
        #endregion

        #region 获取数据
        [HttpGet]
        [AuthorizeFilter("system:sysbankcard:search")]
        public async Task<ActionResult> GetListJson(SysBankCardListParam param)
        {
            TData<List<SysBankCardEntity>> obj = await sysBankCardBLL.GetList(param);
            return Json(obj);
        }

        [HttpGet]
        [AuthorizeFilter("system:sysbankcard:search")]
        public async Task<ActionResult> GetPageListJson(SysBankCardListParam param, Pagination pagination)
        {
            TData<List<SysBankCardEntity>> obj = await sysBankCardBLL.GetPageList(param, pagination);
            return Json(obj);
        }

        [HttpGet]
        public async Task<ActionResult> GetFormJson(long id)
        {
            TData<SysBankCardEntity> obj = await sysBankCardBLL.GetEntity(id);
            return Json(obj);
        }
        #endregion

        #region 提交数据
        [HttpPost]
        [AuthorizeFilter("system:sysbankcard:add,system:sysbankcard:edit")]
        public async Task<ActionResult> SaveFormJson(SysBankCardEntity entity)
        {
            TData<string> obj = await sysBankCardBLL.SaveForm(entity);
            return Json(obj);
        }

        [HttpPost]
        [AuthorizeFilter("system:sysbankcard:delete")]
        public async Task<ActionResult> DeleteFormJson(string ids)
        {
            TData obj = await sysBankCardBLL.DeleteForm(ids);
            return Json(obj);
        }
        #endregion
    }
}
