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
    /// 日 期：2020-08-19 23:55
    /// 描 述：用户缴费订单记录服务类
    /// </summary>
    public class OrderUserFormService :  RepositoryFactory
    {
        #region 获取数据
        public async Task<List<OrderUserFormEntity>> GetList(OrderUserFormListParam param)
        {
            var expression = ListFilter(param);
            var list = await this.BaseRepository().FindList(expression);
            return list.ToList();
        }

        public async Task<List<OrderUserFormEntity>> GetPageList(OrderUserFormListParam param, Pagination pagination)
        {
            //var expression = ListFilter(param);
            //var list= await this.BaseRepository().FindList(expression, pagination);
            //return list.ToList();
            StringBuilder sql = CreateListSql(param);
            var data = await this.BaseRepository().FindList<OrderUserFormEntity>(sql.ToString(), pagination);
            return data.list.ToList<OrderUserFormEntity>();
        }

        public async Task<OrderUserFormEntity> GetEntity(long id)
        {
            // return await this.BaseRepository().FindEntity<OrderUserFormEntity>(id);
            StringBuilder sql = CreateSignalSql(id);
            return await this.BaseRepository().FindSignalModel<OrderUserFormEntity>(sql.ToString());
        }
        #endregion

        #region 提交数据
        public async Task SaveForm(OrderUserFormEntity entity)
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
            await this.BaseRepository().Delete<OrderUserFormEntity>(idArr);
        }
        #endregion

        #region 私有方法
        private Expression<Func<OrderUserFormEntity, bool>> ListFilter(OrderUserFormListParam param)
        {
            var expression = LinqExtensions.True<OrderUserFormEntity>();
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
        private StringBuilder CreateListSql(OrderUserFormListParam param)
        {
            StringBuilder sql = new StringBuilder();

            sql.AppendFormat(" select a.*,b.RealName AS BuyTxt from  ");
            sql.AppendFormat(" (");
            sql.AppendFormat("  SELECT * FROM order_user_form ");
            sql.AppendFormat("  where 1=1 ");
            if (param != null)
            {
                if (!string.IsNullOrEmpty(param.StartTime))
                {
                    sql.AppendFormat(" and BaseCreateTime >{0} 00:00:00", param.StartTime);
                }
                if (!string.IsNullOrEmpty(param.EndTime))
                {
                    sql.AppendFormat(" and BaseCreateTime <{0} 23:59:59", param.EndTime);
                }
            }
            sql.AppendFormat(" ) a ");
            sql.AppendFormat(" join ");
            sql.AppendFormat(" ( ");
            sql.AppendFormat("   select Id,RealName from sysuser ");
            sql.AppendFormat("   where 1=1 ");
            if (param != null)
            {
                if (!string.IsNullOrEmpty(param.BuyTxt))
                {
                    sql.AppendFormat(" and RealName like '%{0}%'", param.BuyTxt);
                }
            }
            sql.AppendFormat(" ) b");
            sql.AppendFormat(" on a.BuyId =b.Id ");

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
            sql.AppendFormat(" SELECT * FROM order_user_form ");
            sql.AppendFormat(" where 1=1 ");
            sql.AppendFormat(" JOIN sysuser b ON a.BuyId  = b.Id and a.Id={0}", id);
            sql.AppendFormat(" ) T WHERE 1=1 ");

            return sql;
        }
        #endregion
    }
}
