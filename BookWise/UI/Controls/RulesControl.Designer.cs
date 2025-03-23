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
            label2 = new Label();
            label4 = new Label();
            numericUpDownMaxDaysToReturn = new NumericUpDown();
            numericUpDownMaxBooksPerUser = new NumericUpDown();
            buttonSave = new Button();
            label5 = new Label();
            numericUpDownFinePerDay = new NumericUpDown();
            label3 = new Label();
            groupBox2 = new GroupBox();
            panel3 = new Panel();
            groupBox1 = new GroupBox();
            panel1 = new Panel();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMaxDaysToReturn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMaxBooksPerUser).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownFinePerDay).BeginInit();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            label2.ForeColor = Color.FromArgb(15, 23, 42);
            label2.Location = new Point(62, 72);
            label2.Name = "label2";
            label2.Size = new Size(290, 21);
            label2.TabIndex = 12;
            label2.Text = "Max books per user can borrow at once :";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            label4.ForeColor = Color.FromArgb(15, 23, 42);
            label4.Location = new Point(59, 38);
            label4.Name = "label4";
            label4.Size = new Size(198, 21);
            label4.TabIndex = 10;
            label4.Text = "Max days to return a book :";
            // 
            // numericUpDownMaxDaysToReturn
            // 
            numericUpDownMaxDaysToReturn.BackColor = Color.GhostWhite;
            numericUpDownMaxDaysToReturn.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            numericUpDownMaxDaysToReturn.Location = new Point(498, 34);
            numericUpDownMaxDaysToReturn.Name = "numericUpDownMaxDaysToReturn";
            numericUpDownMaxDaysToReturn.Size = new Size(319, 29);
            numericUpDownMaxDaysToReturn.TabIndex = 15;
            // 
            // numericUpDownMaxBooksPerUser
            // 
            numericUpDownMaxBooksPerUser.BackColor = Color.GhostWhite;
            numericUpDownMaxBooksPerUser.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            numericUpDownMaxBooksPerUser.Location = new Point(501, 68);
            numericUpDownMaxBooksPerUser.Name = "numericUpDownMaxBooksPerUser";
            numericUpDownMaxBooksPerUser.Size = new Size(319, 29);
            numericUpDownMaxBooksPerUser.TabIndex = 16;
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
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(30, 41, 59);
            label5.Location = new Point(23, 180);
            label5.Name = "label5";
            label5.Size = new Size(0, 37);
            label5.TabIndex = 1;
            // 
            // numericUpDownFinePerDay
            // 
            numericUpDownFinePerDay.BackColor = Color.GhostWhite;
            numericUpDownFinePerDay.DecimalPlaces = 2;
            numericUpDownFinePerDay.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            numericUpDownFinePerDay.Location = new Point(498, 96);
            numericUpDownFinePerDay.Name = "numericUpDownFinePerDay";
            numericUpDownFinePerDay.Size = new Size(319, 29);
            numericUpDownFinePerDay.TabIndex = 18;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            label3.ForeColor = Color.FromArgb(15, 23, 42);
            label3.Location = new Point(59, 100);
            label3.Name = "label3";
            label3.Size = new Size(233, 21);
            label3.TabIndex = 17;
            label3.Text = "Fine per day after overdue (Rs.) :";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(numericUpDownMaxBooksPerUser);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(panel3);
            groupBox2.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold);
            groupBox2.Location = new Point(23, 26);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(882, 128);
            groupBox2.TabIndex = 21;
            groupBox2.TabStop = false;
            groupBox2.Text = "Check-Out Policies";
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(3, 39);
            panel3.Name = "panel3";
            panel3.Size = new Size(876, 86);
            panel3.TabIndex = 17;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(panel1);
            groupBox1.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold);
            groupBox1.Location = new Point(23, 204);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(882, 201);
            groupBox1.TabIndex = 20;
            groupBox1.TabStop = false;
            groupBox1.Text = "Check-In Policies";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 39);
            panel1.Name = "panel1";
            panel1.Size = new Size(876, 159);
            panel1.TabIndex = 19;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(numericUpDownFinePerDay);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(numericUpDownMaxDaysToReturn);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(876, 159);
            panel2.TabIndex = 20;
            // 
            // RulesControl
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.GhostWhite;
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(buttonSave);
            Controls.Add(label5);
            Name = "RulesControl";
            Size = new Size(929, 541);
            ((System.ComponentModel.ISupportInitialize)numericUpDownMaxDaysToReturn).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMaxBooksPerUser).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownFinePerDay).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label4;
        private NumericUpDown numericUpDownMaxDaysToReturn;
        private NumericUpDown numericUpDownMaxBooksPerUser;
        private Button buttonSave;
        private Label label5;
        private NumericUpDown numericUpDownFinePerDay;
        private Label label3;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private Panel panel3;
        private Panel panel1;
        private Panel panel2;
    }
}
