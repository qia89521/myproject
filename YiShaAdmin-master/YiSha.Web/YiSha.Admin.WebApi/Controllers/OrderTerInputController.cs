using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using YiSha.Business.OrderManage;
using YiSha.Entity.OrderManage;
using YiSha.Model.Param.OrderManage;
using YiSha.Model.Result.OrderManage;
using YiSha.Util;
using YiSha.Util.Model;
using YiSha.Web.Code;

namespace YiSha.Admin.WebApi.Controllers
{
    /// <summary>
    /// 设备进货控制器
    /// </summary>
    [Route("[controller]/[action]")]
    [ApiController]
    [AuthorizeFilter]
    public class OrderTerInputController : Controller
    {

        /// <summary>
        /// 获取数据列表
        /// </summary>
        /// <param name="param">查询参数</param>
        /// <returns></returns>
        [HttpPost]
        public async Task<TData<List<OrderTerInputEntity>>> GetPageListJson(
            WebApi_OrderTerInputListParam param)
        {
            //   TData<List<OrderTerInputEntity>> obj = await orderTerInputBLL.GetPageList(param, pagination);
            TData<List<OrderTerInputEntity>> obj = new TData<List<OrderTerInputEntity>>();
            try
            {

                OperatorInfo user = await Web.Code.Operator.Instance.Current(param.ApiToken);
                LogHelper.Info("GetPageListJson user:" + JsonHelper.SerializeObject(user));
                obj = await new OrderTerInputBLL().GetPageList(param.ListParam, param.Pagination, user);
                LogHelper.Info("GetPageListJson Data:" + JsonHelper.SerializeObject(obj));

            }
            catch (Exception ex)
            {
                LogHelper.Info("GetPageListJson ex:" + ex.ToString());
            }

            return obj;
        }

        /// <summary>
        /// 获取数据列表
        /// </summary>
        /// <param name="param">查询参数</param>
        /// <returns></returns>
        [HttpPost]
        public async Task<TData<List<Response_OrderTerInput_ChartLine>>> GetListGroupChart(
            WebApi_OrderTerInputChartParam param)
        {
            // TData<List<OrderTerIssueEntity>> obj = await orderTerIssueBLL.GetPageList(param, pagination);
            TData<List<Response_OrderTerInput_ChartLine>> obj = new TData<List<Response_OrderTerInput_ChartLine>>();
            try
            {

                OperatorInfo user = await Web.Code.Operator.Instance.Current(param.ApiToken);
                LogHelper.Info("GetListGroupChart user:" + JsonHelper.SerializeObject(user));
                obj = await new OrderTerInputBLL().GetListGroupChart(param.ListParam, user);
                LogHelper.Info("GetListGroupChart Data:" + JsonHelper.SerializeObject(obj));

            }
            catch (Exception ex)
            {
                LogHelper.Info("GetListGroupChart ex:" + ex.ToString());
            }

            return obj;
        }


    }
}
