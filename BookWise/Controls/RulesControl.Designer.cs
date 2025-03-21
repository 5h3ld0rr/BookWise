namespace BookWise
{
    partial class RulesControl
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
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            numericUpDownMaxDaysToReturn = new NumericUpDown();
            numericUpDownMaxBooksPerUser = new NumericUpDown();
            numericUpDownFinePerDay = new NumericUpDown();
            label3 = new Label();
            buttonSave = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMaxDaysToReturn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMaxBooksPerUser).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownFinePerDay).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(30, 41, 59);
            label1.Location = new Point(23, 21);
            label1.Name = "label1";
            label1.Size = new Size(231, 37);
            label1.TabIndex = 1;
            label1.Text = "Checkout Policies";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            label2.ForeColor = Color.FromArgb(15, 23, 42);
            label2.Location = new Point(85, 157);
            label2.Name = "label2";
            label2.Size = new Size(290, 21);
            label2.TabIndex = 12;
            label2.Text = "Max books per user can borrow at once :";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            label4.ForeColor = Color.FromArgb(15, 23, 42);
            label4.Location = new Point(85, 103);
            label4.Name = "label4";
            label4.Size = new Size(198, 21);
            label4.TabIndex = 10;
            label4.Text = "Max days to return a book :";
            // 
            // numericUpDownMaxDaysToReturn
            // 
            numericUpDownMaxDaysToReturn.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            numericUpDownMaxDaysToReturn.Location = new Point(524, 101);
            numericUpDownMaxDaysToReturn.Name = "numericUpDownMaxDaysToReturn";
            numericUpDownMaxDaysToReturn.Size = new Size(319, 29);
            numericUpDownMaxDaysToReturn.TabIndex = 15;
            // 
            // numericUpDownMaxBooksPerUser
            // 
            numericUpDownMaxBooksPerUser.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            numericUpDownMaxBooksPerUser.Location = new Point(524, 155);
            numericUpDownMaxBooksPerUser.Name = "numericUpDownMaxBooksPerUser";
            numericUpDownMaxBooksPerUser.Size = new Size(319, 29);
            numericUpDownMaxBooksPerUser.TabIndex = 16;
            // 
            // numericUpDownFinePerDay
            // 
            numericUpDownFinePerDay.DecimalPlaces = 2;
            numericUpDownFinePerDay.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            numericUpDownFinePerDay.Location = new Point(524, 210);
            numericUpDownFinePerDay.Name = "numericUpDownFinePerDay";
            numericUpDownFinePerDay.Size = new Size(319, 29);
            numericUpDownFinePerDay.TabIndex = 18;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            label3.ForeColor = Color.FromArgb(15, 23, 42);
            label3.Location = new Point(85, 212);
            label3.Name = "label3";
            label3.Size = new Size(233, 21);
            label3.TabIndex = 17;
            label3.Text = "Fine per day after overdue (Rs.) :";
            // 
            // buttonSave
            // 
            buttonSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonSave.BackColor = Color.FromArgb(37, 56, 140);
            buttonSave.Cursor = Cursors.Hand;
            buttonSave.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Pixel);
            buttonSave.ForeColor = Color.FromArgb(248, 250, 252);
            buttonSave.Location = new Point(708, 436);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(135, 50);
            buttonSave.TabIndex = 19;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += buttonSave_Click;
            // 
            // RulesControl
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.GhostWhite;
            Controls.Add(buttonSave);
            Controls.Add(numericUpDownFinePerDay);
            Controls.Add(label3);
            Controls.Add(numericUpDownMaxBooksPerUser);
            Controls.Add(numericUpDownMaxDaysToReturn);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(label1);
            Name = "RulesControl";
            Size = new Size(929, 541);
            ((System.ComponentModel.ISupportInitialize)numericUpDownMaxDaysToReturn).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMaxBooksPerUser).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownFinePerDay).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label4;
        private NumericUpDown numericUpDownMaxDaysToReturn;
        private NumericUpDown numericUpDownMaxBooksPerUser;
        private NumericUpDown numericUpDownFinePerDay;
        private Label label3;
        private Button buttonSave;
    }
}
