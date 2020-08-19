using System;
using System.Collections.Generic;
using YiSha.Entity.OrganizationManage;

namespace YiSha.Model.Param.OrganizationManage
{
    public class UserListParam : DateTimeParam
    {
        public string UserName { get; set; }

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
    }

    public class ChangePasswordParam
    {
        public long? Id { get; set; }
        public string Password { get; set; }
        public string NewPassword { get; set; }
    }

}
