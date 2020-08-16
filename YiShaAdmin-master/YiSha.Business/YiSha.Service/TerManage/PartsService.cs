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
    /// 日 期：2020-08-13 15:30
    /// 描 述：设备部件服务类
    /// </summary>
    public class PartsService :  RepositoryFactory
    {
        #region 获取数据
        public async Task<List<PartsEntity>> GetList(PartsListParam param)
        {
            var expression = ListFilter(param);
            var list = await this.BaseRepository().FindList(expression);
            return list.ToList();
        }

        public async Task<List<PartsEntity>> GetPageList(PartsListParam param, Pagination pagination)
        {
            /*
            var expression = ListFilter(param);
            var list= await this.BaseRepository().FindList(expression, pagination);
            return list.ToList();
            */
            StringBuilder sql = CreateListSql(param);
            var data = await this.BaseRepository().FindList<PartsEntity>(sql.ToString(), pagination);
            return data.list.ToList<PartsEntity>();
        }

        public async Task<PartsEntity> GetEntity(long id)
        {
            //return await this.BaseRepository().FindEntity<PartsEntity>(id);

            StringBuilder sql = CreateSignalSql(id);
            return await this.BaseRepository().FindSignalModel<PartsEntity>(sql.ToString());
        }
        #endregion

        #region 提交数据
        public async Task SaveForm(PartsEntity entity)
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
            await this.BaseRepository().Delete<PartsEntity>(idArr);
        }
        #endregion

        #region 私有方法
        private Expression<Func<PartsEntity, bool>> ListFilter(PartsListParam param)
        {
            var expression = LinqExtensions.True<PartsEntity>();
            if (param != null)
            {
                if (!string.IsNullOrEmpty(param.PartName))
                {
                    expression = expression.And(t => t.PartName.Contains(param.PartName));
                }
            }
            return expression;
        }


        /// <summary>
        /// 创建查询sql
        /// </summary>
        /// <param name="param">查询条件数据</param>
        /// <returns></returns>
        private StringBuilder CreateListSql(PartsListParam param)
        {
            StringBuilder sql = new StringBuilder();

            sql.AppendFormat(" SELECT * FROM (");
            sql.AppendFormat(" SELECT a.*,b.RealName AS BaseCreatorTxt ");
            sql.AppendFormat(" FROM  ter_parts a ");
            sql.AppendFormat(" JOIN sysuser b ON a.BaseCreatorId = b.Id ");
            sql.AppendFormat(" ) T WHERE 1=1 ");
            if (param != null)
            {
                if (!string.IsNullOrEmpty(param.PartName))
                {
                    sql.AppendFormat(" AND PartName LIKE '%{0}%'", param.PartName);
                }
            }
            return sql;
        }


        /// <summary>
        /// 创建查询sql
        /// </summary>
        /// <param name="id">主键Id</param>
        /// <returns></returns>
        private StringBuilder CreateSignalSql(long id)
        {
            StringBuilder sql = new StringBuilder();

            sql.AppendFormat(" SELECT * FROM (");
            sql.AppendFormat(" SELECT a.*,b.RealName AS BaseCreatorTxt ");
            sql.AppendFormat(" FROM  ter_parts a ");
            sql.AppendFormat(" JOIN sysuser b ON a.BaseCreatorId = b.Id AND a.Id={0}",id);
            sql.AppendFormat(" ) T WHERE 1=1 ");
          
            return sql;
        }
        #endregion
    }
}
