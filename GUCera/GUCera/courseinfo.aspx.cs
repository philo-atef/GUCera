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
    public partial class courseinfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
                SqlConnection conn = new SqlConnection(connStr);
            try { 
                
                SqlCommand courseInformation = new SqlCommand("courseInformation", conn);
                courseInformation.CommandType = CommandType.StoredProcedure;
                courseInformation.Parameters.Add(new SqlParameter("@id", Session["Course"]));

                conn.Open();
                GridView grid = new GridView();
                grid.EmptyDataText = "No courses found";
                grid.DataSource = courseInformation.ExecuteReader(CommandBehavior.CloseConnection);
                grid.DataBind();
                form1.Controls.Add(grid);
                conn.Close();
            }
            catch
            {
                Response.Write("Error");
            }

        }

        protected void enrol_Click(object sender, EventArgs e)
        {
            Int32 IDD = Int32.Parse(enroll.Text);

            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            try { 

            SqlCommand enrollInCourse = new SqlCommand("enrollInCourse", conn);
            enrollInCourse.CommandType = CommandType.StoredProcedure;
            enrollInCourse.Parameters.Add(new SqlParameter("@sid", Session["user"]));
            enrollInCourse.Parameters.Add(new SqlParameter("@cid", Session["Course"]));
            enrollInCourse.Parameters.Add(new SqlParameter("@instr", IDD));

            conn.Open();
            enrollInCourse.ExecuteNonQuery();
            conn.Close();

            Response.Write("Enrolled succefully");
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