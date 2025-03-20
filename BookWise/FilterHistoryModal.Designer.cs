namespace BookWise
{
    partial class FilterHistoryModal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FilterHistoryModal));
            buttonApply = new Button();
            buttonClear = new Button();
            dateTimePickerBorrowStartDate = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            dateTimePickerBorrowEndDate = new DateTimePicker();
            label3 = new Label();
            comboBoxStatus = new ComboBox();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            label4 = new Label();
            dateTimePickerReturnStartDate = new DateTimePicker();
            dateTimePickerReturnEndDate = new DateTimePicker();
            label5 = new Label();
            comboBoxOverdue = new ComboBox();
            label6 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // buttonApply
            // 
            buttonApply.Anchor = AnchorStyles.Bottom;
            buttonApply.BackColor = Color.FromArgb(37, 56, 140);
            buttonApply.Cursor = Cursors.Hand;
            buttonApply.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Pixel);
            buttonApply.ForeColor = Color.FromArgb(248, 250, 252);
            buttonApply.Location = new Point(268, 483);
            buttonApply.Name = "buttonApply";
            buttonApply.Size = new Size(199, 50);
            buttonApply.TabIndex = 1;
            buttonApply.Text = "Apply";
            buttonApply.UseVisualStyleBackColor = false;
            buttonApply.Click += buttonApply_Click;
            // 
            // buttonClear
            // 
            buttonClear.Anchor = AnchorStyles.Bottom;
            buttonClear.BackColor = Color.White;
            buttonClear.Cursor = Cursors.Hand;
            buttonClear.FlatAppearance.BorderSize = 0;
            buttonClear.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Pixel);
            buttonClear.ForeColor = Color.FromArgb(30, 41, 59);
            buttonClear.Location = new Point(35, 483);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(199, 48);
            buttonClear.TabIndex = 2;
            buttonClear.Text = "Clear";
            buttonClear.UseVisualStyleBackColor = false;
            buttonClear.Click += buttonClear_Click;
            // 
            // dateTimePickerBorrowStartDate
            // 
            dateTimePickerBorrowStartDate.CalendarFont = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            dateTimePickerBorrowStartDate.CalendarForeColor = Color.FromArgb(15, 23, 42);
            dateTimePickerBorrowStartDate.CalendarTitleForeColor = Color.FromArgb(15, 23, 42);
            dateTimePickerBorrowStartDate.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            dateTimePickerBorrowStartDate.Format = DateTimePickerFormat.Custom;
            dateTimePickerBorrowStartDate.Location = new Point(195, 33);
            dateTimePickerBorrowStartDate.Name = "dateTimePickerBorrowStartDate";
            dateTimePickerBorrowStartDate.Size = new Size(236, 29);
            dateTimePickerBorrowStartDate.TabIndex = 3;
            dateTimePickerBorrowStartDate.ValueChanged += dateTimePickerBorrowStartDate_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            label1.ForeColor = Color.FromArgb(15, 23, 42);
            label1.Location = new Point(33, 39);
            label1.Name = "label1";
            label1.Size = new Size(85, 21);
            label1.TabIndex = 4;
            label1.Text = "Start Date :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            label2.ForeColor = Color.FromArgb(15, 23, 42);
            label2.Location = new Point(33, 93);
            label2.Name = "label2";
            label2.Size = new Size(79, 21);
            label2.TabIndex = 6;
            label2.Text = "End Date :";
            // 
            // dateTimePickerBorrowEndDate
            // 
            dateTimePickerBorrowEndDate.CalendarFont = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            dateTimePickerBorrowEndDate.CalendarForeColor = Color.FromArgb(15, 23, 42);
            dateTimePickerBorrowEndDate.CalendarTitleForeColor = Color.FromArgb(15, 23, 42);
            dateTimePickerBorrowEndDate.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            dateTimePickerBorrowEndDate.Format = DateTimePickerFormat.Custom;
            dateTimePickerBorrowEndDate.Location = new Point(195, 87);
            dateTimePickerBorrowEndDate.Name = "dateTimePickerBorrowEndDate";
            dateTimePickerBorrowEndDate.Size = new Size(236, 29);
            dateTimePickerBorrowEndDate.TabIndex = 5;
            dateTimePickerBorrowEndDate.ValueChanged += dateTimePickerBorrowEndDate_ValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            label3.ForeColor = Color.FromArgb(15, 23, 42);
            label3.Location = new Point(52, 370);
            label3.Name = "label3";
            label3.Size = new Size(59, 21);
            label3.TabIndex = 7;
            label3.Text = "Status :";
            // 
            // comboBoxStatus
            // 
            comboBoxStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxStatus.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            comboBoxStatus.ForeColor = Color.FromArgb(15, 23, 42);
            comboBoxStatus.FormattingEnabled = true;
            comboBoxStatus.Items.AddRange(new object[] { "Any", "Returned", "Unreturned" });
            comboBoxStatus.Location = new Point(224, 370);
            comboBoxStatus.Name = "comboBoxStatus";
            comboBoxStatus.Size = new Size(236, 29);
            comboBoxStatus.TabIndex = 8;
            comboBoxStatus.SelectedIndexChanged += comboBoxStatus_SelectedIndexChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(dateTimePickerBorrowStartDate);
            groupBox1.Controls.Add(dateTimePickerBorrowEndDate);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            groupBox1.ForeColor = Color.FromArgb(15, 23, 42);
            groupBox1.Location = new Point(19, 28);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(465, 145);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Borrow";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(dateTimePickerReturnStartDate);
            groupBox2.Controls.Add(dateTimePickerReturnEndDate);
            groupBox2.Controls.Add(label5);
            groupBox2.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            groupBox2.ForeColor = Color.FromArgb(15, 23, 42);
            groupBox2.Location = new Point(19, 197);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(465, 145);
            groupBox2.TabIndex = 10;
            groupBox2.TabStop = false;
            groupBox2.Text = "Return";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            label4.ForeColor = Color.FromArgb(15, 23, 42);
            label4.Location = new Point(33, 39);
            label4.Name = "label4";
            label4.Size = new Size(85, 21);
            label4.TabIndex = 4;
            label4.Text = "Start Date :";
            // 
            // dateTimePickerReturnStartDate
            // 
            dateTimePickerReturnStartDate.CalendarFont = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            dateTimePickerReturnStartDate.CalendarForeColor = Color.FromArgb(15, 23, 42);
            dateTimePickerReturnStartDate.CalendarTitleForeColor = Color.FromArgb(15, 23, 42);
            dateTimePickerReturnStartDate.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            dateTimePickerReturnStartDate.Format = DateTimePickerFormat.Custom;
            dateTimePickerReturnStartDate.Location = new Point(195, 33);
            dateTimePickerReturnStartDate.Name = "dateTimePickerReturnStartDate";
            dateTimePickerReturnStartDate.Size = new Size(236, 29);
            dateTimePickerReturnStartDate.TabIndex = 3;
            dateTimePickerReturnStartDate.ValueChanged += dateTimePickerReturnStartDate_ValueChanged;
            // 
            // dateTimePickerReturnEndDate
            // 
            dateTimePickerReturnEndDate.CalendarFont = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            dateTimePickerReturnEndDate.CalendarForeColor = Color.FromArgb(15, 23, 42);
            dateTimePickerReturnEndDate.CalendarTitleForeColor = Color.FromArgb(15, 23, 42);
            dateTimePickerReturnEndDate.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            dateTimePickerReturnEndDate.Format = DateTimePickerFormat.Custom;
            dateTimePickerReturnEndDate.Location = new Point(195, 87);
            dateTimePickerReturnEndDate.Name = "dateTimePickerReturnEndDate";
            dateTimePickerReturnEndDate.Size = new Size(236, 29);
            dateTimePickerReturnEndDate.TabIndex = 5;
            dateTimePickerReturnEndDate.ValueChanged += dateTimePickerReturnEndDate_ValueChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            label5.ForeColor = Color.FromArgb(15, 23, 42);
            label5.Location = new Point(33, 93);
            label5.Name = "label5";
            label5.Size = new Size(79, 21);
            label5.TabIndex = 6;
            label5.Text = "End Date :";
            // 
            // comboBoxOverdue
            // 
            comboBoxOverdue.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxOverdue.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            comboBoxOverdue.ForeColor = Color.FromArgb(15, 23, 42);
            comboBoxOverdue.FormattingEnabled = true;
            comboBoxOverdue.Items.AddRange(new object[] { "Any", "Yes", "No" });
            comboBoxOverdue.Location = new Point(224, 420);
            comboBoxOverdue.Name = "comboBoxOverdue";
            comboBoxOverdue.Size = new Size(236, 29);
            comboBoxOverdue.TabIndex = 12;
            comboBoxOverdue.SelectedIndexChanged += comboBoxOverdue_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            label6.ForeColor = Color.FromArgb(15, 23, 42);
            label6.Location = new Point(52, 420);
            label6.Name = "label6";
            label6.Size = new Size(77, 21);
            label6.TabIndex = 11;
            label6.Text = "Overdue :";
            // 
            // FilterHistoryModal
            // 
            AcceptButton = buttonApply;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.GhostWhite;
            ClientSize = new Size(503, 553);
            Controls.Add(comboBoxOverdue);
            Controls.Add(label6);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(comboBoxStatus);
            Controls.Add(label3);
            Controls.Add(buttonClear);
            Controls.Add(buttonApply);
            ForeColor = Color.FromArgb(30, 41, 59);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FilterHistoryModal";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Filter History";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonApply;
        private Button buttonClear;
        private DateTimePicker dateTimePickerBorrowStartDate;
        private Label label1;
        private Label label2;
        private DateTimePicker dateTimePickerBorrowEndDate;
        private Label label3;
        private ComboBox comboBoxStatus;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label4;
        private DateTimePicker dateTimePickerReturnStartDate;
        private DateTimePicker dateTimePickerReturnEndDate;
        private Label label5;
        private ComboBox comboBoxOverdue;
        private Label label6;
    }
}