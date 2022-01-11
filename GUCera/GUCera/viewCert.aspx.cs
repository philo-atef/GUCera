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
    public partial class viewCert : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button4_Click(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            try { 
            SqlCommand proc = new SqlCommand("viewCertificate", conn);
            proc.CommandType = CommandType.StoredProcedure;
            //assumed passed from login
            //int id = Session["user"];
            // this 1 is for trial, dont forget to change it
            proc.Parameters.Add(new SqlParameter("@sid", Session["user"]));
            int cid = Int16.Parse(TB6.Text);
            proc.Parameters.Add(new SqlParameter("@cid", cid));
            conn.Open();
            GridView grid = new GridView();
            grid.EmptyDataText = "No certificates found";
            grid.DataSource = proc.ExecuteReader(CommandBehavior.CloseConnection);
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