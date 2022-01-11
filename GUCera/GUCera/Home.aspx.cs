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
    public partial class Home : System.Web.UI.Page
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
            Response.Write("Number added successfully");
            }
            catch
            {
                Response.Write("Error");
            }

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("courses.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("My profile.aspx");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("My promocodes.aspx");
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            Response.Redirect("credit card.aspx");
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            Response.Redirect("courseinfo.aspx");
        }



        protected void pButton5_Click(object sender, EventArgs e)
        {
            Response.Redirect("viewAssign.aspx");
        }

        protected void pButton7_Click(object sender, EventArgs e)
        {
            Response.Redirect("viewAssignGrades.aspx");
        }

        protected void pButton6_Click(object sender, EventArgs e)
        {
            Response.Redirect("submitAssign.aspx");
        }

        protected void pButton8_Click(object sender, EventArgs e)
        {
            Response.Redirect("addFeedback.aspx");
        }

        protected void pButton9_Click(object sender, EventArgs e)
        {
            Response.Redirect("viewCert.aspx");
        }
        protected void Logout(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }

    }
}