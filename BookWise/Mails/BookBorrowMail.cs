namespace BookWise.Mails
{
    public class BookBorrowMail : Mail
    {
        protected override string Subject { get; }
        protected override string Body { get; }
        public BookBorrowMail(string name, string bookTitle, string dueDate)
        {
            string borrowDate = DateTime.Now.ToString("yyyy-MM-dd");

            Subject = "You've Borrowed a Book ";
            Body = $"<div style=background:#111624;color:#fff;padding:50px;width:640px;box-sizing:border-box><div style=\"border-bottom:1px solid #232839;padding-bottom:2rem;height:30px\"><img height=30 src=https://res.cloudinary.com/dphmltfrh/image/upload/v1742541018/bookwise_logo.png><h2 style=display:inline;font-size:28px;margin-left:5px>BookWise</h2></div><h3 style=font-size:1.5rem;padding-top:1rem>You’ve Borrowed a Book!</h3><p style=color:#d6e0ff;font-size:18px><br>Hi {name},<br><br>You’ve successfully borrowed <span style=color:#eed1ac>{bookTitle}</span>. Here are the details:.<ul style=color:#d6e0ff;font-size:18px><li>Borrowed On: <span style=color:#eed1ac>{borrowDate}</span><li>Due Date: <span style=color:#eed1ac>{dueDate}</span></ul><p style=color:#d6e0ff;font-size:18px>Enjoy your reading, and don't forget to return the book on time!<br><br><br>Happy reading,<br>The BookWise Team</div>";
        }
    }
}
