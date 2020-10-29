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
    /// 日 期：2020-10-28 18:04
    /// 描 述：系统收据配置控制器类
    /// </summary>
    [Area("SystemManage")]
    public class SysReceiptConfigController :  BaseController
    {
        private SysReceiptConfigBLL sysReceiptConfigBLL = new SysReceiptConfigBLL();

        #region 视图功能
        [AuthorizeFilter("system:sysreceiptconfig:view")]
        public ActionResult SysReceiptConfigIndex()
        {
            return View();
        }

        [AuthorizeFilter("system:sysreceiptconfig:select")]
        public ActionResult SysReceiptConfigIndexSelect()
        {
            return View();
        }

        public ActionResult SysReceiptConfigForm()
        {
            return View();
        }
        #endregion

        #region 获取数据
        [HttpGet]
        [AuthorizeFilter("system:sysreceiptconfig:search")]
        public async Task<ActionResult> GetListJson(SysReceiptConfigListParam param)
        {
            TData<List<SysReceiptConfigEntity>> obj = await sysReceiptConfigBLL.GetList(param);
            return Json(obj);
        }

        [HttpGet]
        [AuthorizeFilter("system:sysreceiptconfig:search")]
        public async Task<ActionResult> GetPageListJson(SysReceiptConfigListParam param, Pagination pagination)
        {
            TData<List<SysReceiptConfigEntity>> obj = await sysReceiptConfigBLL.GetPageList(param, pagination);
            return Json(obj);
        }

        [HttpGet]
        public async Task<ActionResult> GetFormJson(long id)
        {
            TData<SysReceiptConfigEntity> obj = await sysReceiptConfigBLL.GetEntity(id);
            return Json(obj);
        }
        #endregion

        #region 提交数据
        [HttpPost]
        [AuthorizeFilter("system:sysreceiptconfig:add,system:sysreceiptconfig:edit")]
        public async Task<ActionResult> SaveFormJson(SysReceiptConfigEntity entity)
        {
            TData<string> obj = await sysReceiptConfigBLL.SaveForm(entity);
            return Json(obj);
        }

        [HttpPost]
        [AuthorizeFilter("system:sysreceiptconfig:delete")]
        public async Task<ActionResult> DeleteFormJson(string ids)
        {
            TData obj = await sysReceiptConfigBLL.DeleteForm(ids);
            return Json(obj);
        }
        #endregion
    }
}
