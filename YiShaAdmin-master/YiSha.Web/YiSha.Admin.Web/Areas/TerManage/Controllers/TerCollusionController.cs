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
    /// 日 期：2020-10-14 10:04
    /// 描 述：设备串货提醒控制器类
    /// </summary>
    [Area("TerManage")]
    public class TerCollusionController :  BaseController
    {
        private TerCollusionBLL terCollusionBLL = new TerCollusionBLL();

        #region 视图功能
        [AuthorizeFilter("ter:tercollusion:view")]
        public ActionResult TerCollusionIndex()
        {
            return View();
        }

        public ActionResult TerCollusionForm()
        {
            return View();
        }
        #endregion

        #region 获取数据
        [HttpGet]
        [AuthorizeFilter("ter:tercollusion:search")]
        public async Task<ActionResult> GetListJson(TerCollusionListParam param)
        {
            TData<List<TerCollusionEntity>> obj = await terCollusionBLL.GetList(param);
            return Json(obj);
        }

        [HttpGet]
        [AuthorizeFilter("ter:tercollusion:search")]
        public async Task<ActionResult> GetPageListJson(TerCollusionListParam param, Pagination pagination)
        {
            TData<List<TerCollusionEntity>> obj = await terCollusionBLL.GetPageList(param, pagination);
            return Json(obj);
        }

        [HttpGet]
        public async Task<ActionResult> GetFormJson(long id)
        {
            TData<TerCollusionEntity> obj = await terCollusionBLL.GetEntity(id);
            return Json(obj);
        }
        #endregion

        #region 提交数据
        [HttpPost]
        [AuthorizeFilter("ter:tercollusion:add,ter:tercollusion:edit")]
        public async Task<ActionResult> SaveFormJson(TerCollusionEntity entity)
        {
            TData<string> obj = await terCollusionBLL.SaveForm(entity);
            return Json(obj);
        }

        [HttpPost]
        [AuthorizeFilter("ter:tercollusion:delete")]
        public async Task<ActionResult> DeleteFormJson(string ids)
        {
            TData obj = await terCollusionBLL.DeleteForm(ids);
            return Json(obj);
        }
        #endregion
    }
}
