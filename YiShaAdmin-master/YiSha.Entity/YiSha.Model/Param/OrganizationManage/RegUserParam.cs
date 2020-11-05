using System;
using System.Collections.Generic;
using System.Text;

namespace YiSha.Model.Param.OrganizationManage
{
    /// <summary>
    /// 用户注册参数
    /// </summary>
    public class RegUserParam
    {
        /// <summary>
        /// 推荐码
        /// </summary>
        public string TJCode { get; set; }//
        /// <summary>
        /// 用户名
        /// </summary>
        public string UserName { get; set; }
        /// <summary>
        /// 密码
        /// </summary>
        public string Password { get; set; }
        /// <summary>
        /// 重复密码
        /// </summary>
        public string RePassword { get; set; }
        /// <summary>
        /// 真实名字
        /// </summary>
        public string RealName { get; set; }
        /// <summary>
        /// 性别
        /// </summary>
        public int Gender { get; set; }
        /// <summary>
        /// 手机号
        /// </summary>
        public string Mobile { get; set; }
        /// <summary>
        /// 头像
        /// </summary>
        public string Portrait { get; set; }
    }
}
