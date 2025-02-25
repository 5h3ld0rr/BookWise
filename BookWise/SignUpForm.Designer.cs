namespace BookWise
{
    partial class SignUpForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUpForm));
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            checkBoxShowPassword = new CheckBox();
            textBoxEmail = new TextBox();
            labelEmail = new Label();
            linkLogin = new LinkLabel();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            buttonRegister = new Button();
            textBoxConfirmPassword = new TextBox();
            textBoxPassword = new TextBox();
            labelConfirmPassword = new Label();
            labelPassword = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.auth_bg;
            pictureBox1.Location = new Point(502, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(445, 637);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(18, 20, 29);
            panel1.Controls.Add(checkBoxShowPassword);
            panel1.Controls.Add(textBoxEmail);
            panel1.Controls.Add(labelEmail);
            panel1.Controls.Add(linkLogin);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(buttonRegister);
            panel1.Controls.Add(textBoxConfirmPassword);
            panel1.Controls.Add(textBoxPassword);
            panel1.Controls.Add(labelConfirmPassword);
            panel1.Controls.Add(labelPassword);
            panel1.Location = new Point(39, 37);
            panel1.Name = "panel1";
            panel1.Size = new Size(423, 564);
            panel1.TabIndex = 6;
            // 
            // checkBoxShowPassword
            // 
            checkBoxShowPassword.AutoSize = true;
            checkBoxShowPassword.Cursor = Cursors.Hand;
            checkBoxShowPassword.Font = new Font("Segoe UI", 10F);
            checkBoxShowPassword.Location = new Point(275, 385);
            checkBoxShowPassword.Name = "checkBoxShowPassword";
            checkBoxShowPassword.Size = new Size(123, 23);
            checkBoxShowPassword.TabIndex = 19;
            checkBoxShowPassword.Text = "Show Password";
            checkBoxShowPassword.UseVisualStyleBackColor = true;
            checkBoxShowPassword.CheckedChanged += checkBoxShowPassword_CheckedChanged;
            // 
            // textBoxEmail
            // 
            textBoxEmail.BackColor = Color.FromArgb(35, 40, 57);
            textBoxEmail.BorderStyle = BorderStyle.None;
            textBoxEmail.Font = new Font("Segoe UI", 16F);
            textBoxEmail.ForeColor = Color.White;
            textBoxEmail.Location = new Point(34, 191);
            textBoxEmail.Margin = new Padding(3, 2, 3, 2);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(364, 29);
            textBoxEmail.TabIndex = 18;
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Font = new Font("Segoe UI", 12F);
            labelEmail.ForeColor = Color.FromArgb(214, 224, 255);
            labelEmail.Location = new Point(34, 158);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(48, 21);
            labelEmail.TabIndex = 17;
            labelEmail.Text = "Email";
            // 
            // linkLogin
            // 
            linkLogin.ActiveLinkColor = Color.FromArgb(231, 201, 165);
            linkLogin.AutoSize = true;
            linkLogin.Font = new Font("Segoe UI", 11F);
            linkLogin.LinkBehavior = LinkBehavior.HoverUnderline;
            linkLogin.LinkColor = Color.FromArgb(231, 201, 165);
            linkLogin.Location = new Point(263, 507);
            linkLogin.Name = "linkLogin";
            linkLogin.Size = new Size(79, 20);
            linkLogin.TabIndex = 16;
            linkLogin.TabStop = true;
            linkLogin.Text = "Login here";
            linkLogin.VisitedLinkColor = Color.FromArgb(231, 201, 165);
            linkLogin.LinkClicked += linkLogin_LinkClicked;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F);
            label3.Location = new Point(85, 507);
            label3.Name = "label3";
            label3.Size = new Size(179, 20);
            label3.TabIndex = 15;
            label3.Text = "Have an account already?";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label2.Location = new Point(25, 91);
            label2.Name = "label2";
            label2.Size = new Size(304, 30);
            label2.TabIndex = 14;
            label2.Text = "Create Your Library Account";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.Location = new Point(65, 20);
            label1.Name = "label1";
            label1.Size = new Size(145, 37);
            label1.TabIndex = 13;
            label1.Text = "BookWise";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.logo;
            pictureBox2.Location = new Point(25, 26);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(34, 31);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // buttonRegister
            // 
            buttonRegister.BackColor = Color.FromArgb(231, 201, 165);
            buttonRegister.Cursor = Cursors.Hand;
            buttonRegister.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            buttonRegister.ForeColor = Color.FromArgb(20, 23, 28);
            buttonRegister.Location = new Point(34, 434);
            buttonRegister.Margin = new Padding(3, 2, 3, 2);
            buttonRegister.Name = "buttonRegister";
            buttonRegister.Size = new Size(364, 46);
            buttonRegister.TabIndex = 9;
            buttonRegister.Text = "Register";
            buttonRegister.UseVisualStyleBackColor = false;
            buttonRegister.Click += buttonRegister_Click;
            // 
            // textBoxConfirmPassword
            // 
            textBoxConfirmPassword.BackColor = Color.FromArgb(35, 40, 57);
            textBoxConfirmPassword.BorderStyle = BorderStyle.None;
            textBoxConfirmPassword.Font = new Font("Segoe UI", 16F);
            textBoxConfirmPassword.ForeColor = Color.White;
            textBoxConfirmPassword.Location = new Point(34, 349);
            textBoxConfirmPassword.Margin = new Padding(3, 2, 3, 2);
            textBoxConfirmPassword.Name = "textBoxConfirmPassword";
            textBoxConfirmPassword.Size = new Size(364, 29);
            textBoxConfirmPassword.TabIndex = 8;
            textBoxConfirmPassword.UseSystemPasswordChar = true;
            // 
            // textBoxPassword
            // 
            textBoxPassword.BackColor = Color.FromArgb(35, 40, 57);
            textBoxPassword.BorderStyle = BorderStyle.None;
            textBoxPassword.Font = new Font("Segoe UI", 16F);
            textBoxPassword.ForeColor = Color.White;
            textBoxPassword.Location = new Point(34, 270);
            textBoxPassword.Margin = new Padding(3, 2, 3, 2);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(364, 29);
            textBoxPassword.TabIndex = 7;
            textBoxPassword.UseSystemPasswordChar = true;
            // 
            // labelConfirmPassword
            // 
            labelConfirmPassword.AutoSize = true;
            labelConfirmPassword.Font = new Font("Segoe UI", 12F);
            labelConfirmPassword.ForeColor = Color.FromArgb(214, 224, 255);
            labelConfirmPassword.Location = new Point(34, 315);
            labelConfirmPassword.Name = "labelConfirmPassword";
            labelConfirmPassword.Size = new Size(137, 21);
            labelConfirmPassword.TabIndex = 6;
            labelConfirmPassword.Text = "Confirm Password";
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Font = new Font("Segoe UI", 12F);
            labelPassword.ForeColor = Color.FromArgb(214, 224, 255);
            labelPassword.Location = new Point(34, 238);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(76, 21);
            labelPassword.TabIndex = 5;
            labelPassword.Text = "Password";
            // 
            // SignUpForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(17, 22, 36);
            ClientSize = new Size(946, 634);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "SignUpForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }
        private PictureBox pictureBox1;
        private Panel panel1;
        private Button buttonRegister;
        private TextBox textBoxConfirmPassword;
        private TextBox textBoxPassword;
        private Label labelConfirmPassword;
        private Label labelPassword;
        private Label label2;
        private Label label1;
        private Label label3;
        private LinkLabel linkLogin;
        private Label labelEmail;
        private TextBox textBoxEmail;
        private PictureBox pictureBox2;
        private CheckBox checkBoxShowPassword;
    }
}
