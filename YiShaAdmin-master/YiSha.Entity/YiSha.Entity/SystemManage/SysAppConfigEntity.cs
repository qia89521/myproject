using System;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;
using YiSha.Util;
using System.Collections.Generic;

namespace YiSha.Entity.SystemManage
{
    /// <summary>
    /// 创 建：admin
    /// 日 期：2020-10-28 18:03
    /// 描 述：系统应用配置实体类
    /// </summary>
    [Table("sys_app_config")]
    public class SysAppConfigEntity : BaseModifyEntity
    {
        
        /// <summary>
        /// 联系电话
        /// </summary>
        /// <returns></returns>
        public string Tel { get; set; }
        /// <summary>
        /// 版权
        /// </summary>
        /// <returns></returns>
        public string Copyright { get; set; }
        /// <summary>
        /// 技术支持
        /// </summary>
        /// <returns></returns>
        public string Tecklownloge { get; set; }
        /// <summary>
        /// 开发公司
        /// </summary>
        /// <returns></returns>
        public string CompanyName { get; set; }
        /// <summary>
        /// 欢迎界面图片，多个，分隔
        /// </summary>
        public string WelComeImgs { get; set; }

        [NotMapped]
        public List<string> WelComeImgList {

            get {
                List<string> list = new List<string>();
                if (!string.IsNullOrEmpty(WelComeImgs))
                {
                    foreach (string s in WelComeImgs.Split(','))
                    {
                        list.Add(s);
                    }
                }

                return list;
            }
        }
    }
}
