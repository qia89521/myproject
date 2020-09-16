using System;
using System.Collections.Generic;
using System.Text;

namespace YiSha.Model.Result
{
    /// <summary>
    /// 结果消息
    /// </summary>
    public class ResultMsg
    {
        /// <summary>
        /// 是否成功
        /// </summary>
        public bool IsSucess { get; set; }
        /// <summary>
        /// 消息
        /// </summary>
        public string Msg { get; set; }
    }
}
