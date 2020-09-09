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
    /// 日 期：2020-09-09 22:53
    /// 描 述：供应商服务类
    /// </summary>
    public class OrderSupplierService :  RepositoryFactory
    {
        #region 获取数据
        public async Task<List<OrderSupplierEntity>> GetList(OrderSupplierListParam param)
        {
            var expression = ListFilter(param);
            var list = await this.BaseRepository().FindList(expression);
            return list.ToList();
        }

        public async Task<List<OrderSupplierEntity>> GetPageList(OrderSupplierListParam param, Pagination pagination)
        {
            /*
            var expression = ListFilter(param);
            var list= await this.BaseRepository().FindList(expression, pagination);
            return list.ToList();
            */

            StringBuilder sql = CreateListSql(param);
            var data = await this.BaseRepository().FindList<OrderSupplierEntity>(sql.ToString(), pagination);
            return data.list.ToList<OrderSupplierEntity>();
        }

        public async Task<OrderSupplierEntity> GetEntity(long id)
        {
            /*
            return await this.BaseRepository().FindEntity<OrderSupplierEntity>(id);
            */

            StringBuilder sql = CreateSignalSql(id);
            return await this.BaseRepository().FindSignalModel<OrderSupplierEntity>(sql.ToString());
        }
        #endregion

        #region 提交数据
        public async Task SaveForm(OrderSupplierEntity entity)
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
            await this.BaseRepository().Delete<OrderSupplierEntity>(idArr);
        }
        #endregion

        #region 私有方法
        private Expression<Func<OrderSupplierEntity, bool>> ListFilter(OrderSupplierListParam param)
        {
            var expression = LinqExtensions.True<OrderSupplierEntity>();
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
        private StringBuilder CreateListSql(OrderSupplierListParam param)
        {
            StringBuilder sql = new StringBuilder();

            sql.AppendFormat(" SELECT * FROM (");
            sql.AppendFormat(" SELECT a.*,b.RealName AS BaseCreatorTxt ");
            sql.AppendFormat(" FROM  order_supplier a ");
            sql.AppendFormat(" JOIN sysuser b ON a.BaseCreatorId = b.Id ");
            sql.AppendFormat(" ) T WHERE 1=1 ");
            if (param != null)
            {
                if (!string.IsNullOrEmpty(param.SupplierName))
                {
                    sql.AppendFormat(" AND SupplierName LIKE '%{0}%'", param.SupplierName);
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
            sql.AppendFormat(" FROM  order_supplier a ");
            sql.AppendFormat(" JOIN sysuser b ON a.BaseCreatorId = b.Id AND a.Id={0}", id);
            sql.AppendFormat(" ) T WHERE 1=1 ");

            return sql;
        }
        #endregion
    }
}
