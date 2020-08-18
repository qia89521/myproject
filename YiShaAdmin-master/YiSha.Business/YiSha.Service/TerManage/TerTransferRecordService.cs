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
    /// 日 期：2020-08-18 17:28
    /// 描 述：设备转让记录服务类
    /// </summary>
    public class TerTransferRecordService :  RepositoryFactory
    {
        #region 获取数据
        public async Task<List<TerTransferRecordEntity>> GetList(TerTransferRecordListParam param)
        {
            var expression = ListFilter(param);
            var list = await this.BaseRepository().FindList(expression);
            return list.ToList();
        }

        public async Task<List<TerTransferRecordEntity>> GetPageList(TerTransferRecordListParam param, Pagination pagination)
        {
            var expression = ListFilter(param);
            var list= await this.BaseRepository().FindList(expression, pagination);
            return list.ToList();
        }

        public async Task<TerTransferRecordEntity> GetEntity(long id)
        {
            return await this.BaseRepository().FindEntity<TerTransferRecordEntity>(id);
        }
        #endregion

        #region 提交数据
        public async Task SaveForm(TerTransferRecordEntity entity)
        {
            if (entity.Id.IsNullOrZero())
            {
                await entity.Create();
                await this.BaseRepository().Insert(entity);
            }
            else
            {
                
                await this.BaseRepository().Update(entity);
            }
        }

        public async Task DeleteForm(string ids)
        {
            long[] idArr = TextHelper.SplitToArray<long>(ids, ',');
            await this.BaseRepository().Delete<TerTransferRecordEntity>(idArr);
        }
        #endregion

        #region 私有方法
        private Expression<Func<TerTransferRecordEntity, bool>> ListFilter(TerTransferRecordListParam param)
        {
            var expression = LinqExtensions.True<TerTransferRecordEntity>();
            if (param != null)
            {
                if (param.TerId > 0)
                {
                    expression = expression.And(t => t.TerId==param.TerId);
                }
            }
            return expression;
        }
        #endregion
    }
}
