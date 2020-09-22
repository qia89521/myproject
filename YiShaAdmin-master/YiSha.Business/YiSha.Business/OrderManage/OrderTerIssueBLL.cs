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
using YiSha.Web.Code;
using YiSha.Model.Result;
using YiSha.Enum;

namespace YiSha.Business.OrderManage
{
    /// <summary>
    /// 创 建：admin
    /// 日 期：2020-08-25 17:33
    /// 描 述：设备出货单业务类
    /// </summary>
    public class OrderTerIssueBLL
    {
        private OrderTerIssueService orderTerIssueService = new OrderTerIssueService();
        private OrderMaterielBLL orderMaterielBLL = new OrderMaterielBLL();
       // private OrderPrintIssueBLL orderPrintIssueBLL = new OrderPrintIssueBLL();
        #region 获取数据
        public async Task<TData<List<OrderTerIssueEntity>>> GetList(OrderTerIssueListParam param)
        {
            TData<List<OrderTerIssueEntity>> obj = new TData<List<OrderTerIssueEntity>>();
            obj.Data = await orderTerIssueService.GetList(param);
            obj.Total = obj.Data.Count;
            obj.Tag = 1;
            return obj;
        }

        /// <summary>
        /// 根据ids数组获取数据列表
        /// </summary>
        /// <param name="ids">ids数组</param>
        /// <returns></returns>
        public async Task<TData<List<OrderTerIssueEntity>>> GetListByIds(List<string> ids)
        {
            TData<List<OrderTerIssueEntity>> obj = new TData<List<OrderTerIssueEntity>>();
            obj.Data = await orderTerIssueService.GetListByIds(ids);
            obj.Total = obj.Data.Count;
            obj.Tag = 1;
            return obj;
        }

        public async Task<TData<List<OrderTerIssueEntity>>> GetPageList(OrderTerIssueListParam param, Pagination pagination)
        {
            TData<List<OrderTerIssueEntity>> obj = new TData<List<OrderTerIssueEntity>>();
            obj.Data = await orderTerIssueService.GetPageList(param, pagination);
            obj.Total = pagination.TotalCount;
            obj.Tag = 1;
            return obj;
        }

        public async Task<TData<OrderTerIssueEntity>> GetEntity(long id)
        {
            TData<OrderTerIssueEntity> obj = new TData<OrderTerIssueEntity>();
            obj.Data = await orderTerIssueService.GetEntity(id);
            if (obj.Data != null)
            {
                obj.Tag = 1;
            }
            return obj;
        }
        #endregion

        #region 提交数据
        public async Task<TData<string>> SaveForm(OrderTerIssueEntity entity)
        {
            TData<string> obj = new TData<string>();
            var result = await CheckWorkFLow(entity);
            if (result.IsSucess)
            {
                await orderTerIssueService.SaveForm(entity);
                await FinishWorkFLow(entity);

                obj.Data = entity.Id.ParseToString();
                obj.Tag = 1;
            }
            else
            {
                obj.Message = result.Msg;
                obj.Tag = 0;
            }
            return obj;
        }

        /// <summary>
        /// 流程结束logic
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        private async Task<ResultMsg> FinishWorkFLow(OrderTerIssueEntity entity)
        {

            ResultMsg result = new ResultMsg();
            //通过审批且流程结束
            if (entity.Step == OutPutStepEnum.Finish.ParseToInt() &&
                entity.ShenHeStatus == ShenHeStatusEnum.Past.ParseToInt())
            {
                //修改物料库存和明细了
                long? id = entity.MaterielId;

                TData<string> td_result = await orderMaterielBLL.ModifyMaterielTotal(long.Parse(id + ""),true, 0-entity.SaleNum,
                    "物料销售出库",
                    entity.Id, "order_ter_issue");
                if (td_result.Tag == 1)
                {
                    result.IsSucess = true;
                }
            }
            return result;
        }

        /// <summary>
        /// 检测流程
        /// </summary>
        /// <param name="entity">数据实体</param>
        /// <returns></returns>
        private async Task<ResultMsg> CheckWorkFLow(OrderTerIssueEntity entity)
        {
            ResultMsg result = new ResultMsg();
            //新增
            if (entity.Id.IsNullOrZero())
            {
                entity.ShenHeStatus = 0;
                entity.Step = OutPutStepEnum.Validate.ParseToInt();
                result.IsSucess = true;
            }
            else
            {
                OperatorInfo user = await Operator.Instance.Current();

                if (entity.Step == OutPutStepEnum.Create.ParseToInt())
                {
                    if (entity.BaseCreatorId == user.UserId)
                    {
                        if (entity.ShenHeStatus == ShenHeStatusEnum.Create.ParseToInt())
                        {
                            entity.Step = OutPutStepEnum.Validate.ParseToInt();
                            //表示创建者修改
                            result.IsSucess = true;
                        }
                        else
                        {

                            result.Msg = "已经审批不可修改";
                        }
                    }
                }
                //01 到了财务审批步骤
                else if (entity.Step == OutPutStepEnum.Validate.ParseToInt())
                {
                    if (user.UserId == entity.ShenHeManId)
                    {
                        if (entity.ShenHeStatus == ShenHeStatusEnum.Refuse.ParseToInt())
                        {
                            entity.Step = OutPutStepEnum.Finish.ParseToInt();
                        }
                        else if (entity.ShenHeStatus == ShenHeStatusEnum.Past.ParseToInt())
                        {
                            entity.Step = OutPutStepEnum.Sent.ParseToInt();

                        }
                        result.IsSucess = true;
                    }
                    else
                    {
                        result.Msg = "请先财务审核才能下一步操作";
                    }
                }
                //发货阶段
                else if (entity.Step == OutPutStepEnum.Sent.ParseToInt())
                {
                    if (user.UserId == entity.SentManId)
                    {
                        entity.Step = OutPutStepEnum.Finish.ParseToInt();
                        entity.IsSent = SentStatusEnum.Yes.ParseToInt();
                        result.IsSucess = true;
                    }
                    else
                    {
                        result.Msg = "请售后进行操作";
                    }
                }
                //发货阶段
                else if (entity.Step == OutPutStepEnum.Finish.ParseToInt())
                {

                    result.Msg = "流程已经结束,禁止操作";
                }

            }
            return result;
        }
        /// <summary>
        /// 更新出货物料的 出单单号
        /// </summary>
        /// <param name="ids">出货单id串 逗号分隔</param>
        /// <param name="printOrderNumber">打印订单</param>
        /// <returns></returns>
        public async Task<TData> UpdatePrintOrderNumbe(string ids, string printOrderNumber, 
            string custName, string linkName, 
            string printDay)
        {
            TData obj = new TData();
            List<string> list_ids = ids.Split(',').ToList<string>();
            if (list_ids.Count > 0)
            {
                await orderTerIssueService.UpdatePrintOrderNumbe(list_ids, printOrderNumber);
                obj.Tag = 1;
            }
            else
            {
                obj.Message = "请先选择出货数据,再更新";
            }
            if (obj.Tag == 1)
            {
                OrderPrintIssueEntity entity = new OrderPrintIssueEntity();
                entity.PrintOrderNumber = printOrderNumber;
                entity.CustName = custName;
                entity.LinkName = linkName;
                entity.PrintDay = printDay;
                entity.OrderTerIssueIds = ids;
                //obj=await orderPrintIssueBLL.SaveForm(entity);
            }
            return obj;
        }
        public async Task<TData> DeleteForm(string ids)
        {
            TData obj = new TData();
            await orderTerIssueService.DeleteForm(ids);
            obj.Tag = 1;
            return obj;
        }
        #endregion

        #region 私有方法
        #endregion
    }
}
