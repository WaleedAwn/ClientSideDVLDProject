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
            contextMenuStrip1 = new ContextMenuStrip(components);
            ShowDetailesToolStripMenuItem = new ToolStripMenuItem();
            AddNewToolStripMenuItem = new ToolStripMenuItem();
            EditToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem1 = new ToolStripMenuItem();
            toolStripSeparator5 = new ToolStripSeparator();
            SendEmailoolStripMenuItem = new ToolStripMenuItem();
            phoneCallToolStripMenuItem = new ToolStripMenuItem();
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
            dgvListAllPeople.BackgroundColor = Color.White;
            dgvListAllPeople.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListAllPeople.ContextMenuStrip = contextMenuStrip1;
            dgvListAllPeople.Location = new Point(20, 383);
            dgvListAllPeople.Margin = new Padding(2);
            dgvListAllPeople.Name = "dgvListAllPeople";
            dgvListAllPeople.ReadOnly = true;
            dgvListAllPeople.RowHeadersWidth = 62;
            dgvListAllPeople.ScrollBars = ScrollBars.Vertical;
            dgvListAllPeople.Size = new Size(1738, 307);
            dgvListAllPeople.TabIndex = 3;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.BackColor = SystemColors.ButtonHighlight;
            contextMenuStrip1.BackgroundImageLayout = ImageLayout.None;
            contextMenuStrip1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            contextMenuStrip1.ImageScalingSize = new Size(27, 27);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { ShowDetailesToolStripMenuItem, AddNewToolStripMenuItem, EditToolStripMenuItem, deleteToolStripMenuItem1, toolStripSeparator5, SendEmailoolStripMenuItem, phoneCallToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.RenderMode = ToolStripRenderMode.Professional;
            contextMenuStrip1.Size = new Size(236, 226);
            // 
            // ShowDetailesToolStripMenuItem
            // 
            ShowDetailesToolStripMenuItem.Image = (Image)resources.GetObject("ShowDetailesToolStripMenuItem.Image");
            ShowDetailesToolStripMenuItem.Name = "ShowDetailesToolStripMenuItem";
            ShowDetailesToolStripMenuItem.Size = new Size(235, 36);
            ShowDetailesToolStripMenuItem.Text = "Show Details";
            ShowDetailesToolStripMenuItem.Click += ShowDetailesToolStripMenuItem_Click;
            // 
            // AddNewToolStripMenuItem
            // 
            AddNewToolStripMenuItem.Image = (Image)resources.GetObject("AddNewToolStripMenuItem.Image");
            AddNewToolStripMenuItem.Name = "AddNewToolStripMenuItem";
            AddNewToolStripMenuItem.Size = new Size(235, 36);
            AddNewToolStripMenuItem.Text = "Add new Person";
            // 
            // EditToolStripMenuItem
            // 
            EditToolStripMenuItem.Image = (Image)resources.GetObject("EditToolStripMenuItem.Image");
            EditToolStripMenuItem.Name = "EditToolStripMenuItem";
            EditToolStripMenuItem.Size = new Size(235, 36);
            EditToolStripMenuItem.Text = "Edit Info";
            EditToolStripMenuItem.Click += EditToolStripMenuItem_Click;
            // 
            // deleteToolStripMenuItem1
            // 
            deleteToolStripMenuItem1.Image = (Image)resources.GetObject("deleteToolStripMenuItem1.Image");
            deleteToolStripMenuItem1.Name = "deleteToolStripMenuItem1";
            deleteToolStripMenuItem1.Size = new Size(235, 36);
            deleteToolStripMenuItem1.Text = "Delete";
            deleteToolStripMenuItem1.Click += deleteToolStripMenuItem1_Click;
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new Size(232, 6);
            // 
            // SendEmailoolStripMenuItem
            // 
            SendEmailoolStripMenuItem.Image = (Image)resources.GetObject("SendEmailoolStripMenuItem.Image");
            SendEmailoolStripMenuItem.Name = "SendEmailoolStripMenuItem";
            SendEmailoolStripMenuItem.Size = new Size(235, 36);
            SendEmailoolStripMenuItem.Text = "Send Email";
            // 
            // phoneCallToolStripMenuItem
            // 
            phoneCallToolStripMenuItem.Image = (Image)resources.GetObject("phoneCallToolStripMenuItem.Image");
            phoneCallToolStripMenuItem.Name = "phoneCallToolStripMenuItem";
            phoneCallToolStripMenuItem.Size = new Size(235, 36);
            phoneCallToolStripMenuItem.Text = "Phon Call";
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
            ctrlFindByFilter1.Location = new Point(20, 294);
            ctrlFindByFilter1.Name = "ctrlFindByFilter1";
            ctrlFindByFilter1.Size = new Size(683, 66);
            ctrlFindByFilter1.TabIndex = 46;
            ctrlFindByFilter1.Load += ctrlFindByFilter1_Load;
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
        private Button btnClose;
        private Label label2;
        private Label lnNumberOFPeople;
        private PictureBox btnAddNewPerson;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem ShowDetailesToolStripMenuItem;
        private ToolStripMenuItem EditToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem1;
        private ToolStripMenuItem SendEmailoolStripMenuItem;
        private ToolStripMenuItem phoneCallToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator5;
        private Controls.ctrlFindByFilter ctrlFindByFilter1;
        private ToolStripMenuItem AddNewToolStripMenuItem;
    }
}