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
    /// 日 期：2020-08-14 16:16
    /// 描 述：设备状态业务类
    /// </summary>
    public class TerStatusBLL
    {
        private TerStatusService terStatusService = new TerStatusService();

        TerInforBLL terInforBLL = new TerInforBLL();

        #region 获取数据
        public async Task<TData<List<TerStatusEntity>>> GetList(TerStatusListParam param)
        {
            TData<List<TerStatusEntity>> obj = new TData<List<TerStatusEntity>>();
            obj.Data = await terStatusService.GetList(param);
            obj.Total = obj.Data.Count;
            obj.Tag = 1;
            return obj;
        }

        public async Task<TData<List<TerStatusEntity>>> GetPageList(TerStatusListParam param, Pagination pagination)
        {
            TData<List<TerStatusEntity>> obj = new TData<List<TerStatusEntity>>();
            obj.Data = await terStatusService.GetPageList(param, pagination);
            obj.Total = pagination.TotalCount;
            obj.Tag = 1;
            return obj;
        }

        public async Task<TData<TerStatusEntity>> GetEntity(long id)
        {
            TData<TerStatusEntity> obj = new TData<TerStatusEntity>();
            obj.Data = await terStatusService.GetEntity(id);
            if (obj.Data != null)
            {
                obj.Tag = 1;
            }
            return obj;
        }

        public async Task<TData<TerStatusEntity>> GetEntityByTerId(long terId)
        {
            TData<TerStatusEntity> obj = new TData<TerStatusEntity>();
            obj.Data = await terStatusService.GetEntityByTerId(terId);
            if (obj.Data != null)
            {
                obj.Tag = 1;
            }
            return obj;
        }
        #endregion

        #region 提交数据
        public async Task<TData<string>> SaveForm(TerStatusEntity entity)
        {
            TData<string> obj = new TData<string>();

            entity.BaseModifyTime = DateTime.Now;

            TerStatusEntity ter = await terStatusService.GetEntityByTerNumber(entity.TerNumber);
            if (ter == null)
            {

                ter = new TerStatusEntity();
                ter.SetDefault();

                entity.BaseCreateTime = DateTime.Now;
                entity.BaseVersion = 0;

                TerInforEntity terInfor = await terInforBLL.GetEntityByNumber(entity.TerNumber);
               // LogHelper.Info(" terInfor:" + JsonHelper.SerializeObject(terInfor));
                if (terInfor != null)
                {
                    entity.TerId = terInfor.Id;
                    entity.TerName = terInfor.TerName;
                }
                else
                {
                    obj.Tag = 0;
                    obj.Message = "机器号不存在";
                    return obj;
                }
            }
            else
            {
                entity.TerId = ter.TerId;
                entity.TerName = ter.TerName;
                entity.BaseVersion++;
            }
            //LogHelper.Info(" entity:" + JsonHelper.SerializeObject(entity));
            ClassValueCopierHelper.Copy(ter, entity, true);
           // LogHelper.Info(" ter:"+JsonHelper.SerializeObject(ter));

            await terStatusService.SaveForm(ter);
            //修改设备状态

            await terInforBLL.ModifyStatusBusy(entity);

            obj.Data = entity.Id.ParseToString();
            obj.Tag = 1;
          ;
            //ModifyStatusBusy
            return obj;
        }

        public async Task<TData> DeleteForm(string ids)
        {
            TData obj = new TData();
            await terStatusService.DeleteForm(ids);
            obj.Tag = 1;
            return obj;
        }
        #endregion

        #region 私有方法
        #endregion
    }
}
