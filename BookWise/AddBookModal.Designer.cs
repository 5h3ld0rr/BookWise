namespace BookWise
{
    partial class AddBookModal
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
            buttonSave = new Button();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBoxTitle = new TextBox();
            textBoxISBN = new TextBox();
            textBoxCategory = new TextBox();
            textBoxAuthor = new TextBox();
            label3 = new Label();
            numericUpDownNoOfBooks = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numericUpDownNoOfBooks).BeginInit();
            SuspendLayout();
            // 
            // buttonSave
            // 
            buttonSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonSave.BackColor = Color.FromArgb(37, 56, 140);
            buttonSave.Cursor = Cursors.Hand;
            buttonSave.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Pixel);
            buttonSave.ForeColor = Color.FromArgb(248, 250, 252);
            buttonSave.Location = new Point(23, 424);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(391, 50);
            buttonSave.TabIndex = 0;
            buttonSave.Text = "Add Book";
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += buttonSave_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            label1.ForeColor = Color.FromArgb(15, 23, 42);
            label1.Location = new Point(23, 22);
            label1.Name = "label1";
            label1.Size = new Size(39, 21);
            label1.TabIndex = 1;
            label1.Text = "Title";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            label2.ForeColor = Color.FromArgb(15, 23, 42);
            label2.Location = new Point(23, 98);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.No;
            label2.Size = new Size(69, 21);
            label2.TabIndex = 2;
            label2.Text = "ISBN No";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            label4.ForeColor = Color.FromArgb(15, 23, 42);
            label4.Location = new Point(23, 177);
            label4.Name = "label4";
            label4.Size = new Size(58, 21);
            label4.TabIndex = 4;
            label4.Text = "Author";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            label5.ForeColor = Color.FromArgb(15, 23, 42);
            label5.Location = new Point(23, 255);
            label5.Name = "label5";
            label5.Size = new Size(73, 21);
            label5.TabIndex = 5;
            label5.Text = "Category";
            // 
            // textBoxTitle
            // 
            textBoxTitle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxTitle.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            textBoxTitle.ForeColor = Color.FromArgb(30, 41, 59);
            textBoxTitle.Location = new Point(23, 46);
            textBoxTitle.Name = "textBoxTitle";
            textBoxTitle.Size = new Size(391, 29);
            textBoxTitle.TabIndex = 9;
            // 
            // textBoxISBN
            // 
            textBoxISBN.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxISBN.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            textBoxISBN.ForeColor = Color.FromArgb(30, 41, 59);
            textBoxISBN.Location = new Point(23, 122);
            textBoxISBN.Name = "textBoxISBN";
            textBoxISBN.Size = new Size(391, 29);
            textBoxISBN.TabIndex = 10;
            // 
            // textBoxCategory
            // 
            textBoxCategory.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxCategory.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            textBoxCategory.ForeColor = Color.FromArgb(30, 41, 59);
            textBoxCategory.Location = new Point(23, 279);
            textBoxCategory.Name = "textBoxCategory";
            textBoxCategory.Size = new Size(391, 29);
            textBoxCategory.TabIndex = 14;
            // 
            // textBoxAuthor
            // 
            textBoxAuthor.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxAuthor.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            textBoxAuthor.ForeColor = Color.FromArgb(30, 41, 59);
            textBoxAuthor.Location = new Point(23, 201);
            textBoxAuthor.Name = "textBoxAuthor";
            textBoxAuthor.Size = new Size(391, 29);
            textBoxAuthor.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            label3.ForeColor = Color.FromArgb(15, 23, 42);
            label3.Location = new Point(23, 333);
            label3.Name = "label3";
            label3.Size = new Size(131, 21);
            label3.TabIndex = 16;
            label3.Text = "Total No of Books";
            // 
            // numericUpDownNoOfBooks
            // 
            numericUpDownNoOfBooks.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            numericUpDownNoOfBooks.ForeColor = Color.FromArgb(30, 41, 59);
            numericUpDownNoOfBooks.Location = new Point(23, 357);
            numericUpDownNoOfBooks.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numericUpDownNoOfBooks.Name = "numericUpDownNoOfBooks";
            numericUpDownNoOfBooks.Size = new Size(391, 29);
            numericUpDownNoOfBooks.TabIndex = 23;
            numericUpDownNoOfBooks.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // AddBookModal
            // 
            AcceptButton = buttonSave;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.GhostWhite;
            ClientSize = new Size(442, 495);
            Controls.Add(numericUpDownNoOfBooks);
            Controls.Add(label3);
            Controls.Add(textBoxAuthor);
            Controls.Add(textBoxCategory);
            Controls.Add(textBoxISBN);
            Controls.Add(textBoxTitle);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonSave);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "AddBookModal";
            Text = "Add a New Book";
            ((System.ComponentModel.ISupportInitialize)numericUpDownNoOfBooks).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonSave;
        private Label label1;
        private Label label2;
        private Label label4;
        private Label label5;
        private TextBox textBoxTitle;
        private TextBox textBoxISBN;
        private TextBox textBoxCategory;
        private TextBox textBoxAuthor;
        private Label label3;
        private NumericUpDown numericUpDownNoOfBooks;
    }
}