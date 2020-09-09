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
    /// 日 期：2020-09-09 22:53
    /// 描 述：供应商服务类
    /// </summary>
    public class OrderSupplierService :  RepositoryFactory
    {
        #region 获取数据
        public async Task<List<OrderSupplierEntity>> GetList(OrderSupplierListParam param)
        {
            var expression = ListFilter(param);
            var list = await this.BaseRepository().FindList(expression);
            return list.ToList();
        }

        public async Task<List<OrderSupplierEntity>> GetPageList(OrderSupplierListParam param, Pagination pagination)
        {
            var expression = ListFilter(param);
            var list= await this.BaseRepository().FindList(expression, pagination);
            return list.ToList();
        }

        public async Task<OrderSupplierEntity> GetEntity(long id)
        {
            return await this.BaseRepository().FindEntity<OrderSupplierEntity>(id);
        }
        #endregion

        #region 提交数据
        public async Task SaveForm(OrderSupplierEntity entity)
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
            await this.BaseRepository().Delete<OrderSupplierEntity>(idArr);
        }
        #endregion

        #region 私有方法
        private Expression<Func<OrderSupplierEntity, bool>> ListFilter(OrderSupplierListParam param)
        {
            var expression = LinqExtensions.True<OrderSupplierEntity>();
            if (param != null)
            {
            }
            return expression;
        }
        #endregion
    }
}
