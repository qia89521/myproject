﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using YiSha.Entity.SaleManage;
using YiSha.Enum;
using YiSha.Model.Param.SaleManage;
using YiSha.Util;
using YiSha.Util.Model;
using YiSha.Web.Code;
using YiSha.Business.SaleManage;

namespace YiSha.Admin.WebApi.Controllers
{
    /// <summary>
    /// 意向客户控制器
    /// </summary>
    [Route("[controller]/[action]")]
    [ApiController]
    [AuthorizeFilter]
    public class WishUserController : BaseControler
    {
        #region 获取数据    
        /// <summary>
        /// 获取分页数据列表
        /// </summary>
        /// <param name="listParam">小程序列表参数</param>
        /// <returns></returns>
        [HttpPost]
        public async Task<TData<List<WishUserEntity>>> GetPageListJson([FromBody] WebApi_WishUserListParam listParam)
        {
            TData<List<WishUserEntity>> obj = new TData<List<WishUserEntity>>();
            obj.SetDefault();
            try
            {
                LogHelper.Info("【GetPageListJson】 listParam：" + JsonHelper.SerializeObject(listParam));
                OperatorInfo opuser = await Web.Code.Operator.Instance.Current(listParam.ApiToken);

                obj = await new WishUserBLL().GetPageList(listParam.ListParam, listParam.Pagination, opuser);
            }
            catch (Exception ex)
            {
                LogHelper.Info("【GetPageListJson】 ex：" + ex.ToString());
            }
            return obj;
        }

        #endregion

        /// <summary>
        /// 新增意向客户
        /// </summary>
        /// <param name="entity">意向客户数据实体</param>
        /// <returns></returns>
        [HttpPost]
        public async Task<TData<string>> SaveForm([FromBody] WishUserParam entity)
        {
            OperatorInfo opuser = await Web.Code.Operator.Instance.Current(entity.ApiToken);
            TData<string> obj = await new WishUserBLL().SaveForm(entity,opuser);
            return obj;
        }
    }
}
