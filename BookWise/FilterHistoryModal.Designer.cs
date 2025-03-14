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
            buttonFilter = new Button();
            buttonReset = new Button();
            dateTimePickerStartDate = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            dateTimePickerEndDate = new DateTimePicker();
            label3 = new Label();
            comboBoxStatus = new ComboBox();
            SuspendLayout();
            // 
            // buttonFilter
            // 
            buttonFilter.Anchor = AnchorStyles.Bottom;
            buttonFilter.BackColor = Color.FromArgb(37, 56, 140);
            buttonFilter.Cursor = Cursors.Hand;
            buttonFilter.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Pixel);
            buttonFilter.ForeColor = Color.FromArgb(248, 250, 252);
            buttonFilter.Location = new Point(205, 384);
            buttonFilter.Name = "buttonFilter";
            buttonFilter.Size = new Size(171, 50);
            buttonFilter.TabIndex = 1;
            buttonFilter.Text = "Filter";
            buttonFilter.UseVisualStyleBackColor = false;
            buttonFilter.Click += buttonFilter_Click;
            // 
            // buttonReset
            // 
            buttonReset.Anchor = AnchorStyles.Bottom;
            buttonReset.BackColor = Color.White;
            buttonReset.Cursor = Cursors.Hand;
            buttonReset.FlatAppearance.BorderSize = 0;
            buttonReset.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Pixel);
            buttonReset.ForeColor = Color.FromArgb(30, 41, 59);
            buttonReset.Location = new Point(19, 384);
            buttonReset.Name = "buttonReset";
            buttonReset.Size = new Size(171, 48);
            buttonReset.TabIndex = 2;
            buttonReset.Text = "Reset";
            buttonReset.UseVisualStyleBackColor = false;
            buttonReset.Click += buttonReset_Click;
            // 
            // dateTimePickerStartDate
            // 
            dateTimePickerStartDate.CalendarFont = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            dateTimePickerStartDate.CalendarForeColor = Color.FromArgb(15, 23, 42);
            dateTimePickerStartDate.CalendarTitleForeColor = Color.FromArgb(15, 23, 42);
            dateTimePickerStartDate.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            dateTimePickerStartDate.Format = DateTimePickerFormat.Short;
            dateTimePickerStartDate.Location = new Point(192, 36);
            dateTimePickerStartDate.Name = "dateTimePickerStartDate";
            dateTimePickerStartDate.Size = new Size(184, 29);
            dateTimePickerStartDate.TabIndex = 3;
            dateTimePickerStartDate.ValueChanged += dateTimePickerStartDate_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            label1.ForeColor = Color.FromArgb(15, 23, 42);
            label1.Location = new Point(19, 42);
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
            label2.Location = new Point(19, 96);
            label2.Name = "label2";
            label2.Size = new Size(79, 21);
            label2.TabIndex = 6;
            label2.Text = "End Date :";
            // 
            // dateTimePickerEndDate
            // 
            dateTimePickerEndDate.CalendarFont = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            dateTimePickerEndDate.CalendarForeColor = Color.FromArgb(15, 23, 42);
            dateTimePickerEndDate.CalendarTitleForeColor = Color.FromArgb(15, 23, 42);
            dateTimePickerEndDate.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            dateTimePickerEndDate.Format = DateTimePickerFormat.Short;
            dateTimePickerEndDate.Location = new Point(192, 90);
            dateTimePickerEndDate.Name = "dateTimePickerEndDate";
            dateTimePickerEndDate.Size = new Size(184, 29);
            dateTimePickerEndDate.TabIndex = 5;
            dateTimePickerEndDate.ValueChanged += dateTimePickerEndDate_ValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            label3.ForeColor = Color.FromArgb(15, 23, 42);
            label3.Location = new Point(19, 152);
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
            comboBoxStatus.Items.AddRange(new object[] { "All", "Borrowed", "Returned" });
            comboBoxStatus.Location = new Point(192, 149);
            comboBoxStatus.Name = "comboBoxStatus";
            comboBoxStatus.Size = new Size(184, 29);
            comboBoxStatus.TabIndex = 8;
            comboBoxStatus.SelectedIndexChanged += comboBoxStatus_SelectedIndexChanged;
            // 
            // FilterHistoryModal
            // 
            AcceptButton = buttonFilter;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(397, 450);
            Controls.Add(comboBoxStatus);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dateTimePickerEndDate);
            Controls.Add(label1);
            Controls.Add(dateTimePickerStartDate);
            Controls.Add(buttonReset);
            Controls.Add(buttonFilter);
            Name = "FilterHistoryModal";
            Text = "Filter History";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonFilter;
        private Button buttonReset;
        private DateTimePicker dateTimePickerStartDate;
        private Label label1;
        private Label label2;
        private DateTimePicker dateTimePickerEndDate;
        private Label label3;
        private ComboBox comboBoxStatus;
    }
}