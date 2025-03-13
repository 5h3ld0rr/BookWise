using System.Data;

namespace BookWise
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string NIC { get; set; }
        public string Role { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Password;

        public bool IsRegistered()
        {
            string query = "SELECT COUNT(*) FROM users WHERE Id = @Id OR Email = @Email OR Nic = @Nic";
            object result = DB.ExecuteScalar(query, Id, Email, NIC);

            return Convert.ToInt32(result) > 0;
        }

        public bool Register()
        {
            string _password = String.IsNullOrWhiteSpace(Password) ? null : BCrypt.Net.BCrypt.HashPassword(Password);
            string query = "INSERT INTO users (id, first_name, last_name,email, role, nic, phone, address, password) VALUES (@Id, @FirstName , @LastName , @Email , @Role , @NIC , @Phone , @Address , @Password )";
            int rowsAffected = DB.ExecuteQuery(query, Id, FirstName, LastName, Email, Role, NIC, Phone, Address, _password);

            return rowsAffected > 0;
        }
        public bool Update()
        {
            int rowsAffected = 0;
            if (!String.IsNullOrWhiteSpace(Password))
            {
                string _password = BCrypt.Net.BCrypt.HashPassword(Password);
                string query = "UPDATE users SET first_name = @FirstName ,last_name= @LastName , email = @Email , role = @Role ,nic = @NIC , phone = @Phone , address = @Address , password = @Password WHERE id = @Id";
                rowsAffected = DB.ExecuteQuery(query, FirstName, LastName, Email, Role, NIC, Phone, Address, _password, Id);
            }
            else
            {
                string query = "UPDATE users SET first_name = @FirstName ,last_name= @LastName , email = @Email , role = @Role ,nic = @NIC , phone = @Phone , address = @Address WHERE id = @Id";
                rowsAffected = DB.ExecuteQuery(query, FirstName, LastName, Email, Role, NIC, Phone, Address, Id);
            }

            return rowsAffected > 0;
        }

        public bool Remove()
        {
            string query = "DELETE FROM users WHERE id = @id";
            int rowsAffected = DB.ExecuteQuery(query, Id);

            return rowsAffected > 0;
        }

        public static User[] GetAll(string acceptedRoles)
        {
            string query = $"SELECT id, first_name, last_name,email, role, nic, phone, address FROM users WHERE role IN ({acceptedRoles})";
            DataTable result = DB.ExecuteSelect(query);
            User[] users = new User[result.Rows.Count];

            for (int i = 0; i < result.Rows.Count; i++)
            {
                DataRow row = result.Rows[i];
                users[i] = new User()
                {
                    Id = Convert.ToInt32(row["id"]),
                    Email = row["email"]?.ToString(),
                    FirstName = row["first_name"]?.ToString(),
                    LastName = row["last_name"]?.ToString(),
                    NIC = row["nic"]?.ToString(),
                    Role = row["role"]?.ToString(),
                    Phone = row["phone"]?.ToString(),
                    Address = row["address"]?.ToString()
                };
            }
            return users;
        }

        public static User[] Search(string _query, string acceptedRoles)
        {
            string query = "%" + _query + "%";
            string searchQuery = $"SELECT id, first_name, last_name,email, role, nic, phone, address FROM users WHERE (id LIKE @query OR first_name LIKE @query OR last_name LIKE @query OR email LIKE @query OR nic LIKE @query OR phone LIKE @query) AND role IN ({acceptedRoles})";
            DataTable result = DB.ExecuteSelect(searchQuery, query);
            User[] users = new User[result.Rows.Count];

            for (int i = 0; i < result.Rows.Count; i++)
            {
                DataRow row = result.Rows[i];
                users[i] = new User()
                {
                    Id = Convert.ToInt32(row["id"]),
                    Email = row["email"]?.ToString(),
                    FirstName = row["first_name"]?.ToString(),
                    LastName = row["last_name"]?.ToString(),
                    NIC = row["nic"]?.ToString(),
                    Role = row["role"]?.ToString(),
                    Phone = row["phone"]?.ToString(),
                    Address = row["address"]?.ToString()
                };
            }
            return users;
        }
    }
}
