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
    public partial class enroll : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            try { 
            
            SqlCommand enrollInCourse = new SqlCommand("enrollInCourse", conn);
            enrollInCourse.CommandType = CommandType.StoredProcedure;
            enrollInCourse.Parameters.Add(new SqlParameter("@sid", Session["user"]));
            enrollInCourse.Parameters.Add(new SqlParameter("@cid", Session["Course"]));
            enrollInCourse.Parameters.Add(new SqlParameter("@instr", Session["instructor"]));

            conn.Open();
            enrollInCourse.ExecuteNonQuery();
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