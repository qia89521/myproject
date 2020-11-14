using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;
using System.Text;

namespace YiSha.Util
{
    /// <summary>
    /// 通用工具类
    /// </summary>
    public static class CoomHelper
    {
        #region 0 获取值，为null取默认
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
        #endregion

        #region 1 获取配置文件对象
        /// <summary>
        /// 获取配置文件对象
        /// </summary>
        /// <returns></returns>
        public static string GetConfig(string key)
        {
            return ConfigurationHelper.GetConfigValueByKey(key);

        }
        #endregion

        #region 2 将金额转成中文大写

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
        #endregion

        #region 3 生成随机数和订单号

        /// <summary>
        /// 生成（字母和数字）随机数
        /// </summary>
        /// <param name="len">随机数长度</param>
        /// <returns></returns>
        public static string CreateWordNumRandom(int len)
        {
            string str = @"0123456789abcdefghigklmnopqrstuvwxyz";
            Random random = new Random(GetRandomSeed());
            StringBuilder strNumber = new StringBuilder();
            for (int i = 1; i <= len; i++)
            {
                string word = str.Substring(0 + random.Next(36), 1);
                strNumber.Append(word);
            }
            return strNumber.ToString();
        }
        /// <summary>
        /// 创建唯一序列号
        /// </summary>
        /// <param name="pre">前缀</param>
        /// <returns></returns>
        public static string CreateGuid(string pre)
        {
            string number = string.Format("{0}{1}", pre, Guid.NewGuid().ToString().Replace("-", CreateRandom(1)).ToLower());
            return number;
        }

        /// <summary>
        /// 创建唯一序列号
        /// </summary>
        /// <returns></returns>
        public static string CreateUniqueId()
        {
            return CreateUniqueId(string.Empty);
        }

        /// <summary>
        /// 创建唯一序列号
        /// </summary>
        /// <param name="pre">前缀</param>
        /// <returns></returns>
        public static string CreateUniqueId(string pre)
        {
            string number = string.Format("{0}{1}{2}", pre, CreateTime(), CreateRandom(7));
            return number;
        }

        /// <summary>
        /// 创建时间戳id
        /// </summary>
        /// <returns></returns>
        public static string CreateTime()
        {
            return DateTime.Now.ToString("yyyyMMddHHmmssfff");
        }
        /// <summary>
        /// 创建30位长度的订单号,微信支付需要
        /// </summary>
        /// <returns></returns>
        public static string CreateNewOrderNo()
        {
            StringBuilder oder = new StringBuilder();
            //17位长度
            oder.AppendFormat("{0}", DateTime.Now.ToString("yyyyMMddHHmmssfff"));
            //4
            oder.AppendFormat("{0}", CreateRandomInt(1000, 9999));
            //9
            oder.AppendFormat("{0}", CreateRandomInt(100000000, 999999999));
            return oder.ToString();
        }
        static int GetRandomSeed()
        {
            byte[] bytes = new byte[4];
            System.Security.Cryptography.RNGCryptoServiceProvider rng = new System.Security.Cryptography.RNGCryptoServiceProvider();
            rng.GetBytes(bytes);
            return BitConverter.ToInt32(bytes, 0);
        }

        /// <summary>
        /// 生成随机数 最大九位数
        /// </summary>
        /// <param name="len">随机数长度</param>
        /// <returns></returns>
        public static string CreateRandomInt(int min, int max)
        {
            Random random = new Random(GetRandomSeed());
            int random_int = random.Next(min, max);
            return random_int.ToString();
        }

        /// <summary>
        /// 生成随机数 1-9
        /// </summary>
        /// <param name="len">随机数长度</param>
        /// <returns></returns>
        public static string CreateRandom(int len)
        {
            Random random = new Random(GetRandomSeed());
            StringBuilder strNumber = new StringBuilder();
            for (int i = 1; i <= len; i++)
            {

                strNumber.Append(random.Next(1, 9));
            }
            return strNumber.ToString();
        }
        #endregion

        #region  获取指定字符串第n次出现的位置索引
        /// <summary>
        /// 获取指定字符串第n次出现的位置索引
        /// </summary>
        /// <param name="str">原字符</param>
        /// <param name="cha">查找的字符</param>
        /// <param name="num">出现的次数</param>
        /// <returns></returns>
        public static int GetCharIndex(string str,string cha, int num)
        {
            int x = 0;
            if (!string.IsNullOrEmpty(str))
            {
                x = str.IndexOf(cha);
                for (var i = 0; i < num; i++)
                {
                    x = str.IndexOf(cha, x + 1);
                }
            }
            return x;
        }
        #endregion

    }
}
