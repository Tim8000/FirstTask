using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;



namespace FirstTask
{
    public partial class PersonList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connectionString = WebConfigurationManager.ConnectionStrings["connectionstring"].ToString();

            SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\JobDatabase.mdf;Integrated Security=True;Connect Timeout=30");
            connection.Open();

            string command = "SELECT * From Persons";
           
            SqlDataAdapter adapter = new SqlDataAdapter(command, connectionString);
            DataSet ds = new DataSet();

            adapter.Fill(ds);

            GridView2.DataSource = ds;
            GridView2.DataBind();

            connection.Close();
        }


        protected void GridView2_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            var personId = GridView2.SelectedValue.GetHashCode();
          
            Response.Redirect("ContactList.aspx?personId=" + personId);
        }
    }
}