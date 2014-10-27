using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SocialShares.Model
{
  public static  class Stumbleupon
    {
        public static ShareResult GetShares(string url)
        {
            string apiUrl = string.Format("{0}{1}", "http://www.stumbleupon.com/services/1.01/badge.getinfo?url=", url);
            string result = GetResultData.GetResult(apiUrl);
            ShareResult sr = new ShareResult();
            var o = JObject.Parse(result);
            var t = o.SelectToken("result");
            sr.url = Convert.ToString(t.SelectToken("url"));
            sr.count = Convert.ToInt64(t.SelectToken("views"));
            sr.SocialNetwork = "Stumbleupon";
            return sr;
        }
    }
}
