using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace CricketClubFinal
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Login_btn_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["KumuliClubdb"].ConnectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from User_tbl where TeamName = @TeamName and Password =@pwd", con);
                cmd.Parameters.AddWithValue("@TeamName", TxtTname.Text);
                cmd.Parameters.AddWithValue("@pwd", TextPwd.Text);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count != 0)
                {
                    Session["username"] = TxtTname.Text;
                    Response.Redirect("~/UserHome.aspx");
                }
                else
                {
                 LabelError.Text = "Invalid username and password";
                }
                //Response.Write("<script> alert('Regstration successfully done'); </script>");
                clr();
                con.Close();
            }
        }

        private void clr()
        {
            TxtTname.Text = string.Empty;
            TextPwd.Text = string.Empty;
        }
    }
    
}