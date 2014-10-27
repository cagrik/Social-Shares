using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SocialShares.Model
{
    public static class Facebook
    {
        public static ShareResult GetShares(string url)
        {
            string apiUrl = string.Format("{0}{1}", "http://graph.facebook.com/?id=", url);
            string result = GetResultData.GetResult(apiUrl);
            ShareResult sr = new ShareResult();
            var o = JObject.Parse(result);
           sr.url= Convert.ToString(o.SelectToken("id"));
           sr.count = Convert.ToInt64(o.SelectToken("shares"));
           sr.SocialNetwork = "Facebook";
           return sr;
        }
    }
}
