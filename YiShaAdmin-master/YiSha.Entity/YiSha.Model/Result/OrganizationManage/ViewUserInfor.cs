using System;
using System.Collections.Generic;
using System.Text;

namespace YiSha.Model.Result.OrganizationManage
{
    /// <summary>
    /// 查看用户信息返回数据
    /// </summary>
    public class ViewUserInfor
    {
        /// <summary>
        /// 用户登录名
        /// </summary>
        public string UserName { get; set; }
        /// <summary>
        /// 姓名
        /// </summary>
        public string RealName { get; set; }
        /// <summary>
        /// 性别
        /// </summary>
        public int? Gender { get; set; }
        /// <summary>
        /// 生日
        /// </summary>
        public string Birthday { get; set; }
        public string Portrait { get; set; }
        /// <summary>
        /// 邮箱
        /// </summary>
        public string Email { get; set; }
        public string Mobile { get; set; }
        /// <summary>
        /// 注册时间
        /// </summary>
        public DateTime? FirstVisit { get; set; }
        public string Remark { get; set; }
        /// <summary>
        /// 部门名称
        /// </summary>
        public string DepartmentName { get; set; }
        /// <summary>
        /// 角色名称
        /// </summary>
        public string RoleTxts { get; set; }
        /// <summary>
        /// 代理区域名称
        /// </summary>
        public string DelegetZoneTxt { get; set; }
        /// <summary>
        /// 父级
        /// </summary>
        public string ParentTxt { get; set; }
        /// <summary>
        /// 爷爷级
        /// </summary>
        public string GrandParentTxt { get; set; }
        /// <summary>
        /// 用户openid
        /// </summary>
        public string OpenId { get; set; }
        /// <summary>
        /// 用户微信昵称
        /// </summary>
        public string WxNickName { get; set; }
    }
}
