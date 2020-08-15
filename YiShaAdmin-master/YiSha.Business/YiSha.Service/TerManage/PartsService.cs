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
    /// 日 期：2020-08-13 15:30
    /// 描 述：设备部件服务类
    /// </summary>
    public class PartsService :  RepositoryFactory
    {
        #region 获取数据
        public async Task<List<PartsEntity>> GetList(PartsListParam param)
        {
            var expression = ListFilter(param);
            var list = await this.BaseRepository().FindList(expression);
            return list.ToList();
        }

        public async Task<List<PartsEntity>> GetPageList(PartsListParam param, Pagination pagination)
        {
            var expression = ListFilter(param);
            var list= await this.BaseRepository().FindList(expression, pagination);
            return list.ToList();
        }

        public async Task<PartsEntity> GetEntity(long id)
        {
            return await this.BaseRepository().FindEntity<PartsEntity>(id);
        }
        #endregion

        #region 提交数据
        public async Task SaveForm(PartsEntity entity)
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
            await this.BaseRepository().Delete<PartsEntity>(idArr);
        }
        #endregion

        #region 私有方法
        private Expression<Func<PartsEntity, bool>> ListFilter(PartsListParam param)
        {
            var expression = LinqExtensions.True<PartsEntity>();
            if (param != null)
            {
                if (!string.IsNullOrEmpty(param.PartName))
                {
                    expression = expression.And(t => t.PartName.Contains(param.PartName));
                }
            }
            return expression;
        }
        #endregion
    }
}
