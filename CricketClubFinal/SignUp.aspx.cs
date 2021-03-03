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
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           if(isformvalid())
            {
                using(SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["KumuliClubdb"].ConnectionString))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Insert into User_tbl(TeamName,PhoneNumber,Sports,Password) values('" + TxtUname.Text + "','" + TextPhone.Text + "','" + TextSports.Text + "','" + TextPass.Text + "')", con);
                    cmd.ExecuteNonQuery();
                    Response.Write("<script> alert('Regstration successfully done'); </script>");
                    clr();
                    con.Close();
                }
            }
           else
            {
                Response.Write("<script> alert('Regstration Failed'); </script>");

            }


        }

        private bool isformvalid()
        {
            if(TxtUname.Text=="")
            {
                Response.Write("<script> alert('Username not valid'); </script>");
                return false;
            }
            else if(TextPass.Text=="")
            {
                Response.Write("<script> alert('Password not valid'); </script>");
                return false;
            }
            else if (TextPass.Text != TextCPass.Text)
            {
                Response.Write("<script> alert('Password not matched'); </script>");
                return false;
            }
            else if (TextPhone.Text =="")
            {
                Response.Write("<script> alert('Phonenumber not valid'); </script>");
                return false;
            }
            else if (TextSports.Text=="")
            {
                Response.Write("<script> alert('Sports name not valid'); </script>");
                return false;
            }
            return true;
        }
        private void clr()
        {
            TextSports.Text = string.Empty;
            TextPhone.Text = string.Empty;
            TextPass.Text = string.Empty;
            TextCPass.Text = string.Empty;
            TxtUname.Text = string.Empty;
        }

        protected void Btn_Click(object sender, EventArgs e)
        {

        }
    }
}