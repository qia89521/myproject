using System;
using System.Collections.Generic;
using System.Text;

namespace YiSha.Model.Param.TerManage
{
    /// <summary>
    /// 创 建：admin
    /// 日 期：2020-08-14 16:16
    /// 描 述：设备位置类
    /// </summary>
    public class  TerPositionParam
    {
        //string number,string fistLongitude, string fistLatitude
        /// <summary>
        /// 设备号
        /// </summary>
        public string number { get; set; }
       /// <summary>
       /// 经度
       /// </summary>
        public string fistLongitude { get; set; }
        /// <summary>
        /// 纬度
        /// </summary>
        public string fistLatitude { get; set; }
    }
}
