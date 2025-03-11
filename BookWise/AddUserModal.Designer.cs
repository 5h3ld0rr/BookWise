namespace BookWise
{
    partial class AddUserModal
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
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            textBoxFName = new TextBox();
            textBoxLName = new TextBox();
            textBoxAddress = new TextBox();
            textBoxPassword = new TextBox();
            textBoxConfirmPassword = new TextBox();
            textBoxEmail = new TextBox();
            textBoxNic = new TextBox();
            comboBoxRole = new ComboBox();
            checkBoxShowPassword = new CheckBox();
            textBoxPhone = new TextBox();
            label9 = new Label();
            label10 = new Label();
            textBoxId = new TextBox();
            SuspendLayout();
            // 
            // buttonSave
            // 
            buttonSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonSave.BackColor = Color.FromArgb(37, 56, 140);
            buttonSave.Cursor = Cursors.Hand;
            buttonSave.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Pixel);
            buttonSave.ForeColor = Color.FromArgb(248, 250, 252);
            buttonSave.Location = new Point(23, 438);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(462, 50);
            buttonSave.TabIndex = 0;
            buttonSave.Text = "Add User";
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
            label1.Size = new Size(86, 21);
            label1.TabIndex = 1;
            label1.Text = "First Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            label2.ForeColor = Color.FromArgb(15, 23, 42);
            label2.Location = new Point(264, 22);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.No;
            label2.Size = new Size(84, 21);
            label2.TabIndex = 2;
            label2.Text = "Last Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            label3.ForeColor = Color.FromArgb(15, 23, 42);
            label3.Location = new Point(339, 180);
            label3.Name = "label3";
            label3.Size = new Size(41, 21);
            label3.TabIndex = 3;
            label3.Text = "Role";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            label4.ForeColor = Color.FromArgb(15, 23, 42);
            label4.Location = new Point(23, 180);
            label4.Name = "label4";
            label4.Size = new Size(61, 21);
            label4.TabIndex = 4;
            label4.Text = "NIC No";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            label5.ForeColor = Color.FromArgb(15, 23, 42);
            label5.Location = new Point(181, 99);
            label5.Name = "label5";
            label5.Size = new Size(48, 21);
            label5.TabIndex = 5;
            label5.Text = "Email";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            label6.ForeColor = Color.FromArgb(15, 23, 42);
            label6.Location = new Point(23, 257);
            label6.Name = "label6";
            label6.Size = new Size(66, 21);
            label6.TabIndex = 6;
            label6.Text = "Address";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            label7.ForeColor = Color.FromArgb(15, 23, 42);
            label7.Location = new Point(23, 335);
            label7.Name = "label7";
            label7.Size = new Size(76, 21);
            label7.TabIndex = 7;
            label7.Text = "Password";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            label8.ForeColor = Color.FromArgb(15, 23, 42);
            label8.Location = new Point(264, 335);
            label8.Name = "label8";
            label8.Size = new Size(137, 21);
            label8.TabIndex = 8;
            label8.Text = "Confirm Password";
            // 
            // textBoxFName
            // 
            textBoxFName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxFName.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            textBoxFName.ForeColor = Color.FromArgb(30, 41, 59);
            textBoxFName.Location = new Point(23, 46);
            textBoxFName.Name = "textBoxFName";
            textBoxFName.Size = new Size(220, 29);
            textBoxFName.TabIndex = 9;
            // 
            // textBoxLName
            // 
            textBoxLName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxLName.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            textBoxLName.ForeColor = Color.FromArgb(30, 41, 59);
            textBoxLName.Location = new Point(264, 46);
            textBoxLName.Name = "textBoxLName";
            textBoxLName.Size = new Size(220, 29);
            textBoxLName.TabIndex = 10;
            // 
            // textBoxAddress
            // 
            textBoxAddress.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxAddress.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            textBoxAddress.ForeColor = Color.FromArgb(30, 41, 59);
            textBoxAddress.Location = new Point(23, 281);
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new Size(462, 29);
            textBoxAddress.TabIndex = 11;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxPassword.Enabled = false;
            textBoxPassword.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            textBoxPassword.ForeColor = Color.FromArgb(30, 41, 59);
            textBoxPassword.Location = new Point(23, 359);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(220, 29);
            textBoxPassword.TabIndex = 12;
            textBoxPassword.UseSystemPasswordChar = true;
            // 
            // textBoxConfirmPassword
            // 
            textBoxConfirmPassword.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxConfirmPassword.Enabled = false;
            textBoxConfirmPassword.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            textBoxConfirmPassword.ForeColor = Color.FromArgb(30, 41, 59);
            textBoxConfirmPassword.Location = new Point(264, 359);
            textBoxConfirmPassword.Name = "textBoxConfirmPassword";
            textBoxConfirmPassword.Size = new Size(220, 29);
            textBoxConfirmPassword.TabIndex = 13;
            textBoxConfirmPassword.UseSystemPasswordChar = true;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxEmail.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            textBoxEmail.ForeColor = Color.FromArgb(30, 41, 59);
            textBoxEmail.Location = new Point(181, 123);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(303, 29);
            textBoxEmail.TabIndex = 14;
            // 
            // textBoxNic
            // 
            textBoxNic.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxNic.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            textBoxNic.ForeColor = Color.FromArgb(30, 41, 59);
            textBoxNic.Location = new Point(23, 204);
            textBoxNic.Name = "textBoxNic";
            textBoxNic.Size = new Size(145, 29);
            textBoxNic.TabIndex = 15;
            // 
            // comboBoxRole
            // 
            comboBoxRole.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            comboBoxRole.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxRole.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            comboBoxRole.FormattingEnabled = true;
            comboBoxRole.Items.AddRange(new object[] { "Student", "Staff", "Admin" });
            comboBoxRole.Location = new Point(339, 204);
            comboBoxRole.Name = "comboBoxRole";
            comboBoxRole.Size = new Size(145, 29);
            comboBoxRole.TabIndex = 16;
            comboBoxRole.SelectedIndexChanged += comboBoxRole_SelectedIndexChanged;
            // 
            // checkBoxShowPassword
            // 
            checkBoxShowPassword.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            checkBoxShowPassword.AutoSize = true;
            checkBoxShowPassword.Cursor = Cursors.Hand;
            checkBoxShowPassword.Font = new Font("Segoe UI", 10F);
            checkBoxShowPassword.Location = new Point(361, 394);
            checkBoxShowPassword.Name = "checkBoxShowPassword";
            checkBoxShowPassword.Size = new Size(123, 23);
            checkBoxShowPassword.TabIndex = 19;
            checkBoxShowPassword.Text = "Show Password";
            checkBoxShowPassword.UseVisualStyleBackColor = true;
            checkBoxShowPassword.CheckedChanged += checkBoxShowPassword_CheckedChanged;
            // 
            // textBoxPhone
            // 
            textBoxPhone.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxPhone.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            textBoxPhone.ForeColor = Color.FromArgb(30, 41, 59);
            textBoxPhone.Location = new Point(181, 204);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(145, 29);
            textBoxPhone.TabIndex = 21;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            label9.ForeColor = Color.FromArgb(15, 23, 42);
            label9.Location = new Point(181, 180);
            label9.Name = "label9";
            label9.Size = new Size(79, 21);
            label9.TabIndex = 20;
            label9.Text = "Phone No";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            label10.ForeColor = Color.FromArgb(15, 23, 42);
            label10.Location = new Point(23, 99);
            label10.Name = "label10";
            label10.Size = new Size(48, 21);
            label10.TabIndex = 4;
            label10.Text = "Id No";
            // 
            // textBoxId
            // 
            textBoxId.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxId.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            textBoxId.ForeColor = Color.FromArgb(30, 41, 59);
            textBoxId.Location = new Point(23, 123);
            textBoxId.Name = "textBoxId";
            textBoxId.Size = new Size(145, 29);
            textBoxId.TabIndex = 15;
            textBoxId.KeyPress += textBoxId_KeyPress;
            // 
            // AddUserModal
            // 
            AcceptButton = buttonSave;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.GhostWhite;
            ClientSize = new Size(513, 508);
            Controls.Add(textBoxPhone);
            Controls.Add(label9);
            Controls.Add(checkBoxShowPassword);
            Controls.Add(comboBoxRole);
            Controls.Add(textBoxId);
            Controls.Add(textBoxNic);
            Controls.Add(textBoxEmail);
            Controls.Add(textBoxConfirmPassword);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxAddress);
            Controls.Add(textBoxLName);
            Controls.Add(textBoxFName);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label10);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonSave);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "AddUserModal";
            Text = "Add a New User";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonSave;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox textBoxFName;
        private TextBox textBoxLName;
        private TextBox textBoxAddress;
        private TextBox textBoxPassword;
        private TextBox textBoxConfirmPassword;
        private TextBox textBoxEmail;
        private TextBox textBoxNic;
        private ComboBox comboBoxRole;
        private CheckBox checkBoxShowPassword;
        private TextBox textBoxPhone;
        private Label label9;
        private Label label10;
        private TextBox textBoxId;
    }
}