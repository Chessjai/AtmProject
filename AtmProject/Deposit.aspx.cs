using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AtmProject
{


    public partial class Deposit : System.Web.UI.Page

    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader rd;

        protected void Page_Load(object sender, EventArgs e)
        {
           // Label2.Text = (string)Session["customer_fname"];
            con = new SqlConnection(ConfigurationManager.ConnectionStrings ["jaiatmproject1ConnectionString"].ConnectionString);
           Label2.Text = Session["customer_fname"].ToString();
            cmd = new SqlCommand("select sum(transaction_amount) as current_balancr from tbl_passbook_master where user_id=@user_id", con);
           cmd.Parameters.AddWithValue("@user_id", Session["userId"]);
            try
            {
                con.Open();
                rd = cmd.ExecuteReader();
                bool istrue = false;
                while (rd.Read())
                {
                    istrue = true;
                    Session["current_balancr"] = rd["current_balancr"].ToString();

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
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("Options.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {



            Random rand = new Random();
            int num = rand.Next(0, 100);
            var transactionid = Convert.ToString(num);
            var currentbalance = Session["current_balancr"] ==""? 0 : Session["current_balancr"];
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["jaiatmproject1ConnectionString"].ConnectionString);
            cmd = new SqlCommand("insert into tbl_passbook_master" +
                " (transaction_id,transaction_remark,user_id,transaction_type,transaction_amount,current_balancr)values(@transaction_id,@transaction_remark,@user_id,@transaction_type,@transaction_amount,@current_balancr)", con);

            cmd.Parameters.AddWithValue("@transaction_id", (transactionid));
            cmd.Parameters.AddWithValue("@transaction_remark", "Deposit");
            cmd.Parameters.AddWithValue("@user_id", Session["userId"]);
            cmd.Parameters.AddWithValue("@transaction_type", "DR");
            cmd.Parameters.AddWithValue("@transaction_amount",txtAmount.Text.Trim());
            cmd.Parameters.AddWithValue("@current_balancr", currentbalance+ txtAmount.Text.Trim());


            try
            {
                con.Open();
                int res = cmd.ExecuteNonQuery();
                if (res>0)
                {
                    Label3.Text = "amount deposited successfully";
                    Session["Currentbalance"] = Session["Currentbalance"] + txtAmount.Text;
                }
                else
                {
                  error.InnerText = "Deposit failed";
                }
            }
            catch (Exception ex)
            {

                
            }
            finally
            {
                con.Close();
            }




            //using (SqlConnection con = new SqlConnection(strConnString))
            //{
            //    con.Open();
            //    SqlCommand com = new SqlCommand("update_tbl_passbook_master", con);


            //    com.CommandType = CommandType.StoredProcedure;
            //    com.Parameters.AddWithValue("@transaction_amount", txtAmount.Text);
            //    com.Parameters.AddWithValue("@user_id ", txtremark.Text);

            //    com.ExecuteNonQuery();
            //    con.Close();
            //    Response.Redirect("Passbook.aspx");
            // 



        }
    }
}