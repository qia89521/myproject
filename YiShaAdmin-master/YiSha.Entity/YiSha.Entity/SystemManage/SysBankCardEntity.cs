using System;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;
using YiSha.Util;

namespace YiSha.Entity.SystemManage
{
    /// <summary>
    /// 创 建：admin
    /// 日 期：2020-08-20 09:48
    /// 描 述：收款银行卡管理实体类
    /// </summary>
    [Table("sys_bank_card")]
    public class SysBankCardEntity : BaseModifyEntity
    {
        /// <summary>
        /// 用户姓名
        /// </summary>
        /// <returns></returns>
        public string Name { get; set; }
        /// <summary>
        /// 用户银行卡
        /// </summary>
        /// <returns></returns>
        public string MchNo { get; set; }
        /// <summary>
        /// 开户银行
        /// </summary>
        /// <returns></returns>
        public string BankName { get; set; }
    }
}
