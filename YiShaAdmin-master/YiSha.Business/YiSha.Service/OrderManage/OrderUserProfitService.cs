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
using YiSha.Entity.OrderManage;
using YiSha.Model.Param.OrderManage;

namespace YiSha.Service.OrderManage
{
    /// <summary>
    /// 创 建：admin
    /// 日 期：2020-08-25 17:43
    /// 描 述：订单用户收益服务类
    /// </summary>
    public class OrderUserProfitService :  RepositoryFactory
    {
        #region 获取数据
        public async Task<List<OrderUserProfitEntity>> GetList(OrderUserProfitListParam param)
        {
            var expression = ListFilter(param);
            var list = await this.BaseRepository().FindList(expression);
            return list.ToList();
        }

        public async Task<List<OrderUserProfitEntity>> GetPageList(OrderUserProfitListParam param, Pagination pagination)
        {
            /*
            var expression = ListFilter(param);
            var list= await this.BaseRepository().FindList(expression, pagination);
            return list.ToList();
            */
            StringBuilder sql = CreateListSql(param);
            var data = await this.BaseRepository().FindList<OrderUserProfitEntity>(sql.ToString(), pagination);
            return data.list.ToList<OrderUserProfitEntity>();
        }

        public async Task<OrderUserProfitEntity> GetEntity(long id)
        {
            //return await this.BaseRepository().FindEntity<OrderUserProfitEntity>(id);
            StringBuilder sql = CreateSignalSql(id);
            return await this.BaseRepository().FindSignalModel<OrderUserProfitEntity>(sql.ToString());
        }
        #endregion

        #region 提交数据
        public async Task SaveForm(OrderUserProfitEntity entity)
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
            await this.BaseRepository().Delete<OrderUserProfitEntity>(idArr);
        }
        #endregion

        #region 私有方法
        private Expression<Func<OrderUserProfitEntity, bool>> ListFilter(OrderUserProfitListParam param)
        {
            var expression = LinqExtensions.True<OrderUserProfitEntity>();
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
        private StringBuilder CreateListSql(OrderUserProfitListParam param)
        {
            StringBuilder sql = new StringBuilder();
            sql.AppendFormat(" SELECT a.*,b.RealName AS BaseCreatorTxt from  ");
            sql.AppendFormat(" (");
            sql.AppendFormat("  SELECT * FROM order_user_profit ");
            sql.AppendFormat("  where 1=1 ");
            if (param != null)
            {
                if (!string.IsNullOrEmpty(param.UserName))
                {
                    sql.AppendFormat(" AND UserName LIKE '%{0}%'", param.UserName);
                }
                if (!string.IsNullOrEmpty(param.ChangeType))
                {
                    sql.AppendFormat(" AND ChangeType = '{0}'", param.ChangeType);
                }
                if (!string.IsNullOrEmpty(param.StartTime))
                {
                    sql.AppendFormat(" AND BaseCreateTime >'{0} 00:00:00'", param.StartTime);
                }
                if (!string.IsNullOrEmpty(param.EndTime))
                {
                    sql.AppendFormat(" AND BaseCreateTime <'{0} 23:59:59'", param.EndTime);
                }
            }
            sql.AppendFormat(" ) a ");
            sql.AppendFormat(" JOIN ");
            sql.AppendFormat(" ( ");
            sql.AppendFormat("   SELECT Id,RealName from sysuser ");
            sql.AppendFormat("   WHERE 1=1 ");
            sql.AppendFormat(" ) b");
            sql.AppendFormat(" on a.BaseCreatorId = b.Id ");

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
            sql.AppendFormat(" FROM  order_user_profit a ");
            sql.AppendFormat(" JOIN sysuser b ON a.BaseCreatorId = b.Id AND a.Id={0}", id);
            sql.AppendFormat(" ) T WHERE 1=1 ");

            return sql;
        }

        #endregion
    }
}
