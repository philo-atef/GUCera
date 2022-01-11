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
    public partial class courses : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            try { 
            SqlCommand courses = new SqlCommand("availableCourses", conn);
            courses.CommandType = CommandType.StoredProcedure;

            conn.Open();
            //Response.Write(Session["done"]);
            GridView grid = new GridView();
            grid.EmptyDataText = "No courses found";
            grid.DataSource = courses.ExecuteReader(CommandBehavior.CloseConnection);
            grid.DataBind();
            form1.Controls.Add(grid);
            conn.Close();
            }
            catch
            {
                Response.Write("Error");
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try { 
            Int32 ID = Int32.Parse(iden.Text);
            Session["Course"] = ID;
            Response.Redirect("courseinfo.aspx");
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