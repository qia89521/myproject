using System;
using System.Collections.Generic;
using YiSha.Entity.OrganizationManage;
using YiSha.Util.Model;

namespace YiSha.Model.Param.OrganizationManage
{
    public class UserListParam : DateTimeParam
    {
        public string UserName { get; set; }
        public string RealName { get; set; }

        public string Mobile { get; set; }

        public int? UserStatus { get; set; }

        public long? DepartmentId { get; set; }

        public List<long> ChildrenDepartmentIdList { get; set; }

        public string UserIds { get; set; }
        /// <summary>
        ///省
        /// </summary>
        public string Provoice { get; set; }
        /// <summary>
        /// 市
        /// </summary>
        public string City { get; set; }
        /// <summary>
        /// 县区
        /// </summary>
        public string Xian { get; set; }
        /// <summary>
        /// 当前用户ID
        /// </summary>
        public long? CurUserId { get; set; }

    }

    public class ChangePasswordParam
    {
        public long? Id { get; set; }
        public string Password { get; set; }
        public string NewPassword { get; set; }
    }



    /// <summary>
    /// web api设备信息查询类
    /// </summary>
    public class WebApi_TerInforListParam
    {
        /// <summary>
        /// 工具栏参数
        /// </summary>
        public UserListParam ListParam { get; set; }
        /// <summary>
        /// 分页参数
        /// </summary>
        public Pagination Pagination { get; set; }
        /// <summary>
        /// api token
        /// </summary>
        public string ApiToken { get; set; }
    }

}
