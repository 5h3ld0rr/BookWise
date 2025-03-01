namespace BookWise
{
    partial class HomeForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            pictureBox2 = new PictureBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            panelSidebar = new Panel();
            buttonHistory = new Button();
            buttonUsers = new Button();
            buttonLogout = new Button();
            buttonHome = new Button();
            buttonBooks = new Button();
            panelContainer = new Panel();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            textBoxSearch = new TextBox();
            label3 = new Label();
            labelFName = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            panelSidebar.SuspendLayout();
            panelContainer.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Pixel);
            label1.ForeColor = Color.FromArgb(37, 56, 140);
            label1.Location = new Point(58, 24);
            label1.Name = "label1";
            label1.Size = new Size(127, 32);
            label1.TabIndex = 15;
            label1.Text = "BookWise";
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top;
            pictureBox2.Image = Properties.Resources.logo;
            pictureBox2.Location = new Point(20, 24);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(32, 32);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 14;
            pictureBox2.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 272F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(panelSidebar, 0, 0);
            tableLayoutPanel1.Controls.Add(panelContainer, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(1264, 681);
            tableLayoutPanel1.TabIndex = 16;
            // 
            // panelSidebar
            // 
            panelSidebar.BackColor = Color.White;
            panelSidebar.Controls.Add(buttonHistory);
            panelSidebar.Controls.Add(buttonUsers);
            panelSidebar.Controls.Add(buttonLogout);
            panelSidebar.Controls.Add(buttonHome);
            panelSidebar.Controls.Add(buttonBooks);
            panelSidebar.Controls.Add(pictureBox2);
            panelSidebar.Controls.Add(label1);
            panelSidebar.Dock = DockStyle.Fill;
            panelSidebar.Location = new Point(3, 3);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Size = new Size(266, 675);
            panelSidebar.TabIndex = 0;
            // 
            // buttonHistory
            // 
            buttonHistory.BackColor = Color.White;
            buttonHistory.BackgroundImageLayout = ImageLayout.None;
            buttonHistory.Cursor = Cursors.Hand;
            buttonHistory.FlatAppearance.BorderColor = Color.Black;
            buttonHistory.FlatAppearance.BorderSize = 0;
            buttonHistory.FlatStyle = FlatStyle.Flat;
            buttonHistory.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonHistory.Image = Properties.Resources.borrow;
            buttonHistory.ImageAlign = ContentAlignment.MiddleLeft;
            buttonHistory.Location = new Point(14, 340);
            buttonHistory.Name = "buttonHistory";
            buttonHistory.Padding = new Padding(5, 0, 0, 0);
            buttonHistory.Size = new Size(236, 50);
            buttonHistory.TabIndex = 21;
            buttonHistory.Text = "  History";
            buttonHistory.TextAlign = ContentAlignment.MiddleLeft;
            buttonHistory.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonHistory.UseVisualStyleBackColor = false;
            buttonHistory.Click += buttonHistory_Click;
            // 
            // buttonUsers
            // 
            buttonUsers.BackColor = Color.White;
            buttonUsers.BackgroundImageLayout = ImageLayout.None;
            buttonUsers.Cursor = Cursors.Hand;
            buttonUsers.FlatAppearance.BorderColor = Color.Black;
            buttonUsers.FlatAppearance.BorderSize = 0;
            buttonUsers.FlatStyle = FlatStyle.Flat;
            buttonUsers.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonUsers.Image = Properties.Resources.users;
            buttonUsers.ImageAlign = ContentAlignment.MiddleLeft;
            buttonUsers.Location = new Point(14, 278);
            buttonUsers.Name = "buttonUsers";
            buttonUsers.Padding = new Padding(5, 0, 0, 0);
            buttonUsers.Size = new Size(236, 50);
            buttonUsers.TabIndex = 20;
            buttonUsers.Text = "  All Users";
            buttonUsers.TextAlign = ContentAlignment.MiddleLeft;
            buttonUsers.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonUsers.UseVisualStyleBackColor = false;
            buttonUsers.Click += buttonUsers_Click;
            // 
            // buttonLogout
            // 
            buttonLogout.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonLogout.Cursor = Cursors.Hand;
            buttonLogout.Image = Properties.Resources.logout;
            buttonLogout.ImageAlign = ContentAlignment.MiddleLeft;
            buttonLogout.Location = new Point(13, 613);
            buttonLogout.Name = "buttonLogout";
            buttonLogout.Padding = new Padding(10, 0, 0, 0);
            buttonLogout.Size = new Size(235, 50);
            buttonLogout.TabIndex = 19;
            buttonLogout.Text = "Logout";
            buttonLogout.UseVisualStyleBackColor = true;
            buttonLogout.Click += buttonLogout_Click;
            // 
            // buttonHome
            // 
            buttonHome.BackColor = Color.FromArgb(37, 56, 140);
            buttonHome.BackgroundImageLayout = ImageLayout.None;
            buttonHome.Cursor = Cursors.Hand;
            buttonHome.FlatAppearance.BorderColor = Color.Black;
            buttonHome.FlatAppearance.BorderSize = 0;
            buttonHome.FlatStyle = FlatStyle.Flat;
            buttonHome.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonHome.ForeColor = Color.White;
            buttonHome.Image = Properties.Resources.home;
            buttonHome.ImageAlign = ContentAlignment.MiddleLeft;
            buttonHome.Location = new Point(13, 154);
            buttonHome.Name = "buttonHome";
            buttonHome.Padding = new Padding(5, 0, 0, 0);
            buttonHome.Size = new Size(236, 50);
            buttonHome.TabIndex = 18;
            buttonHome.Text = "  Home";
            buttonHome.TextAlign = ContentAlignment.MiddleLeft;
            buttonHome.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonHome.UseVisualStyleBackColor = false;
            buttonHome.Click += buttonHome_Click;
            // 
            // buttonBooks
            // 
            buttonBooks.BackColor = Color.White;
            buttonBooks.BackgroundImageLayout = ImageLayout.None;
            buttonBooks.Cursor = Cursors.Hand;
            buttonBooks.FlatAppearance.BorderColor = Color.Black;
            buttonBooks.FlatAppearance.BorderSize = 0;
            buttonBooks.FlatStyle = FlatStyle.Flat;
            buttonBooks.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonBooks.Image = Properties.Resources.book;
            buttonBooks.ImageAlign = ContentAlignment.MiddleLeft;
            buttonBooks.Location = new Point(13, 215);
            buttonBooks.Name = "buttonBooks";
            buttonBooks.Padding = new Padding(5, 0, 0, 0);
            buttonBooks.Size = new Size(236, 50);
            buttonBooks.TabIndex = 17;
            buttonBooks.Text = "  All Books";
            buttonBooks.TextAlign = ContentAlignment.MiddleLeft;
            buttonBooks.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonBooks.UseVisualStyleBackColor = false;
            buttonBooks.Click += buttonAllBooks_Click;
            // 
            // panelContainer
            // 
            panelContainer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelContainer.Controls.Add(panel1);
            panelContainer.Controls.Add(label3);
            panelContainer.Controls.Add(labelFName);
            panelContainer.Controls.Add(label2);
            panelContainer.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Pixel);
            panelContainer.Location = new Point(275, 3);
            panelContainer.Name = "panelContainer";
            panelContainer.Padding = new Padding(16, 110, 16, 16);
            panelContainer.Size = new Size(986, 675);
            panelContainer.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(textBoxSearch);
            panel1.Location = new Point(517, 24);
            panel1.Name = "panel1";
            panel1.Size = new Size(450, 45);
            panel1.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.search;
            pictureBox1.Location = new Point(14, 11);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(24, 24);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBoxSearch.BorderStyle = BorderStyle.None;
            textBoxSearch.Location = new Point(53, 7);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.PlaceholderText = "Search ...";
            textBoxSearch.Size = new Size(383, 27);
            textBoxSearch.TabIndex = 3;
            textBoxSearch.TextChanged += textBoxSearch_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            label3.ForeColor = Color.FromArgb(100, 116, 139);
            label3.Location = new Point(19, 54);
            label3.Name = "label3";
            label3.Size = new Size(207, 21);
            label3.TabIndex = 2;
            label3.Text = "Monitor all of your taks here";
            // 
            // labelFName
            // 
            labelFName.AutoSize = true;
            labelFName.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Pixel);
            labelFName.Location = new Point(139, 18);
            labelFName.Name = "labelFName";
            labelFName.Size = new Size(81, 32);
            labelFName.TabIndex = 1;
            labelFName.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Pixel);
            label2.Location = new Point(19, 18);
            label2.Name = "label2";
            label2.Size = new Size(133, 32);
            label2.TabIndex = 0;
            label2.Text = "Welcome, ";
            // 
            // HomeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 681);
            Controls.Add(tableLayoutPanel1);
            MinimumSize = new Size(1280, 720);
            Name = "HomeForm";
            Text = "Home";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            panelSidebar.ResumeLayout(false);
            panelSidebar.PerformLayout();
            panelContainer.ResumeLayout(false);
            panelContainer.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox2;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panelSidebar;
        private Button buttonBooks;
        private Button buttonHome;
        private Panel panelContainer;
        private Button buttonLogout;
        private Button buttonHistory;
        private Button buttonUsers;
        private Label labelFName;
        private Label label2;
        private Label label3;
        private TextBox textBoxSearch;
        private Panel panel1;
        private PictureBox pictureBox1;
    }
}