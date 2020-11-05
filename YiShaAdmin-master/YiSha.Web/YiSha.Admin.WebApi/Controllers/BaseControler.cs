using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YiSha.Util;
using YiSha.Web.Code;

namespace YiSha.Admin.WebApi.Controllers
{
    /// <summary>
    /// 【自定义】控制器基类
    /// </summary>
    public class BaseControler : Controller
    {
       
        /// <summary>
        /// 获取当前登陆用户信息
        /// </summary>
        /// <param name="json"></param>
        /// <returns></returns>
        protected OperatorInfo GetCurLoginUser(string json)
        {
            //{"UserId":16508640061130152,"UserStatus":1,"IsOnline":1,"UserName":"admin","WxNickName":null,"RealName":"普沃森管理员","WebToken":"265d8570ac504b588c85018c7974a431","ApiToken":"8e0ba3eaa33c48c49b4ffa9734091d44","IsSystem":1,"Portrait":"https://thirdwx.qlogo.cn/mmopen/vi_32/WlI7qoQoOFLLK31hoqwyExQL7PNUPcwsT9R6F7hqtu3q95qEnp3NlqxVAqYlt4DgI1dGK6J4xYOFas1TOUpPzw/132","DepartmentId":16508640061124402,"DepartmentName":"普沃森总部","PositionIds":null,"RoleIds":"16508640061130146","RoleCodes":"1","IsAdminOrDev":true}
            OperatorInfo user = null;
            try
            {
                user= JsonHelper.JsonConvertObject<OperatorInfo>(json);
            }
            catch (Exception ex)
            {
                LogHelper.Info("【BaseControler】 ex:"+ex.ToString());
            }
            return user;
        }
    }
}
