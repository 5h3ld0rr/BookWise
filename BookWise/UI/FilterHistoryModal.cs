namespace BookWise
{
    public partial class FilterHistoryModal : Form
    {
        public class FilterData
        {
            public string BorrowStartDate;
            public string BorrowEndDate;
            public string ReturnStartDate;
            public string ReturnEndDate;
            public string Status;
            public string Overdue;

            public FilterData()
            {
                BorrowStartDate = "2025-01-01";
                BorrowEndDate = DateTime.Now.ToString();
                ReturnStartDate = "2025-01-01";
                ReturnEndDate = DateTime.Now.ToString();
                Status = "Any";
                Overdue = "Any";
            }
        }

        public FilterData filterData;
        public FilterHistoryModal()
        {
            InitializeComponent();
            dateTimePickerBorrowStartDate.CustomFormat = "yyyy-MM-dd hh:mm tt";
            dateTimePickerBorrowEndDate.CustomFormat = "yyyy-MM-dd hh:mm tt";
            dateTimePickerReturnStartDate.CustomFormat = "yyyy-MM-dd hh:mm tt";
            dateTimePickerReturnEndDate.CustomFormat = "yyyy-MM-dd hh:mm tt";
            ClearFilter();
        }

        public void ClearFilter()
        {
            filterData = new FilterData();
            dateTimePickerBorrowStartDate.Value = Convert.ToDateTime(filterData.BorrowStartDate);
            dateTimePickerBorrowEndDate.Value = Convert.ToDateTime(filterData.BorrowEndDate);
            dateTimePickerReturnStartDate.Value = Convert.ToDateTime(filterData.ReturnStartDate);
            dateTimePickerReturnEndDate.Value = Convert.ToDateTime(filterData.ReturnEndDate);
            comboBoxStatus.Text = filterData.Status;
            comboBoxOverdue.Text = filterData.Overdue;
        }

        private void buttonApply_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Yes;
            Hide();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Abort;
            Hide();
        }

        private void dateTimePickerBorrowStartDate_ValueChanged(object sender, EventArgs e)
        {
            filterData.BorrowStartDate = dateTimePickerBorrowStartDate.Value.ToString("s");
        }

        private void dateTimePickerBorrowEndDate_ValueChanged(object sender, EventArgs e)
        {
            filterData.BorrowEndDate = dateTimePickerBorrowEndDate.Value.ToString("s");
        }

        private void comboBoxStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            filterData.Status = comboBoxStatus.Text;
        }

        private void dateTimePickerReturnStartDate_ValueChanged(object sender, EventArgs e)
        {
            filterData.ReturnStartDate = dateTimePickerReturnStartDate.Value.ToString("s");
        }

        private void dateTimePickerReturnEndDate_ValueChanged(object sender, EventArgs e)
        {
            filterData.ReturnEndDate = dateTimePickerReturnEndDate.Value.ToString("s");
        }

        private void comboBoxOverdue_SelectedIndexChanged(object sender, EventArgs e)
        {
            filterData.Overdue = comboBoxOverdue.Text;
        }
    }
}
