using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FirstTask
{
    public partial class ContactList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                string personId = GetQueryString("PersonId");

                string connectionString = WebConfigurationManager.ConnectionStrings["connectionstring"].ToString();
                
                SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\JobDatabase.mdf;Integrated Security=True;Connect Timeout=30");
                connection.Open();
                FillTitle(connection, personId);  

                string command = string.Format("SELECT * FROM Contacts c LEFT JOIN Persons p on c.PersonId = p.ID WHERE p.Id = {0}", personId);

                SqlDataAdapter adapter = new SqlDataAdapter(command, connectionString);
                DataSet ds = new DataSet();

                adapter.Fill(ds);

                CListGridView.DataSource = ds;
                CListGridView.DataBind();

                connection.Close();
            }

            
        }

        private void FillTitle(SqlConnection connection, string personId)
        {
            var str = string.Format("select [PersonName] from Persons WHERE Id = {0}", personId); 
            var    com = new SqlCommand(str, connection);
            SqlDataReader reader = com.ExecuteReader();
            reader.Read();
            pageHeader.InnerText = string.Format("{0}\'s Contacts", reader["PersonName"].ToString());
        }


        /// <summary>
        /// Get Value From Request.
        /// </summary>
        /// <param name="queryName"></param>
        /// <returns></returns>
        public string GetQueryString(string queryName)
        {
            String value = String.Empty;
            value = Request.QueryString[queryName];

            return value;
        }
    }
}