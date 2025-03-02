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
            string query = "SELECT (SELECT COUNT(*) FROM Users) AS TotalUsers,(SELECT COUNT(*) FROM Books) AS TotalBooks, (SELECT COUNT(*) FROM Books WHERE available = 'No') AS BorrowedBooks";
            DataTable result = DB.ExecuteSelect(query);
            DataRow row = result.Rows[0];
            BorrowedBooks = row["BorrowedBooks"].ToString();
            TotalBooks = row["TotalBooks"].ToString();
            TotalUsers = row["TotalUsers"].ToString();
        }
    }
}
