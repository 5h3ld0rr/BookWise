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
            MasterData.Stats.Refresh();
            labelBorrowedBooks.Text = MasterData.Stats.BorrowedBooks;
            labelAllBooks.Text = MasterData.Stats.TotalBooks;
            labelTotalUsers.Text = MasterData.Stats.TotalUsers;
        }
    }
}
