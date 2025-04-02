using BookWise.Mails;

namespace BookWise
{
    public partial class BorrowBookControl : UserControl
    {
        private User user;
        private Book book;
        private bool userInfoConfirmed = false;
        private bool bookInfoConfirmed = false;
        public event EventHandler BookBorrowed;
        public BorrowBookControl()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
        }

        private void buttonUserInfoConfirm_Click(object sender, EventArgs e)
        {
            if (userInfoConfirmed)
            {
                userInfoConfirmed = false;
                ToggleUserInfoControls();
                return;
            }

            int userId = (int)numericUpDownId.Value;
            string nic = textBoxNic.Text;
            string email = textBoxEmail.Text;

            bool isEnteredOneField = userId > 0 || !String.IsNullOrWhiteSpace(nic) || !String.IsNullOrWhiteSpace(email);

            if (!isEnteredOneField)
            {
                MessageBox.Show("Please enter at least one field", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            user = User.GetUserByUniqueIdentifier(userId, nic, email);

            if (user == null)
            {
                MessageBox.Show("User not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (user.BorrowedBooks.Length >= CommonData.Rules.MaxBooksPerUser)
            {
                MessageBox.Show("User has already borrowed maximum number of books", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            textBoxName.Text = user.FirstName + " " + user.LastName;
            numericUpDownId.Value = user.Id;
            textBoxNic.Text = user.NIC;
            textBoxEmail.Text = user.Email;
            textBoxPhone.Text = user.Phone;
            textBoxAddress.Text = user.Address;

            userInfoConfirmed = true;
            ToggleUserInfoControls();
        }

        public void SetBook(Book _book)
        {
            if (book != _book)
                book = _book;
            textBoxTitle.Text = book.Title;
            textBoxIsbn.Text = book.ISBN;
            textBoxAuthor.Text = book.Author;
            textBoxCategory.Text = book.Category;

            bookInfoConfirmed = true;
            ToggleBookInfoControls();
        }
        private void buttonBookInfoConfirm_Click(object sender, EventArgs e)
        {
            if (bookInfoConfirmed)
            {
                bookInfoConfirmed = false;
                ToggleBookInfoControls();
                return;
            }

            string isbn = textBoxIsbn.Text;

            if (String.IsNullOrWhiteSpace(isbn))
            {
                MessageBox.Show("Please enter the ISBN No", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            book = Book.Get(isbn);

            if (book == null)
            {
                MessageBox.Show("Book not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (book.AvailableBooks == 0)
            {
                MessageBox.Show("Book is not available", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SetBook(book);
        }
        private void buttonProceed_Click(object sender, EventArgs e)
        {
            try
            {
                if (book.Borrow())
                {
                    string dueDate = DateTime.Now.AddDays(CommonData.Rules.MaxDaysToReturn).ToString("yyyy-MM-dd");
                    BookTransaction.Create(user.Id, book.Id);
                    MessageBox.Show("Book borrowed successfully!\nDue date: " + dueDate, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BookBorrowed?.Invoke(this, EventArgs.Empty);
                    new BookBorrowMail(user.FirstName, book.Title, dueDate).Send(user.Email);
                    Reset();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ToggleUserInfoControls()
        {
            numericUpDownId.Enabled = !userInfoConfirmed;
            textBoxNic.Enabled = !userInfoConfirmed;
            textBoxEmail.Enabled = !userInfoConfirmed;

            buttonUserInfoConfirm.Text = userInfoConfirmed ? "Edit" : "Confirm";
            buttonProceed.Visible = userInfoConfirmed && bookInfoConfirmed;
        }
        private void ToggleBookInfoControls()
        {
            textBoxIsbn.Enabled = !bookInfoConfirmed;

            buttonBookInfoConfirm.Text = bookInfoConfirmed ? "Edit" : "Confirm";
            buttonProceed.Visible = userInfoConfirmed && bookInfoConfirmed;
        }
        private void Reset()
        {
            numericUpDownId.Value = 0;
            textBoxNic.Text = "";
            textBoxEmail.Text = "";
            textBoxName.Text = "";
            textBoxPhone.Text = "";
            textBoxAddress.Text = "";
            textBoxIsbn.Text = "";
            textBoxTitle.Text = "";
            textBoxAuthor.Text = "";
            textBoxCategory.Text = "";
            userInfoConfirmed = false;
            bookInfoConfirmed = false;
            ToggleUserInfoControls();
            ToggleBookInfoControls();
            user = null;
            book = null;
        }
    }
}
