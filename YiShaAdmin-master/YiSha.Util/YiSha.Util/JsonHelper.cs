using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using YiSha.Util.Extension;

namespace YiSha.Util
{
    #region JsonHelper
    public static class JsonHelper
    {
        public static T ToObject<T>(this string Json)
        {
            Json = Json.Replace("&nbsp;", "");
            return Json == null ? default(T) : JsonConvert.DeserializeObject<T>(Json);
        }

        public static JObject ToJObject(this string Json)
        {
            return Json == null ? JObject.Parse("{}") : JObject.Parse(Json.Replace("&nbsp;", ""));
        }

        /// <summary>
        /// 将对象序列化为JSON格式
        /// </summary>
        /// <param name="o">对象</param>
        /// <returns>json字符串</returns>
        public static string SerializeObject(object o)
        {
            string json = JsonConvert.SerializeObject(o);
            return json;
        }



        /// <summary>
        /// 解析JSON字符串生成对象实体
        /// </summary>
        /// <typeparam name="T">对象类型</typeparam>
        /// <param name="json">json字符串(eg.{"ID":"112","Name":"石子儿"})</param>
        /// <returns>对象实体</returns>
        public static T JsonConvertObject<T>(string json) where T : class
        {
            JsonSerializer serializer = new JsonSerializer();
            StringReader sr = new StringReader(json);
            object o = serializer.Deserialize(new JsonTextReader(sr), typeof(T));
            T t = o as T;
            return t;
        }

        /// <summary>
        /// 解析JSON数组生成对象实体集合
        /// </summary>
        /// <typeparam name="T">对象类型</typeparam>
        /// <param name="json">json数组字符串(eg.[{"ID":"112","Name":"石子儿"}])</param>
        /// <returns>对象实体集合</returns>
        public static List<T> JsonConverToList<T>(string json) where T : class
        {
            try
            {
                List<T> list = new List<T>();

                JArray groupjarray = (JArray)JsonConvert.DeserializeObject(json);
                foreach (JToken joten in groupjarray)
                {
                    T t = JokenToEntity<T>(joten);
                    list.Add(t);
                }

                //JsonSerializer serializer = new JsonSerializer();
                //StringReader sr = new StringReader(json);
                //object o = serializer.Deserialize(new JsonTextReader(sr), typeof(List<T>));
                return list;
            }
            catch (Exception ex)
            {
                return new List<T>();
            }

        }

        /// <summary>
        /// 反序列化JSON到给定的匿名对象.
        /// </summary>
        /// <typeparam name="T">匿名对象类型</typeparam>
        /// <param name="json">json字符串</param>
        /// <param name="anonymousTypeObject">匿名对象</param>
        /// <returns>匿名对象</returns>
        public static T DeserializeAnonymousType<T>(string json, T anonymousTypeObject)
        {
            T t = JsonConvert.DeserializeAnonymousType(json, anonymousTypeObject);
            return t;
        }

        /// <summary>
        /// 将joken转成实体信息
        /// </summary>
        /// <typeparam name="T">T类型</typeparam>
        /// <param name="joten">joten 数据信息</param>
        /// <returns>返回T类型</returns>
        public static T JokenToEntity<T>(JToken joten)
        {
            Type t = typeof(T);
            T entity = (T)Activator.CreateInstance(t);
            PropertyInfo[] pi = t.GetProperties();
            foreach (PropertyInfo p in pi)
            {
                if (joten[p.Name] != null)
                {
                    string value = joten[p.Name].ToString();//.Replace("\"", "");
                    if (!string.IsNullOrEmpty(value))
                    {
                        if (!value.StartsWith("\"[{") && value.StartsWith("\""))
                        {
                            value = value.Substring(1, value.Length - 2);
                        }
                    }
                    object obj = GetTypeValue(value, p.PropertyType);
                    p.SetValue(entity, obj, null);
                }
            }
            return entity;
        }

        /// <summary>
        /// 设置值
        /// </summary>
        /// <param name="value">原始值</param>
        /// <param name="colType">类型</param>
        /// <returns></returns>
        private static object GetTypeValue(string value, Type colType)
        {

            if (colType == typeof(Int32))
            {
                int result = 0;
                if (string.IsNullOrEmpty(value))
                {
                    result = 0;
                }
                else
                {
                    int.TryParse(value, out result);
                }
                return result;
            }
            if (colType == typeof(String))
                return string.IsNullOrEmpty(value) ? string.Empty : value;
            if (colType == typeof(DateTime))
            {
                if (string.IsNullOrEmpty(value))
                {
                    return DateTime.Now;
                }
                else
                {
                    DateTime time = DateTime.Now;
                    DateTime.TryParse(value, out time);
                    return time;
                }
            }
            if (colType == typeof(Boolean))
                return string.IsNullOrEmpty(value) ? false : Convert.ToBoolean(value);
            if (colType == typeof(Guid))
                return string.IsNullOrEmpty(value) ? Guid.Empty : Guid.Parse(value);
            if (colType == typeof(Int16))
            {
                int result = 0;
                if (string.IsNullOrEmpty(value))
                {
                    result = 0;
                }
                else
                {
                    int.TryParse(value, out result);
                }
                return result;
            }
            if (colType == typeof(float))
            {
                float result = 0;
                if (string.IsNullOrEmpty(value))
                {
                    result = 0;
                }
                else
                {
                    float.TryParse(value, out result);
                }
                return result;
            }
            return string.IsNullOrEmpty(value) ? null : value;
        }

    }
    #endregion

    #region JsonConverter
    /// <summary>
    /// Json数据返回到前端js的时候，把数值很大的long类型转成字符串
    /// </summary>
    public class StringJsonConverter : JsonConverter
    {
        /// <summary>
        /// 转换成字符串的类型
        /// </summary>
        private readonly NumberConverterShip _ship;

        /// <summary>
        /// 大数据json序列化重写实例化
        /// </summary>
        public StringJsonConverter()
        {
            _ship = (NumberConverterShip)0xFF;
        }

        /// <summary>
        /// 大数据json序列化重写实例化
        /// </summary>
        /// <param name="ship">转换成字符串的类型</param>
        public StringJsonConverter(NumberConverterShip ship)
        {
            _ship = ship;
        }

        /// <inheritdoc />
        /// <summary>
        /// 确定此实例是否可以转换指定的对象类型。
        /// </summary>
        /// <param name="objectType">对象的类型。</param>
        /// <returns>如果此实例可以转换指定的对象类型，则为：<c>true</c>，否则为：<c>false</c></returns>
        public override bool CanConvert(Type objectType)
        {
            var typecode = Type.GetTypeCode(objectType.Name.Equals("Nullable`1") ? objectType.GetGenericArguments().First() : objectType);
            switch (typecode)
            {
                case TypeCode.Decimal:
                    return (_ship & NumberConverterShip.Decimal) == NumberConverterShip.Decimal;
                case TypeCode.Double:
                    return (_ship & NumberConverterShip.Double) == NumberConverterShip.Double;
                case TypeCode.Int64:
                    return (_ship & NumberConverterShip.Int64) == NumberConverterShip.Int64;
                case TypeCode.UInt64:
                    return (_ship & NumberConverterShip.UInt64) == NumberConverterShip.UInt64;
                case TypeCode.Single:
                    return (_ship & NumberConverterShip.Single) == NumberConverterShip.Single;
                    return (_ship & NumberConverterShip.Single) == NumberConverterShip.Single;
                default: return false;
            }
        }

        /// <inheritdoc />
        /// <summary>
        /// 读取对象的JSON表示。
        /// </summary>
        /// <param name="reader">从 <see cref="T:Newtonsoft.Json.JsonReader" /> 中读取。</param>
        /// <param name="objectType">对象的类型。</param>
        /// <param name="existingValue">正在读取的对象的现有值。</param>
        /// <param name="serializer">调用的序列化器实例。</param>
        /// <returns>对象值。</returns>
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            return AsType(reader.Value.ToString(), objectType);
        }

        /// <summary>
        /// 字符串格式数据转其他类型数据
        /// </summary>
        /// <param name="input">输入的字符串</param>
        /// <param name="destinationType">目标格式</param>
        /// <returns>转换结果</returns>
        public static object AsType(string input, Type destinationType)
        {
            try
            {
                var converter = TypeDescriptor.GetConverter(destinationType);
                if (converter.CanConvertFrom(typeof(string)))
                {
                    return converter.ConvertFrom(null, null, input);
                }

                converter = TypeDescriptor.GetConverter(typeof(string));
                if (converter.CanConvertTo(destinationType))
                {
                    return converter.ConvertTo(null, null, input, destinationType);
                }
            }
            catch
            {
                return null;
            }
            return null;
        }

        /// <inheritdoc />
        /// <summary>
        /// 写入对象的JSON表示形式。
        /// </summary>
        /// <param name="writer">要写入的 <see cref="T:Newtonsoft.Json.JsonWriter" /> 。</param>
        /// <param name="value">要写入对象值</param>
        /// <param name="serializer">调用的序列化器实例。</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            if (value == null)
            {
                writer.WriteNull();
            }
            else
            {
                var objectType = value.GetType();
                var typeCode = Type.GetTypeCode(objectType.Name.Equals("Nullable`1") ? objectType.GetGenericArguments().First() : objectType);
                switch (typeCode)
                {
                    case TypeCode.Decimal:
                        writer.WriteValue(((decimal)value).ToString("f6"));
                        break;
                    case TypeCode.Double:
                        writer.WriteValue(((double)value).ToString("f4"));
                        break;
                    case TypeCode.Single:
                        writer.WriteValue(((float)value).ToString("f2"));
                        break;
                    default:
                        writer.WriteValue(value.ToString());
                        break;
                }
            }
        }
    }

    /// <summary>
    /// 转换成字符串的类型
    /// </summary>
    [Flags]
    public enum NumberConverterShip
    {
     
        /// <summary>
        /// 长整数
        /// </summary>
        Int64 = 1,

        /// <summary>
        /// 无符号长整数
        /// </summary>
        UInt64 = 2,
       
        /// <summary>
        /// 浮点数
        /// </summary>
        Single = 4,

        /// <summary>
        /// 双精度浮点数
        /// </summary>
        Double = 8,

        /// <summary>
        /// 大数字
        /// </summary>
        Decimal = 16,

       
    }

    /// <summary>
    /// DateTime类型序列化的时候，转成指定的格式
    /// </summary>
    public class DateTimeJsonConverter : JsonConverter
    {
        public DateTimeJsonConverter() { }

        public override bool CanConvert(Type objectType)
        {
            return true;
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            return reader.Value.ParseToString().ParseToDateTime();
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            DateTime? dt = value as DateTime?;
            if (dt == null)
            {
                writer.WriteNull();
                return;
            }
            writer.WriteValue(dt.Value.ToString("yyyy-MM-dd HH:mm:ss"));
        }
    }
    #endregion
}
