namespace BookWise
{
    public class BookBorrowMail : Mail
    {
        public BookBorrowMail()
        {
            mail.Subject = "You've Borrowed a Book ";
        }
    }
}
