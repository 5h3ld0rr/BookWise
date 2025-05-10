namespace BookWise
{
    partial class HomeControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel = new TableLayoutPanel();
            panel3 = new Panel();
            labelAllBooks = new Label();
            label3 = new Label();
            panel2 = new Panel();
            labelTotalUsers = new Label();
            label2 = new Label();
            panel1 = new Panel();
            labelBorrowedBooks = new Label();
            label1 = new Label();
            tableLayoutPanel.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            tableLayoutPanel.BackColor = Color.Transparent;
            tableLayoutPanel.ColumnCount = 3;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel.Controls.Add(panel3, 2, 0);
            tableLayoutPanel.Controls.Add(panel2, 1, 0);
            tableLayoutPanel.Controls.Add(panel1, 0, 0);
            tableLayoutPanel.Dock = DockStyle.Top;
            tableLayoutPanel.Location = new Point(0, 0);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.Padding = new Padding(0, 10, 0, 0);
            tableLayoutPanel.RowCount = 1;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel.Size = new Size(1280, 133);
            tableLayoutPanel.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(labelAllBooks);
            panel3.Controls.Add(label3);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(868, 13);
            panel3.Margin = new Padding(16, 3, 16, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(396, 117);
            panel3.TabIndex = 2;
            // 
            // labelAllBooks
            // 
            labelAllBooks.AutoSize = true;
            labelAllBooks.Font = new Font("Segoe UI", 32F, FontStyle.Bold, GraphicsUnit.Pixel);
            labelAllBooks.ForeColor = Color.FromArgb(30, 41, 59);
            labelAllBooks.Location = new Point(17, 53);
            labelAllBooks.Name = "labelAllBooks";
            labelAllBooks.RightToLeft = RightToLeft.No;
            labelAllBooks.Size = new Size(38, 45);
            labelAllBooks.TabIndex = 3;
            labelAllBooks.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(100, 116, 139);
            label3.Location = new Point(17, 17);
            label3.Name = "label3";
            label3.Size = new Size(78, 21);
            label3.TabIndex = 1;
            label3.Text = "All Books";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(labelTotalUsers);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(442, 13);
            panel2.Margin = new Padding(16, 3, 16, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(394, 117);
            panel2.TabIndex = 1;
            // 
            // labelTotalUsers
            // 
            labelTotalUsers.AutoSize = true;
            labelTotalUsers.Font = new Font("Segoe UI", 32F, FontStyle.Bold, GraphicsUnit.Pixel);
            labelTotalUsers.ForeColor = Color.FromArgb(30, 41, 59);
            labelTotalUsers.Location = new Point(18, 53);
            labelTotalUsers.Name = "labelTotalUsers";
            labelTotalUsers.RightToLeft = RightToLeft.No;
            labelTotalUsers.Size = new Size(38, 45);
            labelTotalUsers.TabIndex = 2;
            labelTotalUsers.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(100, 116, 139);
            label2.Location = new Point(18, 17);
            label2.Name = "label2";
            label2.Size = new Size(89, 21);
            label2.TabIndex = 1;
            label2.Text = "Total Users";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(labelBorrowedBooks);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(16, 13);
            panel1.Margin = new Padding(16, 3, 16, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(394, 117);
            panel1.TabIndex = 0;
            // 
            // labelBorrowedBooks
            // 
            labelBorrowedBooks.AutoSize = true;
            labelBorrowedBooks.Font = new Font("Segoe UI", 32F, FontStyle.Bold, GraphicsUnit.Pixel);
            labelBorrowedBooks.ForeColor = Color.FromArgb(30, 41, 59);
            labelBorrowedBooks.Location = new Point(17, 53);
            labelBorrowedBooks.Name = "labelBorrowedBooks";
            labelBorrowedBooks.RightToLeft = RightToLeft.No;
            labelBorrowedBooks.Size = new Size(38, 45);
            labelBorrowedBooks.TabIndex = 1;
            labelBorrowedBooks.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(100, 116, 139);
            label1.Location = new Point(17, 17);
            label1.Name = "label1";
            label1.Size = new Size(132, 21);
            label1.TabIndex = 0;
            label1.Text = "Borrowed Books";
            // 
            // HomeControl
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.GhostWhite;
            BackgroundImage = Properties.Resources.home_bg;
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(tableLayoutPanel);
            DoubleBuffered = true;
            Name = "HomeControl";
            Size = new Size(1280, 720);
            tableLayoutPanel.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel;
        private Panel panel1;
        private Panel panel3;
        private Panel panel2;
        private Label label1;
        private Label label3;
        private Label label2;
        private Label labelAllBooks;
        private Label labelTotalUsers;
        private Label labelBorrowedBooks;
    }
}
