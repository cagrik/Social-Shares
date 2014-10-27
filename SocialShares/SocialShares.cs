using Newtonsoft.Json.Linq;
using SocialShares.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;

namespace SocialShares
{
  public  class SocialShare
    {

    
    
   
      public List<ShareResult> GetUrlsShares(string url,List<SocialNetworks> networks) {
          List<ShareResult> shareResults = new List<ShareResult>();
          ShareResult sr;
          foreach (var item in networks)
          {
              sr = new ShareResult();
              switch (item)
              {
                  case SocialNetworks.Facebook:
                      sr = Facebook.GetShares(url);
                      break;
                  case SocialNetworks.Twitter:
                      sr = Twitter.GetShares(url);
                      break;
                  case SocialNetworks.Vk:
                      sr = VKontakte.GetShares(url);
                      break;
                  case SocialNetworks.Linkedin:
                      sr = Linkedin.GetShares(url);
                      break;
                  case SocialNetworks.Mailru:
                      sr = Mailru.GetShares(url);
                      break;
                  case SocialNetworks.Pinterest:
                      sr = Pinterest.GetShares(url);
                      break;
                  case SocialNetworks.Odnoklassniki:
                      sr = Odnoklassniki.GetShares(url);
                      break;
                  case SocialNetworks.Reddit:
                      sr = Reddit.GetShares(url);
                      break;
                  case SocialNetworks.Stumbleupon:
                      sr = Stumbleupon.GetShares(url);
                      break;
                  case SocialNetworks.Google:
                      sr = Google.GetShares(url);
                      break;
              }
              shareResults.Add(sr);
          }
          return shareResults;
      }
      public List<ShareResult> GetAll(string url) {
          List<ShareResult> shareResults = new List<ShareResult>();
          shareResults.Add(Facebook.GetShares(url));
          shareResults.Add(Twitter.GetShares(url));
          shareResults.Add(VKontakte.GetShares(url));
          shareResults.Add(Linkedin.GetShares(url));
          shareResults.Add(Mailru.GetShares(url));
          shareResults.Add(Pinterest.GetShares(url));
          shareResults.Add(Odnoklassniki.GetShares(url));
          shareResults.Add(Reddit.GetShares(url));
          shareResults.Add(Stumbleupon.GetShares(url));
          shareResults.Add(Google.GetShares(url));


          return shareResults;
      }
    }
    public enum SocialNetworks
    {
        Facebook,
        Twitter,
        Vk,
        Linkedin,
        Mailru,
        Pinterest,
        Odnoklassniki,
        Reddit,
        Stumbleupon,
        Google
    }
}
