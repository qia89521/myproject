using System;
using System.Collections.Generic;
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
        public StringJsonConverter() { }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            return reader.Value.ParseToLong();
        }

        public override bool CanConvert(Type objectType)
        {
            return true;
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            string sValue = value.ToString();
            writer.WriteValue(sValue);
        }
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
