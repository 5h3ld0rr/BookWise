using System.Data;

namespace BookWise
{
    public class Book
    {
        public int Id;
        public int TransactionId;

        public string Title { get; set; }
        public string ISBN { get; set; }
        public string Author { get; set; }
        public string Category { get; set; }
        public int AvailableBooks { get; set; }

        public bool IsExisting()
        {
            string query = "SELECT COUNT(*) FROM books WHERE isbn_no = @ISBN";
            object result = DB.ExecuteScalar(query, ISBN);
            return Convert.ToInt32(result) > 0;
        }

        public bool Add()
        {
            string query = "INSERT INTO books (title, isbn_no, author, category, available_books) VALUES ( @Title , @ISBN , @Author , @Category , @AvailableBooks )";
            int rowsAffected = DB.ExecuteQuery(query, Title, ISBN, Author, Category, AvailableBooks);
            return rowsAffected > 0;
        }

        public bool Update()
        {
            string query = "UPDATE books SET title = @Title , isbn_no = @ISBN , author = @Author , category = @Category , available_books = @AvailableBooks WHERE id = @Id";
            int rowsAffected = DB.ExecuteQuery(query, Title, ISBN, Author, Category, AvailableBooks, Id);
            return rowsAffected > 0;
        }

        public bool Remove()
        {
            string query = "DELETE FROM books WHERE id = @Id";
            int rowsAffected = DB.ExecuteQuery(query, Id);
            return rowsAffected > 0;
        }

        public static Book[] GetAll()
        {
            string query = "SELECT id, Title, isbn_no, author, category, available_books FROM books ORDER BY id DESC";
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
                    AvailableBooks = Convert.ToInt32(row["available_books"])
                };
            }
            return books;
        }

        public static Book[] Search(string _searchQuery)
        {
            string searchQuery = "%" + _searchQuery + "%";
            string query = "SELECT id, title, isbn_no, author, category, available FROM books WHERE title LIKE @query OR isbn_no LIKE @query OR author LIKE @query OR category LIKE @query ORDER BY id DESC";
            DataTable result = DB.ExecuteSelect(query, searchQuery);
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
                    AvailableBooks = Convert.ToInt32(row["available_books"])
                };
            }
            return books;
        }
        public bool Borrow(int userId)
        {
            string query = "UPDATE books SET available_books = available_books - 1 WHERE id = @Id";
            int rowsAffected = DB.ExecuteQuery(query, Id);

            if (rowsAffected > 0)
            {
                return BookTransaction.Create(userId, Id);
            }
            return false;
        }

        public bool Return()
        {
            string query = "UPDATE books SET available_books = available_books + 1 WHERE id = @Id";
            int rowsAffected = DB.ExecuteQuery(query, Id);

            if (rowsAffected > 0)
            {
                return BookTransaction.UpdateReturn(TransactionId);
            }
            return false;
        }
    }
}
