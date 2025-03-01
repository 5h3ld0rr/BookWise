namespace BookWise
{
    public partial class UsersControl : UserControl
    {
        private DataGridViewCellCollection selectedRow;
        private int userId;
        private string userRole;
        public UsersControl(int userId, string userRole)
        {
            InitializeComponent();
            RefreshData();
            this.userId = userId;
            this.userRole = userRole;
            dataGridViewUsers.Columns["id"].Visible = false;
            dataGridViewUsers.Columns["first_name"].HeaderText = "First Name";
            dataGridViewUsers.Columns["last_name"].HeaderText = "Last Name";
            dataGridViewUsers.Columns["email"].HeaderText = "Email";
            dataGridViewUsers.Columns["role"].HeaderText = "Role";
            dataGridViewUsers.Columns["nic"].HeaderText = "NIC No";
            dataGridViewUsers.Columns["phone"].HeaderText = "Phone No";
            dataGridViewUsers.Columns["address"].HeaderText = "Address";
        }
        public void RefreshData()
        {
            dataGridViewUsers.DataSource = User.GetAll();
        }

        public void Search(string query)
        {
            if (query.Length == 0)
            {
                RefreshData();
            }
            else
            {
                dataGridViewUsers.DataSource = User.Search(query);
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            User user = new User()
            {
                Id = Convert.ToInt32(selectedRow["id"].Value),
                FirstName = selectedRow["first_name"].Value.ToString(),
                LastName = selectedRow["last_name"].Value.ToString(),
                Email = selectedRow["email"].Value.ToString(),
                Role = selectedRow["role"].Value.ToString(),
                NIC = selectedRow["nic"].Value.ToString(),
                Phone = selectedRow["phone"].Value.ToString(),
                Address = selectedRow["address"].Value.ToString()
            };
            bool allowChangeRole = userRole == "Admin" && user.Id != userId;
            DialogResult result = new AddUserModal(allowChangeRole, user).ShowDialog();

            if (result == DialogResult.OK) RefreshData();
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to remove this user ?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    int id = Convert.ToInt32(selectedRow["id"].Value);
                    User.Remove(id);
                    RefreshData();
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
                selectedRow = dataGridViewUsers.Rows[hit.RowIndex].Cells;
                int selectedUserId = Convert.ToInt32(selectedRow["id"].Value);
                bool hasPermission = userRole == "Admin" || selectedRow["role"].Value.ToString() == "User";
                contextMenu.Items["removeToolStripMenuItem"].Enabled = selectedUserId != userId && hasPermission;
                contextMenu.Items["editToolStripMenuItem"].Enabled = selectedUserId == userId || hasPermission;
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

            if (result == DialogResult.OK) RefreshData();
        }
    }

}
