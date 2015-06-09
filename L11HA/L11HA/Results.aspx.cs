using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace HA11
{
    public partial class Results : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string displayOutput = (string) (Session["FirstName"] + " " + Session["LastName"] + ": " +
                                   Session["BirthDate"]);
            
            TextBox1.Text = displayOutput;
        }
    }
}