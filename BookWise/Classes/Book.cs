using System.Data;

namespace BookWise
{
    public class Book
    {
        public int Id;
        public string Title { get; set; }
        public string ISBN { get; set; }
        public string Author { get; set; }
        public string Category { get; set; }
        private bool _available = true;
        public string Available
        {
            get => _available ? "Yes" : "No";
        }

        public bool IsExisting()
        {
            string query = "SELECT COUNT(*) FROM Books WHERE isbn_no = @ISBN";
            object result = DB.ExecuteScalar(query, ISBN);
            return Convert.ToInt32(result) > 0;
        }

        public bool Add()
        {
            string query = "INSERT INTO Books (title, isbn_no, author, category, available) VALUES ( @Title , @ISBN , @Author , @Category , @Available )";
            int rowsAffected = DB.ExecuteQuery(query, Title, ISBN, Author, Category, _available);
            return rowsAffected > 0;
        }

        public bool Update()
        {
            string query = "UPDATE Books SET title = @Title , isbn_no = @ISBN , author = @Author , category = @Category , available = @Available WHERE id = @Id";
            int rowsAffected = DB.ExecuteQuery(query, Title, ISBN, Author, Category, _available, Id);
            return rowsAffected > 0;
        }

        public bool Remove()
        {
            string query = "DELETE FROM Books WHERE id = @Id";
            int rowsAffected = DB.ExecuteQuery(query, Id);
            return rowsAffected > 0;
        }

        public static Book[] GetAll()
        {
            string query = "SELECT id, Title, isbn_no, author, category, available FROM Books";
            DataTable result = DB.ExecuteSelect(query);
            Book[] books = new Book[result.Rows.Count];

            for (int i = 0; i < result.Rows.Count; i++)
            {
                DataRow row = result.Rows[i];
                books[i] = new Book()
                {
                    Id = Convert.ToInt32(row["id"]),
                    Title = row["title"]?.ToString(),
                    ISBN = row["isbn_no"]?.ToString(),
                    Author = row["author"]?.ToString(),
                    Category = row["category"]?.ToString(),
                    _available = Convert.ToBoolean(row["available"])
                };
            }
            return books;
        }

        public static Book[] Search(string _query)
        {
            string query = "%" + _query + "%";
            string searchQuery = "SELECT id, title, isbn_no, author, category, available FROM Books WHERE title LIKE @query OR isbn_no LIKE @query OR author LIKE @query OR category LIKE @query";
            DataTable result = DB.ExecuteSelect(searchQuery, query);
            Book[] books = new Book[result.Rows.Count];

            for (int i = 0; i < result.Rows.Count; i++)
            {
                DataRow row = result.Rows[i];
                books[i] = new Book()
                {
                    Id = Convert.ToInt32(row["id"]),
                    Title = row["title"]?.ToString(),
                    ISBN = row["isbn_no"]?.ToString(),
                    Author = row["author"]?.ToString(),
                    Category = row["category"]?.ToString(),
                    _available = Convert.ToBoolean(row["available"])
                };
            }
            return books;
        }
    }
}
