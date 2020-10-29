using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;

namespace YiSha.Util
{
    /// <summary>
    /// 通用工具类
    /// </summary>
    public static class CoomHelper
    {
        /// <summary>
        /// 获取值，为null取默认
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="defaltValue"></param>
        /// <returns></returns>
        public static string GetValue(object obj, string defaltValue)
        {
            if (obj == null)
            {
                return defaltValue;
            }
            else
            {
                string sss = obj.ToString();
                if (string.IsNullOrEmpty(sss))
                {
                    return defaltValue;
                }
                else
                {
                    return sss;
                }
            }
        }

        /// <summary>
        /// 获取配置文件对象
        /// </summary>
        /// <returns></returns>
        public static string GetConfig(string key)
        {
            return ConfigurationHelper.GetConfigValueByKey(key);

        }

        /// <summary>
        /// 将金额转成中文大写
        /// </summary>
        /// <param name="money"></param>
        /// <returns></returns>
        public static string Money2CnUper(string money)
        {
            //将小写金额转换成大写金额          
            double MyNumber = Convert.ToDouble(money);
            String[] MyScale = { "分", "角", "元", "拾", "佰", "仟", "万", "拾", "佰", "仟", "亿", "拾", "佰", "仟", "兆", "拾", "佰", "仟" };
            String[] MyBase = { "零", "壹", "贰", "叁", "肆", "伍", "陆", "柒", "捌", "玖" };
            String M = "";
            bool isPoint = false;
            if (money.IndexOf(".") != -1)
            {
                money = money.Remove(money.IndexOf("."), 1);
                isPoint = true;
            }
            for (int i = money.Length; i > 0; i--)
            {
                int MyData = Convert.ToInt16(money[money.Length - i].ToString());
                M += MyBase[MyData];
                if (isPoint == true)
                {
                    M += MyScale[i - 1];
                }
                else
                {
                    M += MyScale[i + 1];
                }
            }
            return M;
        }


    }
}
