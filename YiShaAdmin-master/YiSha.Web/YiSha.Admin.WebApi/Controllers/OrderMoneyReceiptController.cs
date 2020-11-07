using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using YiSha.Business.OrderManage;
using YiSha.Entity.OrderManage;
using YiSha.Model.Param.OrderManage;
using YiSha.Util;
using YiSha.Util.Model;
using YiSha.Web.Code;

namespace YiSha.Admin.WebApi.Controllers
{
    /// <summary>
    /// 订单收据控制器
    /// </summary>
    [Route("[controller]/[action]")]
    [ApiController]
    [AuthorizeFilter]
    public class OrderMoneyReceiptController : BaseControler
    {
        #region 获取数据    
        /// <summary>
        /// 获取分页数据列表
        /// </summary>
        /// <param name="listParam">小程序列表参数</param>
        /// <returns></returns>
        [HttpPost]
        public async Task<TData<List<OrderMoneyReceiptEntity>>> GetPageListJson([FromBody] WebApi_OrderMoneyReceiptListParam listParam)
        {
            TData<List<OrderMoneyReceiptEntity>> obj = new TData<List<OrderMoneyReceiptEntity>>();
            obj.SetDefault();
            try
            {
                LogHelper.Info("【GetPageListJson】 listParam：" + JsonHelper.SerializeObject(listParam));
                OperatorInfo opuser = await Web.Code.Operator.Instance.Current(listParam.ApiToken);

                obj = await new OrderMoneyReceiptBLL().GetPageList(listParam.ListParam, listParam.Pagination, opuser);
                obj.Refresh();
            }
            catch (Exception ex)
            {
                LogHelper.Info("【GetPageListJson】 ex：" + ex.ToString());
            }
            return obj;
        }

        #endregion

        #region 提交数据
        /// <summary>
        /// 保存编辑收据信息
        /// </summary>
        /// <param name="entity">实体数据</param>
        /// <returns></returns>
        [HttpPost]
        public async Task<TData<string>> SaveForm([FromBody] OrderMoneyReceiptParam entity)
        {
            TData<string> obj = new TData<string>();
            obj.SetDefault();
            try
            {
                OperatorInfo opuser = await Web.Code.Operator.Instance.Current(entity.ApiToken);

                obj = await new OrderMoneyReceiptBLL().SaveForm(entity, opuser);
                //检测是否串货
                obj.Refresh();

            }
            catch (Exception ex)
            {
                obj.Message = ex.ToString();
            }

            return obj;
        }
        #endregion

        #region 读取数据信息
        /// <summary>
        /// 获取查看收据信息
        /// </summary>
        /// <param name="id">设备id</param>
        /// <returns></returns>
        [HttpPost]
        public async Task<TData<OrderMoneyReceiptEntity>> GetEntityById([FromQuery] long id)
        {
            TData<OrderMoneyReceiptEntity> obj = await new OrderMoneyReceiptBLL().GetEntity(id);
            return obj;
        }
        #endregion
    }
}
