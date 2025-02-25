using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace BookWise.Classes
{
    public class User
    {
        public string Email;
        public string Password;


        public User(string email, string password)
        {
            Email = email;
            Password = HashPassword(password);
        }


        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
        }

        public bool Authenticate()
        {
            string query = "SELECT COUNT(*) FROM Users WHERE Email = @Email AND Password = @Password";
            object result = DB.ExecuteScalar(query, Email,Password);

            return Convert.ToInt32(result) > 0;
        }
        public bool IsRegistered()
        {
            string query = "SELECT COUNT(*) FROM Users WHERE Email = @Email";
            object result = DB.ExecuteScalar(query, Email);

            return Convert.ToInt32(result) > 0;
        }

        public bool Register()
        {
            string query = "INSERT INTO Users (Email, Password) VALUES (@Email, @Password)";
            int rowsAffected = DB.ExecuteQuery(query, Email, Password);

            return rowsAffected > 0;
        }
    }
}
