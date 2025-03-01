using System.Data;

namespace BookWise
{
    public class User
    {
        public int Id;
        public string Email;
        public string FirstName;
        public string LastName;
        public string NIC;
        public string Role;
        public string Phone;
        public string Address;
        public string Password;
        public bool IsRegistered()
        {
            string query = "SELECT COUNT(*) FROM Users WHERE Email = @Email OR Nic = @Nic";
            object result = DB.ExecuteScalar(query, Email, NIC);

            return Convert.ToInt32(result) > 0;
        }

        public bool Register()
        {
            string _password = BCrypt.Net.BCrypt.HashPassword(Password);
            string query = "INSERT INTO Users (first_name, last_name,email, role, nic, phone, address, password) VALUES ( @FirstName , @LastName , @Email , @Role , @NIC , @Phone , @Address , @Password )";
            int rowsAffected = DB.ExecuteQuery(query, FirstName, LastName, Email, Role, NIC, Phone, Address, _password);

            return rowsAffected > 0;
        }
        public bool Update()
        {
            int rowsAffected = 0;
            if (!string.IsNullOrWhiteSpace(Password))
            {
                string _password = BCrypt.Net.BCrypt.HashPassword(Password);
                string query = $"UPDATE Users SET first_name = @FirstName ,last_name= @LastName , email = @Email , role = @Role ,nic = @NIC , phone = @Phone , address = @Address , password = @Password WHERE id = @Id";
                rowsAffected = DB.ExecuteQuery(query, FirstName, LastName, Email, Role, NIC, Phone, Address, _password, Id);
            }
            else
            {
                string query = $"UPDATE Users SET first_name = @FirstName ,last_name= @LastName , email = @Email , role = @Role ,nic = @NIC , phone = @Phone , address = @Address WHERE id = @Id";
                rowsAffected = DB.ExecuteQuery(query, FirstName, LastName, Email, Role, NIC, Phone, Address, Id);
            }

            return rowsAffected > 0;
        }

        public static bool Remove(int id)
        {
            string query = "DELETE FROM Users WHERE id = @id";
            int rowsAffected = DB.ExecuteQuery(query, id);

            return rowsAffected > 0;
        }

        public static DataTable GetAll()
        {
            string query = "SELECT id, first_name, last_name,email, role, nic, phone, address FROM Users";
            DataTable result = DB.ExecuteSelect(query);
            return result;
        }

        public static DataTable Search(string _query)
        {
            string query = "%" + _query + "%";
            string searchQuery = "SELECT id, first_name, last_name,email, role, nic, phone, address FROM Users WHERE first_name LIKE @query OR last_name LIKE @query OR email LIKE @query OR nic LIKE @query OR phone LIKE @query";
            DataTable result = DB.ExecuteSelect(searchQuery, query);
            return result;
        }
    }
}
