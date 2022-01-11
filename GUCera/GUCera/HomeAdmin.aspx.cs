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
    public partial class HomeAdmin : System.Web.UI.Page
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

            SqlCommand addMobile = new SqlCommand("addMobile", conn);
            addMobile.CommandType = CommandType.StoredProcedure;
            addMobile.Parameters.Add(new SqlParameter("@ID", Session["user"]));
            addMobile.Parameters.Add(new SqlParameter("@mobile_number", num));

            conn.Open();
            addMobile.ExecuteNonQuery();
            conn.Close();
            Response.Write("Phone number added");
            }
            catch
            {
                Response.Write("Error");
            }

        }

        protected void listcourses(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            try { 
            SqlCommand courses = new SqlCommand("AdminViewAllCourses", conn);
            courses.CommandType = CommandType.StoredProcedure;

            conn.Open();
           
        
            //Response.Write(Session["done"]);
            GridView grid = new GridView();
            grid.EmptyDataText = "No courses found";
            grid.DataSource= courses.ExecuteReader(CommandBehavior.CloseConnection);
            grid.DataBind();
            form1.Controls.Add(grid);
            conn.Close();
            }
            catch
            {
                Response.Write("Error");
            }
        }

        protected void listUAcourses(object sender, EventArgs e)
        {

            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            try { 
            SqlCommand courses = new SqlCommand("AdminViewNonAcceptedCourses", conn);
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
        protected void Acceptcourses(object sender, EventArgs e) {
            Response.Redirect("AdminAcceptCourse.aspx");

        }

        protected void addpromo(object sender, EventArgs e)
        {
            Response.Redirect("AdminAddPromo.aspx");
        }

  
        protected void IssuePromo(object sender, EventArgs e)
        {
            Response.Redirect("AdminIssuePromo.aspx");
        }

        protected void Logout(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }

        protected void Home(object sender, EventArgs e)
        {
            Response.Redirect("HomeAdmin.aspx");
        }
    }
    }
