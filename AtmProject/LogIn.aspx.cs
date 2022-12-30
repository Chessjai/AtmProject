using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
namespace AtmProject
{
    public partial class LogIn : System.Web.UI.Page
    {
        //string connectionString=(@"Data Source=ABHISHEK-SUTRAD\SQLEXPRESS;Initial Catalog=jaiatmproject1;Integrated Security=True;Database=jaiatmproject1");

        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader rd;
        protected void Page_Load(object sender, EventArgs e)
        {
          
            Label3.Visible=false;
            Session.Timeout=2;
        }

        protected void Button1_Click(object sender, EventArgs e)

        {
             con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["jaiatmproject1ConnectionString"].ConnectionString);
            //Label2.Text = (string)Session["customer_fname"];
            cmd = new SqlCommand("select * from tbl_customer_master where customer_email=@customer_email and login_password=@login_password", con);


            cmd.Parameters.AddWithValue("@customer_email", txtuserName.Text.Trim());
            cmd.Parameters.AddWithValue("@login_password", txtPassword.Text.Trim());
            try
            {

                con.Open();
                rd = cmd.ExecuteReader();
                bool istrue = false;
                while (rd.Read())
                {
                    istrue = true;
                    Session["UserName"] = rd["customer_fname"].ToString();
                    Session["userId"] = rd["Id"].ToString();
                    Session["customer_email"] = rd["customer_email"].ToString();
                    Session["customer_fname"] = txtuserName.Text;

                }
                if (istrue)
                {
                    Response.Write("logged in successfully");
                    Response.Redirect("Options.aspx");
            


                }
                else
                {
                    error.InnerText = "please enter the valid email& password id";
                }
            }
            catch (Exception ex)
            {
                error.InnerText = "please enter the valid user name";

            }
            finally
            {
                rd.Close(); 
                con.Close();    
            }

























            //DataTable dt = new DataTable();
            //SqlDataAdapter da = new SqlDataAdapter();
            //using (SqlConnection con = new SqlConnection(connectionString))
            //    try
            //    {

            //        SqlCommand com=new SqlCommand("get_login",con);
            //        com.CommandType = CommandType.StoredProcedure;
            //       
            //        da.SelectCommand=com;
            //        da.Fill(dt);
            //        com.Dispose();
            //        if (dt.Rows.Count>0)
            //        {

            //          //  Label4.Visible = false;
            //          ////  Label1.Text = (string)Session["customer_fname"];
            //          Label4.Text = (string)Session["customer_fname"];
            //            Session["customer_fname"] = txtuserName.Text;
            //           // Session["userId"] = rd["Id"].toString();
            //           
            //            Label3.Text = "login successful";

            //        }
            //        else
            //        {
            //            Label3.Text = "wrong username/password";
            //        }
            //    }
            //    catch(Exception ex) 
            //    {
            //        ScriptManager.RegisterStartupScript(this, this.GetType(), "Message", "alert('Oops!!following error occured:" + ex.Message.ToString() + "');", true);

            //    }
            //    finally
            //    {
            //        dt.Clear();
            //        dt.Dispose();
            //        da.Dispose();
            //    }
            //if (Session["customer_fname"] == null)
            //{
            //    Response.Redirect("LogIn.aspx");
            //}
            //else
            //{
            //    new SqlConnection(@"Data Source=ABHISHEK-SUTRAD\SQLEXPRESS;Initial Catalog=jaiatmproject1;Integrated Security=True;Database=jaiatmproject1");
            //}















            //    con.Open();
            //    string query = "select count(1) from tbl_customer_master where customer_fname='" + txtuserName.Text + "'";
            //    SqlCommand com=new SqlCommand(query, con);
            //    com.Parameters.AddWithValue("@customer_fname", txtuserName.Text.Trim());
            //    com.Parameters.AddWithValue("@login_password", txtPassword.Text.Trim());
            //    int count=Convert.ToInt32(com.ExecuteScalar().ToString());
            //    con.Close();
            //    if(count==1)
            //    {
            //        con.Open();
            //        string checkpass = "select login_password from tbl_customer_master where  customer_fname='" + txtuserName.Text + "'";
            //        SqlCommand passcom = new SqlCommand(checkpass, con);
            //        string login_password= passcom.ExecuteScalar().ToString();

            //        if (login_password== txtPassword.Text)
            //        {
            //            Response.Write("password is correct");
            //            Label1.Text = (string)Session["customer_fname"];
            //            Response.Redirect("Options.aspx");

            //            Session["customer_fname"] = txtuserName.Text;
            //        }
            //        else
            //        {

            //            Response.Write(" Password is incorrect");
            //        }

            //    }
            //    else
            //    {
            //        Label3.Text = "Invalid username and password";
            //    }

            //   
            //}

            //select tbl_customer_master.Id,tbl_passbook_master.user_id from tbl_customer_master left join tbl_passbook_master on tbl_customer_master.Id=tbl_passbook_master.user_id



        }

        protected void txtuserName_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
         

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("ForgotPassword.aspx");
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            Response.Redirect("Registration.aspx");
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("https://www.google.com/search?q=xpay+life&rlz=1C1CHBF_enIN1015IN1015&oq=xpay+life&aqs=chrome.0.69i59l2j0i512l3j46i175i199i512j0i512j69i60.3738j0j7&sourceid=chrome&ie=UTF-8");
        }
    }
}
