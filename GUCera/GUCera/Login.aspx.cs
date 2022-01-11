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
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void login(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            try
            {
                int id = Int16.Parse(username.Text);
                String pass = password.Text;

                SqlCommand loginproc = new SqlCommand("userLogin", conn);
                loginproc.CommandType = CommandType.StoredProcedure;
                loginproc.Parameters.Add(new SqlParameter("@id", id));
                loginproc.Parameters.Add(new SqlParameter("@password", pass));

                SqlParameter success = loginproc.Parameters.Add("@success", SqlDbType.Int);
                SqlParameter type = loginproc.Parameters.Add("@type", SqlDbType.Int);


                success.Direction = ParameterDirection.Output;
                type.Direction = ParameterDirection.Output;

                conn.Open();
                loginproc.ExecuteNonQuery();
                conn.Close();


                if (success.Value.ToString() == "1")
                {
                    Session["user"] = id;
                    if (type.Value.ToString() == "0")
                    {
                        Response.Redirect("intrhome.aspx");
                    }
                    if (type.Value.ToString() == "1")
                    {
                        Response.Redirect("HomeAdmin.aspx");
                    }
                    if (type.Value.ToString() == "2")
                    {
                        Response.Redirect("Home.aspx");
                    }


                }
                else
                {
                    Response.Write("Incorrect username or password");
                }
            }
            catch
            {
                Response.Write("Error");
            }

        }

        protected void register(object sender, EventArgs e)
        {
            Response.Redirect("register.aspx");
        }
    }
}