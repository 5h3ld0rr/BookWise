namespace BookWise
{
    public partial class HomeForm : Form
    {
        private Button[] SideBarBtns;
        private UserControl currentControl;
        private HomeControl homeControl;
        private IssueBookControl issueBookControl;
        private ReturnBookControl returnBookControl;
        private BooksControl booksControl;
        private UsersControl usersControl;
        private HistoryControl historyControl;
        private RulesControl rulesControl;

        private int userId;
        private string userRole;
        public HomeForm(string firstName, int userId, string userRole)
        {
            InitializeComponent();
            labelFName.Text = firstName;
            this.userId = userId;
            this.userRole = userRole;
            FormClosing += HomeForm_FormClosing;
            SideBarBtns = [buttonHome, buttonIssue, buttonReturn, buttonBooks, buttonUsers, buttonHistory, buttonRules];
            buttonRules.Visible = userRole == "Admin";
            MasterData.Rules.Refresh();
            homeControl = new HomeControl();
            issueBookControl = new IssueBookControl();
            returnBookControl = new ReturnBookControl();
            booksControl = new BooksControl();
            usersControl = new UsersControl(userId, userRole);
            historyControl = new HistoryControl();
            rulesControl = new RulesControl();
            LoadControl(homeControl);
        }
        private void HomeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason != CloseReason.UserClosing) return;

            DialogResult dialogResult = MessageBox.Show("Are you sure you want to close?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.No)
            {
                e.Cancel = true;
            }
            else if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void buttonLogout_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to logout?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.No) return;
            Application.Restart();
        }

        private void HighlightButton(Button button)
        {
            ResetButtonStyles();
            button.BackColor = Color.FromArgb(37, 56, 140);
            button.ForeColor = Color.White;
        }

        private void ResetButtonStyles()
        {
            foreach (Button btn in SideBarBtns)
            {
                btn.BackColor = Color.White;
                btn.ForeColor = Color.FromArgb(58, 53, 78);
            }
        }
        private void LoadControl(UserControl control)
        {
            if (currentControl == control) return;
            (control as dynamic).RefreshData();
            if (currentControl != null)
            {
                panelContainer.Controls.Remove(currentControl);
            }
            currentControl = control;
            panelContainer.Controls.Add(control);
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            panelSearch.Visible = false;
            HighlightButton(buttonHome);
            LoadControl(homeControl);
        }

        private void buttonIssue_Click(object sender, EventArgs e)
        {
            panelSearch.Visible = false;
            HighlightButton(buttonIssue);
            LoadControl(issueBookControl);
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            panelSearch.Visible = false;
            HighlightButton(buttonReturn);
            LoadControl(returnBookControl);
        }

        private void buttonBooks_Click(object sender, EventArgs e)
        {
            panelSearch.Visible = true;
            textBoxSearch.Text = "";
            textBoxSearch.PlaceholderText = "Search books by name, author, isbn or category";
            HighlightButton(buttonBooks);
            LoadControl(booksControl);
        }
        private void buttonUsers_Click(object sender, EventArgs e)
        {
            panelSearch.Visible = true;
            textBoxSearch.Text = "";
            textBoxSearch.PlaceholderText = "Search users by id, name, email, nic or phone";
            HighlightButton(buttonUsers);
            LoadControl(usersControl);
        }

        private void buttonHistory_Click(object sender, EventArgs e)
        {
            panelSearch.Visible = true;
            textBoxSearch.Text = "";
            textBoxSearch.PlaceholderText = "Search transaction by user or book";
            HighlightButton(buttonHistory);
            LoadControl(historyControl);
        }

        private void buttonRules_Click(object sender, EventArgs e)
        {
            panelSearch.Visible = false;
            HighlightButton(buttonRules);
            LoadControl(rulesControl);
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            (currentControl as dynamic).Search(textBoxSearch.Text);
        }
    }
}
