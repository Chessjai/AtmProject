using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AtmProject
{
    public partial class Options : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                if (Session["customer_fname"] != null)
                {

                    Label6.Text = "your name is:"+(string)Session["customer_fname"];
                }
                else
                {

                    Response.Redirect("LogIn.aspx");
                }
            }


        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Session.Clear();
            Response.Cookies.Clear();
            Response.Redirect("LogIn.aspx");

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
            Response.Redirect("Withdraw.aspx");
           // label1.Text = (string)Session["UserName"];
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Deposit.aspx");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("passbook.aspx");
        }
    }
}