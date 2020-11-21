using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using YiSha.Business.CustSheetManage;
using YiSha.Entity.CustSheetManage;
using YiSha.Model.Param.CustSheetManage;
using YiSha.Util;
using YiSha.Util.Model;
using YiSha.Web.Code;

namespace YiSha.Admin.WebApi.Controllers
{
    /// <summary>
    /// 工单列表控制器
    /// </summary>
    [Route("[controller]/[action]")]
    [ApiController]
    [AuthorizeFilter]
    public class CustWorkSheetController : BaseControler
    {
        #region 获取数据    
        /// <summary>
        /// 获取分页数据列表
        /// </summary>
        /// <param name="listParam">小程序列表参数</param>
        /// <returns></returns>
        [HttpPost]
        public async Task<TData<List<CustWorkSheetEntity>>> GetPageListJson([FromBody] WebApi_CustWorkSheetListParam listParam)
        {
            TData<List<CustWorkSheetEntity>> obj = new TData<List<CustWorkSheetEntity>>();
            obj.SetDefault();
            try
            {
                LogHelper.Info("【GetPageListJson】 listParam：" + JsonHelper.SerializeObject(listParam));
                OperatorInfo opuser = await Web.Code.Operator.Instance.Current(listParam.ApiToken);
                obj = await new CustWorkSheetBLL().GetPageList(listParam.ListParam, listParam.Pagination, opuser);
            }
            catch (Exception ex)
            {
                LogHelper.Info("【GetPageListJson】 ex：" + ex.ToString());
            }
            return obj;
        }

        #endregion

        /// <summary>
        /// 获取实体信息
        /// </summary>
        /// <param name="id">设备id</param>
        /// <returns></returns>
        [HttpPost]
        public async Task<TData<CustWorkSheetEntity>> GetEntityById([FromQuery] long id)
        {
            TData<CustWorkSheetEntity> obj = await new CustWorkSheetBLL().GetEntity(id);
            return obj;
        }

        /// <summary>
        /// 新增意向客户
        /// </summary>
        /// <param name="entity">意向客户数据实体</param>
        /// <returns></returns>
        [HttpPost]
        public async Task<TData<string>> SaveForm([FromBody] CustWorkSheetParam entity)
        {
            OperatorInfo opuser = await Web.Code.Operator.Instance.Current(entity.ApiToken);


            TData<string> obj = await new CustWorkSheetBLL().SaveForm(entity, opuser);
            return obj;
        }
    }
}
