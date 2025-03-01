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
                textBoxName.Text = book.Name;
                textBoxISBN.Text = book.ISBN;
                textBoxAuthor.Text = book.Author;
                textBoxCategory.Text = book.Category;

                Text = "Update an Existing Book";
                buttonSave.Text = "Update Book";
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string Name = textBoxName.Text;
            string ISBN = textBoxISBN.Text;
            string Category = textBoxCategory.Text;
            string Author = textBoxAuthor.Text;

            bool notEnteredRequiredFields = String.IsNullOrWhiteSpace(Name) || String.IsNullOrWhiteSpace(ISBN) || String.IsNullOrWhiteSpace(Author) || String.IsNullOrWhiteSpace(Category);

            if (notEnteredRequiredFields)
            {
                MessageBox.Show("Please enter all the required fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                if (book != null)
                {
                    book.Name = Name;
                    book.ISBN = ISBN;
                    book.Category = Category;
                    book.Author = Author;

                    book.Update();
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    book = new Book()
                    {
                        Name = Name,
                        ISBN = ISBN,
                        Category = Category,
                        Author = Author
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
                return;
            }
        }
    }
}
