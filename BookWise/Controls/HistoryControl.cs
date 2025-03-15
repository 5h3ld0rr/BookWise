namespace BookWise
{
    public partial class HistoryControl : UserControl
    {
        private FilterHistoryModal filterHistoryModal;
        private FilterHistoryModal.FilterData filterData;
        public HistoryControl()
        {
            InitializeComponent();
            RefreshData();
            labelFilterApplied.Visible = false;
            filterHistoryModal = new FilterHistoryModal();
            dataGridViewBookTransactions.Columns["UserId"].HeaderText = "User ID";
            dataGridViewBookTransactions.Columns["UserName"].HeaderText = "User Name";
            dataGridViewBookTransactions.Columns["BookTitle"].HeaderText = "Book Title";
            dataGridViewBookTransactions.Columns["ISBN"].HeaderText = "ISBN No";
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
