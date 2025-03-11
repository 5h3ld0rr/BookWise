namespace BookWise
{
    public partial class AddUserModal : BaseForm
    {
        private User? user;
        public AddUserModal(bool allowChangeRole, User? user = null)
        {
            InitializeComponent();
            comboBoxRole.Enabled = allowChangeRole;
            comboBoxRole.SelectedIndex = 0;

            if (user != null)
            {
                this.user = user;
                textBoxId.Text = user.Id.ToString();
                textBoxId.Enabled = false;
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
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string Id = textBoxId.Text;
            string FirstName = textBoxFName.Text;
            string LastName = textBoxLName.Text;
            string Email = textBoxEmail.Text;
            string Role = comboBoxRole.Text;
            string NIC = textBoxNic.Text;
            string Phone = textBoxPhone.Text;
            string Address = textBoxAddress.Text;
            string Password = textBoxPassword.Text;
            string ConfirmPassword = textBoxConfirmPassword.Text;
            bool passwordRequired = (Role != "Student" && (user?.Role == "Student" || user == null));

            bool notEnteredRequiredFields = String.IsNullOrWhiteSpace(Id) || String.IsNullOrWhiteSpace(FirstName) || String.IsNullOrWhiteSpace(LastName) || String.IsNullOrWhiteSpace(Email) || String.IsNullOrWhiteSpace(Role) || String.IsNullOrWhiteSpace(NIC) || String.IsNullOrWhiteSpace(Phone) || String.IsNullOrWhiteSpace(Address) || passwordRequired && (String.IsNullOrWhiteSpace(Password) || String.IsNullOrWhiteSpace(ConfirmPassword));

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

            try
            {
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

                    user.Update();
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    user = new User()
                    {
                        Id = Convert.ToInt32(Id),
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
                        user.Register();
                        //new UserRegisterMail(FirstName).Send(Email);
                        DialogResult = DialogResult.OK;
                    }
                }
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checkBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            textBoxPassword.UseSystemPasswordChar = !checkBoxShowPassword.Checked;
            textBoxConfirmPassword.UseSystemPasswordChar = !checkBoxShowPassword.Checked;

        }

        private void comboBoxRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool isUser = comboBoxRole.Text == "Student";
            textBoxPassword.Enabled = !isUser;
            textBoxConfirmPassword.Enabled = !isUser;
            if (isUser)
            {
                textBoxPassword.Text = "";
                textBoxConfirmPassword.Text = "";
            }

        }

        private void textBoxId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != '-')
            {
                e.Handled = true;
            }
        }
    }
}
