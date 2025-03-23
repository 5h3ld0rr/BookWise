using System.Data;

namespace BookWise
{
    public static class CommonData
    {
        public static class Stats
        {
            public static string BorrowedBooks;
            public static string TotalBooks;
            public static string TotalUsers;
            public static void Refresh()
            {
                string query = "SELECT (SELECT COUNT(*) FROM users) AS TotalUsers,(SELECT SUM(available_books) FROM books) AS AvailableBooks, (SELECT COUNT(*) FROM book_transactions WHERE ISNULL(return_date)) AS BorrowedBooks";
                DataTable result = DB.ExecuteSelect(query);
                DataRow row = result.Rows[0];
                BorrowedBooks = row["BorrowedBooks"].ToString();
                TotalBooks = (Convert.ToInt32(row["AvailableBooks"]) + Convert.ToInt32(BorrowedBooks)).ToString();
                TotalUsers = row["TotalUsers"].ToString();
            }
        }

        public static class Rules
        {
            public static int MaxBooksPerUser;
            public static int MaxDaysToReturn;
            public static decimal FinePerDay;

            public static void Refresh()
            {
                string query = "SELECT * FROM rules";
                DataTable result = DB.ExecuteSelect(query);
                DataRow row = result.Rows[0];
                MaxBooksPerUser = Convert.ToInt32(row["max_books_per_user"]);
                MaxDaysToReturn = Convert.ToInt32(row["max_days_to_return"]);
                FinePerDay = Convert.ToDecimal(row["fine_per_day"]);
            }

            public static bool Update()
            {
                string query = "UPDATE rules SET max_books_per_user = @MaxBooksPerUser, max_days_to_return = @MaxDaysToReturn, fine_per_day = @FinePerDay";
                int rowsAffected = DB.ExecuteQuery(query, MaxBooksPerUser, MaxDaysToReturn, FinePerDay);
                return rowsAffected > 0;
            }
        }
    }
}
