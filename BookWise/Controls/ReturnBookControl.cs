namespace BookWise
{
    public partial class ReturnBookControl : UserControl
    {
        public event EventHandler BookReturned;
        public ReturnBookControl()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
        }
    }
}
