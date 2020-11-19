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
using YiSha.Model.Result;
using YiSha.Web.Code;
using YiSha.Enum;
using YiSha.Model.Result.OrderManage;

namespace YiSha.Business.OrderManage
{
    /// <summary>
    /// 创 建：admin
    /// 日 期：2020-09-09 22:52
    /// 描 述：物料进货单业务类
    /// </summary>
    public class OrderTerInputBLL
    {
        private OrderTerInputService orderTerInputService = new OrderTerInputService();
        private OrderMaterielBLL orderMaterielBLL = new OrderMaterielBLL();

        #region 获取数据
        public async Task<TData<List<OrderTerInputEntity>>> GetList(OrderTerInputListParam param, OperatorInfo user)
        {
            TData<List<OrderTerInputEntity>> obj = new TData<List<OrderTerInputEntity>>();
            obj.Data = await orderTerInputService.GetList(param, user);
            obj.Total = obj.Data.Count;
            obj.Tag = 1;
            return obj;
        }

        public async Task<TData<List<OrderTerInputEntity>>> GetPageList(OrderTerInputListParam param, Pagination pagination, OperatorInfo user)
        {
            TData<List<OrderTerInputEntity>> obj = new TData<List<OrderTerInputEntity>>();
            obj.Data = await orderTerInputService.GetPageList(param, pagination, user);
            obj.Total = pagination.TotalCount;
            obj.PageTotal = pagination.TotalPage;
            obj.Tag = 1;
            return obj;
        }

        public async Task<TData<List<Response_OrderTerInput_ChartLine>>> GetListGroupChart(OrderTerInputListParam param, OperatorInfo user)
        {
            TData<List<Response_OrderTerInput_ChartLine>> obj = new TData<List<Response_OrderTerInput_ChartLine>>();

            List<Response_OrderTerInput_ChartLine> list = await orderTerInputService.GetListGroup(param, user);

            obj.Data = list;
            obj.Total = list.Count;
            obj.Tag = 1;
            if (obj.Total <= 0)
            {
                obj.Message = "没有查询到数据";
            }
            return obj;
        }

        public async Task<TData<int>> GetShenCount(OperatorInfo user)
        {
            TData<int> obj = new TData<int>();
            if (user.IsFinance)
            {
                obj.Data = await orderTerInputService.GetShenCount(user, InPutStepEnum.Validate);
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


        public async Task<TData<OrderTerInputEntity>> GetEntity(long id)
        {
            TData<OrderTerInputEntity> obj = new TData<OrderTerInputEntity>();
            obj.Data = await orderTerInputService.GetEntity(id);
            if (obj.Data != null)
            {
                obj.Tag = 1;
            }
            return obj;
        }
        #endregion

        #region 提交数据
        public async Task<TData<string>> SaveForm(OrderTerInputParam modelParam, OperatorInfo opuser)
        {
            TData<string> obj = new TData<string>();
            obj.SetDefault();
            try
            {
                OrderTerInputEntity entity = new OrderTerInputEntity();
                ClassValueCopierHelper.Copy(entity, modelParam);


                long num = 0;
                long.TryParse(modelParam.Id, out num);
                entity.Id = num;

                if (!entity.Id.IsNullOrZero())
                {
                    TData<OrderTerInputEntity> tdata = await GetEntity(num);
                    entity = tdata.Data;
                }

                #region 补充数据
                num = 0;
                long.TryParse(modelParam.MaterielId, out num);
                entity.MaterielId = num;


                num = 0;
                long.TryParse(modelParam.BuyId, out num);
                entity.BuyId = num;

                long.TryParse(modelParam.SupplierId, out num);
                entity.SupplierId = num;

                int saleNum = 0;
                int.TryParse(modelParam.BuyNum, out saleNum);
                entity.BuyNum = saleNum;

                decimal money = 0;
                decimal.TryParse(modelParam.BuyPrice, out money);
                entity.BuyPrice = money;


                num = 0;
                long.TryParse(modelParam.ShenHeManId, out num);
                entity.ShenHeManId = num;

                saleNum = 0;
                int.TryParse(modelParam.ShenHeStatus, out saleNum);
                entity.ShenHeStatus = saleNum;

                if (entity.Id.IsNullOrZero())
                {
                    entity.BaseCreatorId = long.Parse(opuser.UserIdStr);
                    entity.BaseCreateTime = DateTime.Now;
                }
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


        public async Task<TData<string>> SaveForm(OrderTerInputEntity entity, OperatorInfo opuser)
        {
            TData<string> obj = new TData<string>();
            var result = CheckWorkFLow(entity, opuser);
            if (result.IsSucess)
            {
                await orderTerInputService.SaveForm(entity);
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
        private async Task<ResultMsg> FinishWorkFLow(OrderTerInputEntity entity)
        {

            ResultMsg result = new ResultMsg();
            //通过审批且流程结束
            if (entity.Step == InPutStepEnum.Finish.ParseToInt() &&
                entity.ShenHeStatus == ShenHeStatusEnum.Past.ParseToInt())
            {
                //修改物料库存和明细了
                long? id = entity.MaterielId;
                int buyNum = 0;
                int.TryParse(entity.BuyNum.ToString(), out buyNum);
                //
                if (buyNum > 0)
                {
                    TData<string> td_result = await orderMaterielBLL.ModifyMaterielTotal(long.Parse(id + ""), true, buyNum,
                        "物料进货",
                        entity.Id, "order_ter_input");
                    if (td_result.Tag == 1)
                    {
                        result.IsSucess = true;
                    }
                }
            }
            return result;
        }

        /// <summary>
        /// 检测流程
        /// </summary>
        /// <param name="entity">数据实体</param>
        /// <returns></returns>
        private ResultMsg CheckWorkFLow(OrderTerInputEntity entity,OperatorInfo user)
        {
            ResultMsg result = new ResultMsg();
            //新增
            if (entity.Id.IsNullOrZero())
            {
                entity.ShenHeStatus = 0;
                entity.Step = InPutStepEnum.Validate.ParseToInt();
                result.IsSucess = true;
            }
            else
            {
                if (entity.Step == InPutStepEnum.Create.ParseToInt())
                {
                    if (entity.BaseCreatorId == user.UserId)
                    {
                        if (entity.ShenHeStatus == ShenHeStatusEnum.Create.ParseToInt())
                        {
                            entity.Step = InPutStepEnum.Validate.ParseToInt();
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
                else if (entity.Step == InPutStepEnum.Validate.ParseToInt())
                {
                    if (user.UserId == entity.ShenHeManId)
                    {
                        entity.Step = InPutStepEnum.Finish.ParseToInt();
                        result.IsSucess = true;
                    }
                    else
                    {
                        result.Msg = "请财务审核才能下一步操作";
                    }
                }
                //发货阶段
                else
                {
                    result.Msg = "流程已经结束,禁止操作";
                }

            }
            return result;
        }

        public async Task<TData> DeleteForm(string ids)
        {
            TData obj = new TData();
            await orderTerInputService.DeleteForm(ids);
            obj.Tag = 1;
            return obj;
        }
        #endregion

        #region 私有方法
        #endregion
    }
}
