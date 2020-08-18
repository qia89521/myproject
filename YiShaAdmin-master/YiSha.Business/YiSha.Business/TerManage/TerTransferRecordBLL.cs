using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using YiSha.Util;
using YiSha.Util.Extension;
using YiSha.Util.Model;
using YiSha.Entity.TerManage;
using YiSha.Model.Param.TerManage;
using YiSha.Service.TerManage;

namespace YiSha.Business.TerManage
{
    /// <summary>
    /// 创 建：admin
    /// 日 期：2020-08-18 17:28
    /// 描 述：设备转让记录业务类
    /// </summary>
    public class TerTransferRecordBLL
    {
        private TerTransferRecordService terTransferRecordService = new TerTransferRecordService();

        #region 获取数据
        public async Task<TData<List<TerTransferRecordEntity>>> GetList(TerTransferRecordListParam param)
        {
            TData<List<TerTransferRecordEntity>> obj = new TData<List<TerTransferRecordEntity>>();
            obj.Data = await terTransferRecordService.GetList(param);
            obj.Total = obj.Data.Count;
            obj.Tag = 1;
            return obj;
        }

        public async Task<TData<List<TerTransferRecordEntity>>> GetPageList(TerTransferRecordListParam param, Pagination pagination)
        {
            TData<List<TerTransferRecordEntity>> obj = new TData<List<TerTransferRecordEntity>>();
            obj.Data = await terTransferRecordService.GetPageList(param, pagination);
            obj.Total = pagination.TotalCount;
            obj.Tag = 1;
            return obj;
        }

        public async Task<TData<TerTransferRecordEntity>> GetEntity(long id)
        {
            TData<TerTransferRecordEntity> obj = new TData<TerTransferRecordEntity>();
            obj.Data = await terTransferRecordService.GetEntity(id);
            if (obj.Data != null)
            {
                obj.Tag = 1;
            }
            return obj;
        }
        #endregion

        #region 提交数据
        public async Task<TData<string>> SaveForm(TerTransferRecordEntity entity)
        {
            TData<string> obj = new TData<string>();
            await terTransferRecordService.SaveForm(entity);
            obj.Data = entity.Id.ParseToString();
            obj.Tag = 1;
            return obj;
        }

        public async Task<TData> DeleteForm(string ids)
        {
            TData obj = new TData();
            await terTransferRecordService.DeleteForm(ids);
            obj.Tag = 1;
            return obj;
        }
        #endregion

        #region 私有方法
        #endregion
    }
}
