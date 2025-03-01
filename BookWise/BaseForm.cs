namespace BookWise
{
    public class BaseForm : Form
    {
        public BaseForm()
        {
            StartPosition = FormStartPosition.CenterScreen;
            ForeColor = Color.FromArgb(30, 41, 59);
            BackColor = Color.GhostWhite;
            using (var ms = new MemoryStream(Properties.Resources.app))
            {
                Icon = new Icon(ms);
            }
        }

    }
}
