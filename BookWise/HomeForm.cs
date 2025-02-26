using BookWise.Controls;

namespace BookWise
{
    public partial class HomeForm : BaseForm
    {
        private Button[] SideBarBtns;
        private SignInForm signInForm;
        private UserControl? currentControl;
        public HomeForm(SignInForm _signInForm, string? firstName)
        {
            InitializeComponent();
            signInForm = _signInForm;
            labelFName.Text = firstName;
            SideBarBtns = [buttonHome, buttonBooks, buttonUsers, buttonHistory];
            LoadControl(new HomeControl());
        }
        private void buttonLogout_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to logout?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.No) return;

            signInForm.Show();
            Dispose();
        }

        private void HighlightButton(Button button)
        {
            ResetButtonStyles();
            button.BackColor = Color.FromArgb(37, 56, 140);
            button.ForeColor = Color.White;
        }

        private void ResetButtonStyles()
        {
            for (int i = 0; i < SideBarBtns.Length; i++)
            {
                SideBarBtns[i].BackColor = Color.White;
                SideBarBtns[i].ForeColor = Color.FromArgb(58, 53, 78);
            }
        }
        private void LoadControl(UserControl control)
        {
            if (currentControl != null)
            {
                panelContainer.Controls.Remove(currentControl);
                currentControl.Dispose();
            }
            currentControl = control;
            control.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(control);
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            HighlightButton(buttonHome);
            LoadControl(new HomeControl());
        }

        private void buttonAllBooks_Click(object sender, EventArgs e)
        {
            HighlightButton(buttonBooks);
            LoadControl(new BooksControl());
        }
        private void buttonUsers_Click(object sender, EventArgs e)
        {
            HighlightButton(buttonUsers);
            LoadControl(new UserControl());
        }

        private void buttonHistory_Click(object sender, EventArgs e)
        {
            HighlightButton(buttonHistory);
            LoadControl(new HistoryControl());
        }
    }
}
