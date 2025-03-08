namespace MainDVLD.Users
{
    partial class frmManageUsers
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageUsers));
            pictureBox1 = new PictureBox();
            lbAddEditUser = new Label();
            btnAddNewUser = new PictureBox();
            lbNumberOFUsers = new Label();
            label2 = new Label();
            dgvListAllUsers = new DataGridView();
            UserID = new DataGridViewTextBoxColumn();
            PersonID = new DataGridViewTextBoxColumn();
            FullName = new DataGridViewTextBoxColumn();
            UserName = new DataGridViewTextBoxColumn();
            IsActive = new DataGridViewCheckBoxColumn();
            contextMenuStrip1 = new ContextMenuStrip(components);
            ShowDetailesToolStripMenuItem = new ToolStripMenuItem();
            AddNewToolStripMenuItem = new ToolStripMenuItem();
            EditToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem1 = new ToolStripMenuItem();
            ChangePasswordToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator5 = new ToolStripSeparator();
            doSendEmailToolStripMenuItem = new ToolStripMenuItem();
            addPhoneCallToolStripMenuItem = new ToolStripMenuItem();
            btnClose = new Button();
            tbSearchValue = new TextBox();
            label1 = new Label();
            cbFilterUserData = new ComboBox();
            errorProvider1 = new ErrorProvider(components);
            cbFilterUserActivity = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnAddNewUser).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvListAllUsers).BeginInit();
            contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = null;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(536, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(244, 190);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // lbAddEditUser
            // 
            lbAddEditUser.AutoSize = true;
            lbAddEditUser.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbAddEditUser.ForeColor = Color.Brown;
            lbAddEditUser.Location = new Point(511, 218);
            lbAddEditUser.Name = "lbAddEditUser";
            lbAddEditUser.Size = new Size(290, 54);
            lbAddEditUser.TabIndex = 6;
            lbAddEditUser.Text = "Manage Users";
            // 
            // btnAddNewUser
            // 
            btnAddNewUser.BackgroundImageLayout = ImageLayout.Zoom;
            btnAddNewUser.BorderStyle = BorderStyle.FixedSingle;
            btnAddNewUser.Image = (Image)resources.GetObject("btnAddNewUser.Image");
            btnAddNewUser.Location = new Point(1186, 313);
            btnAddNewUser.Margin = new Padding(2);
            btnAddNewUser.Name = "btnAddNewUser";
            btnAddNewUser.Size = new Size(91, 74);
            btnAddNewUser.SizeMode = PictureBoxSizeMode.Zoom;
            btnAddNewUser.TabIndex = 49;
            btnAddNewUser.TabStop = false;
            btnAddNewUser.Click += btnAddNewUser_Click;
            // 
            // lbNumberOFUsers
            // 
            lbNumberOFUsers.AutoSize = true;
            lbNumberOFUsers.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold);
            lbNumberOFUsers.Location = new Point(139, 757);
            lbNumberOFUsers.Margin = new Padding(2, 0, 2, 0);
            lbNumberOFUsers.Name = "lbNumberOFUsers";
            lbNumberOFUsers.Size = new Size(19, 20);
            lbNumberOFUsers.TabIndex = 48;
            lbNumberOFUsers.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(23, 754);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(116, 25);
            label2.TabIndex = 47;
            label2.Text = "# Records:";
            // 
            // dgvListAllUsers
            // 
            dgvListAllUsers.AllowUserToAddRows = false;
            dgvListAllUsers.AllowUserToDeleteRows = false;
            dgvListAllUsers.BackgroundColor = Color.White;
            dgvListAllUsers.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            dgvListAllUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListAllUsers.Columns.AddRange(new DataGridViewColumn[] { UserID, PersonID, FullName, UserName, IsActive });
            dgvListAllUsers.ContextMenuStrip = contextMenuStrip1;
            dgvListAllUsers.Location = new Point(23, 393);
            dgvListAllUsers.Margin = new Padding(2);
            dgvListAllUsers.Name = "dgvListAllUsers";
            dgvListAllUsers.ReadOnly = true;
            dgvListAllUsers.RowHeadersWidth = 62;
            dgvListAllUsers.ScrollBars = ScrollBars.Vertical;
            dgvListAllUsers.Size = new Size(1254, 345);
            dgvListAllUsers.TabIndex = 46;
            // 
            // UserID
            // 
            UserID.DataPropertyName = "UserID";
            UserID.HeaderText = "UserID";
            UserID.MinimumWidth = 8;
            UserID.Name = "UserID";
            UserID.ReadOnly = true;
            UserID.Width = 150;
            // 
            // PersonID
            // 
            PersonID.DataPropertyName = "PersonID";
            PersonID.HeaderText = "PersonID";
            PersonID.MinimumWidth = 8;
            PersonID.Name = "PersonID";
            PersonID.ReadOnly = true;
            PersonID.Width = 150;
            // 
            // FullName
            // 
            FullName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            FullName.DataPropertyName = "FullName";
            FullName.HeaderText = "FullName";
            FullName.MinimumWidth = 8;
            FullName.Name = "FullName";
            FullName.ReadOnly = true;
            // 
            // UserName
            // 
            UserName.DataPropertyName = "UserName";
            UserName.HeaderText = "UserName";
            UserName.MinimumWidth = 8;
            UserName.Name = "UserName";
            UserName.ReadOnly = true;
            UserName.Width = 150;
            // 
            // IsActive
            // 
            IsActive.DataPropertyName = "IsActive";
            IsActive.HeaderText = "IsActive";
            IsActive.MinimumWidth = 8;
            IsActive.Name = "IsActive";
            IsActive.ReadOnly = true;
            IsActive.Width = 150;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.BackColor = SystemColors.ButtonHighlight;
            contextMenuStrip1.BackgroundImageLayout = ImageLayout.None;
            contextMenuStrip1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            contextMenuStrip1.ImageScalingSize = new Size(27, 27);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { ShowDetailesToolStripMenuItem, AddNewToolStripMenuItem, EditToolStripMenuItem, deleteToolStripMenuItem1, ChangePasswordToolStripMenuItem, toolStripSeparator5, doSendEmailToolStripMenuItem, addPhoneCallToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.RenderMode = ToolStripRenderMode.Professional;
            contextMenuStrip1.Size = new Size(258, 262);
            // 
            // ShowDetailesToolStripMenuItem
            // 
            ShowDetailesToolStripMenuItem.Image = (Image)resources.GetObject("ShowDetailesToolStripMenuItem.Image");
            ShowDetailesToolStripMenuItem.Name = "ShowDetailesToolStripMenuItem";
            ShowDetailesToolStripMenuItem.Size = new Size(257, 36);
            ShowDetailesToolStripMenuItem.Text = "Show Details";
            ShowDetailesToolStripMenuItem.Click += ShowDetailesToolStripMenuItem_Click;
            // 
            // AddNewToolStripMenuItem
            // 
            AddNewToolStripMenuItem.Image = (Image)resources.GetObject("AddNewToolStripMenuItem.Image");
            AddNewToolStripMenuItem.Name = "AddNewToolStripMenuItem";
            AddNewToolStripMenuItem.Size = new Size(257, 36);
            AddNewToolStripMenuItem.Text = "Add new Person";
            AddNewToolStripMenuItem.Click += AddNewToolStripMenuItem_Click;
            // 
            // EditToolStripMenuItem
            // 
            EditToolStripMenuItem.Image = (Image)resources.GetObject("EditToolStripMenuItem.Image");
            EditToolStripMenuItem.Name = "EditToolStripMenuItem";
            EditToolStripMenuItem.Size = new Size(257, 36);
            EditToolStripMenuItem.Text = "Edit Info";
            EditToolStripMenuItem.Click += EditToolStripMenuItem_Click;
            // 
            // deleteToolStripMenuItem1
            // 
            deleteToolStripMenuItem1.Image = (Image)resources.GetObject("deleteToolStripMenuItem1.Image");
            deleteToolStripMenuItem1.Name = "deleteToolStripMenuItem1";
            deleteToolStripMenuItem1.Size = new Size(257, 36);
            deleteToolStripMenuItem1.Text = "Delete";
            deleteToolStripMenuItem1.Click += deleteToolStripMenuItem1_Click;
            // 
            // ChangePasswordToolStripMenuItem
            // 
            ChangePasswordToolStripMenuItem.Image = (Image)resources.GetObject("ChangePasswordToolStripMenuItem.Image");
            ChangePasswordToolStripMenuItem.Name = "ChangePasswordToolStripMenuItem";
            ChangePasswordToolStripMenuItem.Size = new Size(257, 36);
            ChangePasswordToolStripMenuItem.Text = " Change Password ";
            ChangePasswordToolStripMenuItem.Click += ChangePasswordToolStripMenuItem_Click;
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new Size(254, 6);
            // 
            // doSendEmailToolStripMenuItem
            // 
            doSendEmailToolStripMenuItem.Image = (Image)resources.GetObject("doSendEmailToolStripMenuItem.Image");
            doSendEmailToolStripMenuItem.Name = "doSendEmailToolStripMenuItem";
            doSendEmailToolStripMenuItem.Size = new Size(257, 36);
            doSendEmailToolStripMenuItem.Text = "Send Email";
            // 
            // addPhoneCallToolStripMenuItem
            // 
            addPhoneCallToolStripMenuItem.Image = (Image)resources.GetObject("addPhoneCallToolStripMenuItem.Image");
            addPhoneCallToolStripMenuItem.Name = "addPhoneCallToolStripMenuItem";
            addPhoneCallToolStripMenuItem.Size = new Size(257, 36);
            addPhoneCallToolStripMenuItem.Text = "Phon Call";
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.ImageAlign = ContentAlignment.MiddleLeft;
            btnClose.Location = new Point(1129, 743);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(148, 44);
            btnClose.TabIndex = 50;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // tbSearchValue
            // 
            tbSearchValue.Location = new Point(351, 332);
            tbSearchValue.Multiline = true;
            tbSearchValue.Name = "tbSearchValue";
            tbSearchValue.Size = new Size(243, 34);
            tbSearchValue.TabIndex = 53;
            tbSearchValue.TextChanged += tbSearchValue_TextChanged;
            tbSearchValue.KeyPress += tbSearchValue_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(23, 328);
            label1.Name = "label1";
            label1.Size = new Size(109, 32);
            label1.TabIndex = 52;
            label1.Text = "Filter By:";
            // 
            // cbFilterUserData
            // 
            cbFilterUserData.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbFilterUserData.FormattingEnabled = true;
            cbFilterUserData.Items.AddRange(new object[] { "None", "UserID", "PersonID ", "UserName", "IsActive" });
            cbFilterUserData.Location = new Point(139, 329);
            cbFilterUserData.Name = "cbFilterUserData";
            cbFilterUserData.Size = new Size(197, 36);
            cbFilterUserData.TabIndex = 51;
            cbFilterUserData.SelectedIndexChanged += cbFilterUserData_SelectedIndexChanged;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // cbFilterUserActivity
            // 
            cbFilterUserActivity.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbFilterUserActivity.FormattingEnabled = true;
            cbFilterUserActivity.Items.AddRange(new object[] { "All", "Active", "NotActive" });
            cbFilterUserActivity.Location = new Point(351, 328);
            cbFilterUserActivity.Name = "cbFilterUserActivity";
            cbFilterUserActivity.Size = new Size(197, 36);
            cbFilterUserActivity.TabIndex = 54;
            cbFilterUserActivity.SelectedIndexChanged += cbFilterUserActivity_SelectedIndexChanged;
            // 
            // frmManageUsers
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1288, 792);
            Controls.Add(cbFilterUserActivity);
            Controls.Add(tbSearchValue);
            Controls.Add(label1);
            Controls.Add(cbFilterUserData);
            Controls.Add(btnClose);
            Controls.Add(btnAddNewUser);
            Controls.Add(lbNumberOFUsers);
            Controls.Add(label2);
            Controls.Add(dgvListAllUsers);
            Controls.Add(pictureBox1);
            Controls.Add(lbAddEditUser);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "frmManageUsers";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Users Managment ";
            Load += frmManageUsers_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnAddNewUser).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvListAllUsers).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lbAddEditUser;
        private PictureBox btnAddNewUser;
        private Label lbNumberOFUsers;
        private Label label2;
        private DataGridView dgvListAllUsers;
        private Button btnClose;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem ShowDetailesToolStripMenuItem;
        private ToolStripMenuItem AddNewToolStripMenuItem;
        private ToolStripMenuItem EditToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem1;
        private ToolStripMenuItem ChangePasswordToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripMenuItem doSendEmailToolStripMenuItem;
        private ToolStripMenuItem addPhoneCallToolStripMenuItem;
        private TextBox tbSearchValue;
        private Label label1;
        protected ComboBox cbFilterUserData;
        private DataGridViewTextBoxColumn UserID;
        private DataGridViewTextBoxColumn PersonID;
        private DataGridViewTextBoxColumn FullName;
        private DataGridViewTextBoxColumn UserName;
        private DataGridViewCheckBoxColumn IsActive;
        private ErrorProvider errorProvider1;
        protected ComboBox cbFilterUserActivity;
    }
}