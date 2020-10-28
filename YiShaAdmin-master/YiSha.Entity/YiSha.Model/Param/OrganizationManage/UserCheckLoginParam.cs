using System;
using System.Collections.Generic;
using System.Text;

namespace YiSha.Model.Param.OrganizationManage
{
    /// <summary>
    /// 用户登录参数信息
    /// </summary>
    public class UserCheckLoginParam
    {
        //string userName, string password,
        //string openid, string wx_nikename, string head_img, int sex,
        /// <summary>
        /// 登录名
        /// </summary>
        public string UserName { get; set; }
        /// <summary>
        /// 密码
        /// </summary>
        public string Password { get; set; }
        /// <summary>
        /// 用户openid
        /// </summary>
        public string Openid { get; set; }
        /// <summary>
        /// 微信昵称
        /// </summary>
        public string WxNikeName { get; set; }
        /// <summary>
        /// 微信头像
        /// </summary>
        public string Headimg { get; set; }
        /// <summary>
        /// 用户性别
        /// </summary>
        public int Sex { get; set; }
    }
}
