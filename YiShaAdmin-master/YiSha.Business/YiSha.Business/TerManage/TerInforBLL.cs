using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using YiSha.Util;
using YiSha.Util.Extension;
using YiSha.Util.Model;
using YiSha.Entity.TerManage;
using YiSha.Model.Param.TerManage;
using YiSha.Service.TerManage;

namespace YiSha.Business.TerManage
{
    /// <summary>
    /// 创 建：admin
    /// 日 期：2020-08-14 16:05
    /// 描 述：设备信息业务类
    /// </summary>
    public class TerInforBLL
    {
        private TerInforService terInforService = new TerInforService();

        #region 获取数据
        public async Task<TData<List<TerInforEntity>>> GetList(TerInforListParam param)
        {
            TData<List<TerInforEntity>> obj = new TData<List<TerInforEntity>>();
            obj.Data = await terInforService.GetList(param);
            obj.Total = obj.Data.Count;
            obj.Tag = 1;
            return obj;
        }

        public async Task<TData<List<TerInforEntity>>> GetPageList(TerInforListParam param, Pagination pagination)
        {
            TData<List<TerInforEntity>> obj = new TData<List<TerInforEntity>>();
            obj.Data = await terInforService.GetPageList(param, pagination);
            obj.Total = pagination.TotalCount;
            obj.Tag = 1;
            return obj;
        }

        public async Task<TData<TerInforEntity>> GetEntity(long id)
        {
            TData<TerInforEntity> obj = new TData<TerInforEntity>();
            obj.Data = await terInforService.GetEntity(id);
            if (obj.Data != null)
            {
                obj.Tag = 1;
            }
            return obj;
        }
        #endregion

        #region 提交数据

        /// <summary>
        /// 修改设备编号
        /// </summary>
        /// <param name="id">设备id</param>
        /// <param name="terNumber">设备编号</param>
        /// <returns></returns>
        public async Task<TData<string>> ModifyTerNumber(long id,string terNumber)
        {
            TerInforEntity ter = await terInforService.GetEntity(id);
            ter.TerNumber = terNumber;

            return await SaveForm(ter);
        }

        /// <summary>
        /// 修改运营商
        /// </summary>
        /// <param name="id">设备id</param>
        /// <param name="busyName">运营商名称</param>
        /// <returns></returns>
        public async Task<TData<string>> ModifyBusyName(long id, string busyName)
        {
            TerInforEntity ter = await terInforService.GetEntity(id);
            ter.BusyName = busyName;
            return await SaveForm(ter);
        }
        //IsLock

        /// <summary>
        /// 设置是否锁定
        /// </summary>
        /// <param name="id">设备id</param>
        /// <param name="lsLock">是否锁定0:否 1:是</param>
        /// <returns></returns>
        public async Task<TData<string>> ModifyIsLock(long id, int lsLock)
        {
            TerInforEntity ter = await terInforService.GetEntity(id);
            ter.IsLock = lsLock;
            return await SaveForm(ter);
        }
        /// <summary>
        /// 设置是否出货
        /// </summary>
        /// <param name="id">设备id</param>
        /// <param name="isBuy">是否已经出货0:否 1:是</param>
        /// <returns></returns>
        public async Task<TData<string>> ModifyIsBuy(long id, int isBuy)
        {
            TerInforEntity ter = await terInforService.GetEntity(id);
            ter.IsBuy = isBuy;
            return await SaveForm(ter);
        }

        /// <summary>
        /// 设置业主
        /// </summary>
        /// <param name="id">设备id</param>
        /// <param name="manageId">业主id</param>
        /// <returns></returns>
        public async Task<TData<string>> ModifyManageId(long id, long manageId)
        {
            TerInforEntity ter = await terInforService.GetEntity(id);
            ter.ManageId = manageId;
            return await SaveForm(ter);
        }
        /// <summary>
        /// 修改设备名称
        /// </summary>
        /// <param name="id">设备id</param>
        /// <param name="terName">设备名称</param>
        /// <returns></returns>
        public async Task<TData<string>> ModifyTerName(long id, string terName)
        {
            TerInforEntity ter = await terInforService.GetEntity(id);
            ter.TerName = terName;

            return await SaveForm(ter);
        }


        /// <summary>
        /// 修改设备名称
        /// </summary>
        /// <param name="id">设备id</param>
        /// <param name="busyLink">联系方式</param>
        /// <returns></returns>
        public async Task<TData<string>> ModifyBusyLink(long id, string busyLink)
        {
            TerInforEntity ter = await terInforService.GetEntity(id);
            ter.BusyLink = busyLink;

            return await SaveForm(ter);
        }

        public async Task<TData<string>> SaveForm(TerInforEntity entity)
        {
            TData<string> obj = new TData<string>();
            await terInforService.SaveForm(entity);
            obj.Data = entity.Id.ParseToString();
            obj.Tag = 1;
            return obj;
        }

        public async Task<TData> DeleteForm(string ids)
        {
            TData obj = new TData();
            await terInforService.DeleteForm(ids);
            obj.Tag = 1;
            return obj;
        }
        #endregion

        #region 私有方法
        #endregion
    }
}
