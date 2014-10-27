using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace SocialShares.Model
{
    public static class VKontakte
    {
        public static ShareResult GetShares(string url)
        {
            string apiUrl = string.Format("{0}{1}", "http://vk.com/share.php?act=count&index=1&url=", url);
            string result = GetResultData.GetResult(apiUrl);
            ShareResult sr = new ShareResult();
            Regex r = new Regex("VK\\.Share\\.count\\(\\d, (\\d+)\\);");
            var c = r.Match(result);
            sr.count = Convert.ToInt64(c.Groups[1].Value);
            sr.url = url;
            sr.SocialNetwork = "VKontakte";
            return sr;
        }
    }
}
