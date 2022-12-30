using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace AtmProject
{
    public partial class Registration : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=JAIKUMAR\SQLEXPRESS;Initial Catalog=Jaiatmproject1;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
           
        }

        protected void btnReg_Click(object sender, EventArgs e)
        {
            SqlCommand com = con.CreateCommand();
            com.CommandText = "insert into tbl_customer_master(customer_fname,customer_lname,customer_mobile,customer_email,customer_address,account_no,security_questions_code,security_answer_code,login_password) values " +
                "('" + txFirstName.Text + "','"+txtLastName.Text+"','"+txtMobile.Text+"'," +
                "'"+txtEmail.Text+"','"+txtAddress.Text+"','"+txtaccountno.Text+"','"+DropDownList1.Text+"','"+txtSecurityAnswer.Text+"','"+txtpassword.Text+"')";
           int k= com.ExecuteNonQuery();
            Label11.Text = "Registered Successfully";
            //if (k>0)
            //{
               
            //Response.Redirect("LogIn.aspx");
            //}
            


        }

        protected void btnback_Click(object sender, EventArgs e)
        {
            Response.Redirect("LogIn.aspx");
        }

        protected void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void txtLastName_TextChanged(object sender, EventArgs e)
        {

        }

        protected void txFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("LogIn.aspx");
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("https://www.google.com/search?q=xpay+life&rlz=1C1CHBF_enIN1015IN1015&oq=xpay+life&aqs=chrome.0.69i59l2j0i512l3j46i175i199i512j0i512j69i60.3738j0j7&sourceid=chrome&ie=UTF-8");
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            Response.Redirect("Registration.aspx");
        }
    }
}