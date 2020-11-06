using System;
using System.Collections.Generic;
using System.Text;

namespace YiSha.Model.Param.OrganizationManage
{
    /// <summary>
    /// 用户修改密码参数实体
    /// </summary>
    public class UserModifyPwdParam
    {
        public string OldPwd { get; set; }
        public string NewPwd { get; set; }
        public string ReNewPwd { get; set; }
        public string UserId { get; set; }
    }
}
