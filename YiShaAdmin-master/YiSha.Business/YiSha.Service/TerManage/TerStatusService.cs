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
using YiSha.Entity.TerManage;
using YiSha.Model.Param.TerManage;

namespace YiSha.Service.TerManage
{
    /// <summary>
    /// 创 建：admin
    /// 日 期：2020-08-14 16:16
    /// 描 述：设备状态服务类
    /// </summary>
    public class TerStatusService :  RepositoryFactory
    {
        #region 获取数据
        public async Task<List<TerStatusEntity>> GetList(TerStatusListParam param)
        {
            var expression = ListFilter(param);
            var list = await this.BaseRepository().FindList(expression);
            return list.ToList();
        }

        public async Task<List<TerStatusEntity>> GetPageList(TerStatusListParam param, Pagination pagination)
        {
            var expression = ListFilter(param);
            var list= await this.BaseRepository().FindList(expression, pagination);
            return list.ToList();
        }

        public async Task<TerStatusEntity> GetEntity(long id)
        {
            return await this.BaseRepository().FindEntity<TerStatusEntity>(id);
        }
        #endregion

        #region 提交数据
        public async Task SaveForm(TerStatusEntity entity)
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
            await this.BaseRepository().Delete<TerStatusEntity>(idArr);
        }
        #endregion

        #region 私有方法
        private Expression<Func<TerStatusEntity, bool>> ListFilter(TerStatusListParam param)
        {
            var expression = LinqExtensions.True<TerStatusEntity>();
            if (param != null)
            {
            }
            return expression;
        }


        /// <summary>
        /// 创建查询sql
        /// </summary>
        /// <param name="param">查询条件数据</param>
        /// <returns></returns>
        private StringBuilder CreateListSql(TerStatusListParam param)
        {
            StringBuilder sql = new StringBuilder();

            sql.AppendFormat(" select a.*,b.TerNumber,b.TerName from  ");
            sql.AppendFormat(" (");
            sql.AppendFormat("  select * from ter_status ");
            sql.AppendFormat("  where 1=1 ");
            if (param != null)
            {
                if (!string.IsNullOrEmpty(param.CloseStatus))
                {
                    sql.AppendFormat(" and CloseStatus={0}", param.CloseStatus);
                }
                if (!string.IsNullOrEmpty(param.RunStatus))
                {
                    sql.AppendFormat(" and RunStatus={0}", param.RunStatus);
                }
            }
            sql.AppendFormat(" ) a ");
            sql.AppendFormat(" join ");
            sql.AppendFormat(" ( ");
            sql.AppendFormat("   select Id,TerNumber,TerName from ter_infor ");
            sql.AppendFormat("   where 1=1 ");
            if (param != null)
            {
                if (!string.IsNullOrEmpty(param.TerNumber))
                {
                    sql.AppendFormat(" and TerNumber like '%{0}%'", param.TerNumber);
                }
                if (!string.IsNullOrEmpty(param.TerName))
                {
                    sql.AppendFormat(" and TerName like '%{0}%'", param.TerName);
                }
            }
            sql.AppendFormat(" ) b");
            sql.AppendFormat(" on a.TerId=b.Id ");

            return sql;
        }

        #endregion
    }
}
