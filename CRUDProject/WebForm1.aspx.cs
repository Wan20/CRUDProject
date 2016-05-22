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
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) {
                Load_Store();
            }

        }

        protected void Load_Store() 
        {
            DataSet ds = new DataSet();
            String QueryString = "SELECT * FROM Contact"; 
            SqlConnection con = new SqlConnection (ConfigurationManager.ConnectionStrings["CRUD_Connection"].ConnectionString);
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter (QueryString, con);
            sda.Fill(ds);
            Contact_Gridview.DataSource = ds;
            Contact_Gridview.DataBind();
            con.Close();
        }

        protected void submit(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtId.Text);
            string name = TextBox1.Text;
            string address = TextBox2.Text;
            string telp = TextBox3.Text;
            String QueryString = "INSERT INTO CONTACT VALUES ("+id+",'"+name+"','"+address+"','"+telp+"')";
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["CRUD_Connection"].ConnectionString);
            con.Open();
            SqlCommand com = new SqlCommand(QueryString, con);
            com.ExecuteNonQuery();
            con.Close();
            Response.Redirect("~/WebForm1.aspx", true);
        }




    }
}