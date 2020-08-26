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
    /// 日 期：2020-08-25 17:43
    /// 描 述：订单用户收益服务类
    /// </summary>
    public class OrderUserProfitService :  RepositoryFactory
    {
        #region 获取数据
        public async Task<List<OrderUserProfitEntity>> GetList(OrderUserProfitListParam param)
        {
            var expression = ListFilter(param);
            var list = await this.BaseRepository().FindList(expression);
            return list.ToList();
        }

        public async Task<List<OrderUserProfitEntity>> GetPageList(OrderUserProfitListParam param, Pagination pagination)
        {
            var expression = ListFilter(param);
            var list= await this.BaseRepository().FindList(expression, pagination);
            return list.ToList();
        }

        public async Task<OrderUserProfitEntity> GetEntity(long id)
        {
            return await this.BaseRepository().FindEntity<OrderUserProfitEntity>(id);
        }
        #endregion

        #region 提交数据
        public async Task SaveForm(OrderUserProfitEntity entity)
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
            await this.BaseRepository().Delete<OrderUserProfitEntity>(idArr);
        }
        #endregion

        #region 私有方法
        private Expression<Func<OrderUserProfitEntity, bool>> ListFilter(OrderUserProfitListParam param)
        {
            var expression = LinqExtensions.True<OrderUserProfitEntity>();
            if (param != null)
            {
            }
            return expression;
        }
        #endregion
    }
}
