using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L6M2
{
    class NewsTicker
    {
        public delegate void NewsHandler(object sender, NewsEventArgs args);

        public event NewsHandler News;

        protected virtual void OnNews(object sender, NewsEventArgs args)
        {
            //if delegate is registred for this event
            if (this.News != null)
            {
                this.News(sender, args);
            }
        }
    }
}
