namespace BookWise
{
    public partial class RulesControl : UserControl
    {
        public RulesControl()
        {
            InitializeComponent();
            numericUpDownMaxDaysToReturn.Value = MasterData.Rules.MaxDaysToReturn;
            numericUpDownMaxBooksPerUser.Value = MasterData.Rules.MaxBooksPerUser;
            numericUpDownFinePerDay.Value = MasterData.Rules.FinePerDay;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            MasterData.Rules.MaxDaysToReturn = (int)numericUpDownMaxDaysToReturn.Value;
            MasterData.Rules.MaxBooksPerUser = (int)numericUpDownMaxBooksPerUser.Value;
            MasterData.Rules.FinePerDay = numericUpDownFinePerDay.Value;

            try
            {
                bool updated = MasterData.Rules.Update();
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
