using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace L6M2
{
    class NewsEventArgs : EventArgs
    {
        public string Text { get; set; }

        public NewsEventArgs(string text)
        {
            Text = text;
        }
    }
}
