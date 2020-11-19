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

        #region  4 获取指定字符串第n次出现的位置索引
        /// <summary>
        /// 获取指定字符串第n次出现的位置索引
        /// </summary>
        /// <param name="str">原字符</param>
        /// <param name="cha">查找的字符</param>
        /// <param name="num">出现的次数</param>
        /// <returns></returns>
        public static int GetCharIndex(string str, string cha, int num)
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

        #region 5 时间相减
        /// <summary>
        /// 时间相减,默认返回相差的秒数
        /// </summary>
        /// <param name="time1">减数</param>
        /// <param name="time2">被减数</param>
        /// <param name="flag">day:返回天数，min:分钟，second:秒，hour:小时，mill：毫秒</param>
        /// <returns></returns>
        public static int TimeSub(DateTime time1, DateTime time2, string flag)
        {
            System.TimeSpan ts = time1 - time2;
            int value = 0;
            if (flag == "day")
            {
                value = ts.Days;
            }
            else if (flag == "hour")
            {
                value = ts.Days * 24 + ts.Hours;
            }
            else if (flag == "min")
            {
                value = (ts.Days * 24 + ts.Hours) * 60 + ts.Minutes;
            }
            else if (flag == "second")
            {
                value = (ts.Days * 24 * 60 + ts.Hours * 60 + ts.Minutes) * 60 + ts.Seconds;
            }
            else if (flag == "mill")
            {
                value = (ts.Days * 24 * 60 * 60 + ts.Hours * 60 * 60 + ts.Minutes * 60 + ts.Seconds) * 1000 + ts.Milliseconds;
            }

            return value;
        }

        /// <summary>
        /// 检测是否过期,返回true 表示没有过期，false：过期
        /// </summary>
        /// <param name="start_time">开始时间 格式：yyyy-MM-dd</param>
        /// <param name="end_time">结束时间 格式：yyyy-MM-dd</param>
        ///  <param name="curtime">比较的时间</param>
        /// <returns></returns>
        public static bool CheckIsExpired(string start_time, string end_time, DateTime curtime)
        {
            DateTime stime = Convert.ToDateTime(string.Format("{0} 00:00:00", start_time));
            DateTime etime = Convert.ToDateTime(string.Format("{0} 23:59:59", end_time));
            if (DateTime.Compare(curtime, stime) >= 0 &&
                DateTime.Compare(etime, curtime) >= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion

        #region 6 生成随机数
        /// <summary>
        /// 生成随机数 0-9,a-z
        /// </summary>
        /// <param name="len">随机数长度</param>
        ///  <param name="flag">0：纯数字 1：纯字母 2:混合</param>
        /// <returns></returns>
        public static string CreateRandomWordOrNum(int len, string flag = "2")
        {
            List<string> list = null;
            if (flag == "0")
            {
                list = new List<string>() {
            "0","1","2","3","4","5","6","7","8","9"
            };
            }
            else if (flag == "1")
            {
                list = new List<string>() {
            "a","b","c","d","e","f","g","h","i","j"
             ,"k","l","m","n","o","p","q","r","s","t"
              ,"u","v","w","x","y","z"
            };
            }
            else
            {
                list = new List<string>() {
            "0","1","2","3","4","5","6","7","8","9"
            ,"a","b","c","d","e","f","g","h","i","j"
             ,"k","l","m","n","o","p","q","r","s","t"
              ,"u","v","w","x","y","z"
            };
            }
            Random random = new Random(GetRandomSeed());
            StringBuilder strNumber = new StringBuilder();
            for (int i = 1; i <= len; i++)
            {
                int index = random.Next(0, list.Count);
                strNumber.Append(list[index]);
            }
            return strNumber.ToString();
        }
        #endregion

    }
}
