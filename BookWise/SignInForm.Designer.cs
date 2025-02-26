namespace BookWise
{
    partial class SignInForm
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
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            checkBoxShowPassword = new CheckBox();
            label2 = new Label();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            buttonLogin = new Button();
            textBoxPassword = new TextBox();
            textBoxEmail = new TextBox();
            labelPassword = new Label();
            labelEmail = new Label();
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
            panel1.BackColor = Color.White;
            panel1.Controls.Add(checkBoxShowPassword);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(buttonLogin);
            panel1.Controls.Add(textBoxPassword);
            panel1.Controls.Add(textBoxEmail);
            panel1.Controls.Add(labelPassword);
            panel1.Controls.Add(labelEmail);
            panel1.Location = new Point(40, 75);
            panel1.Name = "panel1";
            panel1.Size = new Size(423, 488);
            panel1.TabIndex = 6;
            // 
            // checkBoxShowPassword
            // 
            checkBoxShowPassword.AutoSize = true;
            checkBoxShowPassword.Cursor = Cursors.Hand;
            checkBoxShowPassword.Font = new Font("Segoe UI", 10F);
            checkBoxShowPassword.Location = new Point(276, 346);
            checkBoxShowPassword.Name = "checkBoxShowPassword";
            checkBoxShowPassword.Size = new Size(123, 23);
            checkBoxShowPassword.TabIndex = 18;
            checkBoxShowPassword.Text = "Show Password";
            checkBoxShowPassword.UseVisualStyleBackColor = true;
            checkBoxShowPassword.CheckedChanged += checkBoxShowPassword_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Pixel);
            label2.Location = new Point(25, 91);
            label2.Name = "label2";
            label2.Size = new Size(373, 32);
            label2.TabIndex = 14;
            label2.Text = "Welcome Back to the BookWise";
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
            // buttonLogin
            // 
            buttonLogin.BackColor = Color.FromArgb(37, 56, 140);
            buttonLogin.Cursor = Cursors.Hand;
            buttonLogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            buttonLogin.ForeColor = Color.FromArgb(248, 250, 252);
            buttonLogin.Location = new Point(34, 403);
            buttonLogin.Margin = new Padding(3, 2, 3, 2);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(364, 46);
            buttonLogin.TabIndex = 9;
            buttonLogin.Text = "Login";
            buttonLogin.UseVisualStyleBackColor = false;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // textBoxPassword
            // 
            textBoxPassword.BackColor = Color.FromArgb(249, 250, 251);
            textBoxPassword.Font = new Font("Segoe UI", 16F);
            textBoxPassword.ForeColor = Color.FromArgb(15, 23, 42);
            textBoxPassword.Location = new Point(34, 298);
            textBoxPassword.Margin = new Padding(3, 2, 3, 2);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(364, 36);
            textBoxPassword.TabIndex = 8;
            textBoxPassword.UseSystemPasswordChar = true;
            // 
            // textBoxEmail
            // 
            textBoxEmail.BackColor = Color.FromArgb(249, 250, 251);
            textBoxEmail.Font = new Font("Segoe UI", 16F);
            textBoxEmail.ForeColor = Color.FromArgb(15, 23, 42);
            textBoxEmail.Location = new Point(34, 197);
            textBoxEmail.Margin = new Padding(3, 2, 3, 2);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(364, 36);
            textBoxEmail.TabIndex = 7;
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Font = new Font("Segoe UI", 12F);
            labelPassword.ForeColor = Color.FromArgb(15, 23, 42);
            labelPassword.Location = new Point(34, 264);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(76, 21);
            labelPassword.TabIndex = 6;
            labelPassword.Text = "Password";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Font = new Font("Segoe UI", 12F);
            labelEmail.ForeColor = Color.FromArgb(15, 23, 42);
            labelEmail.Location = new Point(34, 165);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(48, 21);
            labelEmail.TabIndex = 5;
            labelEmail.Text = "Email";
            // 
            // SignInForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(946, 634);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "SignInForm";
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }
        private PictureBox pictureBox1;
        private Panel panel1;
        private Button buttonLogin;
        private TextBox textBoxPassword;
        private TextBox textBoxEmail;
        private Label labelPassword;
        private Label labelEmail;
        private PictureBox pictureBox2;
        private Label label2;
        private Label label1;
        private CheckBox checkBoxShowPassword;
    }
}
