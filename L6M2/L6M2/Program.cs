using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L6M2
{
    class Program
    {
        static void Main(string[] args)
        {
            NewsTicker tick = new NewsTicker();
            tick.News += NewsTicker_news;

            Console.ReadLine();
        }

        
        static void NewsTicker_news(object sender, NewsEventArgs args)
        {
            Console.WriteLine(args.Text);
        }
    }
}
