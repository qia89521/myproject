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
    /// 日 期：2020-10-28 18:04
    /// 描 述：系统收据配置业务类
    /// </summary>
    public class SysReceiptConfigBLL
    {
        private SysReceiptConfigService sysReceiptConfigService = new SysReceiptConfigService();

        #region 获取数据
        public async Task<TData<List<SysReceiptConfigEntity>>> GetList(SysReceiptConfigListParam param)
        {
            TData<List<SysReceiptConfigEntity>> obj = new TData<List<SysReceiptConfigEntity>>();
            obj.Data = await sysReceiptConfigService.GetList(param);
            obj.Total = obj.Data.Count;
            obj.Tag = 1;
            return obj;
        }

        public async Task<TData<List<SysReceiptConfigEntity>>> GetList()
        {
            TData<List<SysReceiptConfigEntity>> obj = new TData<List<SysReceiptConfigEntity>>();
            obj.Data = await sysReceiptConfigService.GetList();
            obj.Total = obj.Data.Count;
            obj.Tag = 1;
            return obj;
        }

        public async Task<TData<List<SysReceiptConfigEntity>>> GetPageList(SysReceiptConfigListParam param, Pagination pagination)
        {
            TData<List<SysReceiptConfigEntity>> obj = new TData<List<SysReceiptConfigEntity>>();
            obj.Data = await sysReceiptConfigService.GetPageList(param, pagination);
            obj.Total = pagination.TotalCount;
            obj.Tag = 1;
            return obj;
        }

        public async Task<TData<SysReceiptConfigEntity>> GetEntity(long id)
        {
            TData<SysReceiptConfigEntity> obj = new TData<SysReceiptConfigEntity>();
            obj.Data = await sysReceiptConfigService.GetEntity(id);
            if (obj.Data != null)
            {
                obj.Tag = 1;
            }
            return obj;
        }
        #endregion

        #region 提交数据
        public async Task<TData<string>> SaveForm(SysReceiptConfigEntity entity)
        {
            TData<string> obj = new TData<string>();
            await sysReceiptConfigService.SaveForm(entity);
            obj.Data = entity.Id.ParseToString();
            obj.Tag = 1;
            return obj;
        }

        public async Task<TData> DeleteForm(string ids)
        {
            TData obj = new TData();
            await sysReceiptConfigService.DeleteForm(ids);
            obj.Tag = 1;
            return obj;
        }
        #endregion

        #region 私有方法
        #endregion
    }
}
