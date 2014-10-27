using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SocialShares.Model
{
    public static class Mailru
    {
        public static ShareResult GetShares(string url)
        {
            string apiUrl = string.Format("{0}{1}", "http://appsmail.ru/share/count/", url);
            string result = GetResultData.GetResult(apiUrl);
            ShareResult sr = new ShareResult();
            var o = JObject.Parse(result);
            sr.url = url;
            sr.count = Convert.ToInt64(o.SelectToken("share_mm"));
            sr.SocialNetwork = "Mail.ru";
            return sr;
        }
    }
}
