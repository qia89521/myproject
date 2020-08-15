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

namespace YiSha.Service.TerManage
{
    /// <summary>
    /// 创 建：admin
    /// 日 期：2020-08-14 16:05
    /// 描 述：设备信息服务类
    /// </summary>
    public class TerInforService :  RepositoryFactory
    {
        #region 获取数据
        public async Task<List<TerInforEntity>> GetList(TerInforListParam param)
        {
            var expression = ListFilter(param);
            var list = await this.BaseRepository().FindList(expression);
            return list.ToList();
        }

        public async Task<List<TerInforEntity>> GetPageList(TerInforListParam param, Pagination pagination)
        {
            var expression = ListFilter(param);
            var list= await this.BaseRepository().FindList(expression, pagination);
            return list.ToList();
        }

        public async Task<TerInforEntity> GetEntity(long id)
        {
            return await this.BaseRepository().FindEntity<TerInforEntity>(id);
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
            }
            return expression;
        }
        #endregion
    }
}
