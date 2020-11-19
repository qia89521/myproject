using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using YiSha.Business.Cache;
using YiSha.Util;
using YiSha.Util.Model;

namespace YiSha.Business.SmsManage
{
    /// <summary>
    /// 发送短信
    /// </summary>
    public class SmsCodeBLL
    {
        SmsCodeCache cache = new SmsCodeCache();
        /// <summary>
        /// 发送短信验证码
        /// </summary>
        /// <param name="phone">手机号</param>
        public async Task<TData<string>> SentSms(string phone)
        {
            TData<string> obj = new TData<string>();
            obj.SetDefault();
            #region 组装参数
            string PostUrl = "http://sms.253.com/msg/send";
            string un = "N3196661";
            string pw = "1yj0IsLdQD5105";
            string code = CoomHelper.CreateRandomWordOrNum(6, "0");
            string content = "【普沃森】短信验证码是：" + code + "，2分钟内有效。全球清水净化洗涤开创者！";
            string postStrTpl = "un={0}&pw={1}&phone={2}&msg={3}&rd=1";


            UTF8Encoding encoding = new UTF8Encoding();
            byte[] postData = encoding.GetBytes(string.Format(postStrTpl, un, pw, phone, content));

            HttpWebRequest myRequest = HttpWebRequest.Create(PostUrl) as HttpWebRequest;
            myRequest.KeepAlive = false;
            myRequest.Method = "POST";
            myRequest.ContentType = "application/x-www-form-urlencoded";
            myRequest.ContentLength = postData.Length;
            myRequest.Timeout = 5000;
            #endregion

            using (Stream newStream = myRequest.GetRequestStream())
            {
                await  newStream.WriteAsync(postData, 0, postData.Length);

            }
            using (HttpWebResponse myResponse =(HttpWebResponse)myRequest.GetResponse())
            {
                if (myResponse.StatusCode == HttpStatusCode.OK)
                {
                    StreamReader reader = new StreamReader(myResponse.GetResponseStream(), Encoding.UTF8);
                    string res_msg = await reader.ReadToEndAsync();
                    LogHelper.Info("【SentSms】："+ res_msg);
                    bool isok= cache.SaveSmsCode(phone,code);
                    if (isok)
                    {
                        obj.Tag = 1;
                        obj.Message = "发送成功";
                        obj.Refresh();
                    }
                    else
                    {
                        obj.Message = "发送失败";
                    }
                }
            }
            return obj;
        }

       /// <summary>
       /// 校验短信验证码
       /// </summary>
       /// <param name="phone">手机号</param>
       /// <param name="code">短信验证码</param>
       /// <returns></returns>
        public TData<string> CheckSms(string phone,string code)
        {
            TData<string> obj = new TData<string>();
            obj.SetDefault();
            string msg = "";
            bool isok = cache.CheckSmsCode(phone,code,ref msg);

            obj.Message = msg;
            if (isok)
            {
                obj.Tag = 1;
                obj.Refresh();
            }
            return obj;
        }
    }
}
