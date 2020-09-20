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
using YiSha.Entity.SystemManage;
using YiSha.Model.Param.SystemManage;

namespace YiSha.Service.SystemManage
{
    /// <summary>
    /// 创 建：admin
    /// 日 期：2020-09-20 17:55
    /// 描 述：出货打印单配置服务类
    /// </summary>
    public class SysIssueConfigService :  RepositoryFactory
    {
        #region 获取数据
        public async Task<List<SysIssueConfigEntity>> GetList(SysIssueConfigListParam param)
        {
            var expression = ListFilter(param);
            var list = await this.BaseRepository().FindList(expression);
            return list.ToList();
        }

        public async Task<List<SysIssueConfigEntity>> GetPageList(SysIssueConfigListParam param, Pagination pagination)
        {
            /*
            var expression = ListFilter(param);
            var list= await this.BaseRepository().FindList(expression, pagination);
            return list.ToList();
            */
            StringBuilder sql = CreateListSql(param);
            var data = await this.BaseRepository().FindList<SysIssueConfigEntity>(sql.ToString(), pagination);
            return data.list.ToList<SysIssueConfigEntity>();
        }

        public async Task<SysIssueConfigEntity> GetEntity(long id)
        {
            /*
            return await this.BaseRepository().FindEntity<SysIssueConfigEntity>(id);
            */
            StringBuilder sql = CreateSignalSql(id);
            return await this.BaseRepository().FindSignalModel<SysIssueConfigEntity>(sql.ToString());
        }
        #endregion

        #region 提交数据
        public async Task SaveForm(SysIssueConfigEntity entity)
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
            await this.BaseRepository().Delete<SysIssueConfigEntity>(idArr);
        }
        #endregion

        #region 私有方法
        private Expression<Func<SysIssueConfigEntity, bool>> ListFilter(SysIssueConfigListParam param)
        {
            var expression = LinqExtensions.True<SysIssueConfigEntity>();
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
        private StringBuilder CreateListSql(SysIssueConfigListParam param)
        {
            StringBuilder sql = new StringBuilder();

            sql.AppendFormat(" SELECT * FROM (");
            sql.AppendFormat(" SELECT a.*,b.RealName AS BaseCreatorTxt ");
            sql.AppendFormat(" ,c.Name as SysBankMan");
            sql.AppendFormat(" ,c.MchNo as SysBankCardNo");
            sql.AppendFormat(" ,c.BankName as SysBankName");
            sql.AppendFormat(" FROM sys_issue_config a ");
            sql.AppendFormat(" JOIN sysuser b ON a.BaseCreatorId = b.Id ");
            sql.AppendFormat(" JOIN sys_bank_card c ON a.SysBankCardId  = c.Id ");

            sql.AppendFormat(" ) T WHERE 1=1 ");
            if (param != null)
            {
                if (!string.IsNullOrEmpty(param.Title))
                {
                    sql.AppendFormat(" AND Title LIKE '%{0}%'", param.Title);
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
            sql.AppendFormat(" ,c.Name as SysBankMan");
            sql.AppendFormat(" ,c.MchNo as SysBankCardNo");
            sql.AppendFormat(" ,c.BankName as SysBankName");
            sql.AppendFormat(" FROM  sys_issue_config a ");
            sql.AppendFormat(" JOIN sysuser b ON a.BaseCreatorId = b.Id ");
            sql.AppendFormat(" JOIN sys_bank_card c ON a.SysBankCardId  = c.Id ");
            sql.AppendFormat(" AND a.Id={0}",id);
            sql.AppendFormat(" ) T WHERE 1=1 ");

            return sql;
        }
        #endregion
    }
}
