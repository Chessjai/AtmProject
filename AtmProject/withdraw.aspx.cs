using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AtmProject
{
    public partial class withdraw : System.Web.UI.Page
    {
        //SqlConnection con = new SqlConnection(@"Data Source=JAIKUMAR\SQLEXPRESS;Initial Catalog=Jaiatmproject1;Integrated Security=True");

        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader rd;

        protected void Page_Load(object sender, EventArgs e)
        {
            //label1.Text = (string)Session["customer_fname"];
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["jaiatmproject1ConnectionString"].ConnectionString);
            label1.Text = Session["customer_fname"].ToString();
            cmd = new SqlCommand("select sum(transaction_amount)as current_balancr from tbl_passbook_master where user_id=@user_id",con);
            cmd.Parameters.AddWithValue("@user_id", Session["userid"]);
            try
            {
                con.Open();
                rd= cmd.ExecuteReader();
                bool istrue = false;
                while (rd.Read())
                {
                    istrue = true;
                    Session["current_balancr"] = rd["current_balancr"].ToString();
                }

            }
            catch (Exception ex)
            {

                error.InnerText = "please enter valid user name";
            }
            finally
            {
                rd.Close();
                con.Close(); 
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            int number = rand.Next(101, 200);
            var transactionid = Convert.ToString(number);
            var currentbalance = Session["current_balancr"] == "" ? 0 : Session["current_balancr"];
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["jaiatmproject1ConnectionString"].ConnectionString);
            cmd = new SqlCommand("insert into tbl_passbook_master" +
                " (transaction_id,transaction_remark,user_id,transaction_type,transaction_amount,current_balancr)values(@transaction_id,@transaction_remark,@user_id,@transaction_type,@transaction_amount,@current_balancr)", con);

            cmd.Parameters.AddWithValue("@transaction_id", (transactionid));
            cmd.Parameters.AddWithValue("@transaction_remark", "withdraw");
            cmd.Parameters.AddWithValue("@user_id", Session["userid"]);
            cmd.Parameters.AddWithValue("@transaction_type", "CR");
            cmd.Parameters.AddWithValue("@transaction_amount", TextBox5.Text.Trim());
            cmd.Parameters.AddWithValue("@current_balancr", Session["current_balancr"]);

            try
            {
                con.Open();
                int res = cmd.ExecuteNonQuery();
                if (res > 0)
                {
                    Session["nowbalance"] = Convert.ToInt64(Session["Currentbalance"])-Convert.ToInt64(TextBox5.Text);
                    string bal = Session["nowbalance"].ToString();
                    label1.Text = "amount withdrawn successfully";
                }
                else
                {
                    error.InnerText = "withdrawn failed";
                }
            }
            catch (Exception ex)
            {


            }
            finally
            {
                con.Close();
            }

            //try
            //{

            //    con.Open();
            //    rd = cmd.ExecuteReader();
            //    bool istrue = false;
            //    while (rd.Read())
            //    {
            //        istrue = true;
            //        Session["UserName"] = rd["customer_fname"].ToString();
            //        Session["userId"] = rd["Id"].ToString();
            //        Session["customer_email"] = rd["customer_email"].ToString();
            //        Session["customer_fname"] = txtuserName.Text;

            //    }
            //    double curbal = double.MinValue;
            //double newbal = double.MinValue;


            //  double withbal = 0.0;
            //double withbal=Convert.ToDouble(TextBox5.Text);
            //string UserId = label1.Text;
            //withbal=Convert.ToDouble(TextBox5.Text);
            //curbal = getbalance();
            ////if (withbal<=0)
            //{
            //    Response.Write("please enter the valid amount");
            //}
            //else if(withbal>curbal)
            //{
            //    Response.Write("available balance is less than withdraw balance");
            //}
            //else
            //{

            //}
            //    if (TextBox5.Text==""||Convert.ToInt32(TextBox5.Text)<0)
            //    {
            //        Response.Write("please enter the valid amount");
            //    }
            //    else
            //    {
            //        newbal = curbal - Convert.ToDouble(TextBox5.Text);
            //        try
            //        {
            //            con.Open();
            //            SqlCommand cmd = new SqlCommand("insert into tbl_passbook_master(user_id,transaction_type,transaction_amount,current_balancr)values('" + UserId + "','credit'," + withbal + "," + newbal + ")", con);
            //            rd = cmd.ExecuteReader();
            //        }
            //        catch (Exception)
            //        {

            //            throw;
            //        }
            //    }


        }
        //private double getbalance()
        //{
        //    float oldbal;
        //    float newbal;
        //    double currbalance = double.MinValue;
        //    con.Open();
        //    SqlDataAdapter sda=new SqlDataAdapter("select [current_balancr] from tbl_passbook_master where[user_id]='"+label1.Text+"'",con);
        //    DataTable dt= new DataTable();  
        //    sda.Fill(dt);
        //    foreach (DataRow item in dt.Rows)
        //    {
        //        currbalance = Convert.ToDouble(item["current_balancr"]);
        //    }
        //    con.Close();
        //    return currbalance;
        //}


        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Options.aspx");
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void ImageButton1_Click1(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("https://www.google.com/search?q=xpay+life&rlz=1C1CHBF_enIN1015IN1015&oq=xpay+life&aqs=chrome.0.69i59l2j0i512l3j46i175i199i512j0i512j69i60.3738j0j7&sourceid=chrome&ie=UTF-8");
        
    }
    }
}