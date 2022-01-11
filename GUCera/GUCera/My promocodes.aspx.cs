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
    public partial class My_promocodes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            try { 
            SqlCommand viewPromocode = new SqlCommand("viewPromocode", conn);
            viewPromocode.CommandType = CommandType.StoredProcedure;

            viewPromocode.Parameters.Add(new SqlParameter("@sid", Session["user"]));
                conn.Open();
                GridView grid = new GridView();
                grid.EmptyDataText = "No Promocodes found";
                grid.DataSource = viewPromocode.ExecuteReader(CommandBehavior.CloseConnection);
                grid.DataBind();
                form1.Controls.Add(grid);
                conn.Close();
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