using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using YiSha.Util;
using YiSha.Util.Extension;
using YiSha.Util.Model;
using YiSha.Entity.SystemManage;
using YiSha.Model.Param.SystemManage;
using YiSha.Service.SystemManage;

namespace YiSha.Business.SystemManage
{
    /// <summary>
    /// 创 建：admin
    /// 日 期：2020-08-20 09:48
    /// 描 述：收款银行卡管理业务类
    /// </summary>
    public class SysBankCardBLL
    {
        private SysBankCardService sysBankCardService = new SysBankCardService();

        #region 获取数据
        public async Task<TData<List<SysBankCardEntity>>> GetList(SysBankCardListParam param)
        {
            TData<List<SysBankCardEntity>> obj = new TData<List<SysBankCardEntity>>();
            obj.Data = await sysBankCardService.GetList(param);
            obj.Total = obj.Data.Count;
            obj.Tag = 1;
            return obj;
        }

        public async Task<TData<List<SysBankCardEntity>>> GetPageList(SysBankCardListParam param, Pagination pagination)
        {
            TData<List<SysBankCardEntity>> obj = new TData<List<SysBankCardEntity>>();
            obj.Data = await sysBankCardService.GetPageList(param, pagination);
            obj.Total = pagination.TotalCount;
            obj.Tag = 1;
            return obj;
        }

        public async Task<TData<SysBankCardEntity>> GetEntity(long id)
        {
            TData<SysBankCardEntity> obj = new TData<SysBankCardEntity>();
            obj.Data = await sysBankCardService.GetEntity(id);
            if (obj.Data != null)
            {
                obj.Tag = 1;
            }
            return obj;
        }
        #endregion

        #region 提交数据
        public async Task<TData<string>> SaveForm(SysBankCardEntity entity)
        {
            TData<string> obj = new TData<string>();
            await sysBankCardService.SaveForm(entity);
            obj.Data = entity.Id.ParseToString();
            obj.Tag = 1;
            return obj;
        }

        public async Task<TData> DeleteForm(string ids)
        {
            TData obj = new TData();
            await sysBankCardService.DeleteForm(ids);
            obj.Tag = 1;
            return obj;
        }
        #endregion

        #region 私有方法
        #endregion
    }
}
