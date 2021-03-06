﻿using System;
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
using System.Data;
using YiSha.Model.Result.OrderManage;
using YiSha.Enum;

namespace YiSha.Service.OrderManage
{
    /// <summary>
    /// 创 建：admin
    /// 日 期：2020-08-25 17:33
    /// 描 述：设备出货单服务类
    /// </summary>
    public class OrderTerIssueService : RepositoryFactory
    {
        #region 获取数据
        public async Task<List<OrderTerIssueEntity>> GetList(OrderTerIssueListParam param, OperatorInfo user)
        {
            var expression = ListFilter(param);
            var list = await this.BaseRepository().FindList(expression);
            return list.ToList();
        }


        public async Task<List<OrderTerIssueEntity>> GetPageList(OrderTerIssueListParam param, Pagination pagination, OperatorInfo user)
        {
            /*
            var expression = ListFilter(param);
            var list= await this.BaseRepository().FindList(expression, pagination);
            return list.ToList();
            */
            StringBuilder sql = CreateListSql(param,user);
            //LogHelper.Info(" sql:"+sql.ToString());
            var data = await this.BaseRepository().FindList<OrderTerIssueEntity>(sql.ToString(), pagination);
            return data.list.ToList<OrderTerIssueEntity>();
        }

        public async Task<List<Response_OrderTerIssue_ChartLine>> GetListGroup(OrderTerIssueListParam param,OperatorInfo user)
        {
            /*
            var expression = ListFilter(param);
            var list= await this.BaseRepository().FindList(expression, pagination);
            return list.ToList();
            */
            StringBuilder sql = CreateListGropuSql(param, user);
            var data = await this.BaseRepository().FindList<Response_OrderTerIssue_ChartLine>(sql.ToString());

            return data.ToList<Response_OrderTerIssue_ChartLine>();
        }

        /// <summary>
        /// 获取审核数量
        /// </summary>
        /// <param name="user">当前登录用户</param>
        ///  <param name="step">审核步骤</param>
        /// <returns></returns>
        public async Task<int> GetShenCount(OperatorInfo user, OutPutStepEnum step)
        {
            /*
            var expression = ListFilter(param);
            var list= await this.BaseRepository().FindList(expression, pagination);
            return list.ToList();
            */
            int count= 0;
            StringBuilder sql =CreateShenCountSql(user, step);
            object data = await this.BaseRepository().FindObject(sql.ToString());
            if (data != null)
            {
                int.TryParse(data.ToString(),out count);
            }
            return count;
        }


        public async Task<OrderTerIssueEntity> GetEntity(long id)
        {
            // return await this.BaseRepository().FindEntity<OrderTerIssueEntity>(id);
            StringBuilder sql = CreateSignalSql(id);
            return await this.BaseRepository().FindSignalModel<OrderTerIssueEntity>(sql.ToString());
        }

        public async Task<int> UpdatePrintOrderNumbe(List<string> ids, string printOrderNumber)
        {
            StringBuilder sql = CreateUpdatePrintOrderNumber(ids, printOrderNumber);
            int reslt = await this.BaseRepository().ExecuteBySql(sql.ToString());
            return reslt;
        }


        public async Task<List<OrderTerIssueEntity>> GetListByIds(List<string> ids)
        {
            StringBuilder sql = CreateListSqlByIds(ids);
            var list_data= await this.BaseRepository().FindList<OrderTerIssueEntity>(sql.ToString());

            return list_data.ToList<OrderTerIssueEntity>();

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
        private StringBuilder CreateListSql(OrderTerIssueListParam param, OperatorInfo user)
        {
            StringBuilder sql = new StringBuilder();
            sql.AppendFormat(" SELECT a.*");
            sql.AppendFormat(" ,b.RealName AS BaseCreatorTxt");
            sql.AppendFormat(" ,c.RealName AS ShenHeManTxt");
            sql.AppendFormat(" ,d.RealName AS SentManTxt");
            sql.AppendFormat(" ,e.MaterielName as MaterielTxt");

            sql.AppendFormat(" ,e.MaterielType as MaterielType");
            sql.AppendFormat(" ,e.MaterielDesc as MaterielDesc");
            sql.AppendFormat(" ,e.MaterielUnite as MaterielUnite");
            sql.AppendFormat(" from (");
            sql.AppendFormat("  SELECT * FROM order_ter_issue ");
            sql.AppendFormat("  where 1=1 ");
            if (param != null)
            {
                if (param.Step >= 0)
                {
                    sql.AppendFormat(" AND Step={0}", param.Step);
                }
                if (param.ShenHeStatus >= 0)
                {
                    sql.AppendFormat(" AND ShenHeStatus={0}", param.ShenHeStatus);
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
            sql.AppendFormat(" ( ");
            sql.AppendFormat("   SELECT Id,RealName from sysuser ");
            sql.AppendFormat("   WHERE 1=1 ");
            sql.AppendFormat(" ) b");
            sql.AppendFormat(" on a.SaleId  = b.Id ");

            sql.AppendFormat(" LEFT JOIN ");
            sql.AppendFormat(" ( ");
            sql.AppendFormat("   SELECT Id,RealName from sysuser ");
            sql.AppendFormat("   WHERE 1=1 ");
            sql.AppendFormat(" ) c");
            sql.AppendFormat(" on a.ShenHeManId  = c.Id ");

            sql.AppendFormat(" LEFT JOIN ");
            sql.AppendFormat(" ( ");
            sql.AppendFormat("   SELECT Id,RealName from sysuser ");
            sql.AppendFormat("   WHERE 1=1 ");
            sql.AppendFormat(" ) d");
            sql.AppendFormat(" on a.SentManId  = d.Id ");

            sql.AppendFormat(" JOIN ");
            sql.AppendFormat(" ( ");
            sql.AppendFormat("   SELECT Id,MaterielName,MaterielType,MaterielDesc,MaterielUnite from order_materiel ");
            sql.AppendFormat("   WHERE 1=1 ");
            sql.AppendFormat(" ) e");
            sql.AppendFormat(" on a.MaterielId  = e.Id ");
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
            sql.AppendFormat(" ,c.RealName AS ShenHeManTxt");
            sql.AppendFormat(" ,d.RealName AS SentManTxt");

            sql.AppendFormat(" ,e.MaterielName as MaterielTxt");
            sql.AppendFormat(" ,e.MaterielType as MaterielType");
            sql.AppendFormat(" ,e.MaterielDesc as MaterielDesc");
            sql.AppendFormat(" ,e.MaterielUnite as MaterielUnite");
            sql.AppendFormat(" from (");
            sql.AppendFormat("  SELECT * FROM order_ter_issue ");
            sql.AppendFormat("  WHERE 1=1 ");
            sql.AppendFormat(" AND Id={0}", id);

            sql.AppendFormat(" ) a ");

            sql.AppendFormat(" JOIN ");
            sql.AppendFormat(" ( ");
            sql.AppendFormat("   SELECT Id,RealName from sysuser ");
            sql.AppendFormat("   WHERE 1=1 ");
            sql.AppendFormat(" ) b");
            sql.AppendFormat(" on a.SaleId  = b.Id ");

            sql.AppendFormat(" LEFT JOIN ");
            sql.AppendFormat(" ( ");
            sql.AppendFormat("   SELECT Id,RealName from sysuser ");
            sql.AppendFormat("   WHERE 1=1 ");
            sql.AppendFormat(" ) c");
            sql.AppendFormat(" on a.ShenHeManId  = c.Id ");

            sql.AppendFormat(" LEFT JOIN ");
            sql.AppendFormat(" ( ");
            sql.AppendFormat("   SELECT Id,RealName from sysuser ");
            sql.AppendFormat("   WHERE 1=1 ");
            sql.AppendFormat(" ) d");
            sql.AppendFormat(" on a.SentManId  = d.Id ");

            sql.AppendFormat(" JOIN ");
            sql.AppendFormat(" ( ");
            sql.AppendFormat("   SELECT Id,MaterielName,MaterielType,MaterielDesc,MaterielUnite from order_materiel ");
            sql.AppendFormat("   WHERE 1=1 ");
            sql.AppendFormat(" ) e");
            sql.AppendFormat(" on a.MaterielId  = e.Id ");
            return sql;
        }

        /// <summary>
        /// 创建 批量更新打印单号sql
        /// </summary>
        /// <param name="ids">要更新的物料单列表</param>
        /// <param name="printOrderNumber">打印单号</param>
        /// <returns></returns>
        private StringBuilder CreateUpdatePrintOrderNumber(List<string> ids, string printOrderNumber)
        {
            StringBuilder sql = new StringBuilder();

            sql.AppendFormat(" update order_ter_issue set PrintOrderNumber='{0}'", printOrderNumber);
            sql.AppendFormat(" where 1=1");
            sql.AppendFormat(" and Id in ({0})", string.Join(",", ids));

            return sql;

        }

        /// <summary>
        /// 根据id数组创建查询sql
        /// </summary>
        /// <param name="ids">查询的ids数组</param>
        /// <returns></returns>
        private StringBuilder CreateListSqlByIds(List<string> ids)
        {
            /*
            StringBuilder sql = new StringBuilder();
            sql.AppendFormat(" SELECT * FROM order_ter_issue ");
            sql.AppendFormat(" WHERE 1=1");
            sql.AppendFormat(" and Id in ({0})", string.Join(",", ids));

            return sql;
            */

            StringBuilder sql = new StringBuilder();
            sql.AppendFormat(" SELECT a.*");
            sql.AppendFormat(" ,b.RealName AS BaseCreatorTxt");
            sql.AppendFormat(" ,c.RealName AS ShenHeManTxt");
            sql.AppendFormat(" ,d.RealName AS SentManTxt");
            sql.AppendFormat(" ,e.MaterielName as MaterielTxt");

            sql.AppendFormat(" ,e.MaterielType as MaterielType");
            sql.AppendFormat(" ,e.MaterielDesc as MaterielDesc");
            sql.AppendFormat(" ,e.MaterielUnite as MaterielUnite");
            sql.AppendFormat(" from (");
            sql.AppendFormat("  SELECT * FROM order_ter_issue ");
            sql.AppendFormat("  where 1=1 ");
            sql.AppendFormat(" and Id in ({0})", string.Join(",", ids));

            sql.AppendFormat(" ) a ");

            sql.AppendFormat(" JOIN ");
            sql.AppendFormat(" ( ");
            sql.AppendFormat("   SELECT Id,RealName from sysuser ");
            sql.AppendFormat("   WHERE 1=1 ");
            sql.AppendFormat(" ) b");
            sql.AppendFormat(" on a.SaleId  = b.Id ");

            sql.AppendFormat(" LEFT JOIN ");
            sql.AppendFormat(" ( ");
            sql.AppendFormat("   SELECT Id,RealName from sysuser ");
            sql.AppendFormat("   WHERE 1=1 ");
            sql.AppendFormat(" ) c");
            sql.AppendFormat(" on a.ShenHeManId  = c.Id ");

            sql.AppendFormat(" LEFT JOIN ");
            sql.AppendFormat(" ( ");
            sql.AppendFormat("   SELECT Id,RealName from sysuser ");
            sql.AppendFormat("   WHERE 1=1 ");
            sql.AppendFormat(" ) d");
            sql.AppendFormat(" on a.SentManId  = d.Id ");

            sql.AppendFormat(" JOIN ");
            sql.AppendFormat(" ( ");
            sql.AppendFormat("   SELECT Id,MaterielName,MaterielType,MaterielDesc,MaterielUnite from order_materiel ");
            sql.AppendFormat("   WHERE 1=1 ");
            sql.AppendFormat(" ) e");
            sql.AppendFormat(" on a.MaterielId  = e.Id ");
            return sql;
        }



        /// <summary>
        /// 创建查询sql
        /// </summary>
        /// <param name="param">查询条件数据</param>
        /// <returns></returns>
        private StringBuilder CreateListGropuSql(OrderTerIssueListParam param, OperatorInfo user)
        {
            StringBuilder sql = new StringBuilder();
            sql.AppendFormat(" SELECT a.*");

            sql.AppendFormat(" ,e.MaterielName as MaterielTxt");

            sql.AppendFormat(" ,e.MaterielType as MaterielType");
            sql.AppendFormat(" ,e.MaterielDesc as MaterielDesc");
            sql.AppendFormat(" ,e.MaterielUnite as MaterielUnite");
            sql.AppendFormat(" from (");
            sql.AppendFormat("  SELECT  SUM(SaleNum) SaleNum,MaterielId,BuyDay  FROM order_ter_issue ");
            sql.AppendFormat("  where 1=1 ");
            if (param != null)
            {
                if (!user.IsAdminOrDev)
                {
                    sql.AppendFormat(" AND SaleId ={0}",user.UserIdStr);
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
            sql.AppendFormat(" GROUP BY BuyDay,MaterielId");

            sql.AppendFormat(" ) a ");

            sql.AppendFormat(" JOIN ");
            sql.AppendFormat(" ( ");
            sql.AppendFormat("   SELECT Id,MaterielName,MaterielType,MaterielDesc,MaterielUnite from order_materiel ");
            sql.AppendFormat("   WHERE 1=1 ");
            sql.AppendFormat(" ) e");
            sql.AppendFormat(" on a.MaterielId  = e.Id ");
            sql.AppendFormat(" ORDER BY a.BuyDay");
            return sql;
        }



        /// <summary>
        /// 创建待审核数量 查询sql
        /// </summary>
        /// <param name="user">当前登录用户</param>
        /// <param name="step">步骤</param>
        /// <returns></returns>
        private StringBuilder CreateShenCountSql(OperatorInfo user, OutPutStepEnum step)
        {
            StringBuilder sql = new StringBuilder();
            sql.AppendFormat(" SELECT COUNT(1) TotalNum FROM order_ter_issue WHERE 1=1");
            if (step == OutPutStepEnum.Validate)
            {
                sql.AppendFormat(" AND Step=1");
                sql.AppendFormat(" AND ShenHeManId={0}",user.UserIdStr);
            }
            else
            {
                sql.AppendFormat(" AND Step=2");
                sql.AppendFormat(" AND SentManId={0}", user.UserIdStr);
            }

            return sql;
        }

        #endregion
    }
}
