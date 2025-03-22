namespace BookWise
{
    public partial class UsersControl : UserControl
    {
        private User selectedUser;
        private int userId;
        private string userRole;
        private string acceptedRoles = "'Admin', 'Staff', 'Student'";

        public event EventHandler UsersUpdated;
        public UsersControl(int userId, string userRole)
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
            comboBoxUserFilter.SelectedIndex = 0;
            RefreshData();
            this.userId = userId;
            this.userRole = userRole;
            dataGridViewUsers.Columns["Id"].HeaderText = "ID";
            dataGridViewUsers.Columns["Id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewUsers.Columns["FirstName"].HeaderText = "First Name";
            dataGridViewUsers.Columns["LastName"].HeaderText = "Last Name";
            dataGridViewUsers.Columns["NIC"].HeaderText = "NIC No";
            dataGridViewUsers.Columns["Phone"].HeaderText = "Phone No";
        }
        public void RefreshData()
        {
            dataGridViewUsers.DataSource = User.GetAll(acceptedRoles);
        }

        public void Search(string query)
        {
            if (query.Length == 0)
            {
                RefreshData();
            }
            else
            {
                dataGridViewUsers.DataSource = User.Search(query, acceptedRoles);
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool allowChangeRole = userRole == "Admin" && selectedUser.Id != userId;
            DialogResult result = new AddUserModal(allowChangeRole, selectedUser).ShowDialog();

            if (result == DialogResult.OK) RefreshData();
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to remove this user ?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    selectedUser.Remove();
                    RefreshData();
                    UsersUpdated?.Invoke(this, EventArgs.Empty);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void contextMenu_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (contextMenu.SourceControl is not DataGridView dataGridView) return;
            Point mousePosition = Control.MousePosition;
            Point relativePosition = dataGridView.PointToClient(mousePosition);

            DataGridView.HitTestInfo hit = dataGridView.HitTest(relativePosition.X, relativePosition.Y);

            if (hit.RowIndex >= 0)
            {
                dataGridViewUsers.Rows[hit.RowIndex].Selected = true;
                selectedUser = dataGridViewUsers.Rows[hit.RowIndex].DataBoundItem as User;
                bool hasPermission = userRole == "Admin" || selectedUser.Role == "Student";
                contextMenu.Items["removeToolStripMenuItem"].Enabled = selectedUser.Id != userId && hasPermission;
                contextMenu.Items["editToolStripMenuItem"].Enabled = selectedUser.Id == userId || hasPermission;
            }
            else
            {
                e.Cancel = true;
                dataGridViewUsers.ClearSelection();
            }
        }

        private void buttonAddUser_Click(object sender, EventArgs e)
        {
            bool allowChangeRole = userRole == "Admin";
            DialogResult result = new AddUserModal(allowChangeRole).ShowDialog();

            if (result == DialogResult.OK)
            {
                RefreshData();
                UsersUpdated?.Invoke(this, EventArgs.Empty);
            }
        }

        private void comboBoxUserFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxUserFilter.Text)
            {
                case "Staff":
                    labelTitle.Text = "All Staff";
                    acceptedRoles = "'Admin', 'Staff'";
                    break;
                case "Students":
                    labelTitle.Text = "All Students";
                    acceptedRoles = "'Student'";
                    break;
                case "All":
                    labelTitle.Text = "All Users";
                    acceptedRoles = "'Admin', 'Staff', 'Student'";
                    break;
                default:
                    break;

            }
            RefreshData();
        }
    }

}
