using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection;
using System.Text;

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
    }
}
