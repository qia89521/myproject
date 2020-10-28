using System;
using System.Linq;
using System.Text;
using System.Data.Common;
using System.Linq.Expressions;
using System.Collections.Generic;
using System.Threading.Tasks;
using YiSha.Util;
using YiSha.Util.Extension;
using YiSha.Util.Model;
using YiSha.Data;
using YiSha.Data.Repository;
using YiSha.Entity.SystemManage;
using YiSha.Model.Param.SystemManage;

namespace YiSha.Service.SystemManage
{
    /// <summary>
    /// 创 建：admin
    /// 日 期：2020-10-28 18:04
    /// 描 述：系统收据配置服务类
    /// </summary>
    public class SysReceiptConfigService :  RepositoryFactory
    {
        #region 获取数据
        public async Task<List<SysReceiptConfigEntity>> GetList(SysReceiptConfigListParam param)
        {
            var expression = ListFilter(param);
            var list = await this.BaseRepository().FindList(expression);
            return list.ToList();
        }

        public async Task<List<SysReceiptConfigEntity>> GetPageList(SysReceiptConfigListParam param, Pagination pagination)
        {
            var expression = ListFilter(param);
            var list= await this.BaseRepository().FindList(expression, pagination);
            return list.ToList();
        }

        public async Task<SysReceiptConfigEntity> GetEntity(long id)
        {
            return await this.BaseRepository().FindEntity<SysReceiptConfigEntity>(id);
        }
        #endregion

        #region 提交数据
        public async Task SaveForm(SysReceiptConfigEntity entity)
        {
            if (entity.Id.IsNullOrZero())
            {
                await entity.Create();
                await this.BaseRepository().Insert(entity);
            }
            else
            {
                await entity.Modify();
                await this.BaseRepository().Update(entity);
            }
        }

        public async Task DeleteForm(string ids)
        {
            long[] idArr = TextHelper.SplitToArray<long>(ids, ',');
            await this.BaseRepository().Delete<SysReceiptConfigEntity>(idArr);
        }
        #endregion

        #region 私有方法
        private Expression<Func<SysReceiptConfigEntity, bool>> ListFilter(SysReceiptConfigListParam param)
        {
            var expression = LinqExtensions.True<SysReceiptConfigEntity>();
            if (param != null)
            {
            }
            return expression;
        }
        #endregion
    }
}
