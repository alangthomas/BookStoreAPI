using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
namespace WebApplication3
{
    public partial class WebFormBookAdd : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        { 
                string connectionString = @"server=localhost\SQLEXPRESS; database=BookDB;trusted_connection=yes";
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                SqlCommand comm = new SqlCommand();
                comm.Connection = connection;
                comm.CommandText = "insert into Books (Id, Title, Author, Price) values (" 
                  + Convert.ToInt32(TextBox1.Text) + ", '" + TextBox2.Text + "', '" + TextBox3.Text 
                  +"', '" + Convert.ToInt32(TextBox4.Text)+ "')";
                int rows = comm.ExecuteNonQuery();
                Label1.Text = "(" + rows + ") affected";

                connection.Close();
            
        }
    }
}