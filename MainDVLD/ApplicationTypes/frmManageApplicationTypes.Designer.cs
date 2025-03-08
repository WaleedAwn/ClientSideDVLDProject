namespace MainDVLD.ApplicationTypes
{
    partial class frmManageApplicationTypes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageApplicationTypes));
            dgvListAllApplicationTypes = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colTitel = new DataGridViewTextBoxColumn();
            colFees = new DataGridViewTextBoxColumn();
            contextMenuStrip1 = new ContextMenuStrip(components);
            EditToolStripMenuItem = new ToolStripMenuItem();
            lbNumberOFApplicationTypes = new Label();
            label2 = new Label();
            btnClose = new Button();
            pictureBox1 = new PictureBox();
            lbAddEditUser = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvListAllApplicationTypes).BeginInit();
            contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dgvListAllApplicationTypes
            // 
            dgvListAllApplicationTypes.AllowUserToAddRows = false;
            dgvListAllApplicationTypes.AllowUserToDeleteRows = false;
            dgvListAllApplicationTypes.AllowUserToOrderColumns = true;
            dgvListAllApplicationTypes.BackgroundColor = Color.White;
            dgvListAllApplicationTypes.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            dgvListAllApplicationTypes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListAllApplicationTypes.Columns.AddRange(new DataGridViewColumn[] { colId, colTitel, colFees });
            dgvListAllApplicationTypes.ContextMenuStrip = contextMenuStrip1;
            dgvListAllApplicationTypes.Location = new Point(47, 340);
            dgvListAllApplicationTypes.Margin = new Padding(2);
            dgvListAllApplicationTypes.Name = "dgvListAllApplicationTypes";
            dgvListAllApplicationTypes.ReadOnly = true;
            dgvListAllApplicationTypes.RowHeadersWidth = 62;
            dgvListAllApplicationTypes.ScrollBars = ScrollBars.Vertical;
            dgvListAllApplicationTypes.Size = new Size(920, 454);
            dgvListAllApplicationTypes.TabIndex = 47;
            // 
            // colId
            // 
            colId.HeaderText = "ID";
            colId.MinimumWidth = 8;
            colId.Name = "colId";
            colId.ReadOnly = true;
            colId.Width = 150;
            // 
            // colTitel
            // 
            colTitel.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colTitel.HeaderText = "Titel";
            colTitel.MinimumWidth = 8;
            colTitel.Name = "colTitel";
            colTitel.ReadOnly = true;
            // 
            // colFees
            // 
            colFees.HeaderText = "Fees";
            colFees.MinimumWidth = 8;
            colFees.Name = "colFees";
            colFees.ReadOnly = true;
            colFees.Width = 150;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.BackColor = SystemColors.ButtonHighlight;
            contextMenuStrip1.BackgroundImageLayout = ImageLayout.None;
            contextMenuStrip1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            contextMenuStrip1.ImageScalingSize = new Size(27, 27);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { EditToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.RenderMode = ToolStripRenderMode.Professional;
            contextMenuStrip1.Size = new Size(290, 40);
            // 
            // EditToolStripMenuItem
            // 
            EditToolStripMenuItem.Image = (Image)resources.GetObject("EditToolStripMenuItem.Image");
            EditToolStripMenuItem.Name = "EditToolStripMenuItem";
            EditToolStripMenuItem.Size = new Size(289, 36);
            EditToolStripMenuItem.Text = "Edit Application Types";
            EditToolStripMenuItem.Click += EditToolStripMenuItem_Click;
            // 
            // lbNumberOFApplicationTypes
            // 
            lbNumberOFApplicationTypes.AutoSize = true;
            lbNumberOFApplicationTypes.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold);
            lbNumberOFApplicationTypes.Location = new Point(163, 828);
            lbNumberOFApplicationTypes.Margin = new Padding(2, 0, 2, 0);
            lbNumberOFApplicationTypes.Name = "lbNumberOFApplicationTypes";
            lbNumberOFApplicationTypes.Size = new Size(19, 20);
            lbNumberOFApplicationTypes.TabIndex = 50;
            lbNumberOFApplicationTypes.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(47, 825);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(116, 25);
            label2.TabIndex = 49;
            label2.Text = "# Records:";
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.ImageAlign = ContentAlignment.MiddleLeft;
            btnClose.Location = new Point(819, 814);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(148, 44);
            btnClose.TabIndex = 51;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = null;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(399, 48);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(244, 190);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 53;
            pictureBox1.TabStop = false;
            // 
            // lbAddEditUser
            // 
            lbAddEditUser.AutoSize = true;
            lbAddEditUser.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbAddEditUser.ForeColor = Color.Brown;
            lbAddEditUser.Location = new Point(248, 241);
            lbAddEditUser.Name = "lbAddEditUser";
            lbAddEditUser.Size = new Size(522, 54);
            lbAddEditUser.TabIndex = 52;
            lbAddEditUser.Text = "Manage Application Types";
            // 
            // frmManageApplicationTypes
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(989, 875);
            Controls.Add(pictureBox1);
            Controls.Add(lbAddEditUser);
            Controls.Add(btnClose);
            Controls.Add(lbNumberOFApplicationTypes);
            Controls.Add(label2);
            Controls.Add(dgvListAllApplicationTypes);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "frmManageApplicationTypes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Manage Application Types";
            Load += frmManageApplicationTypes_Load;
            ((System.ComponentModel.ISupportInitialize)dgvListAllApplicationTypes).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvListAllApplicationTypes;
        private Label lbNumberOFApplicationTypes;
        private Label label2;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colTitel;
        private DataGridViewTextBoxColumn colFees;
        private Button btnClose;
        private PictureBox pictureBox1;
        private Label lbAddEditUser;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem EditToolStripMenuItem;
    }
}