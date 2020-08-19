using System;
using System.Linq;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using YiSha.Util;
using YiSha.Util.Extension;
using YiSha.Util.Model;
using YiSha.Data.Repository;
using YiSha.Entity.SystemManage;
using YiSha.Model.Param.SystemManage;
using System.Text;
using System.Data;

namespace YiSha.Service.SystemManage
{
    public class AreaService : RepositoryFactory
    {
        #region 获取数据
        public async Task<List<AreaEntity>> GetList(AreaListParam param)
        {
            var expression = ListFilter(param);
            var list = await this.BaseRepository().FindList(expression);
            return list.ToList();
        }

        public async Task<List<AreaEntity>> GetPageList(AreaListParam param, Pagination pagination)
        {
            var expression = ListFilter(param);
            var list = await this.BaseRepository().FindList(expression, pagination);
            return list.ToList();
        }

        public async Task<DataTable> GetData(AreaListParam param)
        {
            /*Task<DataTable> FindTable
               var expression = ListFilter(param);
                var list= await this.BaseRepository().FindList(expression, pagination);
                return list.ToList();
             */
            StringBuilder sql = CreateSql(param);
            var data = await this.BaseRepository().FindTable(sql.ToString());
            return data;
        }


        public async Task<AreaEntity> GetEntity(long id)
        {
            return await this.BaseRepository().FindEntity<AreaEntity>(id);
        }

        public async Task<AreaEntity> GetEntityByAreaCode(string areaCode)
        {
            return await this.BaseRepository().FindEntity<AreaEntity>(p => p.AreaCode == areaCode);
        }
        #endregion

        #region 提交数据
        public async Task SaveForm(AreaEntity entity)
        {
            if (entity.Id.IsNullOrZero())
            {
                await entity.Create();
                await this.BaseRepository().Insert<AreaEntity>(entity);
            }
            else
            {
                await entity.Modify();
                await this.BaseRepository().Update<AreaEntity>(entity);
            }
        }

        public async Task DeleteForm(string ids)
        {
            long[] idArr = TextHelper.SplitToArray<long>(ids, ',');
            await this.BaseRepository().Delete<AreaEntity>(idArr);
        }

        #endregion

        #region 私有方法
        private Expression<Func<AreaEntity, bool>> ListFilter(AreaListParam param)
        {
            var expression = LinqExtensions.True<AreaEntity>();
            if (param != null)
            {
                if (!param.AreaName.IsEmpty())
                {
                    expression = expression.And(t => t.AreaName.Contains(param.AreaName));
                }
            }
            return expression;
        }

        /// <summary>
        /// 创建查询sql
        /// </summary>
        /// <returns></returns>
        private StringBuilder CreateSql(AreaListParam param)
        {
            StringBuilder sql = new StringBuilder();

            sql.AppendFormat(" SELECT AreaCode,ParentAreaCode,AreaName,AreaLevel FROM sysarea");
            sql.AppendFormat(" WHERE 1=1");
            if (param != null)
            {
                if (!param.ParentAreaCode.IsEmpty())
                {
                    //expression = expression.And(t => t.AreaName.Contains(param.AreaName));
                    sql.AppendFormat(" AND ParentAreaCode='{0}'", param.ParentAreaCode);
                }
            }
           
            return sql;
        }
        #endregion
    }
}
