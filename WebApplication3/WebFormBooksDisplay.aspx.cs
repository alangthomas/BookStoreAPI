using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
namespace WebApplication3
{
    public partial class WebFormBooksDisplay : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connectionString = @"server=localhost\SQLEXPRESS; database=BookDB;trusted_connection=yes";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "select * from Books";
            SqlDataReader dr = command.ExecuteReader();
            GridView1.DataSource = dr;
            GridView1.DataBind();
            connection.Close();

        }

    }
}