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
            TweetMachine tweeter = new TweetMachine();
            tweeter.TweetMaker();
        }
    }
}
