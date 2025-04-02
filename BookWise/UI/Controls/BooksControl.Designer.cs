
namespace BookWise
{
    partial class BooksControl
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            label1 = new Label();
            dataGridViewBooks = new DataGridView();
            contextMenu = new ContextMenuStrip(components);
            editToolStripMenuItem = new ToolStripMenuItem();
            removeToolStripMenuItem = new ToolStripMenuItem();
            moreToolStripMenuItem = new ToolStripMenuItem();
            borrowToolStripMenuItem = new ToolStripMenuItem();
            buttonAddBook = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBooks).BeginInit();
            contextMenu.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(30, 41, 59);
            label1.Location = new Point(23, 21);
            label1.Name = "label1";
            label1.Size = new Size(130, 37);
            label1.TabIndex = 0;
            label1.Text = "All Books";
            // 
            // dataGridViewBooks
            // 
            dataGridViewBooks.AllowUserToAddRows = false;
            dataGridViewBooks.AllowUserToDeleteRows = false;
            dataGridViewBooks.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewBooks.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewBooks.BackgroundColor = Color.White;
            dataGridViewBooks.BorderStyle = BorderStyle.None;
            dataGridViewBooks.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewBooks.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.GhostWhite;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Pixel, 0);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(58, 53, 78);
            dataGridViewCellStyle1.Padding = new Padding(10, 16, 10, 16);
            dataGridViewCellStyle1.SelectionBackColor = Color.GhostWhite;
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(58, 53, 78);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewBooks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBooks.ContextMenuStrip = contextMenu;
            dataGridViewBooks.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridViewBooks.EnableHeadersVisualStyles = false;
            dataGridViewBooks.GridColor = Color.GhostWhite;
            dataGridViewBooks.Location = new Point(20, 84);
            dataGridViewBooks.MultiSelect = false;
            dataGridViewBooks.Name = "dataGridViewBooks";
            dataGridViewBooks.ReadOnly = true;
            dataGridViewBooks.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewBooks.RowHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Pixel, 0);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(58, 53, 78);
            dataGridViewCellStyle2.Padding = new Padding(10);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(248, 248, 248);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(58, 53, 78);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridViewBooks.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewBooks.RowTemplate.DividerHeight = 1;
            dataGridViewBooks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewBooks.Size = new Size(889, 440);
            dataGridViewBooks.TabIndex = 1;
            // 
            // contextMenu
            // 
            contextMenu.Items.AddRange(new ToolStripItem[] { editToolStripMenuItem, removeToolStripMenuItem, moreToolStripMenuItem });
            contextMenu.Name = "contextMenuStrip1";
            contextMenu.ShowImageMargin = false;
            contextMenu.Size = new Size(156, 92);
            contextMenu.Opening += contextMenu_Opening;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.Text;
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(155, 22);
            editToolStripMenuItem.Text = "Edit";
            editToolStripMenuItem.Click += editToolStripMenuItem_Click;
            // 
            // removeToolStripMenuItem
            // 
            removeToolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.Text;
            removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            removeToolStripMenuItem.Size = new Size(155, 22);
            removeToolStripMenuItem.Text = "Remove";
            removeToolStripMenuItem.Click += removeToolStripMenuItem_Click;
            // 
            // moreToolStripMenuItem
            // 
            moreToolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.Text;
            moreToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { borrowToolStripMenuItem });
            moreToolStripMenuItem.Name = "moreToolStripMenuItem";
            moreToolStripMenuItem.Size = new Size(155, 22);
            moreToolStripMenuItem.Text = "More";
            // 
            // borrowToolStripMenuItem
            // 
            borrowToolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.Text;
            borrowToolStripMenuItem.Name = "borrowToolStripMenuItem";
            borrowToolStripMenuItem.Size = new Size(180, 22);
            borrowToolStripMenuItem.Text = "Borrow";
            borrowToolStripMenuItem.Click += borrowToolStripMenuItem_Click;
            // 
            // buttonAddBook
            // 
            buttonAddBook.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonAddBook.BackColor = Color.FromArgb(37, 56, 140);
            buttonAddBook.Cursor = Cursors.Hand;
            buttonAddBook.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Pixel, 0);
            buttonAddBook.ForeColor = Color.White;
            buttonAddBook.Image = Properties.Resources.plus;
            buttonAddBook.ImageAlign = ContentAlignment.MiddleLeft;
            buttonAddBook.Location = new Point(744, 21);
            buttonAddBook.Name = "buttonAddBook";
            buttonAddBook.Padding = new Padding(10, 0, 10, 0);
            buttonAddBook.Size = new Size(165, 41);
            buttonAddBook.TabIndex = 2;
            buttonAddBook.Text = "  Add a New Book";
            buttonAddBook.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonAddBook.UseVisualStyleBackColor = false;
            buttonAddBook.Click += buttonAddBook_Click;
            // 
            // BooksControl
            // 
            AutoScaleMode = AutoScaleMode.None;
            AutoScroll = true;
            BackColor = Color.White;
            Controls.Add(buttonAddBook);
            Controls.Add(dataGridViewBooks);
            Controls.Add(label1);
            Name = "BooksControl";
            Padding = new Padding(20);
            Size = new Size(929, 541);
            ((System.ComponentModel.ISupportInitialize)dataGridViewBooks).EndInit();
            contextMenu.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private Label label1;
        private DataGridView dataGridViewBooks;
        private Button buttonAddBook;
        private ContextMenuStrip contextMenu;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem removeToolStripMenuItem;
        private ToolStripMenuItem moreToolStripMenuItem;
        private ToolStripMenuItem borrowToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
    }
}
