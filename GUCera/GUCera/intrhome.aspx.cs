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
    public partial class intrhome : System.Web.UI.Page
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
    }
}