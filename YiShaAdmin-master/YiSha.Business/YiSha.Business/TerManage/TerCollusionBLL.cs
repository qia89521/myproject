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
using YiSha.Service.OrganizationManage;
using YiSha.Entity.OrganizationManage;
using YiSha.Business.OrganizationManage;

namespace YiSha.Business.TerManage
{
    /// <summary>
    /// 创 建：admin
    /// 日 期：2020-10-14 10:04
    /// 描 述：设备串货提醒业务类
    /// </summary>
    public class TerCollusionBLL
    {
        private TerCollusionService terCollusionService = new TerCollusionService();
        private UserBLL userService = new UserBLL();
        private TerInforService terInforService = new TerInforService();

        #region 获取数据
        public async Task<TData<List<TerCollusionEntity>>> GetList(TerCollusionListParam param)
        {
            TData<List<TerCollusionEntity>> obj = new TData<List<TerCollusionEntity>>();
            obj.Data = await terCollusionService.GetList(param);
            obj.Total = obj.Data.Count;
            obj.Tag = 1;
            return obj;
        }

        public async Task<TData<List<TerCollusionEntity>>> GetPageList(TerCollusionListParam param, Pagination pagination)
        {
            TData<List<TerCollusionEntity>> obj = new TData<List<TerCollusionEntity>>();
            obj.Data = await terCollusionService.GetPageList(param, pagination);
            obj.Total = pagination.TotalCount;
            obj.Tag = 1;
            return obj;
        }

        public async Task<TData<TerCollusionEntity>> GetEntity(long id)
        {
            TData<TerCollusionEntity> obj = new TData<TerCollusionEntity>();
            obj.Data = await terCollusionService.GetEntity(id);
            if (obj.Data != null)
            {
                obj.Tag = 1;
            }
            return obj;
        }
        #endregion

        #region 提交数据
        public async Task<TData<string>> SaveForm(TerCollusionEntity entity)
        {

            TData<string> obj = new TData<string>();
            await terCollusionService.SaveForm(entity);
            obj.Data = entity.Id.ParseToString();
            obj.Tag = 1;
            return obj;
        }

        public async Task<TData<string>> SaveForm(TerPositionParam positionParam)
        {
            TData<string> obj = new TData<string>();
            TerInforEntity terInforEntity =await terInforService.GetEntityByNumber(positionParam.number);
            if (terInforEntity != null)
            {
                UserEntity userEntity = await userService.GetUserEnity((long)terInforEntity.SaleManId);
                if (userEntity != null&& userEntity.IsDeleget)
                {
                    TerCollusionEntity entity = new TerCollusionEntity();
                    entity.SaleId = userEntity.Id;
                    entity.TerId = terInforEntity.Id;
                    entity.TerNumber = terInforEntity.TerNumber;
                    entity.Zone = positionParam.address;
                    entity.DelegetZone = userEntity.DelegetZoneTxt;
                    //串货了
                    if (!entity.DelegetZone.Contains(entity.Zone))
                    {
                        await terCollusionService.SaveForm(entity);
                        obj.Data = entity.Id.ParseToString();
                        obj.Tag = 1;
                    }

                }
                else
                {
                    obj.Message = "该设备没有设置销售";
                }
            }
            else
            {
                obj.Message = "设备不存在";
            }
            return obj;
        }

        public async Task<TData> DeleteForm(string ids)
        {
            TData obj = new TData();
            await terCollusionService.DeleteForm(ids);
            obj.Tag = 1;
            return obj;
        }
        #endregion

        #region 私有方法
        #endregion
    }
}
