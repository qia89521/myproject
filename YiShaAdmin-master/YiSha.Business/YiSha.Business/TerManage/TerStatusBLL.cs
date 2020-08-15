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
    /// 日 期：2020-08-14 16:16
    /// 描 述：设备状态业务类
    /// </summary>
    public class TerStatusBLL
    {
        private TerStatusService terStatusService = new TerStatusService();

        #region 获取数据
        public async Task<TData<List<TerStatusEntity>>> GetList(TerStatusListParam param)
        {
            TData<List<TerStatusEntity>> obj = new TData<List<TerStatusEntity>>();
            obj.Data = await terStatusService.GetList(param);
            obj.Total = obj.Data.Count;
            obj.Tag = 1;
            return obj;
        }

        public async Task<TData<List<TerStatusEntity>>> GetPageList(TerStatusListParam param, Pagination pagination)
        {
            TData<List<TerStatusEntity>> obj = new TData<List<TerStatusEntity>>();
            obj.Data = await terStatusService.GetPageList(param, pagination);
            obj.Total = pagination.TotalCount;
            obj.Tag = 1;
            return obj;
        }

        public async Task<TData<TerStatusEntity>> GetEntity(long id)
        {
            TData<TerStatusEntity> obj = new TData<TerStatusEntity>();
            obj.Data = await terStatusService.GetEntity(id);
            if (obj.Data != null)
            {
                obj.Tag = 1;
            }
            return obj;
        }
        #endregion

        #region 提交数据
        public async Task<TData<string>> SaveForm(TerStatusEntity entity)
        {
            TData<string> obj = new TData<string>();
            await terStatusService.SaveForm(entity);
            obj.Data = entity.Id.ParseToString();
            obj.Tag = 1;
            return obj;
        }

        public async Task<TData> DeleteForm(string ids)
        {
            TData obj = new TData();
            await terStatusService.DeleteForm(ids);
            obj.Tag = 1;
            return obj;
        }
        #endregion

        #region 私有方法
        #endregion
    }
}
