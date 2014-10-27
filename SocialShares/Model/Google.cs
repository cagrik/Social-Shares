using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SocialShares.Model
{
   public static class Google
    {
       public static ShareResult GetShares(string url) {
         var result=  GetResultData.GetGoogleResult(url);
         ShareResult sr = new ShareResult();
         var o = JObject.Parse(result);
         sr.count = Convert.ToInt64(o.SelectToken("result.metadata.globalCounts.count"));
         sr.url = Convert.ToString(o.SelectToken("result.id"));
         sr.SocialNetwork = "Google";
         return sr;
       
       }
    }
}
