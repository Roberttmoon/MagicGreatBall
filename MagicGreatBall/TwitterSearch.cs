using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TweetSharp;

namespace MagicGreatBall
{
    public class TwitterSearch
    {
        public void Searcher()
        {
            Resources resources = new Resources();
            var service = new TwitterService(SecretKeys.consumerKey, SecretKeys.consumerSecretKey);
            service.AuthenticateWith(SecretKeys.accessToken, SecretKeys.accessSecretToken);
            var options = new SearchOptions { Q = resources.MakeSearchTerm() };

            var tweets = service.Search(options);

            foreach (var tweet in tweets.Statuses)
            {
                Console.WriteLine("{0} says '{1}'", tweet.User.ScreenName, tweet.Text);
            }
        }
    }
}
