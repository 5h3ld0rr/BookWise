namespace BookWise
{
    public partial class BorrowBookControl : UserControl
    {
        private User user;
        private bool userInformationConfirmed = false;
        public event EventHandler BookBorrowed;
        public BorrowBookControl()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
        }

        private void buttonSaveUserInfo_Click(object sender, EventArgs e)
        {
            if (userInformationConfirmed)
            {
                userInformationConfirmed = false;
                ToggleControls();
                return;
            }

            int userId = (int)numericUpDownId.Value;
            string nic = textBoxNic.Text;
            string email = textBoxEmail.Text;

            bool isEnteredOneField = userId > 0 || !String.IsNullOrWhiteSpace(nic) || !String.IsNullOrWhiteSpace(email);

            if (!isEnteredOneField)
            {
                MessageBox.Show("Please enter at least one field", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            user = User.GetUserByUniqueIdentifier(userId, nic, email);

            if (user == null)
            {
                MessageBox.Show("User not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (user.BorrowedBooks.Length >= CommonData.Rules.MaxBooksPerUser)
            {
                MessageBox.Show("User has already borrowed maximum number of books", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            textBoxName.Text = user.FirstName + " " + user.LastName;
            numericUpDownId.Value = user.Id;
            textBoxNic.Text = user.NIC;
            textBoxEmail.Text = user.Email;
            textBoxPhone.Text = user.Phone;
            textBoxAddress.Text = user.Address;

            userInformationConfirmed = true;
            ToggleControls();
        }

        private void ToggleControls()
        {
            numericUpDownId.Enabled = !userInformationConfirmed;
            textBoxNic.Enabled = !userInformationConfirmed;
            textBoxEmail.Enabled = !userInformationConfirmed;

            buttonSaveUserInfo.Text = userInformationConfirmed ? "Edit" : "Save";
        }
    }
}
