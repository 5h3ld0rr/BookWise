using System.Data;
using System.Security.Cryptography;
using System.Text;

namespace BookWise
{
    public class User
    {
        public string Email;
        public string Password;
        public string? FirstName;
        public string? LastName;
        public string? NIC;
        public string? Phone;
        public string? Address;

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
            string query = "SELECT first_name, last_name, nic, phone, address FROM Users WHERE Email = @Email AND Password = @Password";
            DataTable result = DB.ExecuteSelect(query, Email, Password);
            if (result != null && result.Rows.Count > 0)
            {
                DataRow row = result.Rows[0];
                FirstName = row["first_name"].ToString();
                LastName = row["last_name"].ToString();
                NIC = row["nic"].ToString();
                Phone = row["phone"].ToString();
                Address = row["address"].ToString();
                return true;
            }
            return false;
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
