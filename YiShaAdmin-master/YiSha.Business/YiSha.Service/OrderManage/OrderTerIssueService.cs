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
    /// 日 期：2020-08-25 17:33
    /// 描 述：设备出货单服务类
    /// </summary>
    public class OrderTerIssueService :  RepositoryFactory
    {
        #region 获取数据
        public async Task<List<OrderTerIssueEntity>> GetList(OrderTerIssueListParam param)
        {
            var expression = ListFilter(param);
            var list = await this.BaseRepository().FindList(expression);
            return list.ToList();
        }

        public async Task<List<OrderTerIssueEntity>> GetPageList(OrderTerIssueListParam param, Pagination pagination)
        {
            /*
            var expression = ListFilter(param);
            var list= await this.BaseRepository().FindList(expression, pagination);
            return list.ToList();
            */
            StringBuilder sql = CreateListSql(param);
            var data = await this.BaseRepository().FindList<OrderTerIssueEntity>(sql.ToString(), pagination);
            return data.list.ToList<OrderTerIssueEntity>();
        }

        public async Task<OrderTerIssueEntity> GetEntity(long id)
        {
            // return await this.BaseRepository().FindEntity<OrderTerIssueEntity>(id);
            StringBuilder sql = CreateSignalSql(id);
            return await this.BaseRepository().FindSignalModel<OrderTerIssueEntity>(sql.ToString());
        }
        #endregion

        #region 提交数据
        public async Task SaveForm(OrderTerIssueEntity entity)
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
            await this.BaseRepository().Delete<OrderTerIssueEntity>(idArr);
        }
        #endregion

        #region 私有方法
        private Expression<Func<OrderTerIssueEntity, bool>> ListFilter(OrderTerIssueListParam param)
        {
            var expression = LinqExtensions.True<OrderTerIssueEntity>();
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
        private StringBuilder CreateListSql(OrderTerIssueListParam param)
        {
            StringBuilder sql = new StringBuilder();
            sql.AppendFormat(" SELECT a.*,b.RealName AS BaseCreatorTxt from  ");
            sql.AppendFormat(" (");
            sql.AppendFormat("  SELECT * FROM order_ter_issue ");
            sql.AppendFormat("  where 1=1 ");
            if (param != null)
            {
                if (!string.IsNullOrEmpty(param.SaleTxt))
                {
                    sql.AppendFormat(" AND SaleTxt LIKE '%{0}%'", param.SaleTxt);
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
            sql.AppendFormat(" on a.SaleId  = b.Id ");
            
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
            sql.AppendFormat(" FROM  order_ter_issue a ");
            sql.AppendFormat(" JOIN sysuser b ON a.BaseCreatorId = b.Id AND a.Id={0}", id);
            sql.AppendFormat(" ) T WHERE 1=1 ");

            return sql;
        }

        #endregion
    }
}
