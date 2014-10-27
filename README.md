Social Shares
========================

# Social Shares
Social Shares is a .net library to get an url's share count most popular 10 social network services.
To install Social Shares, run the following command in the Package Manager Console <br />
<code>PM&gt; Install-Package SocialShares</code>
or Download Project and add reference SocialShares.dll on your project.
# Depencies
You must add Json.net(v 6.0 or Higher) references on your project
To install Json.NET, run the following command in the Package Manager Console<br>
<pre>Install-Package InstagramCSharpSDK</pre><br>
if you've already instaled (lower than 6.0) run this. command.
<pre>Update-Package Newtonsoft.Json</pre>

# Social Networks
+  [Facebook](http://facebook.com)
+  [Twitter](http://twitter.com)
+  [VKontakte](http://vk.com)
+  [Google+](http://plus.google.com)
+  [Linkedin](https://www.linkedin.com)
+  [Reddit](http://www.reddit.com)
+  [Pinterest](http://www.pinterest.com)
+  [mail.ru](http://mail.ru)
+  [Stumbleupon](http://www.stumbleupon.com)
+  [Odnoklassniki](http://www.odnoklassniki.ru)

# Usage
Get single service result<br />
<code>
          var shareResult = Facebook.GetShares(url);
          string result = String.Format("Your Link {0} , published {1} times on {2}", shareResult.url, shareResult.count, shareResult.SocialNetwork);
</code>
<br />
Get multiple service result<br />
<code>
	  List<SocialNetworks> socialNetworks = new List<SocialNetworks>();
          socialNetworks.Add(SocialNetworks.Facebook);
          socialNetworks.Add(SocialNetworks.Twitter);
          socialNetworks.Add(SocialNetworks.Vk);
          SocialShare s = new SocialShare();
          var results=  s.GetUrlsShares(url,socialNetworks);
          foreach (var item in results)
          {
             string result = String.Format("Your Link {0} , published {1} times on {2}", item.url, item.count, item.SocialNetwork);
          }
</code>
Get All Result<br />
<code>
	 
          SocialShare s = new SocialShare();
          var results=  s.GetAll(url);
          foreach (var item in results)
          {
             string result = String.Format("Your Link {0} , published {1} times on {2}", item.url, item.count, item.SocialNetwork);
          }
</code>
<br />
Keep Development Alive PayPal cagri058@hotmail.com
