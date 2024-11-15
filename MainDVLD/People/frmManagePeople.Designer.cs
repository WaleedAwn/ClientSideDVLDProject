namespace MainDVLD.People
{
    partial class frmManagePeople
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManagePeople));
            dgvListAllPeople = new DataGridView();
            colPersonID = new DataGridViewTextBoxColumn();
            colNationalNo = new DataGridViewTextBoxColumn();
            colFirstName = new DataGridViewTextBoxColumn();
            colSecondName = new DataGridViewTextBoxColumn();
            colThirdName = new DataGridViewTextBoxColumn();
            colLastName = new DataGridViewTextBoxColumn();
            colGender = new DataGridViewTextBoxColumn();
            colDateOFBirth = new DataGridViewTextBoxColumn();
            colNationality = new DataGridViewTextBoxColumn();
            colPhone = new DataGridViewTextBoxColumn();
            colEmail = new DataGridViewTextBoxColumn();
            contextMenuStrip1 = new ContextMenuStrip(components);
            toolStripSeparator1 = new ToolStripSeparator();
            ShowDetailesToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            AddNewToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            EditToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator4 = new ToolStripSeparator();
            deleteToolStripMenuItem1 = new ToolStripMenuItem();
            toolStripSeparator5 = new ToolStripSeparator();
            doAppoitmentToolStripMenuItem = new ToolStripMenuItem();
            addASPatientToolStripMenuItem = new ToolStripMenuItem();
            addASDoctorToolStripMenuItem = new ToolStripMenuItem();
            lbAddEditPerson = new Label();
            pictureBox1 = new PictureBox();
            btnClose = new Button();
            label2 = new Label();
            lnNumberOFPeople = new Label();
            btnAddNewPerson = new PictureBox();
            ctrlFindByFilter1 = new Controls.ctrlFindByFilter();
            ((System.ComponentModel.ISupportInitialize)dgvListAllPeople).BeginInit();
            contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnAddNewPerson).BeginInit();
            SuspendLayout();
            // 
            // dgvListAllPeople
            // 
            dgvListAllPeople.AllowUserToAddRows = false;
            dgvListAllPeople.AllowUserToDeleteRows = false;
            dgvListAllPeople.AllowUserToOrderColumns = true;
            dgvListAllPeople.BackgroundColor = Color.White;
            dgvListAllPeople.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            dgvListAllPeople.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListAllPeople.Columns.AddRange(new DataGridViewColumn[] { colPersonID, colNationalNo, colFirstName, colSecondName, colThirdName, colLastName, colGender, colDateOFBirth, colNationality, colPhone, colEmail });
            dgvListAllPeople.ContextMenuStrip = contextMenuStrip1;
            dgvListAllPeople.Location = new Point(20, 384);
            dgvListAllPeople.Margin = new Padding(2);
            dgvListAllPeople.Name = "dgvListAllPeople";
            dgvListAllPeople.ReadOnly = true;
            dgvListAllPeople.RowHeadersWidth = 62;
            dgvListAllPeople.ScrollBars = ScrollBars.Vertical;
            dgvListAllPeople.Size = new Size(1738, 307);
            dgvListAllPeople.TabIndex = 3;
            // 
            // colPersonID
            // 
            colPersonID.HeaderText = "Person ID";
            colPersonID.MinimumWidth = 8;
            colPersonID.Name = "colPersonID";
            colPersonID.ReadOnly = true;
            colPersonID.Width = 150;
            // 
            // colNationalNo
            // 
            colNationalNo.HeaderText = "National No.";
            colNationalNo.MinimumWidth = 8;
            colNationalNo.Name = "colNationalNo";
            colNationalNo.ReadOnly = true;
            colNationalNo.Width = 150;
            // 
            // colFirstName
            // 
            colFirstName.HeaderText = "First Name";
            colFirstName.MinimumWidth = 8;
            colFirstName.Name = "colFirstName";
            colFirstName.ReadOnly = true;
            colFirstName.Width = 150;
            // 
            // colSecondName
            // 
            colSecondName.HeaderText = "Second Name";
            colSecondName.MinimumWidth = 8;
            colSecondName.Name = "colSecondName";
            colSecondName.ReadOnly = true;
            colSecondName.Width = 150;
            // 
            // colThirdName
            // 
            colThirdName.HeaderText = "Third Name";
            colThirdName.MinimumWidth = 8;
            colThirdName.Name = "colThirdName";
            colThirdName.ReadOnly = true;
            colThirdName.Width = 150;
            // 
            // colLastName
            // 
            colLastName.HeaderText = "Last Name";
            colLastName.MinimumWidth = 8;
            colLastName.Name = "colLastName";
            colLastName.ReadOnly = true;
            colLastName.Width = 150;
            // 
            // colGender
            // 
            colGender.HeaderText = "Gender";
            colGender.MinimumWidth = 8;
            colGender.Name = "colGender";
            colGender.ReadOnly = true;
            colGender.Width = 150;
            // 
            // colDateOFBirth
            // 
            colDateOFBirth.HeaderText = "Date OF Birth";
            colDateOFBirth.MinimumWidth = 8;
            colDateOFBirth.Name = "colDateOFBirth";
            colDateOFBirth.ReadOnly = true;
            colDateOFBirth.Width = 150;
            // 
            // colNationality
            // 
            colNationality.HeaderText = "Nationality";
            colNationality.MinimumWidth = 8;
            colNationality.Name = "colNationality";
            colNationality.ReadOnly = true;
            colNationality.Width = 150;
            // 
            // colPhone
            // 
            colPhone.HeaderText = "Phone Number";
            colPhone.MinimumWidth = 8;
            colPhone.Name = "colPhone";
            colPhone.ReadOnly = true;
            colPhone.Width = 150;
            // 
            // colEmail
            // 
            colEmail.HeaderText = "Email";
            colEmail.MinimumWidth = 8;
            colEmail.Name = "colEmail";
            colEmail.ReadOnly = true;
            colEmail.Width = 150;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(24, 24);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { toolStripSeparator1, ShowDetailesToolStripMenuItem, toolStripSeparator2, AddNewToolStripMenuItem, toolStripSeparator3, EditToolStripMenuItem, toolStripSeparator4, deleteToolStripMenuItem1, toolStripSeparator5, doAppoitmentToolStripMenuItem, addASPatientToolStripMenuItem, addASDoctorToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.RenderMode = ToolStripRenderMode.System;
            contextMenuStrip1.Size = new Size(222, 258);
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(218, 6);
            // 
            // ShowDetailesToolStripMenuItem
            // 
            ShowDetailesToolStripMenuItem.Image = (Image)resources.GetObject("ShowDetailesToolStripMenuItem.Image");
            ShowDetailesToolStripMenuItem.Name = "ShowDetailesToolStripMenuItem";
            ShowDetailesToolStripMenuItem.Size = new Size(221, 32);
            ShowDetailesToolStripMenuItem.Text = "Show Details";
            ShowDetailesToolStripMenuItem.Click += ShowDetailesToolStripMenuItem_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(218, 6);
            // 
            // AddNewToolStripMenuItem
            // 
            AddNewToolStripMenuItem.Image = (Image)resources.GetObject("AddNewToolStripMenuItem.Image");
            AddNewToolStripMenuItem.Name = "AddNewToolStripMenuItem";
            AddNewToolStripMenuItem.Size = new Size(221, 32);
            AddNewToolStripMenuItem.Text = "Add new Person";
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(218, 6);
            // 
            // EditToolStripMenuItem
            // 
            EditToolStripMenuItem.Image = (Image)resources.GetObject("EditToolStripMenuItem.Image");
            EditToolStripMenuItem.Name = "EditToolStripMenuItem";
            EditToolStripMenuItem.Size = new Size(221, 32);
            EditToolStripMenuItem.Text = "Edit Info";
            EditToolStripMenuItem.Click += EditToolStripMenuItem_Click;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(218, 6);
            // 
            // deleteToolStripMenuItem1
            // 
            deleteToolStripMenuItem1.Image = (Image)resources.GetObject("deleteToolStripMenuItem1.Image");
            deleteToolStripMenuItem1.Name = "deleteToolStripMenuItem1";
            deleteToolStripMenuItem1.Size = new Size(221, 32);
            deleteToolStripMenuItem1.Text = "Delete";
            deleteToolStripMenuItem1.Click += deleteToolStripMenuItem1_Click;
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new Size(218, 6);
            // 
            // doAppoitmentToolStripMenuItem
            // 
            doAppoitmentToolStripMenuItem.Name = "doAppoitmentToolStripMenuItem";
            doAppoitmentToolStripMenuItem.Size = new Size(221, 32);
            doAppoitmentToolStripMenuItem.Text = " ";
            // 
            // addASPatientToolStripMenuItem
            // 
            addASPatientToolStripMenuItem.Name = "addASPatientToolStripMenuItem";
            addASPatientToolStripMenuItem.Size = new Size(221, 32);
            addASPatientToolStripMenuItem.Text = " ";
            // 
            // addASDoctorToolStripMenuItem
            // 
            addASDoctorToolStripMenuItem.Name = "addASDoctorToolStripMenuItem";
            addASDoctorToolStripMenuItem.Size = new Size(221, 32);
            addASDoctorToolStripMenuItem.Text = " ";
            // 
            // lbAddEditPerson
            // 
            lbAddEditPerson.AutoSize = true;
            lbAddEditPerson.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbAddEditPerson.ForeColor = Color.Brown;
            lbAddEditPerson.Location = new Point(766, 251);
            lbAddEditPerson.Name = "lbAddEditPerson";
            lbAddEditPerson.Size = new Size(315, 54);
            lbAddEditPerson.TabIndex = 4;
            lbAddEditPerson.Text = "Manage People";
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = null;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(791, 45);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(244, 190);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.ImageAlign = ContentAlignment.MiddleLeft;
            btnClose.Location = new Point(1610, 716);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(148, 44);
            btnClose.TabIndex = 42;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(20, 716);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(116, 25);
            label2.TabIndex = 43;
            label2.Text = "# Records:";
            // 
            // lnNumberOFPeople
            // 
            lnNumberOFPeople.AutoSize = true;
            lnNumberOFPeople.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold);
            lnNumberOFPeople.Location = new Point(136, 719);
            lnNumberOFPeople.Margin = new Padding(2, 0, 2, 0);
            lnNumberOFPeople.Name = "lnNumberOFPeople";
            lnNumberOFPeople.Size = new Size(19, 20);
            lnNumberOFPeople.TabIndex = 44;
            lnNumberOFPeople.Text = "0";
            // 
            // btnAddNewPerson
            // 
            btnAddNewPerson.BackgroundImageLayout = ImageLayout.Zoom;
            btnAddNewPerson.BorderStyle = BorderStyle.FixedSingle;
            btnAddNewPerson.Image = (Image)resources.GetObject("btnAddNewPerson.Image");
            btnAddNewPerson.Location = new Point(1667, 294);
            btnAddNewPerson.Margin = new Padding(2);
            btnAddNewPerson.Name = "btnAddNewPerson";
            btnAddNewPerson.Size = new Size(91, 74);
            btnAddNewPerson.TabIndex = 45;
            btnAddNewPerson.TabStop = false;
            btnAddNewPerson.Click += btnAddNewPerson_Click;
            // 
            // ctrlFindByFilter1
            // 
            ctrlFindByFilter1.Location = new Point(20, 319);
            ctrlFindByFilter1.Name = "ctrlFindByFilter1";
            ctrlFindByFilter1.Size = new Size(638, 60);
            ctrlFindByFilter1.TabIndex = 46;
            // 
            // frmManagePeople
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1801, 803);
            Controls.Add(ctrlFindByFilter1);
            Controls.Add(btnAddNewPerson);
            Controls.Add(lnNumberOFPeople);
            Controls.Add(label2);
            Controls.Add(btnClose);
            Controls.Add(pictureBox1);
            Controls.Add(lbAddEditPerson);
            Controls.Add(dgvListAllPeople);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "frmManagePeople";
            Text = "Manage People";
            Load += frmManagePeople_Load;
            ((System.ComponentModel.ISupportInitialize)dgvListAllPeople).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnAddNewPerson).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvListAllPeople;
        private Label lbAddEditPerson;
        private PictureBox pictureBox1;
        private DataGridViewTextBoxColumn colPersonID;
        private DataGridViewTextBoxColumn colNationalNo;
        private DataGridViewTextBoxColumn colFirstName;
        private DataGridViewTextBoxColumn colSecondName;
        private DataGridViewTextBoxColumn colThirdName;
        private DataGridViewTextBoxColumn colLastName;
        private DataGridViewTextBoxColumn colGender;
        private DataGridViewTextBoxColumn colDateOFBirth;
        private DataGridViewTextBoxColumn colNationality;
        private DataGridViewTextBoxColumn colPhone;
        private DataGridViewTextBoxColumn colEmail;
        private Button btnClose;
        private Label label2;
        private Label lnNumberOFPeople;
        private PictureBox btnAddNewPerson;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem ShowDetailesToolStripMenuItem;
        private ToolStripMenuItem AddNewToolStripMenuItem;
        private ToolStripMenuItem EditToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem1;
        private ToolStripMenuItem doAppoitmentToolStripMenuItem;
        private ToolStripMenuItem addASPatientToolStripMenuItem;
        private ToolStripMenuItem addASDoctorToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripSeparator toolStripSeparator5;
        private Controls.ctrlFindByFilter ctrlFindByFilter1;
    }
}