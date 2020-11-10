using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;
using YiSha.Util;

namespace YiSha.Model.Result.OrderManage
{
    /// <summary>
    /// 折线图相应数据
    /// </summary>
    public class Response_OrderTerIssue_ChartLine
    {
        //MaterielTxt，MaterielType，MaterielDesc，MaterielUnite、SaleNum,MaterielId,BuyDay

        public string MaterielTxt { get; set; }
        public string MaterielType { get; set; }
        public string MaterielDesc { get; set; }
        public string MaterielUnite { get; set; }

        public int SaleNum { get; set; }
        [JsonConverter(typeof(StringJsonConverter))]
        public long MaterielId { get; set; }
        public string BuyDay { get; set; }
    }
}
