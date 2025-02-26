namespace BookWise
{
    public class BaseForm : Form
    {
        public BaseForm()
        {
            FormClosing += BaseForm_FormClosing;
            StartPosition = FormStartPosition.CenterScreen;
            ForeColor = Color.FromArgb(30, 41, 59);
            BackColor = Color.FromArgb(248, 248, 255);
            using (var ms = new MemoryStream(Properties.Resources.app))
            {
                Icon = new Icon(ms);
            }
        }

        private void BaseForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason != CloseReason.UserClosing || !Visible) return;

            DialogResult dialogResult = MessageBox.Show("Are you sure you want to close?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.No)
            {
                e.Cancel = true;
            }
            else if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
