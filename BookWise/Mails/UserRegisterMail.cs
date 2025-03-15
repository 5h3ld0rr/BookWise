namespace BookWise
{
    public class UserRegisterMail : Mail
    {
        public UserRegisterMail(string name)
        {
            mail.Subject = "Welcome to BookWise";
            mail.Body = $"<div style='background:#111624;color:#fff;padding:50px;width:640px;box-sizing:border-box;'><div style='border-bottom:1px solid #232839;padding-bottom:2rem;height:30px'><img height=30 src=https://i.ibb.co/xqqBHjrs/image.png><h2 style='display:inline;font-size:28px;margin-left:5px;'>BookWise</h2></div><h3 style='font-size:1.5rem;padding-top:1rem;'>Welcome to BookWise, Your Reading Companion!</h3><p style='color:#d6e0ff;font-size:18px;'><br>Hi {name},<br><br>Welcome to BookWise! We're excited to have you join our community of book enthusiasts. Explore a wide range of books, borrow with ease, and manage your reading journey seamlessly.<br><br><br>Happy reading,<br>The BookWise Team</div>";
        }
    }
}