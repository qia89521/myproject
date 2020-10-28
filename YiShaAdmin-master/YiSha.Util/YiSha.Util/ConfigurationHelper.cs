using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace YiSha.Util
{
    /// <summary>
    /// 配置读取帮助类
    /// </summary>
    public static class ConfigurationHelper
    {
        private static IConfiguration _config;
        public static void Configure(IConfiguration config)
        {
            _config = config;
        }
        /// <summary>
        /// 根据配置文件键读取对应的值
        /// </summary>
        /// <param name="Key"></param>
        /// <returns></returns>
        public static string GetConfigValueByKey(string Key)
        {
            var value = _config[Key];
            return value;
        }
    }
}
