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
    /// 日 期：2020-10-28 18:08
    /// 描 述：订单收据服务类
    /// </summary>
    public class OrderMoneyReceiptService :  RepositoryFactory
    {
        #region 获取数据
        public async Task<List<OrderMoneyReceiptEntity>> GetList(OrderMoneyReceiptListParam param)
        {
            var expression = ListFilter(param);
            var list = await this.BaseRepository().FindList(expression);
            return list.ToList();
        }

        public async Task<List<OrderMoneyReceiptEntity>> GetPageList(OrderMoneyReceiptListParam param, Pagination pagination)
        {
            var expression = ListFilter(param);
            var list= await this.BaseRepository().FindList(expression, pagination);
            return list.ToList();
        }

        public async Task<OrderMoneyReceiptEntity> GetEntity(long id)
        {
            return await this.BaseRepository().FindEntity<OrderMoneyReceiptEntity>(id);
        }
        #endregion

        #region 提交数据
        public async Task SaveForm(OrderMoneyReceiptEntity entity)
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
            await this.BaseRepository().Delete<OrderMoneyReceiptEntity>(idArr);
        }
        #endregion

        #region 私有方法
        private Expression<Func<OrderMoneyReceiptEntity, bool>> ListFilter(OrderMoneyReceiptListParam param)
        {
            var expression = LinqExtensions.True<OrderMoneyReceiptEntity>();
            if (param != null)
            {
            }
            return expression;
        }
        #endregion
    }
}
