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
        public void Searcher(Random rnd, TwitterService service, Resources resources)
        {

            Tweeter tweeter = new Tweeter();
            service.AuthenticateWith(SecretKeys.accessToken, SecretKeys.accessSecretToken);
            SearchOptions options = new SearchOptions { Q = resources.MakeSearchTerm(rnd), Count = 1};

            var tweets = service.Search(options);
            foreach (var tweet in tweets.Statuses)
            {
                string msg = string.Format("@{0}, {1}", tweet.User.ScreenName, resources.MakeResponce(rnd));
                tweeter.Tweet(service, msg, tweet.Id);
            }
        }
    }
}
