using System.Data;

namespace BookWise
{
    public static class BookTransaction
    {
        public static bool Create(int userId, int bookId)
        {
            string date = DateTime.Now.ToString("s");
            string query = "INSERT INTO book_transactions (user_id, book_id, borrow_date) VALUES (@UserId, @BookId, @Date)";
            int rowsAffected = DB.ExecuteQuery(query, userId, bookId, date);
            return rowsAffected > 0;
        }
        public static bool UpdateReturn(int id)
        {
            string date = DateTime.Now.ToString("s");
            string query = "UPDATE book_transactions SET return_date = @ReturnDate WHERE id = @Id";
            int rowsAffected = DB.ExecuteQuery(query, date, id);
            return rowsAffected > 0;
        }

        public static (DateTime dueDate, int noOfDaysOverdue, decimal fine) GetReturnDetailsByBorrowDate(DateTime borrowDate)
        {
            DateTime dueDate = borrowDate.AddDays(CommonData.Rules.MaxDaysToReturn);
            int noOfDaysOverdue = (DateTime.Now - dueDate).Days;
            decimal fine = noOfDaysOverdue > 0 ? noOfDaysOverdue * CommonData.Rules.FinePerDay : 0.00M;

            return (dueDate, noOfDaysOverdue, fine);
        }
        public static DataTable GetAll(FilterHistoryModal.FilterData filterData)
        {
            var bookTransactions = GetBookTransactionsQueryAndParams(filterData);

            DataTable result = DB.ExecuteSelect(bookTransactions.query, bookTransactions.parameters);

            return result;
        }
        public static DataTable Search(string _searchQuery, FilterHistoryModal.FilterData filterData)
        {
            string searchQuery = "%" + _searchQuery + "%";
            var bookTransactions = GetBookTransactionsQueryAndParams(filterData, searchQuery);

            DataTable result = DB.ExecuteSelect(bookTransactions.query, bookTransactions.parameters);
            return result;
        }
        public static Book[] GetUnreturnedBooksByUser(int userId)
        {
            string query = "SELECT bt.id, book_id, title, isbn_no, author, borrow_date, category, available_books FROM book_transactions bt INNER JOIN books b ON b.id = bt.book_id WHERE user_id = @userId AND ISNULL(return_date)";
            DataTable result = DB.ExecuteSelect(query, userId);
            Book[] books = new Book[result.Rows.Count];

            for (int i = 0; i < result.Rows.Count; i++)
            {
                DataRow row = result.Rows[i];
                books[i] = new Book()
                {
                    Id = Convert.ToInt32(row["book_id"]),
                    Title = row["title"].ToString(),
                    ISBN = row["isbn_no"].ToString(),
                    Author = row["author"].ToString(),
                    Category = row["category"].ToString(),
                    AvailableBooks = Convert.ToInt32(row["available_books"]),
                    TransactionId = Convert.ToInt32(row["id"]),
                    BorrowDate = Convert.ToDateTime(row["borrow_date"])
                }
            ;
            }
            return books;
        }

        private static (string query, string[] parameters) GetBookTransactionsQueryAndParams(FilterHistoryModal.FilterData filterData, string? searchQuery = null)
        {
            string query = "SELECT isbn_no, title as Title, user_id, CONCAT(first_name,' ', last_name) AS user_name, borrow_date, return_date FROM book_transactions bt INNER JOIN users u ON bt.user_id = u.id INNER JOIN books b ON bt.book_id = b.id";

            List<string> filterParams = new List<string>();

            if (searchQuery != null)
            {
                query += " WHERE (u.id LIKE @query OR first_name LIKE @query OR last_name LIKE @query OR title LIKE @query OR isbn_no LIKE @query)";
                filterParams.Add(searchQuery);
            }
            if (filterData != null)
            {
                query += $"{(searchQuery == null ? " WHERE" : " AND")} (borrow_date BETWEEN @BorrowStartDate AND @BorrowEndDate) AND (ISNULL(return_date) OR (return_date BETWEEN @ReturnStartDate AND @ReturnEndDate))";
                filterParams.Add(filterData.BorrowStartDate);
                filterParams.Add(filterData.BorrowEndDate);
                filterParams.Add(filterData.ReturnStartDate);
                filterParams.Add(filterData.ReturnEndDate);

                switch (filterData.Status)
                {
                    case "Returned":
                        query += " AND NOT ISNULL(return_date)";
                        break;
                    case "Unreturned":
                        query += " AND ISNULL(return_date)";
                        break;
                    default:
                        break;
                }

                int days = CommonData.Rules.MaxDaysToReturn;

                switch (filterData.Overdue)
                {
                    case "Yes":
                        query += $" AND IF(ISNULL(return_date), DATEDIFF(NOW(), borrow_date), DATEDIFF(return_date, borrow_date)) > {days}";
                        break;
                    case "No":
                        query += $" AND IF(ISNULL(return_date), DATEDIFF(NOW(), borrow_date), DATEDIFF(return_date, borrow_date)) < {days}";
                        break;
                    default:
                        break;
                }
            }
            query += " ORDER BY COALESCE(bt.return_date, bt.borrow_date) DESC";
            return (query, filterParams.ToArray());
        }
    }
}
