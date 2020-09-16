using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using YiSha.Util;
using YiSha.Util.Extension;
using YiSha.Util.Model;
using YiSha.Entity.OrderManage;
using YiSha.Model.Param.OrderManage;
using YiSha.Service.OrderManage;

namespace YiSha.Business.OrderManage
{
    /// <summary>
    /// 创 建：admin
    /// 日 期：2020-09-08 18:11
    /// 描 述：物料 业务类
    /// </summary>
    public class OrderMaterielBLL
    {
        private OrderMaterielService orderMaterielService = new OrderMaterielService();
        private OrderMaterielDetailBLL orderMaterielDetailBLL = new OrderMaterielDetailBLL();

        #region 获取数据
        public async Task<TData<List<OrderMaterielEntity>>> GetList(OrderMaterielListParam param)
        {
            TData<List<OrderMaterielEntity>> obj = new TData<List<OrderMaterielEntity>>();
            obj.Data = await orderMaterielService.GetList(param);
            obj.Total = obj.Data.Count;
            obj.Tag = 1;
            return obj;
        }

        public async Task<TData<List<OrderMaterielEntity>>> GetPageList(OrderMaterielListParam param, Pagination pagination)
        {
            TData<List<OrderMaterielEntity>> obj = new TData<List<OrderMaterielEntity>>();
            obj.Data = await orderMaterielService.GetPageList(param, pagination);
            obj.Total = pagination.TotalCount;
            obj.Tag = 1;
            return obj;
        }

        public async Task<TData<OrderMaterielEntity>> GetEntity(long id)
        {
            TData<OrderMaterielEntity> obj = new TData<OrderMaterielEntity>();
            obj.Data = await orderMaterielService.GetEntity(id);
            if (obj.Data != null)
            {
                obj.Tag = 1;
            }
            return obj;
        }
        #endregion

        #region 提交数据

        /// <summary>
        /// 修改库存数量
        /// </summary>
        /// <param name="id">物料id</param>
        /// <param name="terNumber">设备编号</param>
        /// <returns></returns>
        public async Task<TData<string>> ModifyMaterielTotal(long id, int num, string remark,
            long? buniss_id,string busin_table)
        {
            OrderMaterielEntity ter = await orderMaterielService.GetEntity(id);
            //变化数量
            int? src_num = ter.MaterielTotal;
            int? chanageNum = num - src_num;

            if (chanageNum != 0)
            {
                ter.MaterielTotal = num;
                ter.BaseModifyTime = DateTime.Now;
                var result = await SaveForm(ter);
                if (result.Tag == 1)
                {
                    OrderMaterielDetailEntity detail = new OrderMaterielDetailEntity();
                    detail.SrcNum = src_num;
                    detail.ChangeNum = chanageNum;
                    detail.Remark = remark;
                    detail.MaterielId = ter.Id;
                    detail.BusyniessId = buniss_id;
                    detail.BusyniessTable = busin_table;
                    result = await orderMaterielDetailBLL.SaveForm(detail);
                }
                return result;
            }
            else {
                TData<string> obj = new TData<string>();
                obj.Tag = 0;
                return obj;
            }

        }

        public async Task<TData<string>> SaveForm(OrderMaterielEntity entity)
        {
            TData<string> obj = new TData<string>();
            await orderMaterielService.SaveForm(entity);
            obj.Data = entity.Id.ParseToString();
            obj.Tag = 1;
            return obj;
        }

        public async Task<TData> DeleteForm(string ids)
        {
            TData obj = new TData();
            await orderMaterielService.DeleteForm(ids);
            obj.Tag = 1;
            return obj;
        }
        #endregion

        #region 私有方法
        #endregion
    }
}
