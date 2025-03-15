using System.Data;

namespace BookWise
{
    public static class Stats
    {
        public static string BorrowedBooks;
        public static string TotalBooks;
        public static string TotalUsers;
        public static void Update()
        {
            string query = "SELECT (SELECT COUNT(*) FROM users) AS TotalUsers,(SELECT SUM(available_books) FROM books) AS AvailableBooks, ((SELECT COUNT(*) FROM book_transactions WHERE status = 'Borrowed') - (SELECT COUNT(*) FROM book_transactions WHERE status = 'Returned')) AS BorrowedBooks";
            DataTable result = DB.ExecuteSelect(query);
            DataRow row = result.Rows[0];
            BorrowedBooks = row["BorrowedBooks"].ToString();
            TotalBooks = (Convert.ToInt32(row["AvailableBooks"]) + Convert.ToInt32(BorrowedBooks)).ToString();
            TotalUsers = row["TotalUsers"].ToString();
        }
    }
}
