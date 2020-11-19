using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using YiSha.Cache.Factory;
using YiSha.Entity.SmsManage;
using YiSha.Util;

namespace YiSha.Business.Cache
{
    /// <summary>
    /// 短信验证码缓存对象
    /// </summary>
    public class SmsCodeCache : BaseBusinessCache<SmsCodeEntity>
    {
        public override string CacheKey => this.GetType().Name;

        public override async Task<List<SmsCodeEntity>> GetList()
        {
            var cacheList = CacheFactory.Cache.GetCache<List<SmsCodeEntity>>(CacheKey);
            return cacheList;
        }


        #region  Method
        /// <summary>
        /// 保存验证码
        /// </summary>
        /// <param name="phone">手机号</param>
        /// <returns></returns>
        public bool SaveSmsCode(string phone,string code)
        {
            SmsCodeEntity sms = new SmsCodeEntity();
            sms.id = CoomHelper.CreateNewOrderNo();
            sms.mobile_phone = phone;
            sms.sms_code = code;
            sms.create_time = DateTime.Now;
            bool isok = CacheFactory.Cache.SetCache<SmsCodeEntity>(phone, sms, DateTime.Now.AddMinutes(2));
            return isok;
        }
        /// <summary>
        /// 校验短信 是否过期
        /// </summary>
        /// <param name="phone">手机号</param>
        /// <param name="code">短信验证码</param>
        /// <returns></returns>
        public bool CheckSmsCode(string phone, string code, ref string msg)
        {
            bool isok = false;

            #region 校验开始
            if (!string.IsNullOrEmpty(code))
            {
                if (code.Length == 6)
                {
                    SmsCodeEntity sms_code = CacheFactory.Cache.GetCache<SmsCodeEntity>(phone);
                    if (sms_code != null && !string.IsNullOrEmpty(sms_code.sms_code))
                    {
                        if (sms_code.sms_code != code)
                        {
                            msg = "短信验证码过期";
                        }
                        else
                        {
                            isok = true;
                            msg = "短信验证码正确";
                        }
                    }
                    else
                    {
                        msg = "短信验证码错误";
                    }
                }
                else
                {
                    msg = "短信验证码长度为6位";
                }
            }
            else
            {
                msg = "短信验证码不为空";
            }

            #endregion
            return isok;
        }


        #endregion
    }
}
