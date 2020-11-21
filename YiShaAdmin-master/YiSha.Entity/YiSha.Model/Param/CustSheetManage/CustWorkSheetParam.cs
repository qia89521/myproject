using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using YiSha.Util;
using YiSha.Util.Model;

namespace YiSha.Model.Param.CustSheetManage
{

    /// <summary>
    /// web api维修工单处理实体查询类
    /// </summary>
    public class WebApi_CustWorkSheetListParam
    {
        /// <summary>
        /// 工具栏参数
        /// </summary>
        public CustWorkSheetListParam ListParam { get; set; }
        /// <summary>
        /// 分页参数
        /// </summary>
        public Pagination Pagination { get; set; }
        /// <summary>
        /// api token
        /// </summary>
        public string ApiToken { get; set; }
    }

    /// <summary>
    /// 创 建：admin
    /// 日 期：2020-11-19 15:30
    /// 描 述：维修工单处理实体查询类
    /// </summary>
    public class CustWorkSheetListParam
    {
        /// <summary>
        /// 开始日期
        /// </summary>
        public string StartTime { get; set; }

        /// <summary>
        /// 结束日期
        /// </summary>
        public string EndTime { get; set; }
        /// <summary>
        /// 设备名称
        /// </summary>
        public string TerName { get; set; }
        /// <summary>
        /// 设备编号
        /// </summary>
        public string TerNumber { get; set; }
        /// <summary>
        /// 流程步骤
        /// </summary>
        public int Step { get; set; }
    }


    /// <summary>
    /// 创 建：admin
    /// 日 期：2020-09-01 15:48
    /// 描 述：维修工单处理实体查询类
    /// </summary>
    public class CustWorkSheetParam
    {
        /*
            TerId BIGINT    COMMENT '设备Id' ,
            Title VARCHAR(128)    COMMENT '标题' ,
            Content VARCHAR(1024)    COMMENT '详细描述' ,
            Imgs VARCHAR(3072)    COMMENT '故障图' ,
            DoManId BIGINT    COMMENT '售后人' ,
            Step INT    COMMENT '步骤 0:待处理,1:处理中,2 处理完成, 3:结单' ,
         */
        public string Id { get; set; }

        /// <summary>
        /// 设备Id
        /// </summary>
        public string TerId { get; set; }
        /// <summary>
        /// 设备编号
        /// </summary>
        public string TerNumber { get; set; }
        /// <summary>
        /// 标题
        /// </summary>
        /// <returns></returns>
        public string Title { get; set; }
        /// <summary>
        /// 详细描述
        /// </summary>
        /// <returns></returns>
        public string Content { get; set; }
        /// <summary>
        /// 故障图
        /// </summary>
        public string Imgs { get; set; }
        /// <summary>
        /// 售后人
        /// </summary>
        public string DoManId { get; set; }
        /// <summary>
        /// '步骤 0:待处理,1:处理中,2 处理完成, 3:结单' ,
        /// </summary>
        public string Step { get; set; }
        /// <summary>
        /// api token
        /// </summary>
        public string ApiToken { get; set; }

    }
}
