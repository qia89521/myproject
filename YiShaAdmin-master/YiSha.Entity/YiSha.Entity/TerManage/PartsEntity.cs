using System;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;
using YiSha.Util;

namespace YiSha.Entity.TerManage
{
    /// <summary>
    /// 创 建：admin
    /// 日 期：2020-08-13 15:30
    /// 描 述：设备部件实体类
    /// </summary>
    [Table("ter_parts")]
    public class PartsEntity : BaseModifyEntity
    {
        /// <summary>
        /// 部件名称
        /// </summary>
        /// <returns></returns>
        public string PartName { get; set; }
        /// <summary>
        /// 部件编码
        /// </summary>
        /// <returns></returns>
        public string PartCode { get; set; }
    }
}
