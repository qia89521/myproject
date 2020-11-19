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
    /// 日 期：2020-08-14 16:05
    /// 描 述：设备信息服务类
    /// </summary>
    public class TerInforService : RepositoryFactory
    {
        #region 获取数据
        public async Task<List<TerInforEntity>> GetList(TerInforListParam param, OperatorInfo user)
        {
            var expression = ListFilter(param);
            var list = await this.BaseRepository().FindList(expression);
            return list.ToList();
        }

        public async Task<List<TerInforEntity>> GetPageList(TerInforListParam param, Pagination pagination, OperatorInfo user)
        {
            /*
               var expression = ListFilter(param);
                var list= await this.BaseRepository().FindList(expression, pagination);
                return list.ToList();
             */
            StringBuilder sql = CreateListSql(param, user);
            var data = await this.BaseRepository().FindList<TerInforEntity>(sql.ToString(), pagination);
            List<TerInforEntity> list = data.list.ToList<TerInforEntity>();
            return list;
        }

        public async Task<TerInforEntity> GetEntity(long? id)
        {
            /*
            return await this.BaseRepository().FindEntity<TerInforEntity>(id);
            */
            StringBuilder sql = CreateSignalSql(id);

            return await this.BaseRepository().FindSignalModel<TerInforEntity>(sql.ToString());

        }

        /// <summary>
        /// 查询最大编号记录
        /// </summary>
        /// <returns></returns>
        public async Task<TerInforEntity> GetMaxNumberEntity()
        {
            /*
            return await this.BaseRepository().FindEntity<TerInforEntity>(id);
            */
            StringBuilder sql = CreateMaxNumberEntitySql();
            return await this.BaseRepository().FindSignalModel<TerInforEntity>(sql.ToString());
        }


        public async Task<TerInforEntity> GetEntityByNumber(string number)
        {
            /*
            return await this.BaseRepository().FindEntity<TerInforEntity>(id);
            */
            StringBuilder sql = CreateSignalSqlByNumber(number);
            return await this.BaseRepository().FindSignalModel<TerInforEntity>(sql.ToString());

        }
        public async Task<List<TerInforEntity>> GetListByNumber(List<string> numbers)
        {
            /*
            return await this.BaseRepository().FindEntity<TerInforEntity>(id);
            */
            StringBuilder sql = CreateListSqlByNumber(numbers);
            var list = await this.BaseRepository().FindList<TerInforEntity>(sql.ToString());

            return list.ToList<TerInforEntity>();

        }

        #endregion

        #region 提交数据
        public async Task SaveForm(TerInforEntity entity)
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

        public async Task<int> SaveForm(List<TerInforBateAdd> models)
        {

            StringBuilder sql = CreateBateAddSql(models);
            int count = await this.BaseRepository().ExecuteBySql(sql.ToString());
            return count;
        }

        public async Task DeleteForm(string ids)
        {
            long[] idArr = TextHelper.SplitToArray<long>(ids, ',');
            await this.BaseRepository().Delete<TerInforEntity>(idArr);
        }
        #endregion

        #region 私有方法
        private Expression<Func<TerInforEntity, bool>> ListFilter(TerInforListParam param)
        {
            var expression = LinqExtensions.True<TerInforEntity>();
            if (param != null)
            {

                if (!string.IsNullOrEmpty(param.TerName))
                {
                    expression = expression.And(t => t.TerName.Contains(param.TerName));
                }
                if (!string.IsNullOrEmpty(param.TerNumber))
                {
                    expression = expression.And(t => t.TerNumber.Contains(param.TerNumber));
                }
            }
            return expression;
        }

        /// <summary>
        /// 创建查询sql
        /// </summary>
        /// <param name="param">查询条件数据</param>
        /// <returns></returns>
        private StringBuilder CreateListSql(TerInforListParam param, OperatorInfo user)
        {
            StringBuilder sql = new StringBuilder();

            sql.AppendFormat(" SELECT a.*,b.RealName AS BaseCreatorTxt, ");
            sql.AppendFormat(" c.RealName AS SaleManTxt, ");
            sql.AppendFormat(" c.DelegetZoneTxt AS Zone, ");

            sql.AppendFormat(" d.RealName AS BaseModifierTxt, ");
            sql.AppendFormat(" e.RealName AS ManageTxt, ");

            sql.AppendFormat(" f.PartCode AS TerPartCode, ");
            sql.AppendFormat(" f.PartName AS TerPartTxt ");

            sql.AppendFormat(" FROM ( ");
            sql.AppendFormat(" SELECT * FROM ter_infor WHERE 1=1");

            if (param != null)
            {
                if (!string.IsNullOrEmpty(param.TerName))
                {
                    sql.AppendFormat(" AND TerName LIKE '%{0}%'", param.TerName);
                }
                if (!string.IsNullOrEmpty(param.TerNumber))
                {
                    sql.AppendFormat(" AND TerNumber LIKE '%{0}%'", param.TerNumber);
                }

                if (!user.IsAdminOrDev)
                {
                    sql.AppendFormat(" AND ManageId = {0}", user.UserId);

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

            sql.AppendFormat(" JOIN sysuser b ON a.BaseCreatorId = b.Id ");

            sql.AppendFormat(" LEFT JOIN sysuser C ON a.SaleManId = C.Id ");

            sql.AppendFormat(" LEFT JOIN sysuser d ON a.BaseModifierId = d.Id ");
            sql.AppendFormat(" LEFT JOIN sysuser e ON a.ManageId = e.Id ");

            sql.AppendFormat(" JOIN ter_parts f ON a.TerPartId = f.Id ");

            // LogHelper.Info(" CreateListSql sql:"+sql.ToString());


            return sql;
        }


        /// <summary>
        /// 创建查询sql
        /// </summary>
        /// <param name="id">主键Id</param>
        /// <returns></returns>
        private StringBuilder CreateSignalSql(long? id)
        {

            StringBuilder sql = new StringBuilder();

            sql.AppendFormat(" SELECT a.*,b.RealName AS BaseCreatorTxt, ");
            sql.AppendFormat(" c.RealName AS SaleManTxt, ");
            sql.AppendFormat(" c.DelegetZoneTxt AS Zone, ");

            sql.AppendFormat(" d.RealName AS BaseModifierTxt, ");
            sql.AppendFormat(" e.RealName AS ManageTxt, ");

            sql.AppendFormat(" f.PartCode AS TerPartCode, ");
            sql.AppendFormat(" f.PartName AS TerPartTxt ");
            sql.AppendFormat(" FROM ( ");
            sql.AppendFormat(" SELECT * FROM ter_infor WHERE 1=1");

            sql.AppendFormat(" AND Id={0}", id);

            sql.AppendFormat(" ) a ");

            sql.AppendFormat(" JOIN sysuser b ON a.BaseCreatorId = b.Id ");

            sql.AppendFormat(" LEFT JOIN sysuser C ON a.SaleManId = C.Id ");

            sql.AppendFormat(" LEFT JOIN sysuser d ON a.BaseModifierId = d.Id ");
            sql.AppendFormat(" LEFT JOIN sysuser e ON a.ManageId = e.Id ");
            sql.AppendFormat(" JOIN ter_parts f ON a.TerPartId = f.Id ");
            return sql;
        }


        /// <summary>
        /// 创建查询sql
        /// </summary>
        /// <param name="number">设备编号</param>
        /// <returns></returns>
        private StringBuilder CreateSignalSqlByNumber(string number)
        {
            StringBuilder sql = new StringBuilder();
            sql.AppendFormat(" SELECT * ");
            sql.AppendFormat(" FROM  ter_infor ");
            sql.AppendFormat(" WHERE TerNumber='{0}'", number);
            return sql;
        }

        /// <summary>
        /// 创建批量查询sql
        /// </summary>
        /// <param name="number">设备编号</param>
        /// <returns></returns>
        private StringBuilder CreateListSqlByNumber(List<string> numbers)
        {
            StringBuilder sql = new StringBuilder();
            sql.AppendFormat(" SELECT * ");
            sql.AppendFormat(" FROM  ter_infor ");
            sql.AppendFormat(" WHERE TerNumber in ('{0}')", string.Join("','", numbers));
            return sql;
        }

        /// <summary>
        /// 获取最大设备编号记录
        /// </summary>
        /// <returns></returns>
        private StringBuilder CreateMaxNumberEntitySql()
        {
            StringBuilder sql = new StringBuilder();
            sql.AppendFormat("  SELECT * FROM ter_infor ORDER BY TerNumber DESC LIMIT 1");
            return sql;
        }

        private StringBuilder CreateBateAddSql(List<TerInforBateAdd> models)
        {
            StringBuilder sql = new StringBuilder();
            sql.AppendFormat(" INSERT INTO ter_infor (Id,TerName,TerNumber,TerPartId,");
            sql.AppendFormat(" BaseCreatorId,BaseCreateTime)");
            int i = 0;
            foreach (TerInforBateAdd model in models)
            {
                //INSERT INTO table (field1,field2,field3) VALUES (‘a’,”b”,”c”), (‘a’,”b”,”c”),(‘a’,”b”,”c”);
                sql.AppendFormat(" VALUES ({0},'{1}','{2}',{3},", model.Id, model.TerName, model.TerNumber, model.TerPartId);
                sql.AppendFormat("{0},'{1}')", model.BaseCreatorId, model.BaseCreateTime.Value.ToString("yyyy-MM-dd HH:mm:ss"));

                if (i < models.Count - 1)
                {
                    sql.AppendFormat(",");
                }

            }
            sql.AppendFormat(";");

            return sql;
        }
        #endregion
    }
}
