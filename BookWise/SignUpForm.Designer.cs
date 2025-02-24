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
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            textBoxFName = new TextBox();
            labelFName = new Label();
            linkLabel1 = new LinkLabel();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            buttonRegister = new Button();
            textBoxPassword = new TextBox();
            textBoxEmal = new TextBox();
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
            panel1.Controls.Add(textBoxFName);
            panel1.Controls.Add(labelFName);
            panel1.Controls.Add(linkLabel1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(buttonRegister);
            panel1.Controls.Add(textBoxPassword);
            panel1.Controls.Add(textBoxEmal);
            panel1.Controls.Add(labelPassword);
            panel1.Controls.Add(labelEmail);
            panel1.Location = new Point(39, 37);
            panel1.Name = "panel1";
            panel1.Size = new Size(423, 564);
            panel1.TabIndex = 6;
            // 
            // textBoxFName
            // 
            textBoxFName.BackColor = Color.FromArgb(35, 40, 57);
            textBoxFName.BorderStyle = BorderStyle.None;
            textBoxFName.Font = new Font("Segoe UI", 16F);
            textBoxFName.ForeColor = Color.White;
            textBoxFName.Location = new Point(34, 194);
            textBoxFName.Margin = new Padding(3, 2, 3, 2);
            textBoxFName.Name = "textBoxFName";
            textBoxFName.Size = new Size(364, 29);
            textBoxFName.TabIndex = 18;
            // 
            // labelFName
            // 
            labelFName.AutoSize = true;
            labelFName.Font = new Font("Segoe UI", 12F);
            labelFName.ForeColor = Color.FromArgb(214, 224, 255);
            labelFName.Location = new Point(34, 161);
            labelFName.Name = "labelFName";
            labelFName.Size = new Size(78, 21);
            labelFName.TabIndex = 17;
            labelFName.Text = "Full name";
            // 
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor = Color.FromArgb(231, 201, 165);
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI", 11F);
            linkLabel1.LinkBehavior = LinkBehavior.HoverUnderline;
            linkLabel1.LinkColor = Color.FromArgb(231, 201, 165);
            linkLabel1.Location = new Point(264, 507);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(79, 20);
            linkLabel1.TabIndex = 16;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Login here";
            linkLabel1.VisitedLinkColor = Color.FromArgb(231, 201, 165);
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F);
            label3.Location = new Point(86, 507);
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
            label2.Click += label2_Click;
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
            // buttonRegister
            // 
            buttonRegister.BackColor = Color.FromArgb(231, 201, 165);
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
            // textBoxPassword
            // 
            textBoxPassword.BackColor = Color.FromArgb(35, 40, 57);
            textBoxPassword.BorderStyle = BorderStyle.None;
            textBoxPassword.Font = new Font("Segoe UI", 16F);
            textBoxPassword.ForeColor = Color.White;
            textBoxPassword.Location = new Point(34, 362);
            textBoxPassword.Margin = new Padding(3, 2, 3, 2);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.Size = new Size(364, 29);
            textBoxPassword.TabIndex = 8;
            textBoxPassword.UseSystemPasswordChar = true;
            // 
            // textBoxEmal
            // 
            textBoxEmal.BackColor = Color.FromArgb(35, 40, 57);
            textBoxEmal.BorderStyle = BorderStyle.None;
            textBoxEmal.Font = new Font("Segoe UI", 16F);
            textBoxEmal.ForeColor = Color.White;
            textBoxEmal.Location = new Point(34, 276);
            textBoxEmal.Margin = new Padding(3, 2, 3, 2);
            textBoxEmal.Name = "textBoxEmal";
            textBoxEmal.Size = new Size(364, 29);
            textBoxEmal.TabIndex = 7;
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Font = new Font("Segoe UI", 12F);
            labelPassword.ForeColor = Color.FromArgb(214, 224, 255);
            labelPassword.Location = new Point(34, 328);
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
            labelEmail.Location = new Point(34, 244);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(48, 21);
            labelEmail.TabIndex = 5;
            labelEmail.Text = "Email";
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
            Margin = new Padding(3, 2, 3, 2);
            Name = "SignUpForm";
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
        private Button buttonRegister;
        private TextBox textBoxPassword;
        private TextBox textBoxEmal;
        private Label labelPassword;
        private Label labelEmail;
        private PictureBox pictureBox2;
        private Label label2;
        private Label label1;
        private Label label3;
        private LinkLabel linkLabel1;
        private TextBox textBoxFName;
        private Label labelFName;
    }
}
