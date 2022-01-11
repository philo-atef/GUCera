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
    public partial class newuser : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
           // try { 
            SqlCommand getidd = new SqlCommand("getid", conn);
            getidd.CommandType = CommandType.StoredProcedure;

            getidd.Parameters.Add(new SqlParameter("@add", Session["add"]));

            SqlParameter idz = getidd.Parameters.Add("@id", SqlDbType.Int);


            idz.Direction = ParameterDirection.Output;
            conn.Open();
            getidd.ExecuteNonQuery();
            conn.Close();
            Session["newid"] = idz.Value.ToString();
           // }
           // catch
           // {
           //     Response.Write("Error");
           // }
        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }
    }
}