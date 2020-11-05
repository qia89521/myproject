using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NPOI.Util;
using YiSha.Business.TerManage;
using YiSha.Entity.TerManage;
using YiSha.Model.Param.TerManage;
using YiSha.Util;
using YiSha.Util.Model;
using YiSha.Web.Code;

namespace YiSha.Admin.WebApi.Controllers
{
    /// <summary>
    /// 终端信息控制器
    /// </summary>
    [Route("[controller]/[action]")]
    [ApiController]
    [AuthorizeFilter]
    public class TerController : BaseControler
    {

        TerInforBLL terInforBLL = new TerInforBLL();

        TerCollusionBLL terCollusionBLL = new TerCollusionBLL();

        /// <summary>
        /// 保存终端位置状态信息
        /// </summary>
        /// <param name="entity">实体数据</param>
        /// <returns></returns>
        [HttpPost]
        public async Task<TData<string>> SaveForm([FromBody] TerPositionParam entity)
        {
            TData<string> obj = await terInforBLL.ModifyPosition(entity.number, entity.fistLongitude, entity.fistLatitude, entity.address);
            //检测是否串货
            await terCollusionBLL.SaveForm(entity);
            return obj;
        }
        /// <summary>
        /// 绑定设备用户
        /// </summary>
        /// <param name="entity">实体数据</param>
        /// <returns></returns>
        [HttpPost]
        public async Task<TData<string>> BindTer([FromBody] TerBindParam entity)
        {
            OperatorInfo user = await Web.Code.Operator.Instance.Current(entity.ApiToken);
            TData<string> obj = new TData<string>();
            obj.SetDefault();
            try
            {
                if (user != null)
                {
                    obj = await terInforBLL.BindUser(user.UserId.ToString(), entity.Number, entity.FistLongitude, entity.FistLatitude, entity.Address);
                    //检测是否串货
                    obj.Refresh();
                }
                else
                {
                    obj.Message = "当前登录信息失效,请重新登录";
                }

            }
            catch (Exception ex)
            {
                obj.Message = ex.ToString();
            }

            return obj;
        }

        /// <summary>
        /// 保存终端位置状态信息
        /// </summary>
        /// <param name="number">设备编号</param>
        /// <returns></returns>
        [HttpPost]
        public async Task<TData<string>> CheckNumber(String number)
        {
            TData<string> obj = await terInforBLL.CheckNumber(number);
            return obj;
        }


        /// <summary>
        /// 获取设备实体信息
        /// </summary>
        /// <param name="id">设备id</param>
        /// <returns></returns>
        [HttpPost]
        public async Task<TData<TerInforEntity>> GetEntityById([FromQuery] long id)
        {
            TData<TerInforEntity> obj = await terInforBLL.GetEntity(id);
            return obj;
        }

        /// <summary>
        /// 获取数据列表
        /// </summary>
        /// <param name="param">查询参数</param>
        /// <returns></returns>
        [HttpPost]
        public async Task<TData<List<TerInforEntity>>> GetPageListJson(
            WebApi_TerInforListParam param)
        {
            TData<List<TerInforEntity>> obj = new TData<List<TerInforEntity>>();
            try
            {

                OperatorInfo user = await Web.Code.Operator.Instance.Current(param.ApiToken);
                LogHelper.Info("GetPageListJson user:" + JsonHelper.SerializeObject(user));
                obj = await terInforBLL.GetPageList(param.TerInforListParam, param.Pagination, user);
                LogHelper.Info("GetPageListJson Data:" + JsonHelper.SerializeObject(obj));

            }
            catch (Exception ex)
            {
                LogHelper.Info("GetPageListJson ex:" + ex.ToString());
            }

            return obj;
        }

    }
}
