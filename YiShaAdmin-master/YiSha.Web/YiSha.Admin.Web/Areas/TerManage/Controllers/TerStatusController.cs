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
    /// 日 期：2020-08-14 16:16
    /// 描 述：设备状态控制器类
    /// </summary>
    [Area("TerManage")]
    public class TerStatusController :  BaseController
    {
        private TerStatusBLL terStatusBLL = new TerStatusBLL();

        #region 视图功能
        [AuthorizeFilter("ter:terstatus:view")]
        public ActionResult TerStatusIndex()
        {
            return View();
        }

        public ActionResult TerStatusForm()
        {
            return View();
        }
        #endregion

        #region 获取数据
        [HttpGet]
        [AuthorizeFilter("ter:terstatus:search")]
        public async Task<ActionResult> GetListJson(TerStatusListParam param)
        {
            TData<List<TerStatusEntity>> obj = await terStatusBLL.GetList(param);
            return Json(obj);
        }

        [HttpGet]
        [AuthorizeFilter("ter:terstatus:search")]
        public async Task<ActionResult> GetPageListJson(TerStatusListParam param, Pagination pagination)
        {
            TData<List<TerStatusEntity>> obj = await terStatusBLL.GetPageList(param, pagination);
            return Json(obj);
        }

        [HttpGet]
        public async Task<ActionResult> GetFormJson(long id)
        {
            TData<TerStatusEntity> obj = await terStatusBLL.GetEntity(id);
            return Json(obj);
        }
        #endregion

        #region 提交数据
        [HttpPost]
        [AuthorizeFilter("ter:terstatus:add,ter:terstatus:edit")]
        public async Task<ActionResult> SaveFormJson(TerStatusEntity entity)
        {
            TData<string> obj = await terStatusBLL.SaveForm(entity);
            return Json(obj);
        }

        [HttpPost]
        [AuthorizeFilter("ter:terstatus:delete")]
        public async Task<ActionResult> DeleteFormJson(string ids)
        {
            TData obj = await terStatusBLL.DeleteForm(ids);
            return Json(obj);
        }
        #endregion
    }
}
