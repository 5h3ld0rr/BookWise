using System.Data;

namespace BookWise
{
    public class Admin : User
    {
        public bool Authenticate()
        {
            string query = "SELECT id,first_name, last_name, nic,role, phone, address, password FROM Users WHERE Email = @Email and Role != 'User'";
            DataTable result = DB.ExecuteSelect(query, Email);
            if (result != null && result.Rows.Count > 0)
            {
                DataRow row = result.Rows[0];
                bool isPasswordMatched = BCrypt.Net.BCrypt.Verify(Password, row["password"].ToString());
                if (!isPasswordMatched) return false;
                Id = Convert.ToInt32(row["id"]);
                FirstName = row["first_name"].ToString();
                LastName = row["last_name"].ToString();
                NIC = row["nic"].ToString();
                Role = row["role"].ToString();
                Phone = row["phone"].ToString();
                Address = row["address"].ToString();
                return true;
            }
            return false;
        }
    }
}
