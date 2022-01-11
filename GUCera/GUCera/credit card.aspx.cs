using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GUCera
{
    public partial class credit_card : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            try { 
            String num = number.Text;
            String namee = name.Text;
            DateTime dat = date.SelectedDate;
            String cvv = cvvv.Text;


            SqlCommand addCreditCard = new SqlCommand("addCreditCard", conn);
            addCreditCard.CommandType = CommandType.StoredProcedure;
            addCreditCard.Parameters.Add(new SqlParameter("@sid", Session["user"]));
            addCreditCard.Parameters.Add(new SqlParameter("@number", num));
            addCreditCard.Parameters.Add(new SqlParameter("@cardHolderName", namee));
            addCreditCard.Parameters.Add(new SqlParameter("@expiryDate", dat));
            addCreditCard.Parameters.Add(new SqlParameter("@cvv", cvv));


            conn.Open();
            addCreditCard.ExecuteNonQuery();
            conn.Close();
                Response.Write("you have added this Credit Card successfully");
            }
            catch
            {
                Response.Write("Error");
            }
        }
        protected void Logout(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }

        protected void Home(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }
    }
}