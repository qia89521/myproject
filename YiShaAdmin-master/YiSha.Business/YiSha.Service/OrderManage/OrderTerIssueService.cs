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
    /// 日 期：2020-08-25 17:33
    /// 描 述：设备出货单服务类
    /// </summary>
    public class OrderTerIssueService :  RepositoryFactory
    {
        #region 获取数据
        public async Task<List<OrderTerIssueEntity>> GetList(OrderTerIssueListParam param)
        {
            var expression = ListFilter(param);
            var list = await this.BaseRepository().FindList(expression);
            return list.ToList();
        }

        public async Task<List<OrderTerIssueEntity>> GetPageList(OrderTerIssueListParam param, Pagination pagination)
        {
            var expression = ListFilter(param);
            var list= await this.BaseRepository().FindList(expression, pagination);
            return list.ToList();
        }

        public async Task<OrderTerIssueEntity> GetEntity(long id)
        {
            return await this.BaseRepository().FindEntity<OrderTerIssueEntity>(id);
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
        #endregion
    }
}
