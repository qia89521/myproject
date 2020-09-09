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
    /// 日 期：2020-09-08 18:14
    /// 描 述：物料明细服务类
    /// </summary>
    public class OrderMaterielDetailService :  RepositoryFactory
    {
        #region 获取数据
        public async Task<List<OrderMaterielDetailEntity>> GetList(OrderMaterielDetailListParam param)
        {
            var expression = ListFilter(param);
            var list = await this.BaseRepository().FindList(expression);
            return list.ToList();
        }

        public async Task<List<OrderMaterielDetailEntity>> GetPageList(OrderMaterielDetailListParam param, Pagination pagination)
        {
            /*
            var expression = ListFilter(param);
            var list= await this.BaseRepository().FindList(expression, pagination);
            return list.ToList();
            */
            StringBuilder sql = CreateListSql(param);
            var data = await this.BaseRepository().FindList<OrderMaterielDetailEntity>(sql.ToString(), pagination);
            return data.list.ToList<OrderMaterielDetailEntity>();
        }

        public async Task<OrderMaterielDetailEntity> GetEntity(long id)
        {
            return await this.BaseRepository().FindEntity<OrderMaterielDetailEntity>(id);
        }
        #endregion

        #region 提交数据
        public async Task SaveForm(OrderMaterielDetailEntity entity)
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
            await this.BaseRepository().Delete<OrderMaterielDetailEntity>(idArr);
        }
        #endregion

        #region 私有方法
        private Expression<Func<OrderMaterielDetailEntity, bool>> ListFilter(OrderMaterielDetailListParam param)
        {
            var expression = LinqExtensions.True<OrderMaterielDetailEntity>();
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
        private StringBuilder CreateListSql(OrderMaterielDetailListParam param)
        {
            StringBuilder sql = new StringBuilder();

            sql.AppendFormat(" select a.*,b.RealName AS BaseCreatorTxt,c.MaterielName from  ");
            sql.AppendFormat(" (");
            sql.AppendFormat("  SELECT * FROM order_materiel_detail ");
            sql.AppendFormat("  where 1=1 ");
            if (param != null)
            {
                if (param.MaterielId>0)
                {
                    sql.AppendFormat(" AND MaterielId ={0}", param.MaterielId);
                }
                if (!string.IsNullOrEmpty(param.Flag))
                {
                    if (param.Flag == "-")
                    {
                        sql.AppendFormat(" and ChangeNum < 0");
                    }
                    else if(param.Flag == "+")
                    {
                        sql.AppendFormat(" and ChangeNum > 0");
                    }
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
            sql.AppendFormat(" join ");
            sql.AppendFormat(" ( ");
            sql.AppendFormat("   select Id,RealName from sysuser ");
            sql.AppendFormat("   where 1=1 ");

            sql.AppendFormat(" ) b");
            sql.AppendFormat(" on a.BaseCreatorId =b.Id ");

            sql.AppendFormat(" join ");
            sql.AppendFormat(" ( ");
            sql.AppendFormat("   select Id,MaterielName from order_materiel ");
            sql.AppendFormat("   where 1=1 ");

            sql.AppendFormat(" ) c");
            sql.AppendFormat(" on a.MaterielId =c.Id ");
            return sql;
        }
        #endregion
    }
}
