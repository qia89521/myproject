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
    /// 日 期：2020-09-20 17:55
    /// 描 述：出货打印单配置控制器类
    /// </summary>
    [Area("SystemManage")]
    public class SysIssueConfigController :  BaseController
    {
        private SysIssueConfigBLL sysIssueConfigBLL = new SysIssueConfigBLL();

        #region 视图功能
        [AuthorizeFilter("system:sysissueconfig:view")]
        public ActionResult SysIssueConfigIndex()
        {
            return View();
        }

        public ActionResult SysIssueConfigForm()
        {
            return View();
        }
        #endregion

        #region 获取数据
        [HttpGet]
        [AuthorizeFilter("system:sysissueconfig:search")]
        public async Task<ActionResult> GetListJson(SysIssueConfigListParam param)
        {
            TData<List<SysIssueConfigEntity>> obj = await sysIssueConfigBLL.GetList(param);
            return Json(obj);
        }

        [HttpGet]
        [AuthorizeFilter("system:sysissueconfig:search")]
        public async Task<ActionResult> GetPageListJson(SysIssueConfigListParam param, Pagination pagination)
        {
            TData<List<SysIssueConfigEntity>> obj = await sysIssueConfigBLL.GetPageList(param, pagination);
            return Json(obj);
        }

        [HttpGet]
        public async Task<ActionResult> GetFormJson(long id)
        {
            TData<SysIssueConfigEntity> obj = await sysIssueConfigBLL.GetEntity(id);
            return Json(obj);
        }
        #endregion

        #region 提交数据
        [HttpPost]
        [AuthorizeFilter("system:sysissueconfig:add,system:sysissueconfig:edit")]
        public async Task<ActionResult> SaveFormJson(SysIssueConfigEntity entity)
        {
            TData<string> obj = await sysIssueConfigBLL.SaveForm(entity);
            return Json(obj);
        }

        [HttpPost]
        [AuthorizeFilter("system:sysissueconfig:delete")]
        public async Task<ActionResult> DeleteFormJson(string ids)
        {
            TData obj = await sysIssueConfigBLL.DeleteForm(ids);
            return Json(obj);
        }
        #endregion
    }
}
