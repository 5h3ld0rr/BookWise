namespace BookWise
{
    public partial class BooksControl : UserControl
    {
        private Book selectedBook;
        public event EventHandler BooksUpdated;
        public BooksControl()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
            RefreshData();
            dataGridViewBooks.Columns["ISBN"].HeaderText = "ISBN No";
            dataGridViewBooks.Columns["AvailableBooks"].HeaderText = "Available Books";
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
            DialogResult result = new AddBookModal(selectedBook).ShowDialog();

            if (result == DialogResult.OK)
            {
                RefreshData();
                BooksUpdated?.Invoke(this, EventArgs.Empty);
            }
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to remove this user ?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    selectedBook.Remove();
                    RefreshData();
                    BooksUpdated?.Invoke(this, EventArgs.Empty);
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
                selectedBook = dataGridViewBooks.Rows[hit.RowIndex].DataBoundItem as Book;
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

            if (result == DialogResult.OK)
            {
                RefreshData();
                BooksUpdated?.Invoke(this, EventArgs.Empty);
            }
        }
    }

}
