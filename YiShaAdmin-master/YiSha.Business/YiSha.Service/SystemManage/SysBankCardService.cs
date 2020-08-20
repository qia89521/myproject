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
    /// 日 期：2020-08-20 09:48
    /// 描 述：收款银行卡管理服务类
    /// </summary>
    public class SysBankCardService :  RepositoryFactory
    {
        #region 获取数据
        public async Task<List<SysBankCardEntity>> GetList(SysBankCardListParam param)
        {
            var expression = ListFilter(param);
            var list = await this.BaseRepository().FindList(expression);
            return list.ToList();
        }

        public async Task<List<SysBankCardEntity>> GetPageList(SysBankCardListParam param, Pagination pagination)
        {
            var expression = ListFilter(param);
            var list= await this.BaseRepository().FindList(expression, pagination);
            return list.ToList();
        }

        public async Task<SysBankCardEntity> GetEntity(long id)
        {
            return await this.BaseRepository().FindEntity<SysBankCardEntity>(id);
        }
        #endregion

        #region 提交数据
        public async Task SaveForm(SysBankCardEntity entity)
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
            await this.BaseRepository().Delete<SysBankCardEntity>(idArr);
        }
        #endregion

        #region 私有方法
        private Expression<Func<SysBankCardEntity, bool>> ListFilter(SysBankCardListParam param)
        {
            var expression = LinqExtensions.True<SysBankCardEntity>();
            if (param != null)
            {
            }
            return expression;
        }
        #endregion
    }
}
