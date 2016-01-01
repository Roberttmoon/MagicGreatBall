using MagicGreatBall;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TweetControler
{
    class Program
    {
        static void Main(string[] args)
        {
            TwitterSearch search = new TwitterSearch();
            search.Searcher();
            Console.ReadLine();
        }
    }
}
