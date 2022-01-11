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
    public partial class AdminIssuePromo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void submit(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            try { 
            String c = code.Text;
           
            int d = Int32.Parse(stud.Text);



            SqlCommand accproc = new SqlCommand("AdminIssuePromocodeToStudent", conn);
            accproc.CommandType = CommandType.StoredProcedure;
       
            accproc.Parameters.Add(new SqlParameter("@pid", c));
        
            accproc.Parameters.Add(new SqlParameter("@sid", d));





            conn.Open();
            accproc.ExecuteNonQuery();
            conn.Close();
            Response.Write("Done");
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
            Response.Redirect("HomeAdmin.aspx");
        }
    }
}
