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
    /// 日 期：2020-08-13 15:30
    /// 描 述：设备部件业务类
    /// </summary>
    public class PartsBLL
    {
        private PartsService partsService = new PartsService();

        #region 获取数据
        public async Task<TData<List<PartsEntity>>> GetList(PartsListParam param)
        {
            TData<List<PartsEntity>> obj = new TData<List<PartsEntity>>();
            obj.Data = await partsService.GetList(param);
            obj.Total = obj.Data.Count;
            obj.Tag = 1;
            return obj;
        }

        public async Task<TData<List<PartsEntity>>> GetPageList(PartsListParam param, Pagination pagination)
        {
            TData<List<PartsEntity>> obj = new TData<List<PartsEntity>>();
            obj.Data = await partsService.GetPageList(param, pagination);
            obj.Total = pagination.TotalCount;
            obj.Tag = 1;
            return obj;
        }

        public async Task<TData<PartsEntity>> GetEntity(long id)
        {
            TData<PartsEntity> obj = new TData<PartsEntity>();
            obj.Data = await partsService.GetEntity(id);
            if (obj.Data != null)
            {
                obj.Tag = 1;
            }
            return obj;
        }
        #endregion

        #region 提交数据
        public async Task<TData<string>> SaveForm(PartsEntity entity)
        {
            TData<string> obj = new TData<string>();
            await partsService.SaveForm(entity);
            obj.Data = entity.Id.ParseToString();
            obj.Tag = 1;
            return obj;
        }

        public async Task<TData> DeleteForm(string ids)
        {
            TData obj = new TData();
            await partsService.DeleteForm(ids);
            obj.Tag = 1;
            return obj;
        }
        #endregion

        #region 私有方法
        #endregion
    }
}
