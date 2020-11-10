﻿using System;
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
                LogHelper.Info("GetPageListJson user:" + JsonHelper.SerializeObject(user));
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



    }
}
