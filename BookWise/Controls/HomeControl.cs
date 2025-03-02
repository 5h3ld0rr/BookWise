namespace BookWise
{
    public partial class HomeControl : UserControl
    {
        public HomeControl()
        {
            InitializeComponent();
            RefreshData();
        }
        public void RefreshData()
        {
            Stats.Update();
            labelBorrowedBooks.Text = Stats.BorrowedBooks;
            labelAllBooks.Text = Stats.TotalBooks;
            labelTotalUsers.Text = Stats.TotalUsers;
        }
    }
}
