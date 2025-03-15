namespace BookWise
{
    public class BookReturnMail : Mail
    {
        public BookReturnMail(string name, string bookTitle, int noOfDaysOverdue, string dueDate, float fineRate)
        {
            string addtionalInfo = noOfDaysOverdue > 0 ? $"Next time, try to return it on time.</p><ul style=color:#d6e0ff;font-size:18px><li>Due Date: <span style=color:#eed1ac>{dueDate}</span><li>Overdue Since: <span style=color:#eed1ac>{noOfDaysOverdue} days</span><li>Fine Per Day: <span style=color:#eed1ac>Rs. {fineRate}</span><li>Total Fine: <span style=color:#eed1ac>Rs. {fineRate * noOfDaysOverdue}</span></ul>" : "Thank you for returning it on time.</p>";

            mail.Subject = "Thank You for Returning the Book";
            mail.Body = $"<div style=background:#111624;color:#fff;padding:50px;width:640px;box-sizing:border-box><div style=\"border-bottom:1px solid #232839;padding-bottom:2rem;height:30px\"><img height=30 src=https://i.ibb.co/xqqBHjrs/image.png><h2 style=display:inline;font-size:28px;margin-left:5px>BookWise</h2></div><h3 style=font-size:1.5rem;padding-top:1rem>Thank You for Returning {bookTitle}!</h3><p style=color:#d6e0ff;font-size:18px><br>Hi {name},<br><br>We've successfully received your return of<span style=color:#eed1ac>{bookTitle}</span>. {addtionalInfo}<br><br><p style=color:#d6e0ff;font-size:18px>Keep the pages turning,<br>The BookWise Team</p></div>";
        }
    }
}
