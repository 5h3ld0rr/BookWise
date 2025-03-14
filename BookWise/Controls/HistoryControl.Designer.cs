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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            dataGridViewBookTransactions = new DataGridView();
            label1 = new Label();
            buttonFilter = new Button();
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
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.GhostWhite;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Pixel, 0);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(58, 53, 78);
            dataGridViewCellStyle3.Padding = new Padding(10, 16, 10, 16);
            dataGridViewCellStyle3.SelectionBackColor = Color.GhostWhite;
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(58, 53, 78);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridViewBookTransactions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
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
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Pixel, 0);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(58, 53, 78);
            dataGridViewCellStyle4.Padding = new Padding(10);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(248, 248, 248);
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(58, 53, 78);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridViewBookTransactions.RowsDefaultCellStyle = dataGridViewCellStyle4;
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
            buttonFilter.Cursor = Cursors.Hand;
            buttonFilter.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Pixel, 0);
            buttonFilter.ForeColor = Color.FromArgb(30, 41, 59);
            buttonFilter.ImageAlign = ContentAlignment.MiddleLeft;
            buttonFilter.Location = new Point(784, 23);
            buttonFilter.Name = "buttonFilter";
            buttonFilter.Padding = new Padding(10, 0, 10, 0);
            buttonFilter.Size = new Size(112, 41);
            buttonFilter.TabIndex = 4;
            buttonFilter.Text = "Filter";
            buttonFilter.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonFilter.UseVisualStyleBackColor = false;
            buttonFilter.Click += buttonFilter_Click;
            // 
            // HistoryControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
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
    }
}
