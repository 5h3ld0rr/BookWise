namespace BookWise
{
    public partial class HomeControl : UserControl
    {
        public HomeControl()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
            RefreshData();
        }

        public void RefreshData()
        {
            CommonData.Stats.Refresh();
            labelBorrowedBooks.Text = CommonData.Stats.BorrowedBooks;
            labelAllBooks.Text = CommonData.Stats.TotalBooks;
            labelTotalUsers.Text = CommonData.Stats.TotalUsers;
        }
    }
}
