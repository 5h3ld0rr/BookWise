namespace BookWise
{
    public partial class SignInForm : Form
    {
        public string userName;
        public int userId;
        public string userRole;

        public SignInForm()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string email = textBoxEmail.Text;
            string password = textBoxPassword.Text;

            if (String.IsNullOrWhiteSpace(email) || String.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter all the required fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            bool isIdEntered = int.TryParse(email, out int id);
            try
            {
                Admin admin = new Admin()
                {
                    Password = password
                };

                if (isIdEntered)
                {
                    admin.Id = id;
                }
                else
                {
                    admin.Email = email;
                }

                if (admin.Authenticate())
                {
                    userName = admin.FirstName;
                    userId = admin.Id;
                    userRole = admin.Role;
                    DialogResult = DialogResult.OK;
                    Dispose();
                }
                else
                {
                    textBoxEmail.Text = "";
                    textBoxPassword.Text = "";
                    MessageBox.Show("Invalid credentials", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checkBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            textBoxPassword.UseSystemPasswordChar = !checkBoxShowPassword.Checked;
        }
    }
}
