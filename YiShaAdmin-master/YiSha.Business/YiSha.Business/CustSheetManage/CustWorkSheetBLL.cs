using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using YiSha.Util;
using YiSha.Util.Extension;
using YiSha.Util.Model;
using YiSha.Entity.CustSheetManage;
using YiSha.Model.Param.CustSheetManage;
using YiSha.Service.CustSheetManage;
using YiSha.Web.Code;
using YiSha.Enum;
using YiSha.Model.Result;

namespace YiSha.Business.CustSheetManage
{
    /// <summary>
    /// 创 建：admin
    /// 日 期：2020-11-19 15:30
    /// 描 述：维修工单处理业务类
    /// </summary>
    public class CustWorkSheetBLL
    {
        private CustWorkSheetService custWorkSheetService = new CustWorkSheetService();

        #region 获取数据
        public async Task<TData<List<CustWorkSheetEntity>>> GetList(CustWorkSheetListParam param)
        {
            TData<List<CustWorkSheetEntity>> obj = new TData<List<CustWorkSheetEntity>>();
            obj.Data = await custWorkSheetService.GetList(param);
            obj.Total = obj.Data.Count;
            obj.Tag = 1;
            return obj;
        }

        public async Task<TData<List<CustWorkSheetEntity>>> GetPageList(CustWorkSheetListParam param, Pagination pagination, OperatorInfo user)
        {
            TData<List<CustWorkSheetEntity>> obj = new TData<List<CustWorkSheetEntity>>();
            obj.Data = await custWorkSheetService.GetPageList(param, pagination, user);
            obj.Total = pagination.TotalCount;
            obj.Tag = 1;
            return obj;
        }

        public async Task<TData<CustWorkSheetEntity>> GetEntity(long id)
        {
            TData<CustWorkSheetEntity> obj = new TData<CustWorkSheetEntity>();
            obj.Data = await custWorkSheetService.GetEntity(id);
            if (obj.Data != null)
            {
                obj.Tag = 1;
            }
            return obj;
        }

        public async Task<TData<int>> GetShenCount(OperatorInfo user)
        {
            TData<int> obj = new TData<int>();
            if (user.IsWeihu)
            {
                obj.Data = await custWorkSheetService.GetShenCount(user, CustWorkSheeStepEnum.ToDo);
            }
            else
            {
                obj.Data = 0;
            }
            if (obj.Data > 0)
            {
                obj.Tag = 1;
            }
            return obj;
        }
        #endregion

        #region 提交数据
        public async Task<TData<string>> SaveForm(CustWorkSheetEntity entity, OperatorInfo opuser)
        {
            TData<string> obj = new TData<string>();
            obj.SetDefault();
            var result = CheckWorkFLow(entity, opuser);
            if (result.IsSucess)
            {
                await custWorkSheetService.SaveForm(entity);

                obj.Data = entity.Id.ParseToString();
                obj.Tag = 1;
                obj.Refresh();
            }
            else
            {
                obj.Message = result.Msg;
                obj.Tag = 0;
            }
            return obj;
        }

        public async Task<TData> DeleteForm(string ids)
        {
            TData obj = new TData();
            await custWorkSheetService.DeleteForm(ids);
            obj.Tag = 1;
            return obj;
        }


        #endregion

        #region 私有方法

    
        /// <summary>
        /// 检测流程
        /// </summary>
        /// <param name="entity">数据实体</param>
        /// <returns></returns>
        private ResultMsg CheckWorkFLow(CustWorkSheetEntity entity, OperatorInfo user)
        {
            ResultMsg result = new ResultMsg();
            //新增
            if (entity.Id.IsNullOrZero())
            {
                entity.Step = CustWorkSheeStepEnum.ToDo.ParseToInt();
                result.IsSucess = true;
            }
            else
            {
                if (entity.Step == CustWorkSheeStepEnum.Done.ParseToInt())
                {
                    result.Msg = "已经结单不可处理";
                }
            }
            return result;
        }
        #endregion
    }
}
