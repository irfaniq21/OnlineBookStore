using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System;
using Microsoft.Data.SqlClient; // Required package
using System.Threading.Tasks;

namespace BookStoreConsoleApp
{
    internal class DBLayer
    {

        public bool SaveBookDataToDB(string bookName, string bookPrice)
        {
            string insertQuery = "INSERT INTO Book (BookName, Price) VALUES ('" + bookName + "', " + bookPrice + ")";
            string connString = "Server=IRFANS-DESKTOP\\SQLEXPRESS;Database=BookStore;Trusted_Connection=True;Encrypt=True;TrustServerCertificate=True;User Id=irfan;Password=admin123";
            SqlConnection connection = new SqlConnection(connString);
            SqlCommand command = new SqlCommand(insertQuery, connection);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();

            return true;
        }
        //}


        //public void ConnectToDB()
        //{


        //    string connString = "Server=YOUR_SERVER;Database=YourDb;Trusted_Connection=True;Encrypt=True;TrustServerCertificate=True;User Id=myUsername;Password=myPassword";

        //    SqlConnection connection = new SqlConnection(connString);
        //    SqlCommand command = new SqlCommand("SELECT Id, FirstName, LastName FROM Users", connection);
        //    connection.Open();
        //    command.ExecuteReader();
        //    connection.Close();

        //    string sql = "SELECT Id, FirstName, LastName FROM Users WHERE Status = @Status";

        //    using (SqlConnection connection = new SqlConnection(connString))
        //    {
        //        using (SqlCommand command = new SqlCommand(sql, connection))
        //        {
        //            // Always parameterize inputs to block SQL Injection
        //            command.Parameters.AddWithValue("@Status", "Active");

        //            connection.Open();

        //            using (SqlDataReader reader = command.ExecuteReader())
        //            {
        //                while (reader.Read())
        //                {
        //                    // Safely extract values by column name or index
        //                    int id = reader.GetInt32(0);
        //                    string firstName = reader.GetString(1);
        //                    string lastName = reader["LastName"].ToString();

        //                    Console.WriteLine($"ID: {id}, Name: {firstName} {lastName}");
        //                }
        //            }
        //        }
        //    }
        //}
    }
}
