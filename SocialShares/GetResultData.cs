using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;

namespace SocialShares
{
    public static class GetResultData
    {
        public static string GetResult(string url) {

            var client = new HttpClient();
            var rslt = client.GetAsync(url).Result;
            var result = rslt.Content.ReadAsStringAsync().Result;
            return result;
        }
        public static string GetGoogleResult(string url) {
            var client = new HttpClient();
            string apiUrl = "https://clients6.google.com/rpc?key=AIzaSyCKSbrvQasunBoV16zDH9R33D88CeLr9gQ";
           HttpContent hc = new StringContent("{\"method\":\"pos.plusones.get\",\"id\":\"p\",\"jsonrpc\":\"2.0\",\"key\":\"p\",\"apiVersion\":\"v1\",\"params\":{\"nolog\":true,\"id\":\""+url+"\",\"source\":\"widget\",\"userId\":\"@viewer\",\"groupId\":\"@self\"}}", Encoding.UTF8, "application/json");
           client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            var rslt = client.PostAsync(apiUrl, hc).Result;
            var result = rslt.Content.ReadAsStringAsync().Result;
            return result;
        }
    }
}
