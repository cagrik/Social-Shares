using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SocialShares.Model
{
   public static class Reddit
    {
       public static ShareResult GetShares(string url)
       {
           string apiUrl = string.Format("{0}{1}", "http://www.reddit.com/api/info.json?url=", url);
           string result = GetResultData.GetResult(apiUrl);
           ShareResult sr = new ShareResult();
           var o = JObject.Parse(result);
           var t = o.SelectToken("data.children[0].data.score");
           sr.url = url;
           sr.count = Convert.ToInt64(t);
           sr.SocialNetwork = "Reddit";
           return sr;
       }
    }
}
