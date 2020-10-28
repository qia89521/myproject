using System;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;
using YiSha.Util;

namespace YiSha.Entity.TerManage
{
    /// <summary>
    /// 创 建：admin
    /// 日 期：2020-08-14 16:16
    /// 描 述：设备状态实体类
    /// </summary>
    [Table("ter_status")]
    public class TerStatusEntity : BaseModifyEntity
    {
        public void SetDefault()
        {
            if (this.CloseStatus == null)
            {
                this.CloseStatus = "";
            }

            if (this.RunStatus == null)
            {
                this.RunStatus = "";
            }
            if (this.SW == null)
            {
                this.SW = "";
            }
            if (this.CW == null)
            {
                this.CW = "";
            }
            if (this.O3Rate == null)
            {
                this.O3Rate = "";
            }
            if (this.W == null)
            {
                this.W = "";
            }
            if (this.ErrorCode == null)
            {
                this.ErrorCode = "";
            }
            if (this.ErrorMsg == null)
            {
                this.ErrorMsg = "";
            }
            if (this.TerNumber == null)
            {
                this.TerNumber = "";
            }
            if (this.ClassName == null)
            {
                this.ClassName = "";
            }
        }

        /// <summary>
        /// 锁定状态
        /// </summary>
        /// <returns></returns>
        public string CloseStatus { get; set; }
        /// <summary>
        /// 运行状态
        /// </summary>
        /// <returns></returns>
        public string RunStatus { get; set; }
     
        /// <summary>
        /// 臭氧浓度百分比
        /// </summary>
        /// <returns></returns>
        public string O3Rate { get; set; }
        /// <summary>
        /// 银离子水量
        /// </summary>
        /// <returns></returns>
        public string SW { get; set; }
        /// <summary>
        /// 磁化器水量 单位L
        /// </summary>
        /// <returns></returns>
        public string CW { get; set; }
        /// <summary>
        /// 水量 单位L
        /// </summary>
        /// <returns></returns>
        public string W { get; set; }
        /// <summary>
        /// 故障代码
        /// </summary>
        /// <returns></returns>
        public string ErrorCode { get; set; }
        /// <summary>
        /// 故障消息
        /// </summary>
        /// <returns></returns>
        public string ErrorMsg { get; set; }
        /// <summary>
        /// 终端设备id
        /// </summary>
        /// <returns></returns>
        [JsonConverter(typeof(StringJsonConverter))]
        public long? TerId { get; set; }
        /// <summary>
        /// 设备编号
        /// </summary>
        /// <returns></returns>
        [NotMapped]
        public string TerNumber { get; set; }
        /// <summary>
        /// 设备名称
        /// </summary>
        /// <returns></returns>
        [NotMapped]
        public string TerName { get; set; }

        /// <summary>
        /// 分类
        /// </summary>
        /// <returns></returns>
        [NotMapped]
        public string ClassName { get; set; }
    }
}
