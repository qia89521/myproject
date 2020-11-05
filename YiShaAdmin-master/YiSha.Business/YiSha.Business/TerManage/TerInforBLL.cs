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
using YiSha.Web.Code;

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
        private TerTransferRecordBLL terTransferRecordBLL = new TerTransferRecordBLL();

        #region 获取数据
        public async Task<TData<List<TerInforEntity>>> GetList(TerInforListParam param, OperatorInfo user)
        {
            TData<List<TerInforEntity>> obj = new TData<List<TerInforEntity>>();
            obj.Data = await terInforService.GetList(param, user);
            obj.Total = obj.Data.Count;
            obj.Tag = 1;
            return obj;
        }

        public async Task<TData<List<TerInforEntity>>> GetPageList(TerInforListParam param, Pagination pagination, OperatorInfo user)
        {
            
            TData<List<TerInforEntity>> obj = new TData<List<TerInforEntity>>();
            obj.Data = await terInforService.GetPageList(param, pagination, user);
            obj.Total = pagination.TotalCount;
            obj.PageTotal = pagination.TotalPage;
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
        public async Task<TerInforEntity> GetEntityByNumber(string ternumber)
        {
            TerInforEntity  obj= await terInforService.GetEntityByNumber(ternumber);
           
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
        public async Task<TData<string>> ModifyTerNumber(long id, string terNumber)
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

            TData<string> obj = new TData<string>();
            if (ter.ManageId != id)
            {
                TerTransferRecordEntity entity = new TerTransferRecordEntity();
                entity.SentId = ter.ManageId;
                entity.SendTxt = ter.ManageTxt;
                entity.TerId = ter.Id;
                entity.TerNumber = ter.TerNumber;

                ter.ManageId = manageId;
                obj = await SaveForm(ter);

                ter = await terInforService.GetEntity(id);
                entity.ReceiverId = id;
                entity.ReceiverTxt = ter.ManageTxt;

                obj = await terTransferRecordBLL.SaveForm(entity);
            }
            else
            {
                obj.Message = "没有变化";
                obj.Tag = 0;
            }
            return obj;
        }

        /// <summary>
        /// 设置销售人员
        /// </summary>
        /// <param name="id">设备id</param>
        /// <param name="manageId">销售id</param>
        /// <returns></returns>
        public async Task<TData<string>> ModifySaleId(long id, long manageId)
        {
            TerInforEntity ter = await terInforService.GetEntity(id);

            TData<string> obj = new TData<string>();
            if (ter.ManageId != id)
            {
                ter.SaleManId = manageId;
                obj = await SaveForm(ter);
            }
            else
            {
                obj.Message = "没有变化";
                obj.Tag = 0;
            }
            return obj;
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

        /// <summary>
        /// 修改设备名称
        /// </summary>
        /// <param name="id">设备id</param>
        /// <param name="busyLink">联系方式</param>
        /// <returns></returns>
        public async Task<TData<string>> CheckNumber(string number)
        {
            TData<string> obj = new TData<string>();
            obj.Description = number;
            TerInforEntity ter = await terInforService.GetEntityByNumber(number);
            if (ter != null)
            {
                obj.Tag = 1;
                obj.Message = "设备编号存在";
            }
            else
            {
                obj.Tag = 0;
                obj.Message = "设备编号不存在";
            }
            return await SaveForm(ter);
        }


        /// <summary>
        /// 更新设备状态业务
        /// </summary>
        /// <param name="statusModel">设备状态业务</param>
        /// <returns></returns>
        public async Task<TData<string>> ModifyStatusBusy(TerStatusEntity statusModel)
        {
            TerInforEntity ter = await terInforService.GetEntity(statusModel.TerId);
            //设备一旦锁定，激活时间（FistOn）,FistPosition,FistLongitude,FistLatitude 不再编号
           // LogHelper.Info("TerInforEntity ter:" + JsonHelper.SerializeObject(ter));
            if (ter.IsLock == 1)
            {
                if (!string.IsNullOrEmpty(statusModel.W))
                {
                    ter.WaterNum = statusModel.W;
                    return await SaveForm(ter);
                }
                else
                {
                    TData<string> obj = new TData<string>();
                    obj.Tag = 0;
                    obj.Message = "没有水量不更新";
                    return obj;
                }
            }
            else
            {
                ter.IsLock = 1;
                ter.FistOn = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                return await SaveForm(ter);
            }
        }

        /***
         * 更新设备位置经纬度
         * @number:设备号
         * @fistLongitude：经度
         * @fistLatitude：纬度
         */
        public async Task<TData<string>> ModifyPosition(string number,string fistLongitude, string fistLatitude,string position)
        {
            TerInforEntity ter = await terInforService.GetEntityByNumber(number);
            //设备一旦锁定，激活时间（FistOn）,FistPosition,FistLongitude,FistLatitude 不再编号
            if (ter.IsLock != 1)
            {
                ter.FistLatitude = fistLatitude;
                ter.FistLongitude = fistLongitude;
                ter.FistPosition = position;

                ter.Latitude = fistLatitude;
                ter.Longitude = fistLongitude;
                ter.Position = position;
                return await SaveForm(ter);
            }
            else
            {
                //更新当前位置
                ter.Latitude = fistLatitude;
                ter.Longitude = fistLongitude;
                ter.Position = position;

                return await SaveForm(ter);
            }
        }

        /// <summary>
        /// 用户绑定设置
        /// </summary>
        ///  <param name="userId">用户登录id</param>
        /// <param name="number"></param>
        /// <param name="fistLongitude"></param>
        /// <param name="fistLatitude"></param>
        /// <param name="position"></param>
        /// <returns></returns>
        public async Task<TData<string>> BindUser(string userId,string number, string fistLongitude, string fistLatitude, string position)
        {
            TData<string> obj = new TData<string>();

            TerInforEntity ter = await terInforService.GetEntityByNumber(number);

            obj.SetDefault();
            //设备一旦锁定，激活时间（FistOn）,FistPosition,FistLongitude,FistLatitude 不再编号
            if (ter != null)
            {
                if (ter.ManageId <= 0)
                {
                    ter.FistLatitude = fistLatitude;
                    ter.FistLongitude = fistLongitude;
                    ter.FistPosition = position;

                    ter.Latitude = fistLatitude;
                    ter.Longitude = fistLongitude;
                    ter.Position = position;

                    ter.ManageId = long.Parse(userId);
                    ter.FistOn = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    obj = await SaveForm(ter);

                    obj.Refresh();
                }
                else
                {
                    obj.Message = "已经绑定,您不能再绑定";
                }
            }
            else
            {
                obj.Message = "设备不存在";
            }
            return obj;


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
