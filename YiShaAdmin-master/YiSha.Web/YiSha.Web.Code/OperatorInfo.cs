﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using YiSha.Enum;
using YiSha.Util;
using YiSha.Util.Extension;
using YiSha.Util.Model;

namespace YiSha.Web.Code
{
    public class OperatorInfo
    {
       [JsonConverter(typeof(Util.StringJsonConverter))]
        public long? UserId { get; set; }
        public string UserIdStr {
            get {
                return this.UserId.ToString();
            }
        }
        public int? UserStatus { get; set; }
        public int? IsOnline { get; set; }
        public string UserName { get; set; }
        /// <summary>
        /// 微信昵称
        /// </summary>
        [NotMapped]
        public string WxNickName { get; set; }
        public string RealName { get; set; }
        public string WebToken { get; set; }
        public string ApiToken { get; set; }
        public int? IsSystem { get; set; }
        public string Portrait { get; set; }
        [JsonConverter(typeof(Util.StringJsonConverter))]
        public long? DepartmentId { get; set; }

        [NotMapped]
        public string DepartmentName { get; set; }

        /// <summary>
        /// 岗位Id
        /// </summary>
        [NotMapped]
        public string PositionIds { get; set; }
       
     
        /// <summary>
        /// 角色Id
        /// </summary>
        [NotMapped]
        public string RoleIds { get; set; }

        /// <summary>
        /// 角色Codes Id
        /// </summary>
        [NotMapped]
        public string RoleCodes { get; set; }

        /// <summary>
        /// 是否为管理员或者开发人员
        /// </summary>
        [NotMapped]
        public bool IsAdminOrDev {
            get
            {
                bool isTrue = false;
                if (this.RoleCodes != null)
                {
                    if (this.RoleCodes.Contains(SysRoleEnum.dev.ParseToInt().ToString())
                        || this.RoleCodes.Contains(SysRoleEnum.admin.ParseToInt().ToString()))
                    {
                        isTrue = true;
                    }
                }
                return isTrue;
            }
        }


        /// <summary>
        /// 是否为财务
        /// </summary>
        [NotMapped]
        public bool IsFinance
        {
            get
            {
                bool isTrue = false;
                if (this.RoleCodes != null)
                {
                    if (this.RoleCodes.Contains(SysRoleEnum.finance.ParseToInt().ToString()))
                    {
                        isTrue = true;
                    }
                }
                return isTrue;
            }
        }

        /// <summary>
        /// 是否为售后
        /// </summary>
        [NotMapped]
        public bool IsWeihu
        {
            get
            {
                bool isTrue = false;
                if (this.RoleCodes != null)
                {
                    if (this.RoleCodes.Contains(SysRoleEnum.weihu.ParseToInt().ToString()))
                    {
                        isTrue = true;
                    }
                }
                return isTrue;
            }
        }

    }
    public class RoleInfo
    {
        public long RoleId { get; set; }
        /// <summary>
        /// 角色名称
        /// </summary>
        public string RoleName { get; set; }
        /// <summary>
        /// 角色代码
        /// </summary>
        public string RoleCode { get; set; }

    }

}
