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
    /// 日 期：2020-09-09 22:52
    /// 描 述：物料进货单服务类
    /// </summary>
    public class OrderTerInputService : RepositoryFactory
    {
        #region 获取数据
        public async Task<List<OrderTerInputEntity>> GetList(OrderTerInputListParam param)
        {
            var expression = ListFilter(param);
            var list = await this.BaseRepository().FindList(expression);
            return list.ToList();
        }

        public async Task<List<OrderTerInputEntity>> GetPageList(OrderTerInputListParam param, Pagination pagination)
        {
            /*
            var expression = ListFilter(param);
            var list = await this.BaseRepository().FindList(expression, pagination);
            return list.ToList();
            */
            StringBuilder sql = CreateListSql(param);
            var data = await this.BaseRepository().FindList<OrderTerInputEntity>(sql.ToString(), pagination);
            return data.list.ToList<OrderTerInputEntity>();
        }

        public async Task<OrderTerInputEntity> GetEntity(long id)
        {
            /*
            return await this.BaseRepository().FindEntity<OrderTerInputEntity>(id);
            */
            StringBuilder sql = CreateSignalSql(id);
            return await this.BaseRepository().FindSignalModel<OrderTerInputEntity>(sql.ToString());
        }
        #endregion

        #region 提交数据
        public async Task SaveForm(OrderTerInputEntity entity)
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
            await this.BaseRepository().Delete<OrderTerInputEntity>(idArr);
        }
        #endregion

        #region 私有方法
        private Expression<Func<OrderTerInputEntity, bool>> ListFilter(OrderTerInputListParam param)
        {
            var expression = LinqExtensions.True<OrderTerInputEntity>();
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
        private StringBuilder CreateListSql(OrderTerInputListParam param)
        {
            StringBuilder sql = new StringBuilder();
            sql.AppendFormat(" SELECT a.*");
            sql.AppendFormat(" ,b.RealName AS BaseCreatorTxt");
            sql.AppendFormat(" ,c.SupplierName as SupplierTxt");
            sql.AppendFormat(" ,d.MaterielName as MaterielTxt");
            sql.AppendFormat(" from (");
            sql.AppendFormat("  SELECT * FROM order_ter_input ");
            sql.AppendFormat("  where 1=1 ");
            if (param != null)
            {
                if (!string.IsNullOrEmpty(param.BuyTxt))
                {
                    sql.AppendFormat(" AND BuyTxt LIKE '%{0}%'", param.BuyTxt);
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
            sql.AppendFormat(" on a.BuyId  = b.Id ");

            sql.AppendFormat(" JOIN ");
            sql.AppendFormat(" ( ");
            sql.AppendFormat("   SELECT Id,SupplierName from order_supplier ");
            sql.AppendFormat("   WHERE 1=1 ");
            sql.AppendFormat(" ) c");
            sql.AppendFormat(" on a.SupplierId  = c.Id ");

            sql.AppendFormat(" JOIN ");
            sql.AppendFormat(" ( ");
            sql.AppendFormat("   SELECT Id,MaterielName from order_materiel ");
            sql.AppendFormat("   WHERE 1=1 ");
            sql.AppendFormat(" ) d");
            sql.AppendFormat(" on a.MaterielId  = d.Id ");

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
            sql.AppendFormat(" ,c.SupplierName as SupplierTxt");
            sql.AppendFormat(" ,d.MaterielName as MaterielTxt");
            sql.AppendFormat(" from (");

            sql.AppendFormat("  SELECT * FROM order_ter_input ");
            sql.AppendFormat("  where 1=1 ");
            sql.AppendFormat(" AND Id ='{0}'", id);

            sql.AppendFormat(" ) a ");

            sql.AppendFormat(" JOIN ");
            sql.AppendFormat(" ( ");
            sql.AppendFormat("   SELECT Id,RealName from sysuser ");
            sql.AppendFormat("   WHERE 1=1 ");
            sql.AppendFormat(" ) b");
            sql.AppendFormat(" on a.BuyId  = b.Id ");

            sql.AppendFormat(" JOIN ");
            sql.AppendFormat(" ( ");
            sql.AppendFormat("   SELECT Id,SupplierName from order_supplier ");
            sql.AppendFormat("   WHERE 1=1 ");
            sql.AppendFormat(" ) c");
            sql.AppendFormat(" on a.SupplierId  = c.Id ");

            sql.AppendFormat(" JOIN ");
            sql.AppendFormat(" ( ");
            sql.AppendFormat("   SELECT Id,MaterielName from order_materiel ");
            sql.AppendFormat("   WHERE 1=1 ");
            sql.AppendFormat(" ) d");
            sql.AppendFormat(" on a.MaterielId  = d.Id ");

            return sql;
        }
        #endregion
    }
}
