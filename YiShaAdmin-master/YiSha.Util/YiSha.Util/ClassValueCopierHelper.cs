using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace YiSha.Util
{
    /// <summary>
    /// 类属性/字段的值复制工具
    /// </summary>
    public static class ClassValueCopierHelper
    {
        /// <summary>
        /// 将源对象数据复制到目标对象，只复制名称相同且类型也相同的属性，返回复制成功的属性个数
        /// </summary>
        /// <param name="destination">目标对象</param>
        /// <param name="source">来源对象</param>
        /// <returns>成功复制的值个数</returns>
        public static int Copy(object destination, object source)
        {
            if (source != null)
            {
                return Copy(destination, source, source.GetType(), false);
            }
            return 0;
        }

        /// <summary>
        /// 复制
        /// </summary>
        /// <param name="destination">目标</param>
        /// <param name="source">来源</param>
        /// <param name="type">复制的属性字段模板</param>
        /// <returns>成功复制的值个数</returns>
        public static int Copy(object destination, object source, Type type)
        {
            if (type != null)
            {
                return Copy(destination, source, type, null, false);
            }
            return 0;
        }

        /// <summary>
        /// 将源对象数据复制到目标对象，只复制名称相同且类型也相同的属性，返回复制成功的属性个数
        /// </summary>
        /// <param name="destination">目标对象</param>
        /// <param name="source">来源对象</param>
        ///  <param name="checkNull">是否检测null值，如果为null就不用覆盖</param>
        /// <returns>成功复制的值个数</returns>
        public static int Copy(object destination, object source, bool checkNull)
        {
            if (destination == null || source == null)
            {
                return 0;
            }
            return Copy(destination, source, source.GetType(), checkNull);
        }

        /// <summary>
        /// 复制
        /// </summary>
        /// <param name="destination">目标</param>
        /// <param name="source">来源</param>
        /// <param name="type">复制的属性字段模板</param>
        /// <param name="checkNull">是否检测null值，如果为null就不用覆盖</param>
        /// <returns>成功复制的值个数</returns>
        public static int Copy(object destination, object source, Type type, bool checkNull)
        {
            if (type != null)
            {
                return Copy(destination, source, type, null, checkNull);
            }
            return 0;
        }

        /// <summary>
        /// 复制
        /// </summary>
        /// <param name="destination">目标</param>
        /// <param name="source">来源</param>
        /// <param name="type">复制的属性字段模板</param>
        /// <param name="excludeName">排除下列名称的属性不要复制</param>
        /// <returns>成功复制的值个数</returns>
        private static int Copy(object destination, object source, Type type, IEnumerable<string> excludeName)
        {
            return Copy(destination, source, type, excludeName, false);
        }

        /// <summary>
        /// 复制
        /// </summary>
        /// <param name="destination">目标</param>
        /// <param name="source">来源</param>
        /// <param name="type">复制的属性字段模板</param>
        /// <param name="excludeName">排除下列名称的属性不要复制</param>
        /// <returns>成功复制的值个数</returns>
        private static int Copy(object destination, object source, Type type, IEnumerable<string> excludeName, bool checkNull)
        {
            if (destination == null || source == null)
            {
                return 0;
            }
            if (excludeName == null)
            {
                excludeName = new List<string>();
            }
            int i = 0;
            Type desType = destination.GetType();
            foreach (FieldInfo mi in type.GetFields())
            {
               // if (excludeName.Contains(mi.Name))
               if(excludeName.Contains(mi.Name))
                {
                    continue;
                }
                try
                {
                    FieldInfo des = desType.GetField(mi.Name);
                    if (des != null && des.FieldType == mi.FieldType)
                    {
                        if (checkNull)
                        {
                            if (mi.GetValue(source) != null && mi.GetValue(source).ToString().Trim().Length>0)
                            {
                                des.SetValue(destination, mi.GetValue(source));
                            }
                        }
                        else
                        {
                            if (mi.GetValue(destination) == null && mi.GetValue(destination).ToString().Trim().Length >= 0)
                            {
                                des.SetValue(destination, mi.GetValue(source));
                            }
                        }
                        i++;
                    }

                }
                catch
                {
                }
            }

            foreach (PropertyInfo pi in type.GetProperties())
            {
                if (excludeName.Contains(pi.Name))
                {
                    continue;
                }
                try
                {
                    PropertyInfo des = desType.GetProperty(pi.Name);
                    if (des != null && des.PropertyType == pi.PropertyType && des.CanWrite && pi.CanRead)
                    {
                        if (checkNull)
                        {
                            //如果null就不用赋值 了
                            if (pi.GetValue(source, null) != null && pi.GetValue(source, null).ToString().Trim().Length > 0)
                            {
                                des.SetValue(destination, pi.GetValue(source, null), null);
                            }
                        }
                        else
                        {
                            des.SetValue(destination, pi.GetValue(source, null), null);
                        }

                        i++;
                    }

                }
                catch
                {
                    //throw ex;
                }
            }
            return i;
        }
    }


}
