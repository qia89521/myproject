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
using YiSha.Entity.TerManage;
using YiSha.Business.TerManage;
using YiSha.Model.Param.TerManage;

namespace YiSha.Admin.Web.Areas.TerManage.Controllers
{
    /// <summary>
    /// 创 建：admin
    /// 日 期：2020-08-13 15:30
    /// 描 述：设备部件控制器类
    /// </summary>
    [Area("TerManage")]
    public class PartsController :  BaseController
    {
        private PartsBLL partsBLL = new PartsBLL();

        #region 视图功能
        [AuthorizeFilter("ter:parts:view")]
        public ActionResult PartsIndex()
        {
            return View();
        }

        public ActionResult PartsForm()
        {
            return View();
        }
        #endregion

        #region 获取数据
        [HttpGet]
        [AuthorizeFilter("ter:parts:search")]
        public async Task<ActionResult> GetListJson(PartsListParam param)
        {
            TData<List<PartsEntity>> obj = await partsBLL.GetList(param);
            return Json(obj);
        }

        [HttpGet]
        [AuthorizeFilter("ter:parts:search")]
        public async Task<ActionResult> GetPageListJson(PartsListParam param, Pagination pagination)
        {
            TData<List<PartsEntity>> obj = await partsBLL.GetPageList(param, pagination);
            return Json(obj);
        }

        [HttpGet]
        public async Task<ActionResult> GetFormJson(long id)
        {
            TData<PartsEntity> obj = await partsBLL.GetEntity(id);
            return Json(obj);
        }
        #endregion

        #region 提交数据
        [HttpPost]
        [AuthorizeFilter("ter:parts:add,ter:parts:edit")]
        public async Task<ActionResult> SaveFormJson(PartsEntity entity)
        {
            TData<string> obj = await partsBLL.SaveForm(entity);
            return Json(obj);
        }

        [HttpPost]
        [AuthorizeFilter("ter:parts:delete")]
        public async Task<ActionResult> DeleteFormJson(string ids)
        {
            TData obj = await partsBLL.DeleteForm(ids);
            return Json(obj);
        }
        #endregion
    }
}
