using System;
using System.Collections.Generic;
using System.Text;

namespace YiSha.Model.Param.TerManage
{
    /// <summary>
    /// 创 建：admin
    /// 日 期：2020-08-14 16:16
    /// 描 述：设备绑定参数类
    /// </summary>
    public class TerBindParam
    {

        //string ApiToken,string fistLongitude, string fistLatitude
        /// <summary>
        /// 用户登录apidToken
        /// </summary>
        public string ApiToken { get; set; }
        /// <summary>
        /// 设备号
        /// </summary>
        public string Number { get; set; }
        /// <summary>
        /// 位置
        /// </summary>
        public string Address { get; set; }
        /// <summary>
        /// 经度
        /// </summary>
        public string FistLongitude { get; set; }
        /// <summary>
        /// 纬度
        /// </summary>
        public string FistLatitude { get; set; }
    }
}
