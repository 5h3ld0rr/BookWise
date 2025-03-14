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
        public string Date { get => _date.ToShortDateString(); }
        public string Time { get => _date.ToShortTimeString(); }

        public void Save()
        {
            string query = "INSERT INTO book_transactions (user_id, book_id, action, date, time) VALUES (@UserId, @BookId, @Action, @Date, @Time)";
            DB.ExecuteQuery(query, UserId, BookId, Date, Status);
        }
        public static BookTransaction[] GetAll(FilterHistoryModal.FilterData filterData)
        {
            string query = "SELECT user_id, CONCAT(first_name,' ', last_name) AS user_name , title, isbn_no, status, date FROM book_transactions bt INNER JOIN users u ON user_id = u.id INNER JOIN books b ON book_id = b.id";

            List<object> filterParams = new List<object>();

            if (filterData != null)
            {
                query += " WHERE (date BETWEEN @StartDate AND @EndDate)";
                filterParams.Add(filterData.StartDate);
                filterParams.Add(filterData.EndDate);
                if (filterData.Status != "All")
                {
                    query += " AND status = @Status";
                    filterParams.Add(filterData.Status);
                }
            }
            query += " ORDER BY date DESC";

            DataTable result = DB.ExecuteSelect(query, filterParams.ToArray());
            BookTransaction[] transactions = new BookTransaction[result.Rows.Count];

            for (int i = 0; i < result.Rows.Count; i++)
            {
                DataRow row = result.Rows[i];
                transactions[i] = new BookTransaction()
                {
                    UserId = Convert.ToInt32(row["user_id"]),
                    UserName = row["user_name"].ToString(),
                    BookTitle = row["title"].ToString(),
                    ISBN = row["isbn_no"].ToString(),
                    Status = row["status"].ToString(),
                    _date = Convert.ToDateTime(row["date"])
                };
            }
            return transactions;
        }
        public static BookTransaction[] GetByUser(int userId)
        {
            string query = "SELECT * FROM book_transactions WHERE user_id = @userId";
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
        public static BookTransaction[] Search(string _searchQuery, FilterHistoryModal.FilterData filterData)
        {
            string searchQuery = "%" + _searchQuery + "%";

            string query = "SELECT bt.user_id, first_name, last_name, title, isbn_no, status, date FROM book_transactions bt INNER JOIN users u ON bt.user_id = u.id INNER JOIN books b ON bt.book_id = b.id WHERE (u.id LIKE @query OR first_name LIKE @query OR last_name LIKE @query OR title LIKE @query OR isbn_no LIKE @query)";

            List<object> filterParams = new List<object>();
            filterParams.Add(searchQuery);
            if (filterData != null)
            {
                query += " AND date BETWEEN @StartDate AND @EndDate";
                filterParams.Add(filterData.StartDate);
                filterParams.Add(filterData.EndDate);
                if (filterData.Status != "All")
                {
                    query += " AND status = @Status";
                    filterParams.Add(filterData.Status);
                }
            }
            query += " ORDER BY date DESC";

            DataTable result = DB.ExecuteSelect(query, filterParams.ToArray());
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
    }
}
