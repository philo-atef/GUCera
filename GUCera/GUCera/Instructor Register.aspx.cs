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
    public partial class Instructor_Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void register(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            try { 
            String fName = firstName.Text;
            String LName = lastName.Text;
            String pass = password.Text;
            String mail = email.Text;
            Boolean gen = Boolean.Parse(gender.SelectedValue);
            String add = address.Text;



            SqlCommand InstructorRegister = new SqlCommand("InstructorRegister", conn);
            InstructorRegister.CommandType = CommandType.StoredProcedure;
            InstructorRegister.Parameters.Add(new SqlParameter("@first_name", fName));
            InstructorRegister.Parameters.Add(new SqlParameter("@last_name", LName));
            InstructorRegister.Parameters.Add(new SqlParameter("@password", pass));
            InstructorRegister.Parameters.Add(new SqlParameter("@email", mail));
            InstructorRegister.Parameters.Add(new SqlParameter("@gender", gen));
            InstructorRegister.Parameters.Add(new SqlParameter("@address", add));


            conn.Open();
            InstructorRegister.ExecuteNonQuery();
            conn.Close();


            Session["add"] = mail;

            //  Response.Write("you have registered successfully, your id is"+ idz.Value.ToString());
            Response.Redirect("newuser.aspx");
            }
            catch
            {
                Response.Write("Error");
            }

        }
    }

        
 }
