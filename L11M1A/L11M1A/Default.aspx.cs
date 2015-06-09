using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace L11M1A
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SubmitClick(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TextBox1.Text))
            {
                throw new NotImplementedException("This app can't handle an empty TextBox");
            }

            var sb = new StringBuilder();
            sb.Append(TextBox1.Text);
            sb.Append(" - ");
            sb.Append(DateTime.Now);
            sb.Append(" Desiree Sacher");

            Label1.Text = sb.ToString();
        }
    }
}