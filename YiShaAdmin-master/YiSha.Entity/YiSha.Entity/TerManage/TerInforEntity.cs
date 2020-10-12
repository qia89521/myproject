using System;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;
using YiSha.Util;
using YiSha.Util.Model;
using System.ComponentModel;

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
        [JsonConverter(typeof(StringJsonConverter))]
        public long? ManageId { get; set; }
        /// <summary>
        /// 业主
        /// </summary>
        /// <returns></returns>
        [NotMapped]
        public string ManageTxt { get; set; }
        
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
        /// <summary>
        /// 设备部件
        /// </summary>
        /// <returns></returns>
        public string TerParts { get; set; }

        /// <summary>
        /// 第一次开机时间 yyyy-MM-dd HH:mm:ss
        /// </summary>
        /// <returns></returns>
        public string FistOn { get; set; }
        /// <summary>
        /// 第一次位置
        /// </summary>
        /// <returns></returns>
        public string FistPosition { get; set; }
        /// <summary>
        /// 第一次经度
        /// </summary>
        /// <returns></returns>
        public string FistLongitude { get; set; }
        /// <summary>
        ///第一次纬度
        /// </summary>
        /// <returns></returns>
        public string FistLatitude { get; set; }
        /// <summary>
        ///是否锁定 0:没有 1:锁定
        /// </summary>
        /// <returns></returns>
        [Description("锁定之后，就不能更改业主")]
        public int IsLock { get; set; }
        /// <summary>
        ///设备是否出货 0:否 1:是
        /// </summary>
        /// <returns></returns>
        [Description("设备是否出货 0:否 1:是")]
        public int IsBuy { get; set; }
        /// <summary>
        ///发货目的区(用于生产底下二维码提示文字)
        /// </summary>
        /// <returns></returns>
        [Description("发货目的区(用于生产底下二维码提示文字)")]
        [NotMapped]
        public string Zone { get; set; }

        /// <summary>
        /// 销售人id
        /// </summary>
        /// <returns></returns>
        [JsonConverter(typeof(StringJsonConverter))]
        public long? SaleManId { get; set; }
        /// <summary>
        /// 销售人
        /// </summary>
        /// <returns></returns>
        [NotMapped]
        public string SaleManTxt { get; set; }
        public static implicit operator TerInforEntity(TData<TerInforEntity> v)
        {
            throw new NotImplementedException();
        }
    }
}
