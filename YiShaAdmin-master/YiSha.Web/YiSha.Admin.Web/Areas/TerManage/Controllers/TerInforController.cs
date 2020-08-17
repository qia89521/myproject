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
    /// 日 期：2020-08-14 16:05
    /// 描 述：设备信息控制器类
    /// </summary>
    [Area("TerManage")]
    public class TerInforController :  BaseController
    {
        private TerInforBLL terInforBLL = new TerInforBLL();

        #region 视图功能
        [AuthorizeFilter("ter:terinfor:view")]
        public ActionResult TerInforIndex()
        {
            return View();
        }

        public ActionResult TerInforForm()
        {
            return View();
        }
        #endregion

        #region 获取数据
        [HttpGet]
        [AuthorizeFilter("ter:terinfor:search")]
        public async Task<ActionResult> GetListJson(TerInforListParam param)
        {
            TData<List<TerInforEntity>> obj = await terInforBLL.GetList(param);
            return Json(obj);
        }

        [HttpGet]
        [AuthorizeFilter("ter:terinfor:search")]
        public async Task<ActionResult> GetPageListJson(TerInforListParam param, Pagination pagination)
        {
            TData<List<TerInforEntity>> obj = await terInforBLL.GetPageList(param, pagination);
            return Json(obj);
        }

        [HttpGet]
        public async Task<ActionResult> GetFormJson(long id)
        {
            TData<TerInforEntity> obj = await terInforBLL.GetEntity(id);
            return Json(obj);
        }
        #endregion

        #region 提交数据
        [HttpPost]
        [AuthorizeFilter("ter:terinfor:add,ter:terinfor:edit")]
        public async Task<ActionResult> SaveFormJson(TerInforEntity entity)
        {
            TData<string> obj = await terInforBLL.SaveForm(entity);
            return Json(obj);
        }

        [HttpPost]
        [AuthorizeFilter("ter:terinfor:delete")]
        public async Task<ActionResult> DeleteFormJson(string ids)
        {
            TData obj = await terInforBLL.DeleteForm(ids);
            return Json(obj);
        }
        #endregion

        #region 修改数据
        /// <summary>
        /// 修改设备编号
        /// </summary>
        /// <param name="id">id</param>
        /// <param name="value">设备编号</param>
        /// <returns></returns>
        [HttpPost]
        [AuthorizeFilter("ter:terinfor:ModifyTerNumber")]
        public async Task<ActionResult> ModifyTerNumber(string id, string value)
        {
            TData obj = await terInforBLL.ModifyTerNumber(long.Parse(id), value);
            return Json(obj);
        }
        /// <summary>
        /// 修改设备名称
        /// </summary>
        /// <param name="id">id</param>
        /// <param name="value">设备名称</param>
        /// <returns></returns>
        [HttpPost]
        [AuthorizeFilter("ter:terinfor:ModifyTerName")]
        public async Task<ActionResult> ModifyTerName(string id, string value)
        {
            TData obj = await terInforBLL.ModifyTerName(long.Parse(id), value);
            return Json(obj);
        }
        /// <summary>
        /// 修改设备联系方式
        /// </summary>
        /// <param name="id">id</param>
        /// <param name="value">联系方式</param>
        /// <returns></returns>
        [HttpPost]
        [AuthorizeFilter("ter:terinfor:ModifyBusyLink")]
        public async Task<ActionResult> ModifyBusyLink(string id, string value)
        {
            TData obj = await terInforBLL.ModifyBusyLink(long.Parse(id), value);
            return Json(obj);
        }
        
        #endregion
    }
}
