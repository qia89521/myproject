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
using System.Data;
using YiSha.Model.Result.OrderManage;

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
            OperatorInfo user = await Operator.Instance.Current();
            TData<List<OrderTerIssueEntity>> obj = new TData<List<OrderTerIssueEntity>>();
            obj.Data = await orderTerIssueService.GetList(param, user);
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

        public async Task<TData<List<OrderTerIssueEntity>>> GetPageList(OrderTerIssueListParam param, Pagination pagination, OperatorInfo user)
        {
            TData<List<OrderTerIssueEntity>> obj = new TData<List<OrderTerIssueEntity>>();
            obj.Data = await orderTerIssueService.GetPageList(param, pagination, user);
            obj.Total = pagination.TotalCount;
            obj.PageTotal = pagination.TotalPage;
            obj.Tag = 1;
            return obj;
        }

        public async Task<TData<List<Response_OrderTerIssue_ChartLine>>> GetListGroupChart(OrderTerIssueListParam param, OperatorInfo user)
        {
            TData<List<Response_OrderTerIssue_ChartLine>> obj = new TData<List<Response_OrderTerIssue_ChartLine>>();

            List<Response_OrderTerIssue_ChartLine> list = await orderTerIssueService.GetListGroup(param, user);
            obj.Total = list.Count;
            obj.Data = list;
            obj.Tag = 1;
            if (obj.Total <= 0)
            {
                obj.Message = "没有查询到数据";
            }
            return obj;
        }


        public async Task<TData<OrderTerIssueEntity>> GetEntity(long id)
        {
            TData<OrderTerIssueEntity> obj = new TData<OrderTerIssueEntity>();
            OrderTerIssueEntity entity = await orderTerIssueService.GetEntity(id);
            if (entity != null)
            {
                int index = CoomHelper.GetCharIndex(entity.ReciveAddress, "-", 3);
                if (index > 0)
                {
                    entity.ReciveAddre = entity.ReciveAddress.Substring(0, index);
                    entity.ReciveZone = entity.ReciveAddress.Substring(index);
                }
                obj.Data = entity;
                obj.Tag = 1;
            }
            return obj;
        }

        public async Task<TData<int>> GetShenCount(OperatorInfo user)
        {
            TData<int> obj = new TData<int>();
            if (user.IsFinance)
            {
                obj.Data = await orderTerIssueService.GetShenCount(user, OutPutStepEnum.Validate);
            }
            else if (user.IsWeihu)
            {
                obj.Data = await orderTerIssueService.GetShenCount(user, OutPutStepEnum.Sent);
            }
            else
            {
                obj.Data = 0;
            }
            if (obj.Data > 0)
            {
                obj.Tag = 1;
            }
            return obj;
        }
        #endregion

        #region 提交数据
        public async Task<TData<string>> SaveForm(OrderTerIssueParam modelParam, OperatorInfo opuser)
        {
            TData<string> obj = new TData<string>();
            obj.SetDefault();
            try
            {
                OrderTerIssueEntity entity = new OrderTerIssueEntity();

                long num = 0;
                long.TryParse(modelParam.Id, out num);
                entity.Id = num;

                if (!entity.Id.IsNullOrZero())
                {
                    TData<OrderTerIssueEntity> tdata = await GetEntity(num);
                    entity = tdata.Data;
                }

                ClassValueCopierHelper.Copy(entity, modelParam);

                #region 补充数据
                num = 0;
                long.TryParse(modelParam.Id, out num);
                entity.Id = num;

                num = 0;
                long.TryParse(modelParam.MaterielId, out num);
                entity.MaterielId = num;


                num = 0;
                long.TryParse(modelParam.SaleId, out num);
                entity.SaleId = num;


                int saleNum = 0;
                int.TryParse(modelParam.SaleNum, out saleNum);
                entity.SaleNum = saleNum;

                decimal money = 0;
                decimal.TryParse(modelParam.SalePrice, out money);
                entity.SalePrice = money;

                money = 0;
                decimal.TryParse(modelParam.FactMoney, out money);
                entity.FactMoney = money;


                money = 0;
                decimal.TryParse(modelParam.SrcPrice, out money);
                entity.SrcPrice = money;

                saleNum = 0;
                int.TryParse(modelParam.TakeType, out saleNum);
                entity.TakeType = saleNum;

                saleNum = 0;
                int.TryParse(modelParam.ShenHeStatus, out saleNum);
                entity.ShenHeStatus = saleNum;

                num = 0;
                long.TryParse(modelParam.ShenHeManId, out num);
                entity.ShenHeManId = num;

                num = 0;
                long.TryParse(modelParam.SentManId, out num);
                entity.SentManId = num;
                
                if (entity.Id.IsNullOrZero())
                {
                    entity.BaseCreatorId = long.Parse(opuser.UserIdStr);
                    entity.BaseCreateTime = DateTime.Now;
                }
                entity.ReciveAddress = modelParam.ReciveZone + modelParam.ReciveAddre;
                entity.BaseModifyTime = DateTime.Now;
                entity.BaseModifierId = long.Parse(opuser.UserIdStr);
                #endregion

                LogHelper.Info("【SaveForm】entity:" + JsonHelper.SerializeObject(entity));
                obj = await SaveForm(entity, opuser);
            }
            catch (Exception ex)
            {
                LogHelper.Info("【SaveForm】ex:" + ex.ToString());
            }
            return obj;
        }

        public async Task<TData<string>> SaveForm(OrderTerIssueEntity entity, OperatorInfo opuser)
        {
            TData<string> obj = new TData<string>();
            var result = await CheckWorkFLow(entity, opuser);
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

                TData<string> td_result = await orderMaterielBLL.ModifyMaterielTotal(long.Parse(id + ""), true, 0 - entity.SaleNum,
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
        private async Task<ResultMsg> CheckWorkFLow(OrderTerIssueEntity entity, OperatorInfo user)
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
