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
    /// 日 期：2020-10-28 18:03
    /// 描 述：系统应用配置控制器类
    /// </summary>
    [Area("SystemManage")]
    public class SysAppConfigController :  BaseController
    {
        private SysAppConfigBLL sysAppConfigBLL = new SysAppConfigBLL();

        #region 视图功能
        [AuthorizeFilter("system:sysappconfig:view")]
        public ActionResult SysAppConfigIndex()
        {
            return View();
        }

        public ActionResult SysAppConfigForm()
        {
            return View();
        }
        #endregion

        #region 获取数据
        [HttpGet]
        [AuthorizeFilter("system:sysappconfig:search")]
        public async Task<ActionResult> GetListJson(SysAppConfigListParam param)
        {
            TData<List<SysAppConfigEntity>> obj = await sysAppConfigBLL.GetList(param);
            return Json(obj);
        }

        [HttpGet]
        [AuthorizeFilter("system:sysappconfig:search")]
        public async Task<ActionResult> GetPageListJson(SysAppConfigListParam param, Pagination pagination)
        {
            TData<List<SysAppConfigEntity>> obj = await sysAppConfigBLL.GetPageList(param, pagination);
            return Json(obj);
        }

        [HttpGet]
        public async Task<ActionResult> GetFormJson(long id)
        {
            TData<SysAppConfigEntity> obj = await sysAppConfigBLL.GetEntity(id);
            return Json(obj);
        }
        #endregion

        #region 提交数据
        [HttpPost]
        [AuthorizeFilter("system:sysappconfig:add,system:sysappconfig:edit")]
        public async Task<ActionResult> SaveFormJson(SysAppConfigEntity entity)
        {
            TData<string> obj = await sysAppConfigBLL.SaveForm(entity);
            return Json(obj);
        }

        [HttpPost]
        [AuthorizeFilter("system:sysappconfig:delete")]
        public async Task<ActionResult> DeleteFormJson(string ids)
        {
            TData obj = await sysAppConfigBLL.DeleteForm(ids);
            return Json(obj);
        }
        #endregion
    }
}
