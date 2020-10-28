using System;
using System.Collections.Generic;
using System.Text;

namespace YiSha.Model.Param
{
    /// <summary>
    /// 消息队列数据
    /// </summary>
    [Serializable]
    public class MsmqMsg
    {
        public MsmqMsg() { }

        public MsmqMsg(string touser, string p_type, string msg, string head)
        {
            this.ToUserId = touser;
            this.Msg = msg;
            this.Head = head;
            this.PType = p_type;
        }
        /// <summary>
        /// 消息接收者
        /// </summary>
        public string ToUserId { get; set; }
        /// <summary>
        /// 消息头标识 长度固定8位，不足用0代替
        /// </summary>
        public string Head { get; set; }
        /// <summary>
        /// 产品类别
        /// </summary>
        public string PType { get; set; }
        /// <summary>
        /// 消息
        /// </summary>
        public string Msg { get; set; }
    }
}
