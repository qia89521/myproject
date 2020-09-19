using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace YiSha.Admin.WebApi.Controllers
{
    /// <summary>
    /// 设备出货控制器
    /// </summary>
    [Route("[controller]/[action]")]
    [ApiController]
    [AuthorizeFilter]
    public class OrderTerIssueController : Controller
    {
      
    }
}
