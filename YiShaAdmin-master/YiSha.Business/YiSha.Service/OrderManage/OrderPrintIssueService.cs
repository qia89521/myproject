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
using System.Data;

namespace YiSha.Service.OrderManage
{
    /// <summary>
    /// 创 建：admin
    /// 日 期：2020-09-20 17:56
    /// 描 述：系统出货打印单服务类
    /// </summary>
    public class OrderPrintIssueService :  RepositoryFactory
    {
        #region 获取数据
        public async Task<List<OrderPrintIssueEntity>> GetList(OrderPrintIssueListParam param)
        {
            var expression = ListFilter(param);
            var list = await this.BaseRepository().FindList(expression);
            return list.ToList();
        }


        public async Task<List<OrderPrintIssueEntity>> GetPageList(OrderPrintIssueListParam param, Pagination pagination)
        {
            /*
            var expression = ListFilter(param);
            var list= await this.BaseRepository().FindList(expression, pagination);
            return list.ToList();
            */
            StringBuilder sql = CreateListSql(param);
            var data = await this.BaseRepository().FindList<OrderPrintIssueEntity>(sql.ToString(), pagination);
            return data.list.ToList<OrderPrintIssueEntity>();
        }

        public async Task<OrderPrintIssueEntity> GetEntity(long id)
        {
            /*
            return await this.BaseRepository().FindEntity<OrderPrintIssueEntity>(id);
            */

            StringBuilder sql = CreateSignalSql(id);
            return await this.BaseRepository().FindSignalModel<OrderPrintIssueEntity>(sql.ToString());
        }

        /// <summary>
        /// 获取当日打印订单数量
        /// </summary>
        /// <param name="printDay">打印日期</param>
        /// <returns></returns>
        public async Task<int> GetPrintDayCount(string printDay)
        {
            //FindObject
            StringBuilder sql = CreatePrintDayCount(printDay);
            DataTable dt = await this.BaseRepository().FindTable(sql.ToString());
            int count = 0;
            if (dt.Rows.Count > 0)
            {
               int.TryParse( dt.Rows[0]["Total"].ToString(),out count);
            }
            return count;
        }

        #endregion

        #region 提交数据
        public async Task SaveForm(OrderPrintIssueEntity entity)
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
            await this.BaseRepository().Delete<OrderPrintIssueEntity>(idArr);
        }
        #endregion

        #region 私有方法
        private Expression<Func<OrderPrintIssueEntity, bool>> ListFilter(OrderPrintIssueListParam param)
        {
            var expression = LinqExtensions.True<OrderPrintIssueEntity>();
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
        private StringBuilder CreateListSql(OrderPrintIssueListParam param)
        {
            StringBuilder sql = new StringBuilder();
            sql.AppendFormat(" SELECT a.*");
            sql.AppendFormat(" ,b.RealName AS BaseCreatorTxt");
            sql.AppendFormat(" from (");
            sql.AppendFormat("  SELECT * FROM order_print_issue ");
            sql.AppendFormat("  where 1=1 ");
            if (param != null)
            {
                if (!string.IsNullOrEmpty(param.CustName))
                {
                    sql.AppendFormat(" AND CustName LIKE '%{0}%'", param.CustName);
                }
                if (!string.IsNullOrEmpty(param.LinkName))
                {
                    sql.AppendFormat(" AND LinkName LIKE '%{0}%'", param.LinkName);
                }
                if (!string.IsNullOrEmpty(param.LinkPhone))
                {
                    sql.AppendFormat(" AND LinkPhone LIKE '%{0}%'", param.LinkPhone);
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
            sql.AppendFormat(" on a.BaseCreatorId  = b.Id ");

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
            sql.AppendFormat(" SELECT a.*");
            sql.AppendFormat(" ,b.RealName AS BaseCreatorTxt");
            sql.AppendFormat(" from (");
            sql.AppendFormat("  SELECT * FROM order_print_issue ");
            sql.AppendFormat("  where 1=1 ");
            sql.AppendFormat("  and Id={0} ",id);

            sql.AppendFormat(" ) a ");

            sql.AppendFormat(" JOIN ");
            sql.AppendFormat(" ( ");
            sql.AppendFormat("   SELECT Id,RealName from sysuser ");
            sql.AppendFormat("   WHERE 1=1 ");
            sql.AppendFormat(" ) b");
            sql.AppendFormat(" on a.BaseCreatorId  = b.Id ");

            return sql;
        }

        /// <summary>
        /// 创建查询sql
        /// </summary>
        /// <param name="printDay">打印日期</param>
        /// <returns></returns>
        private StringBuilder CreatePrintDayCount(string printDay)
        {
            StringBuilder sql = new StringBuilder();
            sql.AppendFormat("  SELECT COUNT(PrintDay) Total FROM order_print_issue ");
            sql.AppendFormat("  where 1=1 ");
            sql.AppendFormat("  and PrintDay='{0}' ", printDay);
            return sql;
        }
        #endregion
    }
}
