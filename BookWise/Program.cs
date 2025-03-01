namespace BookWise
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            SignInForm signInForm = new SignInForm();
            if (signInForm.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new HomeForm(signInForm.userName, signInForm.userId, signInForm.userRole));
            }
        }
    }
}