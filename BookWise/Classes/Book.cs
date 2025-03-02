using System.Data;

namespace BookWise
{
    public class Book
    {
        public int Id;
        public string Name;
        public string ISBN;
        public string Author;
        public string Category;
        public string Role;
        public string Phone;
        public string Address;

        public bool IsExisting()
        {
            string query = "SELECT COUNT(*) FROM Books WHERE isbn_no = @ISBN";
            object result = DB.ExecuteScalar(query, ISBN);
            return Convert.ToInt32(result) > 0;
        }

        public bool Add()
        {
            string query = "INSERT INTO Books (name, isbn_no, author, category) VALUES ( @Name , @ISBN , @Author , @Category )";
            int rowsAffected = DB.ExecuteQuery(query, Name, ISBN, Author, Category);
            return rowsAffected > 0;
        }
        public bool Update()
        {
            string query = "UPDATE Books SET name = @Name , isbn_no = @ISBN , author = @Author , category = @Category WHERE id = @Id";
            int rowsAffected = DB.ExecuteQuery(query, Name, ISBN, Author, Category, Id);
            return rowsAffected > 0;
        }

        public static bool Remove(int id)
        {
            string query = "DELETE FROM Books WHERE id = @id";
            int rowsAffected = DB.ExecuteQuery(query, id);
            return rowsAffected > 0;
        }

        public static DataTable GetAll()
        {
            string query = "SELECT id, name, isbn_no, author, category, available FROM Books";
            DataTable result = DB.ExecuteSelect(query);
            return result;
        }

        public static DataTable Search(string _query)
        {
            string query = "%" + _query + "%";
            string searchQuery = "SELECT id, name, isbn_no, author, category, available FROM Books WHERE name LIKE @query OR isbn_no LIKE @query OR author LIKE @query OR category LIKE @query";
            DataTable result = DB.ExecuteSelect(searchQuery, query);
            return result;
        }
    }
}
