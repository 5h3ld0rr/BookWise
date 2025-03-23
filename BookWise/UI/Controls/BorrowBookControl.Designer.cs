namespace BookWise
{
    partial class BorrowBookControl
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
            labelTitle = new Label();
            splitContainer1 = new SplitContainer();
            groupBox1 = new GroupBox();
            panel1 = new Panel();
            textBoxAddress = new TextBox();
            textBoxPhone = new TextBox();
            textBoxEmail = new TextBox();
            textBoxNic = new TextBox();
            textBoxName = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            numericUpDownId = new NumericUpDown();
            buttonUserInfoConfirm = new Button();
            groupBox2 = new GroupBox();
            panel2 = new Panel();
            textBoxIsbn = new TextBox();
            textBoxCategory = new TextBox();
            textBoxAuthor = new TextBox();
            textBoxTitle = new TextBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            buttonBookInfoConfirm = new Button();
            buttonProceed = new Button();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownId).BeginInit();
            groupBox2.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitle.ForeColor = Color.FromArgb(30, 41, 59);
            labelTitle.Location = new Point(23, 21);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(195, 37);
            labelTitle.TabIndex = 1;
            labelTitle.Text = "Borrow a Book";
            // 
            // splitContainer1
            // 
            splitContainer1.BackColor = Color.GhostWhite;
            splitContainer1.Location = new Point(0, 61);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(groupBox1);
            splitContainer1.Panel1.Padding = new Padding(30);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(groupBox2);
            splitContainer1.Panel2.Padding = new Padding(30);
            splitContainer1.Size = new Size(929, 480);
            splitContainer1.SplitterDistance = 463;
            splitContainer1.SplitterWidth = 1;
            splitContainer1.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(panel1);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Font = new Font("Segoe UI", 16F);
            groupBox1.ForeColor = Color.FromArgb(30, 41, 59);
            groupBox1.Location = new Point(30, 30);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(403, 420);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "User Information";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(textBoxAddress);
            panel1.Controls.Add(textBoxPhone);
            panel1.Controls.Add(textBoxEmail);
            panel1.Controls.Add(textBoxNic);
            panel1.Controls.Add(textBoxName);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(numericUpDownId);
            panel1.Controls.Add(buttonUserInfoConfirm);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 32);
            panel1.Name = "panel1";
            panel1.Size = new Size(397, 385);
            panel1.TabIndex = 0;
            // 
            // textBoxAddress
            // 
            textBoxAddress.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBoxAddress.BackColor = Color.GhostWhite;
            textBoxAddress.Enabled = false;
            textBoxAddress.Font = new Font("Segoe UI", 12F);
            textBoxAddress.ForeColor = Color.FromArgb(30, 41, 59);
            textBoxAddress.Location = new Point(161, 268);
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new Size(213, 29);
            textBoxAddress.TabIndex = 15;
            // 
            // textBoxPhone
            // 
            textBoxPhone.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBoxPhone.BackColor = Color.GhostWhite;
            textBoxPhone.Enabled = false;
            textBoxPhone.Font = new Font("Segoe UI", 12F);
            textBoxPhone.ForeColor = Color.FromArgb(30, 41, 59);
            textBoxPhone.Location = new Point(161, 220);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(213, 29);
            textBoxPhone.TabIndex = 14;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBoxEmail.BackColor = Color.GhostWhite;
            textBoxEmail.Font = new Font("Segoe UI", 12F);
            textBoxEmail.ForeColor = Color.FromArgb(30, 41, 59);
            textBoxEmail.Location = new Point(161, 172);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(213, 29);
            textBoxEmail.TabIndex = 13;
            // 
            // textBoxNic
            // 
            textBoxNic.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBoxNic.BackColor = Color.GhostWhite;
            textBoxNic.Font = new Font("Segoe UI", 12F);
            textBoxNic.ForeColor = Color.FromArgb(30, 41, 59);
            textBoxNic.Location = new Point(161, 124);
            textBoxNic.Name = "textBoxNic";
            textBoxNic.Size = new Size(213, 29);
            textBoxNic.TabIndex = 12;
            // 
            // textBoxName
            // 
            textBoxName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBoxName.BackColor = Color.GhostWhite;
            textBoxName.Enabled = false;
            textBoxName.Font = new Font("Segoe UI", 12F);
            textBoxName.ForeColor = Color.FromArgb(30, 41, 59);
            textBoxName.Location = new Point(161, 32);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(213, 29);
            textBoxName.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(19, 223);
            label6.Name = "label6";
            label6.Size = new Size(83, 21);
            label6.TabIndex = 10;
            label6.Text = "Mobile No";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(19, 271);
            label5.Name = "label5";
            label5.Size = new Size(66, 21);
            label5.TabIndex = 9;
            label5.Text = "Address";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(19, 175);
            label4.Name = "label4";
            label4.Size = new Size(48, 21);
            label4.TabIndex = 8;
            label4.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(19, 127);
            label3.Name = "label3";
            label3.Size = new Size(61, 21);
            label3.TabIndex = 7;
            label3.Text = "NIC No";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(19, 79);
            label2.Name = "label2";
            label2.Size = new Size(50, 21);
            label2.TabIndex = 6;
            label2.Text = "ID No";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(19, 31);
            label1.Name = "label1";
            label1.Size = new Size(52, 21);
            label1.TabIndex = 5;
            label1.Text = "Name";
            // 
            // numericUpDownId
            // 
            numericUpDownId.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            numericUpDownId.BackColor = Color.GhostWhite;
            numericUpDownId.Font = new Font("Segoe UI", 12F);
            numericUpDownId.ForeColor = Color.FromArgb(30, 41, 59);
            numericUpDownId.InterceptArrowKeys = false;
            numericUpDownId.Location = new Point(161, 77);
            numericUpDownId.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            numericUpDownId.Name = "numericUpDownId";
            numericUpDownId.Size = new Size(213, 29);
            numericUpDownId.TabIndex = 4;
            // 
            // buttonUserInfoConfirm
            // 
            buttonUserInfoConfirm.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonUserInfoConfirm.BackColor = Color.FromArgb(37, 56, 140);
            buttonUserInfoConfirm.Cursor = Cursors.Hand;
            buttonUserInfoConfirm.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Pixel, 0);
            buttonUserInfoConfirm.ForeColor = Color.White;
            buttonUserInfoConfirm.ImageAlign = ContentAlignment.MiddleLeft;
            buttonUserInfoConfirm.Location = new Point(263, 324);
            buttonUserInfoConfirm.Name = "buttonUserInfoConfirm";
            buttonUserInfoConfirm.Padding = new Padding(10, 0, 10, 0);
            buttonUserInfoConfirm.Size = new Size(111, 41);
            buttonUserInfoConfirm.TabIndex = 3;
            buttonUserInfoConfirm.Text = "Confirm";
            buttonUserInfoConfirm.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonUserInfoConfirm.UseVisualStyleBackColor = false;
            buttonUserInfoConfirm.Click += buttonUserInfoConfirm_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(panel2);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Font = new Font("Segoe UI", 16F);
            groupBox2.ForeColor = Color.FromArgb(30, 41, 59);
            groupBox2.Location = new Point(30, 30);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(405, 420);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Book Information";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(textBoxIsbn);
            panel2.Controls.Add(textBoxCategory);
            panel2.Controls.Add(textBoxAuthor);
            panel2.Controls.Add(textBoxTitle);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(buttonBookInfoConfirm);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 32);
            panel2.Name = "panel2";
            panel2.Size = new Size(399, 385);
            panel2.TabIndex = 1;
            // 
            // textBoxIsbn
            // 
            textBoxIsbn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBoxIsbn.BackColor = Color.GhostWhite;
            textBoxIsbn.Font = new Font("Segoe UI", 12F);
            textBoxIsbn.ForeColor = Color.FromArgb(30, 41, 59);
            textBoxIsbn.Location = new Point(164, 80);
            textBoxIsbn.Name = "textBoxIsbn";
            textBoxIsbn.Size = new Size(213, 29);
            textBoxIsbn.TabIndex = 25;
            // 
            // textBoxCategory
            // 
            textBoxCategory.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBoxCategory.BackColor = Color.GhostWhite;
            textBoxCategory.Enabled = false;
            textBoxCategory.Font = new Font("Segoe UI", 12F);
            textBoxCategory.ForeColor = Color.FromArgb(30, 41, 59);
            textBoxCategory.Location = new Point(164, 176);
            textBoxCategory.Name = "textBoxCategory";
            textBoxCategory.Size = new Size(213, 29);
            textBoxCategory.TabIndex = 24;
            // 
            // textBoxAuthor
            // 
            textBoxAuthor.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBoxAuthor.BackColor = Color.GhostWhite;
            textBoxAuthor.Enabled = false;
            textBoxAuthor.Font = new Font("Segoe UI", 12F);
            textBoxAuthor.ForeColor = Color.FromArgb(30, 41, 59);
            textBoxAuthor.Location = new Point(164, 128);
            textBoxAuthor.Name = "textBoxAuthor";
            textBoxAuthor.Size = new Size(213, 29);
            textBoxAuthor.TabIndex = 23;
            // 
            // textBoxTitle
            // 
            textBoxTitle.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBoxTitle.BackColor = Color.GhostWhite;
            textBoxTitle.Enabled = false;
            textBoxTitle.Font = new Font("Segoe UI", 12F);
            textBoxTitle.ForeColor = Color.FromArgb(30, 41, 59);
            textBoxTitle.Location = new Point(164, 36);
            textBoxTitle.Name = "textBoxTitle";
            textBoxTitle.Size = new Size(213, 29);
            textBoxTitle.TabIndex = 22;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(22, 179);
            label7.Name = "label7";
            label7.Size = new Size(73, 21);
            label7.TabIndex = 21;
            label7.Text = "Category";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.Location = new Point(22, 131);
            label8.Name = "label8";
            label8.Size = new Size(58, 21);
            label8.TabIndex = 20;
            label8.Text = "Author";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F);
            label9.Location = new Point(22, 83);
            label9.Name = "label9";
            label9.Size = new Size(69, 21);
            label9.TabIndex = 19;
            label9.Text = "ISBN No";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F);
            label10.Location = new Point(22, 35);
            label10.Name = "label10";
            label10.Size = new Size(39, 21);
            label10.TabIndex = 18;
            label10.Text = "Title";
            // 
            // buttonBookInfoConfirm
            // 
            buttonBookInfoConfirm.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonBookInfoConfirm.BackColor = Color.FromArgb(37, 56, 140);
            buttonBookInfoConfirm.Cursor = Cursors.Hand;
            buttonBookInfoConfirm.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Pixel, 0);
            buttonBookInfoConfirm.ForeColor = Color.White;
            buttonBookInfoConfirm.ImageAlign = ContentAlignment.MiddleLeft;
            buttonBookInfoConfirm.Location = new Point(266, 324);
            buttonBookInfoConfirm.Name = "buttonBookInfoConfirm";
            buttonBookInfoConfirm.Padding = new Padding(10, 0, 10, 0);
            buttonBookInfoConfirm.Size = new Size(111, 41);
            buttonBookInfoConfirm.TabIndex = 16;
            buttonBookInfoConfirm.Text = "Confirm";
            buttonBookInfoConfirm.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonBookInfoConfirm.UseVisualStyleBackColor = false;
            buttonBookInfoConfirm.Click += buttonBookInfoConfirm_Click;
            // 
            // buttonProceed
            // 
            buttonProceed.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonProceed.BackColor = Color.FromArgb(37, 56, 140);
            buttonProceed.Cursor = Cursors.Hand;
            buttonProceed.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Pixel, 0);
            buttonProceed.ForeColor = Color.White;
            buttonProceed.ImageAlign = ContentAlignment.MiddleLeft;
            buttonProceed.Location = new Point(788, 25);
            buttonProceed.Name = "buttonProceed";
            buttonProceed.Padding = new Padding(10, 0, 10, 0);
            buttonProceed.Size = new Size(111, 41);
            buttonProceed.TabIndex = 17;
            buttonProceed.Text = "Proceed";
            buttonProceed.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonProceed.UseVisualStyleBackColor = false;
            buttonProceed.Visible = false;
            buttonProceed.Click += buttonProceed_Click;
            // 
            // BorrowBookControl
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.GhostWhite;
            Controls.Add(buttonProceed);
            Controls.Add(splitContainer1);
            Controls.Add(labelTitle);
            Name = "BorrowBookControl";
            Size = new Size(929, 541);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownId).EndInit();
            groupBox2.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitle;
        private SplitContainer splitContainer1;
        private GroupBox groupBox1;
        private Panel panel1;
        private GroupBox groupBox2;
        private Panel panel2;
        private NumericUpDown numericUpDownId;
        private Button buttonUserInfoConfirm;
        private TextBox textBoxName;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBoxAddress;
        private TextBox textBoxPhone;
        private TextBox textBoxEmail;
        private TextBox textBoxNic;
        private Button buttonBookInfoConfirm;
        private Button buttonProceed;
        private TextBox textBoxIsbn;
        private TextBox textBoxCategory;
        private TextBox textBoxAuthor;
        private TextBox textBoxTitle;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
    }
}
