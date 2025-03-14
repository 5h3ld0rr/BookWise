namespace BookWise
{
    public partial class FilterHistoryModal : BaseForm
    {
        public class FilterData
        {
            public string StartDate;
            public string EndDate;
            public string Status;

            public FilterData()
            {
                StartDate = "2025-01-01";
                EndDate = DateTime.Now.AddDays(1).ToString("yyyy-MM-dd");
                Status = "All";
            }
        }

        public FilterData filterData;
        public FilterHistoryModal()
        {
            InitializeComponent();
            filterData = new FilterData();
            comboBoxStatus.Text = filterData.Status;
            dateTimePickerStartDate.Value = Convert.ToDateTime(filterData.StartDate);
            dateTimePickerEndDate.Value = Convert.ToDateTime(filterData.EndDate);
        }

        private void buttonFilter_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Yes;
            Hide();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Abort;
            Hide();
        }

        private void dateTimePickerStartDate_ValueChanged(object sender, EventArgs e)
        {
            filterData.StartDate = dateTimePickerStartDate.Value.ToString("yyyy-MM-dd");
        }

        private void dateTimePickerEndDate_ValueChanged(object sender, EventArgs e)
        {
            filterData.EndDate = dateTimePickerEndDate.Value.ToString("yyyy-MM-dd");
        }

        private void comboBoxStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            filterData.Status = comboBoxStatus.Text;
        }
    }
}
