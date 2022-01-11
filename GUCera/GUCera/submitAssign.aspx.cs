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
    public partial class submitAssign : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            try
            {
                SqlCommand proc = new SqlCommand("submitAssign", conn);
                proc.CommandType = CommandType.StoredProcedure;
                //assumed passed from login
                //int id = Session["user"];
                // this 1 is for trial, dont forget to change it
                proc.Parameters.Add(new SqlParameter("@sid", Session["user"]));
                int cid = Int16.Parse(TextBox5.Text);
                proc.Parameters.Add(new SqlParameter("@cid", cid));
                int num = Int16.Parse(TextBox3.Text);
                proc.Parameters.Add(new SqlParameter("@assignnumber", num));
                string type = TextBox2.Text;
                proc.Parameters.Add(new SqlParameter("@assignType", type));

                conn.Open();
                proc.ExecuteNonQuery();
                conn.Close();

                Label data = new Label();
                data.Text = "Assign Submitted Successfully";
                form1.Controls.Add(data);
            }
            catch {
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