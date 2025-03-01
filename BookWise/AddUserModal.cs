namespace BookWise
{
    public partial class AddUserModal : BaseForm
    {
        private User? user;
        public AddUserModal(bool allowChangeRole, User? user = null)
        {
            InitializeComponent();
            if (user != null)
            {
                this.user = user;
                textBoxFName.Text = user.FirstName;
                textBoxLName.Text = user.LastName;
                textBoxEmail.Text = user.Email;
                comboBoxRole.Text = user.Role;
                textBoxNic.Text = user.NIC;
                textBoxPhone.Text = user.Phone;
                textBoxAddress.Text = user.Address;

                Text = "Update an Existing User";
                buttonSave.Text = "Update User";
            }
            comboBoxRole.Enabled = allowChangeRole;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string FirstName = textBoxFName.Text;
            string LastName = textBoxLName.Text;
            string Email = textBoxEmail.Text;
            string Role = comboBoxRole.Text;
            string NIC = textBoxNic.Text;
            string Phone = textBoxPhone.Text;
            string Address = textBoxAddress.Text;
            string Password = textBoxPassword.Text;
            string ConfirmPassword = textBoxConfirmPassword.Text;
            bool passwordRequired = (Role != "User" && (user?.Role == "User" || user == null));

            bool notEnteredRequiredFields = String.IsNullOrWhiteSpace(FirstName) || String.IsNullOrWhiteSpace(LastName) || String.IsNullOrWhiteSpace(Email) || String.IsNullOrWhiteSpace(Role) || String.IsNullOrWhiteSpace(NIC) || String.IsNullOrWhiteSpace(Phone) || String.IsNullOrWhiteSpace(Address) || passwordRequired && (String.IsNullOrWhiteSpace(Password) || String.IsNullOrWhiteSpace(ConfirmPassword));

            if (notEnteredRequiredFields)
            {
                MessageBox.Show("Please enter all the required fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Password != ConfirmPassword)
            {
                MessageBox.Show("Passwords do not match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (user != null)
            {
                user.FirstName = FirstName;
                user.LastName = LastName;
                user.Email = Email;
                user.Role = Role;
                user.NIC = NIC;
                user.Phone = Phone;
                user.Address = Address;
                user.Password = Password;

                if (user.Update())
                {
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Failed to update user", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    DialogResult = DialogResult.Cancel;
                }
            }
            else
            {
                user = new User()
                {
                    FirstName = FirstName,
                    LastName = LastName,
                    Email = Email,
                    Role = Role,
                    NIC = NIC,
                    Phone = Phone,
                    Address = Address,
                    Password = Password
                };

                if (user.IsRegistered())
                {
                    MessageBox.Show("User already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    DialogResult = DialogResult.Cancel;
                }
                else
                {
                    if (user.Register())
                    {
                        DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show("Failed to add user", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        DialogResult = DialogResult.Cancel;
                    }
                }
            }
            Close();
        }

        private void checkBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            textBoxPassword.UseSystemPasswordChar = !checkBoxShowPassword.Checked;
            textBoxConfirmPassword.UseSystemPasswordChar = !checkBoxShowPassword.Checked;

        }

        private void comboBoxRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool isUser = comboBoxRole.Text == "User";
            textBoxPassword.Enabled = !isUser;
            textBoxConfirmPassword.Enabled = !isUser;
            if (isUser)
            {
                textBoxPassword.Text = "";
                textBoxConfirmPassword.Text = "";
            }

        }
    }
}
