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
    /// 日 期：2020-10-28 18:03
    /// 描 述：系统应用配置服务类
    /// </summary>
    public class SysAppConfigService :  RepositoryFactory
    {
        #region 获取数据
        public async Task<List<SysAppConfigEntity>> GetList(SysAppConfigListParam param)
        {
            var expression = ListFilter(param);
            var list = await this.BaseRepository().FindList(expression);
            return list.ToList();
        }

        public async Task<List<SysAppConfigEntity>> GetPageList(SysAppConfigListParam param, Pagination pagination)
        {
            var expression = ListFilter(param);
            var list= await this.BaseRepository().FindList(expression, pagination);
            return list.ToList();
        }

        public async Task<SysAppConfigEntity> GetEntity(long id)
        {
            return await this.BaseRepository().FindEntity<SysAppConfigEntity>(id);
        }


        public async Task<SysAppConfigEntity> GetEntity()
        {
            //return await this.BaseRepository().FindEntity<PartsEntity>(id);

            StringBuilder sql = CreateSignalSql();
            return await this.BaseRepository().FindSignalModel<SysAppConfigEntity>(sql.ToString());
        }
        #endregion

        #region 提交数据
        public async Task SaveForm(SysAppConfigEntity entity)
        {
            if (entity.Id.IsNullOrZero())
            {
                entity.Create();
                await this.BaseRepository().Insert(entity);
            }
            else
            {
                
                await this.BaseRepository().Update(entity);
            }
        }

        public async Task DeleteForm(string ids)
        {
            long[] idArr = TextHelper.SplitToArray<long>(ids, ',');
            await this.BaseRepository().Delete<SysAppConfigEntity>(idArr);
        }
        #endregion

        #region 私有方法
        private Expression<Func<SysAppConfigEntity, bool>> ListFilter(SysAppConfigListParam param)
        {
            var expression = LinqExtensions.True<SysAppConfigEntity>();
            if (param != null)
            {
            }
            return expression;
        }

        /// <summary>
        /// 创建查询sql
        /// </summary>
        /// <param name="id">主键Id</param>
        /// <returns></returns>
        private StringBuilder CreateSignalSql()
        {
            StringBuilder sql = new StringBuilder();

            sql.AppendFormat(" SELECT * FROM  sys_app_config LIMIT 1");

            return sql;
        }
        #endregion
    }
}
