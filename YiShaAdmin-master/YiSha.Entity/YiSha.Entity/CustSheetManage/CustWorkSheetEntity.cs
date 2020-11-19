using System;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;
using YiSha.Util;
using System.Collections.Generic;

namespace YiSha.Entity.CustSheetManage
{
    /// <summary>
    /// 创 建：admin
    /// 日 期：2020-11-19 15:30
    /// 描 述：维修工单处理实体类
    /// </summary>
    [Table("cust_work_sheet")]
    public class CustWorkSheetEntity : BaseModifyEntity
    {
        /// <summary>
        /// 设备Id
        /// </summary>
        /// <returns></returns>
        [JsonConverter(typeof(StringJsonConverter))]
        public long TerId { get; set; }

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
        /// <returns></returns>
        public string Imgs { get; set; }

        /// <summary>
        /// 故障首张图
        /// </summary>
        /// <returns></returns>
        [NotMapped]
        public string FristImg {
            get
            {
                if (this.ImgList.Count > 0)
                {
                    return this.ImgList[0];
                }
                else
                {
                    return "";
                }
            }
        }

        [NotMapped]
        public List<string> ImgList
        {

            get
            {
                List<string> list = new List<string>();
                if (!string.IsNullOrEmpty(Imgs))
                {
                    foreach (string s in Imgs.Split(','))
                    {
                        list.Add(s);
                    }
                }

                return list;
            }
        }

        /// <summary>
        /// 售后人
        /// </summary>
        /// <returns></returns>
        [JsonConverter(typeof(StringJsonConverter))]
        public long DoManId { get; set; }
        /// <summary>
        /// 售后人名称
        /// </summary>
        /// <returns></returns>
        public string DoManTxt { get; set; }
        /// <summary>
        /// 步骤 步骤 0:待处理,1:处理中,2 处理完成, 3:结单
        /// </summary>
        /// <returns></returns>
        public int Step { get; set; }
    }
}
