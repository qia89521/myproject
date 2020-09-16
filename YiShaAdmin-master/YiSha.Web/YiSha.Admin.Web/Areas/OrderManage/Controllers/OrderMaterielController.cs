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
using YiSha.Entity.OrderManage;
using YiSha.Business.OrderManage;
using YiSha.Model.Param.OrderManage;

namespace YiSha.Admin.Web.Areas.OrderManage.Controllers
{
    /// <summary>
    /// 创 建：admin
    /// 日 期：2020-09-08 18:11
    /// 描 述：OrderManage控制器类
    /// </summary>
    [Area("OrderManage")]
    public class OrderMaterielController :  BaseController
    {
        private OrderMaterielBLL orderMaterielBLL = new OrderMaterielBLL();

        #region 视图功能
        [AuthorizeFilter("order:ordermateriel:view")]
        public ActionResult OrderMaterielIndex()
        {
            return View();
        }
        [AuthorizeFilter("order:ordermateriel:select")]
        public ActionResult OrderMaterielIndexSelect()
        {
            return View();
        }
        public ActionResult OrderMaterielForm()
        {
            return View();
        }
        #endregion

        #region 获取数据
        [HttpGet]
        [AuthorizeFilter("order:ordermateriel:search")]
        public async Task<ActionResult> GetListJson(OrderMaterielListParam param)
        {
            TData<List<OrderMaterielEntity>> obj = await orderMaterielBLL.GetList(param);
            return Json(obj);
        }

        [HttpGet]
        [AuthorizeFilter("order:ordermateriel:search")]
        public async Task<ActionResult> GetPageListJson(OrderMaterielListParam param, Pagination pagination)
        {
            TData<List<OrderMaterielEntity>> obj = await orderMaterielBLL.GetPageList(param, pagination);
            return Json(obj);
        }

        [HttpGet]
        public async Task<ActionResult> GetFormJson(long id)
        {
            TData<OrderMaterielEntity> obj = await orderMaterielBLL.GetEntity(id);
            return Json(obj);
        }
        #endregion

        #region 提交数据
        [HttpPost]
        [AuthorizeFilter("order:ordermateriel:add,order:ordermateriel:edit")]
        public async Task<ActionResult> SaveFormJson(OrderMaterielEntity entity)
        {

            TData<string> obj = await orderMaterielBLL.SaveForm(entity);

            return Json(obj);
        }

        [HttpPost]
        [AuthorizeFilter("order:ordermateriel:delete")]
        public async Task<ActionResult> DeleteFormJson(string ids)
        {
            TData obj = await orderMaterielBLL.DeleteForm(ids);
            return Json(obj);
        }

        /// <summary>
        /// 修改库存
        /// </summary>
        /// <param name="id">物料id</param>
        /// <param name="num">修改数量</param>
        /// <param name="remark">备注</param>
        /// <returns></returns>
        [HttpPost]
        [AuthorizeFilter("order:ordermateriel:modifyTotal")]
        public async Task<ActionResult> ModifyMaterielTotal(string id, string num, string remark)
        {
            long int_id = long.Parse(id);
            int int_num = int.Parse(num);
            TData<string> obj = await orderMaterielBLL.ModifyMaterielTotal(int_id,int_num,remark, int_id,CoomHelper.GetClassTableName<OrderMaterielEntity>());

            return Json(obj);
        }
        #endregion
    }
}
