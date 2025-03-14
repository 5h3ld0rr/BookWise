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
            filterHistoryModal = new FilterHistoryModal();
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
                case DialogResult.Yes:
                    filterData = filterHistoryModal.filterData;
                    RefreshData();
                    break;

                // Filter Reset Button Clicked
                case DialogResult.Abort:
                    filterHistoryModal.Dispose();
                    filterHistoryModal = new FilterHistoryModal();
                    filterData = null;
                    RefreshData();
                    break;
                default:
                    break;
            }
        }
    }
}
