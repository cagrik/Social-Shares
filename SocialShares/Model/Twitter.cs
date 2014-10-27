using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SocialShares.Model
{
    public static class Twitter
    {
        public static ShareResult GetShares(string url)
        {
            string apiUrl = string.Format("{0}{1}", "https://cdn.api.twitter.com/1/urls/count.json?url=", url);
            string result = GetResultData.GetResult(apiUrl);
            ShareResult sr = new ShareResult();
            var o = JObject.Parse(result);
            sr.url = Convert.ToString(o.SelectToken("url"));
            sr.count = Convert.ToInt64(o.SelectToken("count"));
            sr.SocialNetwork = "Twitter";
            return sr;
        }
    }
}
