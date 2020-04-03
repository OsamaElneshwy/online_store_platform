using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace SWE2.Models
{
    public class Admin : ApplicationUser
    {

        private string email { get; set; }
        private string Discriminator { get; set; }

        public string getemail()
        {
            return email;
        }
        public string geteDiscriminator()
        {
            return Discriminator;
        }


        public void SetAdmin(string mail)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=(LocalDb)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\aspnet-SWE2-20200329012449.mdf;Initial Catalog=aspnet-SWE2-20200329012449;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();
            sqlCommand.CommandText = "UPDATE [AspNetUsers] SET Discriminator = 'Admin' WHERE Email='"+mail+"'";
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }


        public List<Admin> getUsers()
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=(LocalDb)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\aspnet-SWE2-20200329012449.mdf;Initial Catalog=aspnet-SWE2-20200329012449;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("Select Email, Discriminator from [AspNetUsers] ", sqlConnection);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            sqlConnection.Close();

            var users = new List<Admin>();

            for(int i=0;i<dt.Rows.Count;i++)
            {
                var User = new Admin();
                User.email = dt.Rows[i][0].ToString();
                User.Discriminator = dt.Rows[i][1].ToString();
                users.Add(User);
            }
            return users;
        }




    }


    public class SetAdminViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }

}