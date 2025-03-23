namespace BookWise
{
    partial class ReturnBookControl
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
            labelTitle = new Label();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitle.ForeColor = Color.FromArgb(30, 41, 59);
            labelTitle.Location = new Point(23, 21);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(189, 37);
            labelTitle.TabIndex = 1;
            labelTitle.Text = "Return a Book";
            // 
            // ReturnBookControl
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.GhostWhite;
            Controls.Add(labelTitle);
            Name = "ReturnBookControl";
            Size = new Size(929, 541);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitle;
    }
}
