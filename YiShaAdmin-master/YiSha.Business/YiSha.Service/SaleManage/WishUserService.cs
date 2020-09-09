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
using YiSha.Entity.SaleManage;
using YiSha.Model.Param.SaleManage;

namespace YiSha.Service.SaleManage
{
    /// <summary>
    /// 创 建：admin
    /// 日 期：2020-09-01 15:48
    /// 描 述：意向用户服务类
    /// </summary>
    public class WishUserService :  RepositoryFactory
    {
        #region 获取数据
        public async Task<List<WishUserEntity>> GetList(WishUserListParam param)
        {
            var expression = ListFilter(param);
            var list = await this.BaseRepository().FindList(expression);
            return list.ToList();
        }

        public async Task<List<WishUserEntity>> GetPageList(WishUserListParam param, Pagination pagination)
        {
            /*
            var expression = ListFilter(param);
            var list= await this.BaseRepository().FindList(expression, pagination);
            return list.ToList();*/
            StringBuilder sql = CreateListSql(param);
            var data = await this.BaseRepository().FindList<WishUserEntity>(sql.ToString(), pagination);
            return data.list.ToList<WishUserEntity>();
        }

        public async Task<WishUserEntity> GetEntity(long id)
        {
            /*
            return await this.BaseRepository().FindEntity<WishUserEntity>(id);
            */
            StringBuilder sql = CreateSignalSql(id);
            return await this.BaseRepository().FindSignalModel<WishUserEntity>(sql.ToString());
        }

        public async Task<WishUserEntity> GetEntityByPhone(string phone)
        {
            /*
            return await this.BaseRepository().FindEntity<WishUserEntity>(id);
            */
            StringBuilder sql = CreateSignalByPhone(phone);
            return await this.BaseRepository().FindSignalModel<WishUserEntity>(sql.ToString());
        }
        #endregion

        #region 提交数据
        public async Task SaveForm(WishUserEntity entity)
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
            await this.BaseRepository().Delete<WishUserEntity>(idArr);
        }
        #endregion

        #region 私有方法
        private Expression<Func<WishUserEntity, bool>> ListFilter(WishUserListParam param)
        {
            var expression = LinqExtensions.True<WishUserEntity>();
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
        private StringBuilder CreateListSql(WishUserListParam param)
        {
            StringBuilder sql = new StringBuilder();

            sql.AppendFormat(" SELECT a.*,b.RealName AS TuiJianUserTxt FROM (");

            sql.AppendFormat(" SELECT * ");
            sql.AppendFormat(" FROM wish_user ");
            sql.AppendFormat(" WHERE 1=1");
            if (param != null)
            {
                if (!string.IsNullOrEmpty(param.MobilePhone))
                {
                    sql.AppendFormat(" AND MobilePhone = '{0}'", param.MobilePhone);
                }
                if (!string.IsNullOrEmpty(param.RealName))
                {
                    sql.AppendFormat(" AND RealName LIKE '{0}%'", param.RealName);
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

            sql.AppendFormat(" JOIN sysuser b ON a.TuiJianUserId = b.Id ");
           
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
            sql.AppendFormat(" SELECT a.*,b.RealName AS TuiJianUserTxt ");
            sql.AppendFormat(" FROM  wish_user a ");
            sql.AppendFormat(" JOIN sysuser b ON a.TuiJianUserId = b.Id AND a.Id={0}", id);
            sql.AppendFormat(" ) T WHERE 1=1 ");

            return sql;
        }

        /// <summary>
        /// 根据手机号查询客户
        /// </summary>
        /// <param name="phone">手机号</param>
        /// <returns></returns>
        private StringBuilder CreateSignalByPhone(string phone)
        {
            StringBuilder sql = new StringBuilder();

            sql.AppendFormat(" SELECT * ");
            sql.AppendFormat(" FROM  wish_user WHERE MobilePhone='{0}'", phone);

            return sql;
        }
        #endregion
    }
}
