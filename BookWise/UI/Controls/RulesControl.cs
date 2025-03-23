namespace BookWise
{
    public partial class RulesControl : UserControl
    {
        public RulesControl()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
            numericUpDownMaxDaysToReturn.Value = CommonData.Rules.MaxDaysToReturn;
            numericUpDownMaxBooksPerUser.Value = CommonData.Rules.MaxBooksPerUser;
            numericUpDownFinePerDay.Value = CommonData.Rules.FinePerDay;
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            CommonData.Rules.MaxDaysToReturn = (int)numericUpDownMaxDaysToReturn.Value;
            CommonData.Rules.MaxBooksPerUser = (int)numericUpDownMaxBooksPerUser.Value;
            CommonData.Rules.FinePerDay = numericUpDownFinePerDay.Value;

            try
            {
                bool updated = CommonData.Rules.Update();
                if (updated)
                    MessageBox.Show("Rules updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Failed to update rules", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
