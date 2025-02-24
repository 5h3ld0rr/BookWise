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
            linkLabel1 = new LinkLabel();
            label3 = new Label();
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
            panel1.BackColor = Color.FromArgb(18, 20, 29);
            panel1.Controls.Add(linkLabel1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(buttonLogin);
            panel1.Controls.Add(textBoxPassword);
            panel1.Controls.Add(textBoxEmail);
            panel1.Controls.Add(labelPassword);
            panel1.Controls.Add(labelEmail);
            panel1.Location = new Point(40, 68);
            panel1.Name = "panel1";
            panel1.Size = new Size(423, 509);
            panel1.TabIndex = 6;
            // 
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor = Color.FromArgb(231, 201, 165);
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI", 11F);
            linkLabel1.LinkBehavior = LinkBehavior.HoverUnderline;
            linkLabel1.LinkColor = Color.FromArgb(231, 201, 165);
            linkLabel1.Location = new Point(276, 457);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(96, 20);
            linkLabel1.TabIndex = 16;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Register here";
            linkLabel1.VisitedLinkColor = Color.FromArgb(231, 201, 165);
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F);
            label3.Location = new Point(59, 457);
            label3.Name = "label3";
            label3.Size = new Size(216, 20);
            label3.TabIndex = 15;
            label3.Text = "Don’t have an account already?";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label2.Location = new Point(25, 91);
            label2.Name = "label2";
            label2.Size = new Size(339, 30);
            label2.TabIndex = 14;
            label2.Text = "Welcome Back to the BookWise";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.Location = new Point(77, 20);
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
            pictureBox2.Size = new Size(46, 31);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // buttonLogin
            // 
            buttonLogin.BackColor = Color.FromArgb(231, 201, 165);
            buttonLogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            buttonLogin.ForeColor = Color.FromArgb(20, 23, 28);
            buttonLogin.Location = new Point(34, 384);
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
            textBoxPassword.BackColor = Color.FromArgb(35, 40, 57);
            textBoxPassword.BorderStyle = BorderStyle.None;
            textBoxPassword.Font = new Font("Segoe UI", 16F);
            textBoxPassword.ForeColor = Color.White;
            textBoxPassword.Location = new Point(34, 303);
            textBoxPassword.Margin = new Padding(3, 2, 3, 2);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.Size = new Size(364, 29);
            textBoxPassword.TabIndex = 8;
            textBoxPassword.UseSystemPasswordChar = true;
            // 
            // textBoxEmail
            // 
            textBoxEmail.BackColor = Color.FromArgb(35, 40, 57);
            textBoxEmail.BorderStyle = BorderStyle.None;
            textBoxEmail.Font = new Font("Segoe UI", 16F);
            textBoxEmail.ForeColor = Color.White;
            textBoxEmail.Location = new Point(34, 196);
            textBoxEmail.Margin = new Padding(3, 2, 3, 2);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(364, 29);
            textBoxEmail.TabIndex = 7;
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Font = new Font("Segoe UI", 12F);
            labelPassword.ForeColor = Color.FromArgb(214, 224, 255);
            labelPassword.Location = new Point(34, 269);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(76, 21);
            labelPassword.TabIndex = 6;
            labelPassword.Text = "Password";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Font = new Font("Segoe UI", 12F);
            labelEmail.ForeColor = Color.FromArgb(214, 224, 255);
            labelEmail.Location = new Point(34, 164);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(48, 21);
            labelEmail.TabIndex = 5;
            labelEmail.Text = "Email";
            // 
            // SignInForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(17, 22, 36);
            ClientSize = new Size(946, 634);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(3, 2, 3, 2);
            Name = "SignInForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BookWise-Login";
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
        private Label label3;
        private LinkLabel linkLabel1;
    }
}
