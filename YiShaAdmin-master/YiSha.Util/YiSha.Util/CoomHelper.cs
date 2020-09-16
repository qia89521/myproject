using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace YiSha.Util
{
    /// <summary>
    /// 通用工具类
    /// </summary>
    public static class CoomHelper
    {
        /// <summary>
        /// 获取类中属性表名称
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static string GetClassTableName<T>()
        {
            try
            {
                Type targetType = typeof(T);
                HashSet<string> columName = new HashSet<string>();
                Type type = targetType.GetType();
                TableAttribute temp = (TableAttribute)type.GetCustomAttributes(typeof(TableAttribute), false)[0];
                return temp.Name;
            }
            catch
            {
                return "";
            }
        }
    }
}
