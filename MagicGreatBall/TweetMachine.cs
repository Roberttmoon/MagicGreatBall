using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TweetSharp;

namespace MagicGreatBall
{
    public class TweetMachine
    {
        TwitterService twitterService;
        TwitterSearch twitterSearch;
        Resources resources;
        Random rnd;
        int thirtySeconds = 30000;
        int twoMinutes = 120000;
        int fourHours = 14400000;
        int eightHours = 28800000;
        public TweetMachine()
        {
            twitterSearch = new TwitterSearch();
            twitterService = new TwitterService();
            resources = new Resources();
            rnd = new Random();
        }
        public void TweetMaker()
        {
            while (true)
            {
                int choiceCheck = rnd.Next(1, 10);
                if (choiceCheck < 8)
                {
                    int sleeptime = rnd.Next(thirtySeconds, twoMinutes);
                    Console.WriteLine("shaking 8ball" + sleeptime);
                    ShakeEightBall();
                    System.Threading.Thread.Sleep(sleeptime);
                }
                else {
                    int restTime = rnd.Next(fourHours, eightHours);
                    Console.WriteLine("sleeping 5ever: " + restTime);
                    System.Threading.Thread.Sleep(restTime);
                }
            }
        }
        public void ShakeEightBall()
        {
            twitterService.AuthenticateWith(SecretKeys.consumerKey, SecretKeys.consumerSecretKey, SecretKeys.accessToken, SecretKeys.accessSecretToken);
            twitterSearch.Searcher(rnd, twitterService, resources);
        }
    }
}
