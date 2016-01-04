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
        public void Tweet(TwitterService twitterService, string msg, long tweetID)
        {
            TwitterStatus result = twitterService.SendTweet(new SendTweetOptions{Status = msg, InReplyToStatusId = tweetID});
        }
    }
}
