using System;
using System.Collections.Generic;
using System.Data;
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
    /// 设备出货控制器
    /// </summary>
    [Route("[controller]/[action]")]
    [ApiController]
    [AuthorizeFilter]
    public class OrderTerIssueController : Controller
    {

        /// <summary>
        /// 获取数据列表
        /// </summary>
        /// <param name="param">查询参数</param>
        /// <returns></returns>
        [HttpPost]
        public async Task<TData<List<OrderTerIssueEntity>>> GetPageListJson(
            WebApi_OrderTerIssueListParam param)
        {
            // TData<List<OrderTerIssueEntity>> obj = await orderTerIssueBLL.GetPageList(param, pagination);
            TData<List<OrderTerIssueEntity>> obj = new TData<List<OrderTerIssueEntity>>();
            try
            {

                OperatorInfo user = await Web.Code.Operator.Instance.Current(param.ApiToken);
                LogHelper.Info("GetPageListJson param:" + JsonHelper.SerializeObject(param));
                obj = await new OrderTerIssueBLL().GetPageList(param.ListParam, param.Pagination, user);
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
        public async Task<TData<List<Response_OrderTerIssue_ChartLine>>> GetListGroupChart(
            WebApi_OrderTerIssueChartParam param)
        {
            // TData<List<OrderTerIssueEntity>> obj = await orderTerIssueBLL.GetPageList(param, pagination);
            TData<List<Response_OrderTerIssue_ChartLine>> obj = new TData<List<Response_OrderTerIssue_ChartLine>>();
            try
            {

                OperatorInfo user = await Web.Code.Operator.Instance.Current(param.ApiToken);
                LogHelper.Info("GetListGroupChart user:" + JsonHelper.SerializeObject(user));
                obj = await new OrderTerIssueBLL().GetListGroupChart(param.ListParam,user);
                LogHelper.Info("GetListGroupChart Data:" + JsonHelper.SerializeObject(obj));

            }
            catch (Exception ex)
            {
                LogHelper.Info("GetListGroupChart ex:" + ex.ToString());
            }

            return obj;
        }

        /// <summary>
        /// 获取要审核的数量
        /// </summary>
        /// <param name="apiToken">api登录 凭证</param>
        /// <returns></returns>
        [HttpPost]
        public async Task<TData<int>> GetShenCount([FromQuery] string apiToken)
        {
            TData<int> obj = new TData<int>();
            try
            {
                OperatorInfo user = await Web.Code.Operator.Instance.Current(apiToken);
                obj = await new OrderTerIssueBLL().GetShenCount( user);

            }
            catch (Exception ex)
            {
                LogHelper.Info("GetShenCount ex:" + ex.ToString());
            }

            return obj;
        }

        /// <summary>
        /// 获取实体信息
        /// </summary>
        /// <param name="id">设备id</param>
        /// <returns></returns>
        [HttpPost]
        public async Task<TData<OrderTerIssueEntity>> GetEntityById([FromQuery] long id)
        {
            TData<OrderTerIssueEntity> obj = await new OrderTerIssueBLL().GetEntity(id);
            return obj;
        }


        /// <summary>
        /// 保存信息
        /// </summary>
        /// <param name="entity">实体数据</param>
        /// <returns></returns>
        [HttpPost]
        public async Task<TData<string>> SaveForm([FromBody] OrderTerIssueParam entity)
        {

            TData<string> obj = new TData<string>();
            obj.SetDefault();
            try
            {
                LogHelper.Info("SaveForm entity:" + JsonHelper.SerializeObject(entity));
                OperatorInfo opuser = await Web.Code.Operator.Instance.Current(entity.ApiToken);

                obj = await new OrderTerIssueBLL().SaveForm(entity, opuser);
                //检测是否串货
                obj.Refresh();

            }
            catch (Exception ex)
            {
                obj.Message = ex.ToString();
            }

            return obj;
        }
    }
}
