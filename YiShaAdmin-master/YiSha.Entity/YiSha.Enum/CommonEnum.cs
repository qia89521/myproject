using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YiSha.Enum
{

    /// <summary>
    /// 系统特殊角色
    /// </summary>
    public enum SysRoleEnum
    {
        [Description("系统-开发者")]
        dev = 0,

        [Description("系统-管理员")]
        admin = 1,

        [Description("系统-财务")]
        finance = 2,

        [Description("系统-售后维护")]
        weihu = 3,

        [Description("系统-客服")]
        cust = 4,

        [Description("系统-普通用户")]
        normal = 5,
    }


    public enum StatusEnum
    {
        [Description("启用")]
        Yes = 1,
        [Description("隐藏")]
        Hide = 2,
        [Description("禁用")]
        No = 0
    }

    public enum IsEnum
    {
        [Description("是")]
        Yes = 1,

        [Description("否")]
        No = 0
    }

    public enum NeedEnum
    {
        [Description("不需要")]
        NotNeed = 0,

        [Description("需要")]
        Need = 1
    }

    public enum OperateStatusEnum
    {
        [Description("失败")]
        Fail = 0,

        [Description("成功")]
        Success = 1
    }

    public enum UploadFileType
    {
        [Description("头像")]
        Portrait = 1,

        [Description("新闻图片")]
        News = 2,

        [Description("财务图")]
        Money = 3,

        [Description("导入的文件")]
        Import = 10

    }

    public enum PlatformEnum
    {
        [Description("Web后台")]
        Web = 1,

        [Description("WebApi")]
        WebApi = 2
    }

    public enum PayStatusEnum
    {
        [Description("未知")]
        Unknown = 0,

        [Description("已支付")]
        Success = 1,

        [Description("转入退款")]
        Refund = 2,

        [Description("未支付")]
        NotPay = 3,

        [Description("已关闭")]
        Closed = 4,

        [Description("已撤销（付款码支付）")]
        Revoked = 5,

        [Description("用户支付中（付款码支付）")]
        UserPaying = 6,

        [Description("支付失败(其他原因，如银行返回失败)")]
        PayError = 7
    }


    public enum RunStatusEnum
    {
        [Description("停止")]
        Stop = 0,

        [Description("运行")]
        Run = 1,
    }

    public enum CloseStatusEnum
    {
        [Description("关机")]
        Close = 0,

        [Description("开机")]
        Open = 1,
    }
    /// <summary>
    /// 购买方式
    /// </summary>
    public enum BuyTypeEnum
    {
        [Description("微信")]
        WX = 0,

        [Description("支付宝")]
        ZFB = 1,

        [Description("现金")]
        Carsh = 2,
    }

    /// <summary>
    /// 来源方式
    /// </summary>
    public enum SrcFlagEnum
    {
        [Description("后台添加")]
        Admin = 0,

        [Description("分享")]
        Share = 1,
    }

    /// <summary>
    /// 审核状态 0未审核,1:审核通过,2 拒绝
    /// </summary>
    public enum ShenHeStatusEnum
    {
        /// <summary>
        /// 未审核
        /// </summary>
        [Description("未审核")]
        Create = 0,
        /// <summary>
        ///审核通过
        /// </summary>
        [Description("审核通过")]
        Past = 1,
        /// <summary>
        /// 拒绝
        /// </summary>
        [Description("拒绝")]
        Refuse = 2,
    }
    /// <summary>
    /// 出货流程步骤 0:草稿,1:财务审核,2:售后发货,3:流程结束
    /// </summary>
    public enum OutPutStepEnum
    {
        /// <summary>
        /// 草稿
        /// </summary>
        [Description("草稿")]
        Create = 0,
        /// <summary>
        /// 财务审核
        /// </summary>
        [Description("财务审核")]
        Validate = 1,
        /// <summary>
        /// 售后发货
        /// </summary>
        [Description("售后发货")]
        Sent = 2,
        /// <summary>
        /// 流程结束
        /// </summary>
        [Description("流程结束")]
        Finish = 3,
    }
    /// <summary>
    /// 进货流程步骤 0:草稿,1:财务审核,2:售后发货,3:流程结束
    /// </summary>
    public enum InPutStepEnum
    {
        /// <summary>
        /// 草稿
        /// </summary>
        [Description("草稿")]
        Create = 0,
        /// <summary>
        ///财务审核
        /// </summary>
        [Description("财务审核")]
        Validate = 1,
        /// <summary>
        /// 流程结束
        /// </summary>
        [Description("流程结束")]
        Finish = 2,

    }

    /// <summary>
    /// 0未发货 1已发货 2自提
    /// </summary>
    public enum SentStatusEnum
    {
        /// <summary>
        /// 0未发货
        /// </summary>
        [Description("未发货")]
        No = 0,
        /// <summary>
        ///1已发货
        /// </summary>
        [Description("已发货")]
        Yes = 1,
       

    }
    /// <summary>
    ///提货方式
    /// </summary>
    public enum TakeTypeEnum
    {
        /// <summary>
        /// 0快递
        /// </summary>
        [Description("快递")]
        No = 0,
        /// <summary>
        ///1自提
        /// </summary>
        [Description("自提")]
        Yes = 1,

    }

}
