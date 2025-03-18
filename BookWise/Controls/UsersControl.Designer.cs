
namespace BookWise
{
    partial class UsersControl
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
            labelTitle = new Label();
            dataGridViewUsers = new DataGridView();
            contextMenu = new ContextMenuStrip(components);
            editToolStripMenuItem = new ToolStripMenuItem();
            removeToolStripMenuItem = new ToolStripMenuItem();
            buttonAddUser = new Button();
            comboBoxUserFilter = new ComboBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsers).BeginInit();
            contextMenu.SuspendLayout();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitle.ForeColor = Color.FromArgb(30, 41, 59);
            labelTitle.Location = new Point(23, 21);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(123, 37);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "All Users";
            // 
            // dataGridViewUsers
            // 
            dataGridViewUsers.AllowUserToAddRows = false;
            dataGridViewUsers.AllowUserToDeleteRows = false;
            dataGridViewUsers.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewUsers.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewUsers.BackgroundColor = Color.White;
            dataGridViewUsers.BorderStyle = BorderStyle.None;
            dataGridViewUsers.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewUsers.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.GhostWhite;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Pixel, 0);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(58, 53, 78);
            dataGridViewCellStyle1.Padding = new Padding(10, 16, 10, 16);
            dataGridViewCellStyle1.SelectionBackColor = Color.GhostWhite;
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(58, 53, 78);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewUsers.ContextMenuStrip = contextMenu;
            dataGridViewUsers.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridViewUsers.EnableHeadersVisualStyles = false;
            dataGridViewUsers.GridColor = Color.GhostWhite;
            dataGridViewUsers.Location = new Point(20, 84);
            dataGridViewUsers.MultiSelect = false;
            dataGridViewUsers.Name = "dataGridViewUsers";
            dataGridViewUsers.ReadOnly = true;
            dataGridViewUsers.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewUsers.RowHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Pixel, 0);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(58, 53, 78);
            dataGridViewCellStyle2.Padding = new Padding(10);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(248, 248, 248);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(58, 53, 78);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridViewUsers.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewUsers.RowTemplate.DividerHeight = 1;
            dataGridViewUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewUsers.Size = new Size(889, 440);
            dataGridViewUsers.TabIndex = 1;
            // 
            // contextMenu
            // 
            contextMenu.Items.AddRange(new ToolStripItem[] { editToolStripMenuItem, removeToolStripMenuItem });
            contextMenu.Name = "contextMenuStrip1";
            contextMenu.ShowImageMargin = false;
            contextMenu.Size = new Size(93, 48);
            contextMenu.Opening += contextMenu_Opening;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.Text;
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(92, 22);
            editToolStripMenuItem.Text = "Edit";
            editToolStripMenuItem.Click += editToolStripMenuItem_Click;
            // 
            // removeToolStripMenuItem
            // 
            removeToolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.Text;
            removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            removeToolStripMenuItem.Size = new Size(92, 22);
            removeToolStripMenuItem.Text = "Remove";
            removeToolStripMenuItem.Click += removeToolStripMenuItem_Click;
            // 
            // buttonAddUser
            // 
            buttonAddUser.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonAddUser.BackColor = Color.FromArgb(37, 56, 140);
            buttonAddUser.Cursor = Cursors.Hand;
            buttonAddUser.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Pixel, 0);
            buttonAddUser.ForeColor = Color.White;
            buttonAddUser.Image = Properties.Resources.plus;
            buttonAddUser.ImageAlign = ContentAlignment.MiddleLeft;
            buttonAddUser.Location = new Point(744, 21);
            buttonAddUser.Name = "buttonAddUser";
            buttonAddUser.Padding = new Padding(10, 0, 10, 0);
            buttonAddUser.Size = new Size(165, 41);
            buttonAddUser.TabIndex = 2;
            buttonAddUser.Text = "  Add a New User";
            buttonAddUser.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonAddUser.UseVisualStyleBackColor = false;
            buttonAddUser.Click += buttonAddUser_Click;
            // 
            // comboBoxUserFilter
            // 
            comboBoxUserFilter.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            comboBoxUserFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxUserFilter.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            comboBoxUserFilter.ForeColor = Color.FromArgb(58, 53, 78);
            comboBoxUserFilter.FormattingEnabled = true;
            comboBoxUserFilter.Items.AddRange(new object[] { "All", "Students", "Staff" });
            comboBoxUserFilter.Location = new Point(621, 29);
            comboBoxUserFilter.Name = "comboBoxUserFilter";
            comboBoxUserFilter.Size = new Size(101, 27);
            comboBoxUserFilter.TabIndex = 3;
            comboBoxUserFilter.SelectedIndexChanged += comboBoxUserFilter_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            label2.ForeColor = Color.FromArgb(100, 116, 139);
            label2.Location = new Point(569, 32);
            label2.Name = "label2";
            label2.Size = new Size(46, 19);
            label2.TabIndex = 4;
            label2.Text = "Filter :";
            // 
            // UsersControl
            // 
            AutoScaleMode = AutoScaleMode.None;
            AutoScroll = true;
            BackColor = Color.White;
            Controls.Add(label2);
            Controls.Add(comboBoxUserFilter);
            Controls.Add(buttonAddUser);
            Controls.Add(dataGridViewUsers);
            Controls.Add(labelTitle);
            Name = "UsersControl";
            Padding = new Padding(20);
            Size = new Size(929, 541);
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsers).EndInit();
            contextMenu.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private Label labelTitle;
        private DataGridView dataGridViewUsers;
        private Button buttonAddUser;
        private ContextMenuStrip contextMenu;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem removeToolStripMenuItem;
        private ComboBox comboBoxUserFilter;
        private Label label2;
    }
}
