using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SocialShares.Model
{
    public static class Pinterest
    {
        public static ShareResult GetShares(string url)
        {
            string apiUrl = string.Format("{0}{1}", "http://api.pinterest.com/v1/urls/count.json?url=", url);
            string result = GetResultData.GetResult(apiUrl);
            ShareResult sr = new ShareResult();
            result = result.Replace("receiveCount(", "");
            result = result.Replace(")","");
            var o = JObject.Parse(result);
            sr.url = Convert.ToString(o.SelectToken("url"));
            sr.count = Convert.ToInt64(o.SelectToken("count"));
            sr.SocialNetwork = "Pinterest";
            return sr;
        }
    }
}
