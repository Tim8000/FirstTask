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
    public partial class DbTest : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connectionString = WebConfigurationManager.ConnectionStrings["connectionstring"].ToString();
            

            SqlConnection connectTo = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\JobDatabase.mdf;Integrated Security=True;Connect Timeout=30");
            connectTo.Open();

            string command = "SELECT * From Contacts";
            //string command = "SELECT * FROM Contacts c LEFT JOIN Persons p on c.PersonId = p.ID WHERE p.Id = 2";
            //WHERE p.Id"
            SqlDataAdapter adapter = new SqlDataAdapter(command, connectionString);
            DataSet ds = new DataSet();

            adapter.Fill(ds);
            
          //  DataTable table = new DataTable();
          //   adapter.Fill(table);
          //  SqlDataSource1 = table;
           // SqlDataReader reader = command.ExecuteReader();
            GridView2.DataSource = ds;
            GridView2.DataBind();
           
            //  int value = GridView2.SelectedIndex;

            connectTo.Close();


        }


        protected void GridView2_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            var value2 = GridView2.SelectedValue.GetHashCode();
            //throw new NotImplementedException();

            //SELECT * FROM Contacts c LEFT JOIN Persons p on c.PersonId = p.ID
            //WHERE p.Id = твоё значение
        }
    }
}