using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HA11
{
    public partial class Input : System.Web.UI.Page
    {


        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            Session["FirstName"] = FirstnameTextbox.Text;
            Session["LastName"] = LastnameTextbox.Text;
            Session["BirthDate"] = BirthdateTextbox.Text;

            Context.Response.Redirect("Results.aspx");

        }
    }
}