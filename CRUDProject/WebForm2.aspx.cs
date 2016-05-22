using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace CRUDProject
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Change(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(TextBoxid.Text);
            string name = TextBox1.Text;
            string address = TextBox2.Text;
            string telp = TextBox3.Text;
            String QueryString = "UPDATE Contact SET Name = '" + name + "', Address = '" + address + "',Telepon = '" + telp + "' Where id = "+id+"  ";
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["CRUD_Connection"].ConnectionString);
            con.Open();
            SqlCommand com = new SqlCommand(QueryString, con);
            com.ExecuteNonQuery();
            con.Close();
            Response.Redirect("~/WebForm1.aspx", true);
        }

        protected void DELETE(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(TextBoxid.Text);
            String QueryString = "DELETE FROM Contact WHERE ID = "+id+"";
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["CRUD_Connection"].ConnectionString);
            con.Open();
            SqlCommand com = new SqlCommand(QueryString, con);
            com.ExecuteNonQuery();
            con.Close();
            Response.Redirect("~/WebForm1.aspx", true);
        }
    }
}