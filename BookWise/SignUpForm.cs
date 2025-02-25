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
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            string email = textBoxEmail.Text;
            string password = textBoxPassword.Text;
            string confirmPassword = textBoxConfirmPassword.Text;

            if (String.IsNullOrWhiteSpace(email)|| String.IsNullOrWhiteSpace(password) || String.IsNullOrWhiteSpace(confirmPassword))
            {
                MessageBox.Show("Please enter all the required fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            User user = new User(email, password);
            if (user.IsRegistered())
            {
                MessageBox.Show("User already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                SignInForm signInForm = new SignInForm();
                signInForm.Show();
                this.Hide();
            }
            else
            {
                user.Register();
                MessageBox.Show("User registered successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SignInForm signInForm = new SignInForm();
                signInForm.Show();
                this.Hide();
            }
        }

        private void linkLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignInForm signInForm = new SignInForm();
            signInForm.Show();
            this.Hide();
        }

        private void checkBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            textBoxPassword.UseSystemPasswordChar = !checkBoxShowPassword.Checked;
            textBoxConfirmPassword.UseSystemPasswordChar = !checkBoxShowPassword.Checked;
        }
    }
}
