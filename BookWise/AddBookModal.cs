namespace BookWise
{
    public partial class AddBookModal : BaseForm
    {
        private Book? book;
        public AddBookModal(Book? book = null)
        {
            InitializeComponent();

            if (book != null)
            {
                this.book = book;
                textBoxTitle.Text = book.Title;
                textBoxISBN.Text = book.ISBN;
                textBoxAuthor.Text = book.Author;
                textBoxCategory.Text = book.Category;
                textBoxNoOfBooks.Text = book.AvailableBooks;

                Text = "Update an Existing Book";
                buttonSave.Text = "Update Book";
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string title = textBoxTitle.Text;
            string isbnNo = textBoxISBN.Text;
            string category = textBoxCategory.Text;
            string author = textBoxAuthor.Text;
            string noOfBooks = textBoxNoOfBooks.Text;

            bool notEnteredRequiredFields = String.IsNullOrWhiteSpace(title) || String.IsNullOrWhiteSpace(isbnNo) || String.IsNullOrWhiteSpace(author) || String.IsNullOrWhiteSpace(category) || String.IsNullOrWhiteSpace(noOfBooks);

            if (notEnteredRequiredFields)
            {
                MessageBox.Show("Please enter all the required fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                if (book != null)
                {
                    book.Title = title;
                    book.ISBN = isbnNo;
                    book.Category = category;
                    book.Author = author;
                    book.AvailableBooks = noOfBooks;

                    book.Update();
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    book = new Book()
                    {
                        Title = title,
                        ISBN = isbnNo,
                        Author = author,
                        Category = category,
                        AvailableBooks = noOfBooks
                    };

                    if (book.IsExisting())
                    {
                        MessageBox.Show("Book already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        DialogResult = DialogResult.Cancel;
                    }
                    else
                    {
                        book.Add();
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

        private void textBoxNoOfBooks_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != '-')
            {
                e.Handled = true;
            }
        }
    }
}
