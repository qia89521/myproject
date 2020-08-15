﻿using System;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;
using YiSha.Util;

namespace YiSha.Entity.TerManage
{
    /// <summary>
    /// 创 建：admin
    /// 日 期：2020-08-14 16:05
    /// 描 述：设备信息实体类
    /// </summary>
    [Table("ter_infor")]
    public class TerInforEntity : BaseModifyEntity
    {
        /// <summary>
        /// 设备名称
        /// </summary>
        /// <returns></returns>
        public string TerName { get; set; }
        /// <summary>
        /// 设备编号
        /// </summary>
        /// <returns></returns>
        public string TerNumber { get; set; }
        /// <summary>
        /// 运营商名称
        /// </summary>
        /// <returns></returns>
        public string BusyName { get; set; }
        /// <summary>
        /// 运营商联系方式
        /// </summary>
        /// <returns></returns>
        public string BusyLink { get; set; }
        /// <summary>
        /// 关机密码
        /// </summary>
        /// <returns></returns>
        public string ClosePwd { get; set; }
        /// <summary>
        /// 商户号
        /// </summary>
        /// <returns></returns>
        public string MchId { get; set; }
        /// <summary>
        /// 商户名称
        /// </summary>
        /// <returns></returns>
        public string MchName { get; set; }
        /// <summary>
        /// 累计用水总量
        /// </summary>
        /// <returns></returns>
        public string WaterNum { get; set; }
        /// <summary>
        /// 累计使用时长
        /// </summary>
        /// <returns></returns>
        public string TimeLen { get; set; }
        /// <summary>
        /// 当前网络信号
        /// </summary>
        /// <returns></returns>
        public string NetSignal { get; set; }
        /// <summary>
        /// 业主
        /// </summary>
        /// <returns></returns>
        public string ManageId { get; set; }
        /// <summary>
        /// 位置
        /// </summary>
        /// <returns></returns>
        public string Position { get; set; }
        /// <summary>
        /// 经度
        /// </summary>
        /// <returns></returns>
        public string Longitude { get; set; }
        /// <summary>
        /// 纬度
        /// </summary>
        /// <returns></returns>
        public string Latitude { get; set; }
    }
}