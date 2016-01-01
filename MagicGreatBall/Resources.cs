using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicGreatBall
{
    public class Resources
    {
        List<string> searchTerms;
        List<string> responces;

        public Resources()
        {
            searchTerms = new List<string>()
            {
                "why",
                "will i",
                "how come",
                "i wish",
                "could i",
                "I'd Like"
            };
            responces = new List<string>()
            {
                "It is certain",
                "It is decidedly so",
                "Without a doubt",
                "Yes, definitely",
                "You may rely on it",
                "As I see it, yes",
                "Most likely",
                "Outlook good",
                "Yes",
                "Signs point to yes",
                "Reply hazy try again",
                "Ask again later",
                "Better not tell you now",
                "Cannot predict now",
                "Concentrate and ask again",
                "Don't count on it",
                "My reply is no",
                "My sources say no",
                "Outlook not so good",
                "Very doubtful"
            };
        }
        public string MakeResponce()
        {
            string choice;
            Random rnd = new Random();
            choice = responces[rnd.Next(responces.Count)];
            return choice;
        }
        public string MakeSearchTerm()
        {
            string search;
            Random rnd = new Random();
            search = searchTerms[rnd.Next(searchTerms.Count)];
            return search;
        }
    }
}
