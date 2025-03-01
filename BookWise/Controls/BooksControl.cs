namespace BookWise
{
    public partial class BooksControl : UserControl
    {
        private DataGridViewCellCollection selectedRow;
        public BooksControl()
        {
            InitializeComponent();
            RefreshData();
            dataGridViewBooks.Columns["id"].Visible = false;
            dataGridViewBooks.Columns["name"].HeaderText = "Name";
            dataGridViewBooks.Columns["isbn_no"].HeaderText = "ISBN No";
            dataGridViewBooks.Columns["author"].HeaderText = "Author";
            dataGridViewBooks.Columns["category"].HeaderText = "Category";
        }

        public void RefreshData()
        {
            dataGridViewBooks.DataSource = Book.GetAll();
        }

        public void Search(string query)
        {
            if (query.Length == 0)
            {
                RefreshData();
            }
            else
            {
                dataGridViewBooks.DataSource = Book.Search(query);
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Book book = new Book()
            {
                Id = Convert.ToInt32(selectedRow["id"].Value),
                Name = selectedRow["name"].Value.ToString(),
                ISBN = selectedRow["isbn_no"].Value.ToString(),
                Author = selectedRow["author"].Value.ToString(),
                Category = selectedRow["category"].Value.ToString()
            };
            DialogResult result = new AddBookModal(book).ShowDialog();

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
                    Book.Remove(id);
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
                dataGridViewBooks.Rows[hit.RowIndex].Selected = true;
                selectedRow = dataGridViewBooks.Rows[hit.RowIndex].Cells;
            }
            else
            {
                e.Cancel = true;
                dataGridViewBooks.ClearSelection();
            }
        }

        private void buttonAddBook_Click(object sender, EventArgs e)
        {
            DialogResult result = new AddBookModal().ShowDialog();

            if (result == DialogResult.OK) RefreshData();
        }
    }

}
