namespace MainDVLD.ApplicationTypes
{
    partial class frmEditApplicationTypes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditApplicationTypes));
            lbAddEditPersonTitel = new Label();
            label1 = new Label();
            lbApplicationTypeD = new Label();
            tbTitel = new TextBox();
            pictureBox1 = new PictureBox();
            tbFees = new TextBox();
            pbName = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            btnSave = new Button();
            btnClose = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbName).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // lbAddEditPersonTitel
            // 
            lbAddEditPersonTitel.AutoSize = true;
            lbAddEditPersonTitel.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbAddEditPersonTitel.ForeColor = Color.Maroon;
            lbAddEditPersonTitel.Location = new Point(40, 25);
            lbAddEditPersonTitel.Name = "lbAddEditPersonTitel";
            lbAddEditPersonTitel.RightToLeft = RightToLeft.Yes;
            lbAddEditPersonTitel.Size = new Size(508, 54);
            lbAddEditPersonTitel.TabIndex = 2;
            lbAddEditPersonTitel.Text = "Update Application Types";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label1.Location = new Point(40, 112);
            label1.Name = "label1";
            label1.Size = new Size(54, 30);
            label1.TabIndex = 37;
            label1.Text = "ID : ";
            // 
            // lbApplicationTypeD
            // 
            lbApplicationTypeD.AutoSize = true;
            lbApplicationTypeD.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lbApplicationTypeD.Location = new Point(154, 112);
            lbApplicationTypeD.Name = "lbApplicationTypeD";
            lbApplicationTypeD.Size = new Size(39, 28);
            lbApplicationTypeD.TabIndex = 38;
            lbApplicationTypeD.Text = "???";
            // 
            // tbTitel
            // 
            tbTitel.Location = new Point(154, 163);
            tbTitel.Name = "tbTitel";
            tbTitel.Size = new Size(394, 31);
            tbTitel.TabIndex = 73;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(110, 223);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(34, 34);
            pictureBox1.TabIndex = 71;
            pictureBox1.TabStop = false;
            // 
            // tbFees
            // 
            tbFees.Location = new Point(154, 223);
            tbFees.Name = "tbFees";
            tbFees.Size = new Size(394, 31);
            tbFees.TabIndex = 72;
            tbFees.KeyPress += tbFees_KeyPress;
            // 
            // pbName
            // 
            pbName.Image = (Image)resources.GetObject("pbName.Image");
            pbName.Location = new Point(110, 160);
            pbName.Name = "pbName";
            pbName.Size = new Size(34, 34);
            pbName.TabIndex = 70;
            pbName.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label2.Location = new Point(27, 160);
            label2.Name = "label2";
            label2.Size = new Size(77, 30);
            label2.TabIndex = 74;
            label2.Text = "Title : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label3.Location = new Point(27, 223);
            label3.Name = "label3";
            label3.Size = new Size(76, 30);
            label3.TabIndex = 75;
            label3.Text = "Fees : ";
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSave.Image = (Image)resources.GetObject("btnSave.Image");
            btnSave.ImageAlign = ContentAlignment.MiddleLeft;
            btnSave.Location = new Point(400, 277);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(148, 44);
            btnSave.TabIndex = 77;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.ImageAlign = ContentAlignment.MiddleLeft;
            btnClose.Location = new Point(194, 277);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(148, 44);
            btnClose.TabIndex = 76;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmEditApplicationTypes
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(586, 330);
            Controls.Add(btnSave);
            Controls.Add(btnClose);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(tbTitel);
            Controls.Add(pictureBox1);
            Controls.Add(tbFees);
            Controls.Add(pbName);
            Controls.Add(label1);
            Controls.Add(lbApplicationTypeD);
            Controls.Add(lbAddEditPersonTitel);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "frmEditApplicationTypes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Update Application Types";
            Load += frmEditApplicationTypes_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbName).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbAddEditPersonTitel;
        private Label label1;
        private Label lbApplicationTypeD;
        private TextBox tbTitel;
        private PictureBox pictureBox1;
        private TextBox tbFees;
        private PictureBox pbName;
        private Label label2;
        private Label label3;
        private Button btnSave;
        private Button btnClose;
        private ErrorProvider errorProvider1;
    }
}