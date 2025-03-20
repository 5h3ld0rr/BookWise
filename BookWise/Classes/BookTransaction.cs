using System.Data;

namespace BookWise
{
    public class BookTransaction
    {
        public int Id;
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string BookTitle { get; set; }
        public string ISBN { get; set; }
        public int BookId;
        private DateTime _date;
        public string Status { get; set; }
        public string Date;
        public string Time { get => Convert.ToDateTime(Time).ToString("hh:mm"); }

        public void Save()
        {
            string query = "INSERT INTO book_transactions (user_id, book_id, action, date, time) VALUES (@UserId, @BookId, @Action, @Date, @Time)";
            DB.ExecuteQuery(query, UserId, BookId, Date, Status);
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
        public static BookTransaction[] GetUnreturnedBooksByUser(int userId)
        {
            string query = "SELECT * FROM book_transactions WHERE user_id = @userId AND ISNULL(return_date)";
            DataTable result = DB.ExecuteSelect(query, userId);
            BookTransaction[] transactions = new BookTransaction[result.Rows.Count];

            for (int i = 0; i < result.Rows.Count; i++)
            {
                DataRow row = result.Rows[i];
                transactions[i] = new BookTransaction()
                {
                    UserId = Convert.ToInt32(row["user_id"]),
                    UserName = row["first_name"].ToString() + " " + row["last_name"].ToString(),
                    BookTitle = row["title"].ToString(),
                    ISBN = row["isbn_no"].ToString(),
                    Status = row["status"].ToString(),
                    _date = Convert.ToDateTime(row["date"])
                };
            }
            return transactions;
        }

        private static (string query, string[] parameters) GetBookTransactionsQueryAndParams(FilterHistoryModal.FilterData filterData, string? searchQuery = null)
        {
            string query = "SELECT isbn_no, title as Title, user_id, CONCAT(first_name,' ', last_name) AS user_name, DATE_FORMAT(borrow_date, '%Y-%m-%d %h:%i %p') as borrowdate,DATE_FORMAT(return_date, '%Y-%m-%d %h:%i %p') as returndate FROM book_transactions bt INNER JOIN users u ON bt.user_id = u.id INNER JOIN books b ON bt.book_id = b.id";

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

                int days = MasterData.Rules.MaxDaysToReturn;

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
            query += " ORDER BY bt.return_date DESC, bt.borrow_date DESC";
            return (query, filterParams.ToArray());
        }
    }
}
