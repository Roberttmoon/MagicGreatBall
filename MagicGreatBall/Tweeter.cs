using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TweetSharp;

namespace MagicGreatBall
{
    public class Tweeter
    {
        public void Tweet(string msg)
        {
            var twiterService = new TwitterService(SecretKeys.consumerKey, SecretKeys.consumerSecretKey);
            twiterService.AuthenticateWith(SecretKeys.accessToken, SecretKeys.accessSecretToken);
            TwitterStatus result = twiterService.SendTweet(new SendTweetOptions
            {
                Status = msg
            });
        }
    }
}
