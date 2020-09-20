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
    /// 日 期：2020-09-20 17:55
    /// 描 述：出货打印单配置业务类
    /// </summary>
    public class SysIssueConfigBLL
    {
        private SysIssueConfigService sysIssueConfigService = new SysIssueConfigService();

        #region 获取数据
        public async Task<TData<List<SysIssueConfigEntity>>> GetList(SysIssueConfigListParam param)
        {
            TData<List<SysIssueConfigEntity>> obj = new TData<List<SysIssueConfigEntity>>();
            obj.Data = await sysIssueConfigService.GetList(param);
            obj.Total = obj.Data.Count;
            obj.Tag = 1;
            return obj;
        }
        /// <summary>
        /// 获取第一个配置
        /// </summary>
        /// <returns></returns>
        public async Task<TData<SysIssueConfigEntity>> GetFristModel()
        {
            TData<SysIssueConfigEntity> obj = new TData<SysIssueConfigEntity>();
            obj.Data = await sysIssueConfigService.GetFristModel();
            if (obj.Data != null)
            {
                obj.Tag = 1;
            }
            return obj;
        }

        public async Task<TData<List<SysIssueConfigEntity>>> GetPageList(SysIssueConfigListParam param, Pagination pagination)
        {
            TData<List<SysIssueConfigEntity>> obj = new TData<List<SysIssueConfigEntity>>();
            obj.Data = await sysIssueConfigService.GetPageList(param, pagination);
            obj.Total = pagination.TotalCount;
            obj.Tag = 1;
            return obj;
        }

        public async Task<TData<SysIssueConfigEntity>> GetEntity(long id)
        {
            TData<SysIssueConfigEntity> obj = new TData<SysIssueConfigEntity>();
            obj.Data = await sysIssueConfigService.GetEntity(id);
            if (obj.Data != null)
            {
                obj.Tag = 1;
            }
            return obj;
        }
        #endregion

        #region 提交数据
        public async Task<TData<string>> SaveForm(SysIssueConfigEntity entity)
        {
            TData<string> obj = new TData<string>();
            await sysIssueConfigService.SaveForm(entity);
            obj.Data = entity.Id.ParseToString();
            obj.Tag = 1;
            return obj;
        }

        public async Task<TData> DeleteForm(string ids)
        {
            TData obj = new TData();
            await sysIssueConfigService.DeleteForm(ids);
            obj.Tag = 1;
            return obj;
        }
        #endregion

        #region 私有方法
        #endregion
    }
}
