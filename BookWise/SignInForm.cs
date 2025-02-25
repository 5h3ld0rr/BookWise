using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookWise.Classes;


namespace BookWise
{
    public partial class SignInForm : Form
    {
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

            User user = new User(email,password);

            if (user.Authenticate())
            {
                MainForm mainForm = new MainForm();
                mainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid email or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxEmail.Text = "";
                textBoxPassword.Text = "";
            }
        }

        private void linkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUpForm signUpForm = new SignUpForm();
            signUpForm.Show();
            this.Hide();
        }

        private void checkBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            textBoxPassword.UseSystemPasswordChar = !checkBoxShowPassword.Checked;
        }
    }
}
