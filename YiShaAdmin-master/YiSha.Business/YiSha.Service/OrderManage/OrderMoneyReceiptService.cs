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
using YiSha.Web.Code;

namespace YiSha.Service.OrderManage
{
    /// <summary>
    /// 创 建：admin
    /// 日 期：2020-10-28 18:08
    /// 描 述：订单收据服务类
    /// </summary>
    public class OrderMoneyReceiptService : RepositoryFactory
    {
        #region 获取数据
        public async Task<List<OrderMoneyReceiptEntity>> GetList(OrderMoneyReceiptListParam param, OperatorInfo opuser)
        {
            var expression = ListFilter(param);
            var list = await this.BaseRepository().FindList(expression);
            return list.ToList();
        }

        public async Task<List<OrderMoneyReceiptEntity>> GetPageList(OrderMoneyReceiptListParam param, Pagination pagination, OperatorInfo opuser)
        {
            /*
            var expression = ListFilter(param);
            var list= await this.BaseRepository().FindList(expression, pagination);
            return list.ToList();
            */
            StringBuilder sql = CreateListSql(param,opuser);
            var data = await this.BaseRepository().FindList<OrderMoneyReceiptEntity>(sql.ToString(), pagination);
            return data.list.ToList<OrderMoneyReceiptEntity>();
        }

        public async Task<OrderMoneyReceiptEntity> GetEntity(long id)
        {
            // return await this.BaseRepository().FindEntity<OrderMoneyReceiptEntity>(id);
            StringBuilder sql = CreateSignalSql(id);
            return await this.BaseRepository().FindSignalModel<OrderMoneyReceiptEntity>(sql.ToString());
        }

        public async Task<object> GetCount(string stime,string etime)
        {
            // return await this.BaseRepository().FindEntity<OrderMoneyReceiptEntity>(id);
            StringBuilder sql = CreateTodayCount(stime,etime);
            return await this.BaseRepository().FindObject(sql.ToString());
        }
        #endregion

        #region 提交数据
        public async Task SaveForm(OrderMoneyReceiptEntity entity)
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
            await this.BaseRepository().Delete<OrderMoneyReceiptEntity>(idArr);
        }
        #endregion

        #region 私有方法
        private Expression<Func<OrderMoneyReceiptEntity, bool>> ListFilter(OrderMoneyReceiptListParam param)
        {
            var expression = LinqExtensions.True<OrderMoneyReceiptEntity>();
            if (param != null)
            {
            }
            return expression;
        }

        private StringBuilder CreateTodayCount(string startTime, string endTime)
        {
            StringBuilder sql = new StringBuilder();
            sql.AppendFormat("  SELECT COUNT(1) FROM order_money_receipt ");
            sql.AppendFormat("  where 1=1 ");
            if (!string.IsNullOrEmpty(startTime))
            {
                sql.AppendFormat(" AND BaseCreateTime >'{0} 00:00:00'", startTime);

            }
            if (!string.IsNullOrEmpty(endTime))
            {
                sql.AppendFormat(" AND BaseCreateTime <'{0} 23:59:59'", endTime);

            }
            return sql;
        }

        /// <summary>
        /// 创建查询sql
        /// </summary>
        /// <param name="param">查询条件数据</param>
        /// <returns></returns>
        private StringBuilder CreateListSql(OrderMoneyReceiptListParam param, OperatorInfo opuser)
        {
            StringBuilder sql = new StringBuilder();
            sql.AppendFormat(" SELECT a.*");
            sql.AppendFormat(" ,b.RealName AS SaleManTxt");

            sql.AppendFormat(" ,c.Title AS CompanyTxt");
            sql.AppendFormat(" ,c.CompanyImg");
            sql.AppendFormat(" ,c.NumberPre");
            sql.AppendFormat(" from (");
            sql.AppendFormat("  SELECT * FROM order_money_receipt ");
            sql.AppendFormat("  where 1=1 ");
            if (param != null)
            {
                if (!opuser.IsAdminOrDev)
                {
                    sql.AppendFormat(" AND SaleManId = {0}", opuser.UserIdStr);
                }
                if (!string.IsNullOrEmpty(param.Title))
                {
                    sql.AppendFormat(" AND Title LIKE '%{0}%'", param.Title);
                }
                if (!string.IsNullOrEmpty(param.PayManName))
                {
                    sql.AppendFormat(" AND Title LIKE '%{0}%'", param.PayManName);
                }
                if (!string.IsNullOrEmpty(param.PayManName))
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
            sql.AppendFormat(" on a.SaleManId  = b.Id ");

            sql.AppendFormat("  JOIN ");
            sql.AppendFormat(" ( ");
            sql.AppendFormat("   SELECT Id,CompanyImg,NumberPre,Title from sys_receipt_config ");
            sql.AppendFormat("   WHERE 1=1 ");
            sql.AppendFormat(" ) c");
            sql.AppendFormat(" on a.CompanyId  = c.Id ");


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
            sql.AppendFormat(" ,b.RealName AS SaleManTxt");

            sql.AppendFormat(" ,c.Title AS CompanyTxt");
            sql.AppendFormat(" ,c.CompanyImg");
            sql.AppendFormat(" ,c.NumberPre");
            sql.AppendFormat(" from (");
            sql.AppendFormat("  SELECT * FROM order_money_receipt ");
            sql.AppendFormat("  where 1=1 ");
            sql.AppendFormat("  and Id={0}", id);

            sql.AppendFormat(" ) a ");

            sql.AppendFormat(" JOIN ");
            sql.AppendFormat(" ( ");
            sql.AppendFormat("   SELECT Id,RealName from sysuser ");
            sql.AppendFormat("   WHERE 1=1 ");
            sql.AppendFormat(" ) b");
            sql.AppendFormat(" on a.SaleManId  = b.Id ");

            sql.AppendFormat("  JOIN ");
            sql.AppendFormat(" ( ");
            sql.AppendFormat("   SELECT Id,CompanyImg,NumberPre,Title from sys_receipt_config ");
            sql.AppendFormat("   WHERE 1=1 ");
            sql.AppendFormat(" ) c");
            sql.AppendFormat(" on a.CompanyId  = c.Id ");


            return sql;
        }
        #endregion
    }
}
