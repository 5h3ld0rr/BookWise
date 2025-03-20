namespace BookWise
{
    public partial class HistoryControl : UserControl
    {
        private FilterHistoryModal filterHistoryModal;
        private FilterHistoryModal.FilterData filterData;
        public HistoryControl()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
            RefreshData();
            labelFilterApplied.Visible = false;
            filterHistoryModal = new FilterHistoryModal();
            dataGridViewBookTransactions.Columns["isbn_no"].HeaderText = "ISBN No";
            dataGridViewBookTransactions.Columns["title"].HeaderText = "Book Title";
            dataGridViewBookTransactions.Columns["user_id"].HeaderText = "User ID";
            dataGridViewBookTransactions.Columns["user_name"].HeaderText = "User Name";
            dataGridViewBookTransactions.Columns["borrowdate"].HeaderText = "Borrow Date";
            dataGridViewBookTransactions.Columns["returndate"].HeaderText = "Return Date";
        }
        public void RefreshData()
        {
            dataGridViewBookTransactions.DataSource = BookTransaction.GetAll(filterData);
        }
        public void Search(string query)
        {
            if (query.Length == 0)
            {
                RefreshData();
            }
            else
            {
                dataGridViewBookTransactions.DataSource = BookTransaction.Search(query, filterData);
            }
        }

        private void buttonFilter_Click(object sender, EventArgs e)
        {
            DialogResult result = filterHistoryModal.ShowDialog();

            switch (result)
            {
                // Apply filter
                case DialogResult.Yes:
                    filterData = filterHistoryModal.filterData;
                    RefreshData();
                    labelFilterApplied.Visible = true;
                    break;

                // Clear filter
                case DialogResult.Abort:
                    filterHistoryModal.ClearFilter();
                    filterData = null;
                    RefreshData();
                    labelFilterApplied.Visible = false;
                    break;
                default:
                    break;
            }
        }
    }
}
