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
    public partial class viewAssignGrades : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void VG_Click(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            try { 
            SqlCommand proc = new SqlCommand("viewAssignGrades", conn);
            proc.CommandType = CommandType.StoredProcedure;
            //assumed passed from login
            //int id = Session["user"];
            // this 1 is for trial, dont forget to change it
            proc.Parameters.Add(new SqlParameter("@sid", Session["user"]));
            int cid = Int16.Parse(CIDT.Text);
            proc.Parameters.Add(new SqlParameter("@cid", cid));
            String type = ATT.Text;
            proc.Parameters.Add(new SqlParameter("@assignType", type));
            String num = ANT.Text;
            proc.Parameters.Add(new SqlParameter("@assignnumber", num));
            SqlParameter grade = proc.Parameters.Add("@assignGrade", SqlDbType.Int);
            grade.Direction = ParameterDirection.Output;


            conn.Open();
            proc.ExecuteNonQuery();
            conn.Close();

            Label data = new Label();
                if (grade.Value.ToString() =="" )
                {
                    data.Text = "You did not submit this Assignment";
                }
                else
                {
                    data.Text = "Grade of Entered Assignment is " + grade.Value.ToString();
                }
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