using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace WebApplication2
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void btnRegister_Click(object sender, EventArgs e)
        {
            // Perform validation and save user data
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            // Example: Saving to a SQL Server database
            string connectionString = "Arun.mdf";
            using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-BRQ3U1U\SQLEXPRESS;Initial Catalog=Arun;Integrated Security=True"))
            {
                string query = "INSERT INTO data (Username, Password) VALUES (@Username, @Password)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@Password", password);
                connection.Open();
                command.ExecuteNonQuery();
                Response.Redirect("Default.aspx");
          }
        }
    }
}
