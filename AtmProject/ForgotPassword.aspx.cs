using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Reflection.Emit;
using System.Configuration;
using System.Drawing;
using System.Net.Mail;
using System.Net;
using System.Collections;

namespace AtmProject
{
    public partial class ForgotPassword : System.Web.UI.Page
    {
      string strConnString=(@"Data Source=JAIKUMAR\SQLEXPRESS;Initial Catalog=Jaiatmproject1;Integrated Security=True");
       

        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("LogIn.aspx");
        }
        protected void Button1_Click(object sender, EventArgs e)
        {

           using( SqlConnection con = new SqlConnection(strConnString))
            {
                con.Open();
                SqlCommand com = new SqlCommand("update_tbl_customer_master", con);
  
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@security_questions_code", DropDownList1.Text);
                com.Parameters.AddWithValue("@security_answer_code", txtanswer.Text);
                com.Parameters.AddWithValue("@customer_mobile", txtmobileno.Text);
                com.Parameters.AddWithValue("@login_password", txtpassword.Text);
                com.ExecuteNonQuery();
                con.Close();
               // Response.Redirect("LogIn.aspx");
                lblmsg.Text="Password reset successfully";

            }


         
        }

        protected void SqlDataSource1_Selecting(object sender, SqlDataSourceSelectingEventArgs e)
        {

        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("https://www.google.com/search?q=xpay+life&rlz=1C1CHBF_enIN1015IN1015&oq=xpay+life&aqs=chrome.0.69i59l2j0i512l3j46i175i199i512j0i512j69i60.3738j0j7&sourceid=chrome&ie=UTF-8");
        }
    }
    }
    
