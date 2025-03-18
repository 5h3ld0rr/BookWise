namespace BookWise
{
    partial class HistoryControl
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dataGridViewBookTransactions = new DataGridView();
            label1 = new Label();
            buttonFilter = new Button();
            labelFilterApplied = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBookTransactions).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewBookTransactions
            // 
            dataGridViewBookTransactions.AllowUserToAddRows = false;
            dataGridViewBookTransactions.AllowUserToDeleteRows = false;
            dataGridViewBookTransactions.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewBookTransactions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewBookTransactions.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewBookTransactions.BackgroundColor = Color.White;
            dataGridViewBookTransactions.BorderStyle = BorderStyle.None;
            dataGridViewBookTransactions.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewBookTransactions.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dataGridViewBookTransactions.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.GhostWhite;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Pixel, 0);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(58, 53, 78);
            dataGridViewCellStyle1.Padding = new Padding(10, 16, 10, 16);
            dataGridViewCellStyle1.SelectionBackColor = Color.GhostWhite;
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(58, 53, 78);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewBookTransactions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewBookTransactions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBookTransactions.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridViewBookTransactions.EnableHeadersVisualStyles = false;
            dataGridViewBookTransactions.GridColor = Color.GhostWhite;
            dataGridViewBookTransactions.Location = new Point(20, 82);
            dataGridViewBookTransactions.MultiSelect = false;
            dataGridViewBookTransactions.Name = "dataGridViewBookTransactions";
            dataGridViewBookTransactions.ReadOnly = true;
            dataGridViewBookTransactions.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewBookTransactions.RowHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Pixel, 0);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(58, 53, 78);
            dataGridViewCellStyle2.Padding = new Padding(10);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(248, 248, 248);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(58, 53, 78);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridViewBookTransactions.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewBookTransactions.RowTemplate.DividerHeight = 1;
            dataGridViewBookTransactions.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGridViewBookTransactions.Size = new Size(889, 440);
            dataGridViewBookTransactions.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(30, 41, 59);
            label1.Location = new Point(23, 19);
            label1.Name = "label1";
            label1.Size = new Size(239, 37);
            label1.TabIndex = 2;
            label1.Text = "Book Transactions";
            // 
            // buttonFilter
            // 
            buttonFilter.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonFilter.BackColor = Color.GhostWhite;
            buttonFilter.BackgroundImage = Properties.Resources.filter;
            buttonFilter.BackgroundImageLayout = ImageLayout.Zoom;
            buttonFilter.Cursor = Cursors.Hand;
            buttonFilter.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Pixel, 0);
            buttonFilter.ForeColor = Color.FromArgb(30, 41, 59);
            buttonFilter.Location = new Point(872, 19);
            buttonFilter.Name = "buttonFilter";
            buttonFilter.Padding = new Padding(10, 0, 10, 0);
            buttonFilter.Size = new Size(37, 37);
            buttonFilter.TabIndex = 4;
            buttonFilter.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonFilter.UseVisualStyleBackColor = false;
            buttonFilter.Click += buttonFilter_Click;
            // 
            // labelFilterApplied
            // 
            labelFilterApplied.AutoSize = true;
            labelFilterApplied.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            labelFilterApplied.ForeColor = SystemColors.ControlDarkDark;
            labelFilterApplied.Location = new Point(261, 28);
            labelFilterApplied.Name = "labelFilterApplied";
            labelFilterApplied.Size = new Size(80, 13);
            labelFilterApplied.TabIndex = 5;
            labelFilterApplied.Text = "*Filter applied";
            // 
            // HistoryControl
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            Controls.Add(labelFilterApplied);
            Controls.Add(buttonFilter);
            Controls.Add(dataGridViewBookTransactions);
            Controls.Add(label1);
            Name = "HistoryControl";
            Size = new Size(929, 541);
            ((System.ComponentModel.ISupportInitialize)dataGridViewBookTransactions).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewBookTransactions;
        private Label label1;
        private Button buttonFilter;
        private Label labelFilterApplied;
    }
}
