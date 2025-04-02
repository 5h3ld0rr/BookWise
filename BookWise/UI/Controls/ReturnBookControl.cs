using BookWise.Mails;

namespace BookWise
{
    public partial class ReturnBookControl : UserControl
    {
        private User user;
        private Book[] books;
        private Book book;
        private int selectedBookIndex;
        private (DateTime dueDate, int noOfDaysOverdue, decimal fine) data;
        private bool userInfoConfirmed = false;
        private bool bookInfoConfirmed = false;
        public event EventHandler BookReturned;
        public ReturnBookControl()
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

            textBoxName.Text = user.FirstName + " " + user.LastName;
            numericUpDownId.Value = user.Id;
            textBoxNic.Text = user.NIC;
            textBoxEmail.Text = user.Email;
            textBoxPhone.Text = user.Phone;
            textBoxAddress.Text = user.Address;

            userInfoConfirmed = true;

            books = BookTransaction.GetUnreturnedBooksByUser(user.Id);
            if (books.Length == 0)
            {
                MessageBox.Show("No books to return", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Reset();
                return;
            }

            ToggleUserInfoControls();

            books = BookTransaction.GetUnreturnedBooksByUser(user.Id);
            comboBoxTitle.DataSource = books.Select(b => b.Title).ToArray();
            comboBoxIsbn.DataSource = books.Select(b => b.ISBN).ToArray();
            book = books[0];
            textBoxAuthor.Text = book.Author;
            textBoxCategory.Text = book.Category;
        }
        private void buttonBookInfoConfirm_Click(object sender, EventArgs e)
        {
            if (bookInfoConfirmed)
            {
                bookInfoConfirmed = false;
                ToggleBookInfoControls();
                return;
            }
            data = BookTransaction.GetMoreById(book.TransactionId);

            if (data.fine > 0)
            {
                labelOverdue.Visible = true;
                labelOverdueV.Visible = true;
                labelOverdueV.Text = data.noOfDaysOverdue.ToString();
                labelFine.Visible = true;
                labelFineV.Visible = true;
                labelFineV.Text = "Rs. " + data.fine.ToString();
            }
            else
            {
                labelOverdue.Visible = false;
                labelOverdueV.Visible = false;
                labelFine.Visible = false;
                labelFineV.Visible = false;
            }

            bookInfoConfirmed = true;
            ToggleBookInfoControls();
        }
        private void buttonProceed_Click(object sender, EventArgs e)
        {
            try
            {
                if (book.Return())
                {
                    BookTransaction.UpdateReturn(book.TransactionId);
                    MessageBox.Show("Book returned successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BookReturned?.Invoke(this, EventArgs.Empty);
                    new BookReturnMail(user.FirstName, book.Title, data.noOfDaysOverdue, data.dueDate.ToString()).Send(user.Email);
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
            comboBoxTitle.Enabled = userInfoConfirmed;
            comboBoxIsbn.Enabled = userInfoConfirmed;

            buttonUserInfoConfirm.Text = userInfoConfirmed ? "Edit" : "Confirm";
            buttonProceed.Visible = userInfoConfirmed && bookInfoConfirmed;
            buttonBookInfoConfirm.Visible = userInfoConfirmed;
        }
        private void ToggleBookInfoControls()
        {
            comboBoxTitle.Enabled = !bookInfoConfirmed;
            comboBoxIsbn.Enabled = !bookInfoConfirmed;

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
            textBoxAuthor.Text = "";
            comboBoxTitle.DataSource = new string[0];
            comboBoxIsbn.DataSource = new string[0];
            textBoxCategory.Text = "";
            comboBoxIsbn.Enabled = false;
            comboBoxTitle.Enabled = false;
            labelFine.Visible = false;
            labelFineV.Visible = false;
            labelOverdue.Visible = false;
            labelOverdueV.Visible = false;
            userInfoConfirmed = false;
            bookInfoConfirmed = false;
            ToggleUserInfoControls();
            selectedBookIndex = 0;
            book = null;
            books = null;
        }

        private void comboBoxTitle_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxTitle.SelectedIndex == selectedBookIndex)
                return;
            selectedBookIndex = comboBoxTitle.SelectedIndex;
            book = books[selectedBookIndex];
            comboBoxIsbn.SelectedIndex = selectedBookIndex;
            textBoxAuthor.Text = book.Author;
            textBoxCategory.Text = book.Category;
        }

        private void comboBoxIsbn_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxIsbn.SelectedIndex == selectedBookIndex)
                return;
            selectedBookIndex = comboBoxIsbn.SelectedIndex;
            book = books[selectedBookIndex];
            comboBoxTitle.SelectedIndex = selectedBookIndex;
            textBoxAuthor.Text = book.Author;
            textBoxCategory.Text = book.Category;
        }
    }
}
