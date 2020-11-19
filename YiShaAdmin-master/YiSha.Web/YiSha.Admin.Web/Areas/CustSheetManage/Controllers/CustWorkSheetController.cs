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
using YiSha.Entity.CustSheetManage;
using YiSha.Business.CustSheetManage;
using YiSha.Model.Param.CustSheetManage;
using YiSha.Web.Code;

namespace YiSha.Admin.Web.Areas.CustSheetManage.Controllers
{
    /// <summary>
    /// 创 建：admin
    /// 日 期：2020-11-19 15:30
    /// 描 述：维修工单处理控制器类
    /// </summary>
    [Area("CustSheetManage")]
    public class CustWorkSheetController :  BaseController
    {
        private CustWorkSheetBLL custWorkSheetBLL = new CustWorkSheetBLL();

        #region 视图功能
        [AuthorizeFilter("custsheet:custworksheet:view")]
        public ActionResult CustWorkSheetIndex()
        {
            return View();
        }

        public ActionResult CustWorkSheetForm()
        {
            return View();
        }
        #endregion

        #region 获取数据
        [HttpGet]
        [AuthorizeFilter("custsheet:custworksheet:search")]
        public async Task<ActionResult> GetListJson(CustWorkSheetListParam param)
        {
            TData<List<CustWorkSheetEntity>> obj = await custWorkSheetBLL.GetList(param);
            return Json(obj);
        }

        [HttpGet]
        [AuthorizeFilter("custsheet:custworksheet:search")]
        public async Task<ActionResult> GetPageListJson(CustWorkSheetListParam param, Pagination pagination)
        {
            OperatorInfo user = await Operator.Instance.Current();
            TData<List<CustWorkSheetEntity>> obj = await custWorkSheetBLL.GetPageList(param, pagination, user);
            return Json(obj);
        }

        [HttpGet]
        public async Task<ActionResult> GetFormJson(long id)
        {
            TData<CustWorkSheetEntity> obj = await custWorkSheetBLL.GetEntity(id);
            return Json(obj);
        }
        #endregion

        #region 提交数据
        [HttpPost]
        [AuthorizeFilter("custsheet:custworksheet:add,custsheet:custworksheet:edit")]
        public async Task<ActionResult> SaveFormJson(CustWorkSheetEntity entity)
        {
            OperatorInfo user = await Operator.Instance.Current();
            TData<string> obj = await custWorkSheetBLL.SaveForm(entity, user);
            return Json(obj);
        }

        [HttpPost]
        [AuthorizeFilter("custsheet:custworksheet:delete")]
        public async Task<ActionResult> DeleteFormJson(string ids)
        {
            TData obj = await custWorkSheetBLL.DeleteForm(ids);
            return Json(obj);
        }
        #endregion
    }
}
