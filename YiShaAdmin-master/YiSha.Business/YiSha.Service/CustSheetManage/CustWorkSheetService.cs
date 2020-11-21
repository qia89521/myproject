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
using YiSha.Entity.CustSheetManage;
using YiSha.Model.Param.CustSheetManage;
using YiSha.Web.Code;
using YiSha.Enum;

namespace YiSha.Service.CustSheetManage
{
    /// <summary>
    /// 创 建：admin
    /// 日 期：2020-11-19 15:30
    /// 描 述：维修工单处理服务类
    /// </summary>
    public class CustWorkSheetService : RepositoryFactory
    {
        #region 获取数据
        public async Task<List<CustWorkSheetEntity>> GetList(CustWorkSheetListParam param)
        {
            var expression = ListFilter(param);
            var list = await this.BaseRepository().FindList(expression);
            return list.ToList();
        }

        public async Task<List<CustWorkSheetEntity>> GetPageList(CustWorkSheetListParam param, Pagination pagination, OperatorInfo user)
        {
            /*
            var expression = ListFilter(param);
            var list = await this.BaseRepository().FindList(expression, pagination);
            return list.ToList();
            */
            StringBuilder sql = CreateListSql(param, user);
            var data = await this.BaseRepository().FindList<CustWorkSheetEntity>(sql.ToString(), pagination);
            return data.list.ToList<CustWorkSheetEntity>();
        }


        /// <summary>
        /// 获取审核数量
        /// </summary>
        /// <param name="user">当前登录用户</param>
        ///  <param name="step">审核步骤</param>
        /// <returns></returns>
        public async Task<int> GetShenCount(OperatorInfo user, CustWorkSheeStepEnum step)
        {
            /*
            var expression = ListFilter(param);
            var list= await this.BaseRepository().FindList(expression, pagination);
            return list.ToList();
            */
            int count = 0;
            StringBuilder sql = CreateShenCountSql(user, step);
            object data = await this.BaseRepository().FindObject(sql.ToString());
            if (data != null)
            {
                int.TryParse(data.ToString(), out count);
            }
            return count;
        }

        public async Task<CustWorkSheetEntity> GetEntity(long id)
        {
            //CreateSignalSqlById
            //return await this.BaseRepository().FindEntity<CustWorkSheetEntity>(id);
            StringBuilder sql = CreateSignalSqlById(id);

            return await this.BaseRepository().FindSignalModel<CustWorkSheetEntity>(sql.ToString());
        }
        #endregion

        #region 提交数据
        public async Task SaveForm(CustWorkSheetEntity entity)
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
            await this.BaseRepository().Delete<CustWorkSheetEntity>(idArr);
        }
        #endregion

        #region 私有方法
        private Expression<Func<CustWorkSheetEntity, bool>> ListFilter(CustWorkSheetListParam param)
        {
            var expression = LinqExtensions.True<CustWorkSheetEntity>();
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
        private StringBuilder CreateListSql(CustWorkSheetListParam param, OperatorInfo user)
        {
            StringBuilder sql = new StringBuilder();
            sql.AppendFormat(" SELECT a.*,");
            sql.AppendFormat(" b.TerNumber,b.TerName,");
            sql.AppendFormat(" c.RealName AS DoManTxt,");
            sql.AppendFormat(" d.RealName AS BaseCreatorTxt");
            sql.AppendFormat(" from ");
            sql.AppendFormat(" (");
            sql.AppendFormat("  select * from cust_work_sheet ");
            sql.AppendFormat("  where 1=1 ");
            if (param != null)
            {
                if (!user.IsAdminOrDev)
                {
                    sql.AppendFormat(" AND (BaseCreatorId={0} OR DoManId={0})", user.UserIdStr);
                }
                if (param.Step >= 0)
                {
                    sql.AppendFormat(" AND Step={0}", param.Step);
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
            sql.AppendFormat("   select Id,TerNumber,TerName from ter_infor ");
            sql.AppendFormat("   where 1=1 ");
            if (param != null)
            {
                if (!string.IsNullOrEmpty(param.TerNumber))
                {
                    sql.AppendFormat(" and TerNumber like '%{0}%'", param.TerNumber);
                }
                if (!string.IsNullOrEmpty(param.TerName))
                {
                    sql.AppendFormat(" and TerName like '%{0}%'", param.TerName);
                }
            }
            sql.AppendFormat(" ) b");
            sql.AppendFormat(" on a.TerId=b.Id ");

            sql.AppendFormat(" JOIN ");
            sql.AppendFormat(" ( ");
            sql.AppendFormat("   SELECT Id,RealName from sysuser ");
            sql.AppendFormat("   WHERE 1=1 ");
            sql.AppendFormat(" ) c");
            sql.AppendFormat(" on a.DoManId  = c.Id ");

            sql.AppendFormat(" JOIN ");
            sql.AppendFormat(" ( ");
            sql.AppendFormat("   SELECT Id,RealName from sysuser ");
            sql.AppendFormat("   WHERE 1=1 ");
            sql.AppendFormat(" ) d");
            sql.AppendFormat(" on a.BaseCreatorId  = d.Id ");
            return sql;
        }

        /// <summary>
        /// 创建查询sql
        /// </summary>
        /// <param name="terId">终端设备id</param>
        /// <returns></returns>
        private StringBuilder CreateSignalSqlById(long Id)
        {
            StringBuilder sql = new StringBuilder();
            sql.AppendFormat(" SELECT a.*,");
            sql.AppendFormat(" b.TerNumber,b.TerName,");
            sql.AppendFormat(" c.RealName AS DoManTxt,");
            sql.AppendFormat(" d.RealName AS BaseCreatorTxt");
            sql.AppendFormat(" from ");
            sql.AppendFormat(" (");
            sql.AppendFormat("  select * from cust_work_sheet ");
            sql.AppendFormat("  where 1=1 ");
            sql.AppendFormat("  and Id={0}", Id);
            sql.AppendFormat(" ) a ");

            sql.AppendFormat(" JOIN ");
            sql.AppendFormat(" ( ");
            sql.AppendFormat("  SELECT Id,TerNumber,TerName from ter_infor ");
            sql.AppendFormat("  where 1=1 ");
            sql.AppendFormat(" ) b");
            sql.AppendFormat(" on a.TerId=b.Id ");

            sql.AppendFormat(" JOIN ");
            sql.AppendFormat(" ( ");
            sql.AppendFormat("   SELECT Id,RealName from sysuser ");
            sql.AppendFormat("   WHERE 1=1 ");
            sql.AppendFormat(" ) c");
            sql.AppendFormat(" on a.DoManId  = c.Id ");

            sql.AppendFormat(" JOIN ");
            sql.AppendFormat(" ( ");
            sql.AppendFormat("   SELECT Id,RealName from sysuser ");
            sql.AppendFormat("   WHERE 1=1 ");
            sql.AppendFormat(" ) d");
            sql.AppendFormat(" on a.BaseCreatorId  = d.Id ");
            return sql;
        }

        /// <summary>
        /// 创建待审核数量 查询sql
        /// </summary>
        /// <param name="user">当前登录用户</param>
        /// <param name="step">步骤</param>
        /// <returns></returns>
        private StringBuilder CreateShenCountSql(OperatorInfo user, CustWorkSheeStepEnum step)
        {
            StringBuilder sql = new StringBuilder();
            sql.AppendFormat(" SELECT COUNT(1) TotalNum FROM cust_work_sheet WHERE 1=1");
            if (step == CustWorkSheeStepEnum.ToDo)
            {
                sql.AppendFormat(" AND Step=0");
                sql.AppendFormat(" AND DoManId={0}", user.UserIdStr);
            }
            return sql;
        }
        #endregion
    }
}
