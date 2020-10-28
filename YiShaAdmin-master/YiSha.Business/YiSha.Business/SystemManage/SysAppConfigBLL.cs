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
    /// 日 期：2020-10-28 18:03
    /// 描 述：系统应用配置业务类
    /// </summary>
    public class SysAppConfigBLL
    {
        private SysAppConfigService sysAppConfigService = new SysAppConfigService();

        #region 获取数据
        public async Task<TData<List<SysAppConfigEntity>>> GetList(SysAppConfigListParam param)
        {
            TData<List<SysAppConfigEntity>> obj = new TData<List<SysAppConfigEntity>>();
            obj.Data = await sysAppConfigService.GetList(param);
            obj.Total = obj.Data.Count;
            obj.Tag = 1;
            return obj;
        }

        public async Task<TData<List<SysAppConfigEntity>>> GetPageList(SysAppConfigListParam param, Pagination pagination)
        {
            TData<List<SysAppConfigEntity>> obj = new TData<List<SysAppConfigEntity>>();
            obj.Data = await sysAppConfigService.GetPageList(param, pagination);
            obj.Total = pagination.TotalCount;
            obj.Tag = 1;
            return obj;
        }

        public async Task<TData<SysAppConfigEntity>> GetEntity(long id)
        {
            TData<SysAppConfigEntity> obj = new TData<SysAppConfigEntity>();
            obj.Data = await sysAppConfigService.GetEntity(id);
            if (obj.Data != null)
            {
                obj.Tag = 1;
            }
            return obj;
        }

        public async Task<TData<SysAppConfigEntity>> GetEntity()
        {
            TData<SysAppConfigEntity> obj = new TData<SysAppConfigEntity>();
            obj.Data = await sysAppConfigService.GetEntity();
            if (obj.Data != null)
            {
                obj.Tag = 1;
            }
            return obj;
        }
        #endregion

        #region 提交数据
        public async Task<TData<string>> SaveForm(SysAppConfigEntity entity)
        {
            TData<string> obj = new TData<string>();
            TData<SysAppConfigEntity> oldEntity = new TData<SysAppConfigEntity>();
            oldEntity.Data = await sysAppConfigService.GetEntity();
            if (oldEntity.Data != null)
            {
                entity.Id = oldEntity.Data.Id;
                entity.BaseModifyTime = DateTime.Now;
            }
            await sysAppConfigService.SaveForm(entity);
            obj.Data = entity.Id.ParseToString();
            obj.Tag = 1;
            return obj;
        }

        public async Task<TData> DeleteForm(string ids)
        {
            TData obj = new TData();
            await sysAppConfigService.DeleteForm(ids);
            obj.Tag = 1;
            return obj;
        }
        #endregion

        #region 私有方法
        #endregion
    }
}
