using Microsoft.VisualBasic.ApplicationServices;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200305043
{
    public class MySQLDataAccess
    {
        private string _connectionString;

        public MySQLDataAccess(string connectionString)
        {
            _connectionString = connectionString;
        }

        public List<User> GetUsers(string username, string password)
        {
            List<User> users = new List<User>();

            using (MySqlConnection connection = new MySqlConnection(_connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT * FROM users WHERE user_name = @username AND user_password = @password";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            User user = new User
                            {
                                UserID = Convert.ToInt32(reader["user_id"]),
                                UserName = reader["user_name"].ToString(),
                            };
                            users.Add(user);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }

            return users;
        }

        public int AddBrand(string brandName)
        {
            using (MySqlConnection connection = new MySqlConnection(_connectionString))
            {
                connection.Open();

                string query = "INSERT INTO brands (brand_name) VALUES (@BrandName)";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@BrandName", brandName);
                    return cmd.ExecuteNonQuery();
                }
            }
        }

        public int AddProduct(string productName)
        {
            using (MySqlConnection connection = new MySqlConnection(_connectionString))
            {
                connection.Open();

                string query = "INSERT INTO products (product_name) VALUES (@ProductName)";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@ProductName", productName);
                    return cmd.ExecuteNonQuery();
                }
            }
        }

        public int AddUser(string userName, string userEmail, string userPassword)
        {
            using (MySqlConnection connection = new MySqlConnection(_connectionString))
            {
                connection.Open();

                string query = "INSERT INTO users (user_name, user_email, user_password) VALUES (@userName, @userEmail, @userPassword)";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@userName", userName);
                    cmd.Parameters.AddWithValue("@userEmail", userEmail);
                    cmd.Parameters.AddWithValue("@userPassword", userPassword);
                    return cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
