namespace BookWise
{
    public partial class HomeControl : UserControl
    {
        public HomeControl()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
            RefreshData();
            VisibleChanged += (sender, e) => RefreshData();
        }

        public void RefreshData()
        {
            if (!Visible) return;
            MasterData.Stats.Refresh();
            labelBorrowedBooks.Text = MasterData.Stats.BorrowedBooks;
            labelAllBooks.Text = MasterData.Stats.TotalBooks;
            labelTotalUsers.Text = MasterData.Stats.TotalUsers;
        }
    }
}
