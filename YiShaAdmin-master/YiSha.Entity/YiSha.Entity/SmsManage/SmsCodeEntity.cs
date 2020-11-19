using System;
using System.Collections.Generic;
using System.Text;
using YiSha.Util;

namespace YiSha.Entity.SmsManage
{
    /// <summary>
    /// 短信验证码实体
    /// </summary>
    public class SmsCodeEntity
    {
        /// <summary>
        /// id
        /// </summary>		
        public string id { get; set; }

        /// <summary>
        /// 手机号
        /// </summary>		
        public string mobile_phone { get; set; }

        /// <summary>
        /// 短信验证码
        /// </summary>		
        public string sms_code { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>		
        public DateTime create_time { get; set; }

       
    }
}
