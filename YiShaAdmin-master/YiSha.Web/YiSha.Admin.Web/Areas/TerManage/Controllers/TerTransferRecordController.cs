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
    /// 日 期：2020-08-18 17:28
    /// 描 述：设备转让记录控制器类
    /// </summary>
    [Area("TerManage")]
    public class TerTransferRecordController : BaseController
    {
        private TerTransferRecordBLL terTransferRecordBLL = new TerTransferRecordBLL();

        #region 视图功能
        [AuthorizeFilter("ter:tertransferrecord:view")]
        public ActionResult TerTransferRecordIndex()
        {
            return View();
        }

        public ActionResult TerTransferRecordForm()
        {
            return View();
        }
        #endregion

        #region 获取数据
        [HttpGet]
        [AuthorizeFilter("ter:tertransferrecord:search")]
        public async Task<ActionResult> GetListJson(TerTransferRecordListParam param)
        {
            TData<List<TerTransferRecordEntity>> obj = await terTransferRecordBLL.GetList(param);

            return Json(obj);
        }

        /// <summary>
        /// 获取数据列表
        /// </summary>
        /// <param name="terid">终端id</param>
        /// <returns></returns>
        [HttpGet]
        [AuthorizeFilter("ter:tertransferrecord:view")]
        public async Task<ActionResult> GetListData(string terid)
        {
            TerTransferRecordListParam param = new TerTransferRecordListParam();
            param.TerId = long.Parse(terid);
            TData<List<TerTransferRecordEntity>> obj = await terTransferRecordBLL.GetList(param);
            return Json(obj);

        }

        [HttpGet]
        [AuthorizeFilter("ter:tertransferrecord:search")]
        public async Task<ActionResult> GetPageListJson(TerTransferRecordListParam param, Pagination pagination)
        {
            TData<List<TerTransferRecordEntity>> obj = await terTransferRecordBLL.GetPageList(param, pagination);
            return Json(obj);
        }

        [HttpGet]
        public async Task<ActionResult> GetFormJson(long id)
        {
            TData<TerTransferRecordEntity> obj = await terTransferRecordBLL.GetEntity(id);
            return Json(obj);
        }
        #endregion

        #region 提交数据
        [HttpPost]
        [AuthorizeFilter("ter:tertransferrecord:add,ter:tertransferrecord:edit")]
        public async Task<ActionResult> SaveFormJson(TerTransferRecordEntity entity)
        {
            TData<string> obj = await terTransferRecordBLL.SaveForm(entity);
            return Json(obj);
        }

        [HttpPost]
        [AuthorizeFilter("ter:tertransferrecord:delete")]
        public async Task<ActionResult> DeleteFormJson(string ids)
        {
            TData obj = await terTransferRecordBLL.DeleteForm(ids);
            return Json(obj);
        }
        #endregion
    }
}
