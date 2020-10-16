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
using YiSha.Web.Code;

namespace YiSha.Service.TerManage
{
    /// <summary>
    /// 创 建：admin
    /// 日 期：2020-10-14 10:04
    /// 描 述：设备串货提醒服务类
    /// </summary>
    public class TerCollusionService : RepositoryFactory
    {
        #region 获取数据
        public async Task<List<TerCollusionEntity>> GetList(TerCollusionListParam param)
        {
            var expression = ListFilter(param);
            var list = await this.BaseRepository().FindList(expression);
            return list.ToList();
        }

        public async Task<List<TerCollusionEntity>> GetPageList(TerCollusionListParam param, Pagination pagination)
        {
            /*
            var expression = ListFilter(param);
            var list = await this.BaseRepository().FindList(expression, pagination);
            return list.ToList();
            */
            OperatorInfo user= await Operator.Instance.Current();
            StringBuilder sql = CreateListSql(param, user);
            var data = await this.BaseRepository().FindList<TerCollusionEntity>(sql.ToString(), pagination);
            return data.list.ToList<TerCollusionEntity>();
        }

        public async Task<TerCollusionEntity> GetEntity(long id)
        {
            /*
            return await this.BaseRepository().FindEntity<TerCollusionEntity>(id);
            */
            StringBuilder sql = CreateSignalSql(id);
            return await this.BaseRepository().FindSignalModel<TerCollusionEntity>(sql.ToString());
        }
        #endregion

        #region 提交数据
        public async Task SaveForm(TerCollusionEntity entity)
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
            await this.BaseRepository().Delete<TerCollusionEntity>(idArr);
        }
        #endregion

        #region 私有方法
        private Expression<Func<TerCollusionEntity, bool>> ListFilter(TerCollusionListParam param)
        {
            var expression = LinqExtensions.True<TerCollusionEntity>();
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
        private StringBuilder CreateListSql(TerCollusionListParam param, OperatorInfo user)
        {
            StringBuilder sql = new StringBuilder();

            sql.AppendFormat(" SELECT a.*, ");
            sql.AppendFormat(" b.TerName, ");
            sql.AppendFormat(" b.TerNumber, ");

            sql.AppendFormat(" c.RealName AS SaleTxt");

            sql.AppendFormat(" FROM ( ");
            sql.AppendFormat(" SELECT * FROM ter_collusion WHERE 1=1");

            if (param != null)
            {
                if (user != null)
                {
                    if (!user.IsAdminOrDev)
                    {
                        sql.AppendFormat(" AND SaleId  = {0}", user.UserId);
                    }
                }
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
            sql.AppendFormat(" (");
            sql.AppendFormat(" SELECT TerName,TerNumber FROM ter_infor WHERE 1=1");
            if (param != null)
            {
                if (!string.IsNullOrEmpty(param.TerNumber))
                {
                    sql.AppendFormat(" AND Id,TerNumber LIKE '%{0}%'", param.TerNumber);
                }
            }
            sql.AppendFormat(" ) b");
            sql.AppendFormat(" ON a.TerId =b.Id");

            sql.AppendFormat(" LEFT JOIN sysuser C ON a.SaleId  = C.Id ");

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

            sql.AppendFormat(" SELECT a.*, ");
            sql.AppendFormat(" b.TerName, ");
            sql.AppendFormat(" b.TerNumber, ");

            sql.AppendFormat(" c.RealName AS SaleTxt");

            sql.AppendFormat(" FROM ( ");
            sql.AppendFormat(" SELECT * FROM ter_collusion WHERE 1=1");
            sql.AppendFormat(" AND Id ={0}", id);

            sql.AppendFormat(" ) a ");
            sql.AppendFormat(" JOIN ");
            sql.AppendFormat(" (");

            sql.AppendFormat(" SELECT Id,TerName,TerNumber FROM ter_infor WHERE 1=1");

            sql.AppendFormat(" ) b");
            sql.AppendFormat(" ON a.TerId =b.Id");

            sql.AppendFormat(" LEFT JOIN sysuser C ON a.SaleId  = C.Id ");

            return sql;
        }

        #endregion
    }
}
