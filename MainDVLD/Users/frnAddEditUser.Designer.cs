namespace MainDVLD.Users
{
    partial class frmAddEditUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddEditUser));
            tabControl1 = new TabControl();
            tpPersonPage = new TabPage();
            ctrlPersonCardWithFilter1 = new Controls.ctrlPersonCardWithFilter();
            btnNext = new Button();
            tpUserPage = new TabPage();
            cbIsActive = new CheckBox();
            pictureBox4 = new PictureBox();
            tbConfirmPassword = new TextBox();
            tbpassword = new TextBox();
            tbUserName = new TextBox();
            pictureBox3 = new PictureBox();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            lbUserId = new Label();
            label1 = new Label();
            lbAddEdituseritel = new Label();
            btnSave = new Button();
            btnClose = new Button();
            errorProvider1 = new ErrorProvider(components);
            tabControl1.SuspendLayout();
            tpPersonPage.SuspendLayout();
            tpUserPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Appearance = TabAppearance.Buttons;
            tabControl1.Controls.Add(tpPersonPage);
            tabControl1.Controls.Add(tpUserPage);
            tabControl1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabControl1.Location = new Point(29, 138);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1109, 680);
            tabControl1.TabIndex = 0;
            // 
            // tpPersonPage
            // 
            tpPersonPage.BorderStyle = BorderStyle.FixedSingle;
            tpPersonPage.Controls.Add(ctrlPersonCardWithFilter1);
            tpPersonPage.Controls.Add(btnNext);
            tpPersonPage.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tpPersonPage.Location = new Point(4, 40);
            tpPersonPage.Name = "tpPersonPage";
            tpPersonPage.Padding = new Padding(3);
            tpPersonPage.Size = new Size(1101, 636);
            tpPersonPage.TabIndex = 0;
            tpPersonPage.Text = "Person Info";
            tpPersonPage.UseVisualStyleBackColor = true;
            // 
            // ctrlPersonCardWithFilter1
            // 
            ctrlPersonCardWithFilter1.Location = new Point(24, 36);
            ctrlPersonCardWithFilter1.Name = "ctrlPersonCardWithFilter1";
            ctrlPersonCardWithFilter1.Size = new Size(1068, 545);
            ctrlPersonCardWithFilter1.TabIndex = 46;
          
            // 
            // btnNext
            // 
            btnNext.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNext.Image = (Image)resources.GetObject("btnNext.Image");
            btnNext.ImageAlign = ContentAlignment.MiddleRight;
            btnNext.Location = new Point(944, 587);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(148, 44);
            btnNext.TabIndex = 45;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // tpUserPage
            // 
            tpUserPage.BorderStyle = BorderStyle.Fixed3D;
            tpUserPage.Controls.Add(cbIsActive);
            tpUserPage.Controls.Add(pictureBox4);
            tpUserPage.Controls.Add(tbConfirmPassword);
            tpUserPage.Controls.Add(tbpassword);
            tpUserPage.Controls.Add(tbUserName);
            tpUserPage.Controls.Add(pictureBox3);
            tpUserPage.Controls.Add(label2);
            tpUserPage.Controls.Add(pictureBox2);
            tpUserPage.Controls.Add(label3);
            tpUserPage.Controls.Add(pictureBox1);
            tpUserPage.Controls.Add(label4);
            tpUserPage.Controls.Add(lbUserId);
            tpUserPage.Controls.Add(label1);
            tpUserPage.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tpUserPage.Location = new Point(4, 40);
            tpUserPage.Name = "tpUserPage";
            tpUserPage.Padding = new Padding(3);
            tpUserPage.Size = new Size(1101, 636);
            tpUserPage.TabIndex = 1;
            tpUserPage.Text = "User Info";
            tpUserPage.UseVisualStyleBackColor = true;
            // 
            // cbIsActive
            // 
            cbIsActive.AutoSize = true;
            cbIsActive.Location = new Point(299, 315);
            cbIsActive.Name = "cbIsActive";
            cbIsActive.Size = new Size(119, 32);
            cbIsActive.TabIndex = 54;
            cbIsActive.Text = "Is Active";
            cbIsActive.UseVisualStyleBackColor = true;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(252, 88);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(34, 30);
            pictureBox4.TabIndex = 53;
            pictureBox4.TabStop = false;
            // 
            // tbConfirmPassword
            // 
            tbConfirmPassword.Location = new Point(299, 257);
            tbConfirmPassword.Name = "tbConfirmPassword";
            tbConfirmPassword.PasswordChar = '*';
            tbConfirmPassword.Size = new Size(220, 34);
            tbConfirmPassword.TabIndex = 52;
            tbConfirmPassword.TextChanged += tbConfirmPassword_TextChanged;
            tbConfirmPassword.Validating += tbConfirmPassword_Validating;
            // 
            // tbpassword
            // 
            tbpassword.Location = new Point(299, 204);
            tbpassword.Name = "tbpassword";
            tbpassword.PasswordChar = '*';
            tbpassword.Size = new Size(220, 34);
            tbpassword.TabIndex = 51;
            tbpassword.TextChanged += tbpassword_TextChanged;
            // 
            // tbUserName
            // 
            tbUserName.Location = new Point(299, 151);
            tbUserName.Name = "tbUserName";
            tbUserName.Size = new Size(220, 34);
            tbUserName.TabIndex = 50;
           
            tbUserName.Validating += tbUserName_Validating;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(252, 257);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(34, 30);
            pictureBox3.TabIndex = 49;
            pictureBox3.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label2.Location = new Point(33, 256);
            label2.Name = "label2";
            label2.Size = new Size(213, 30);
            label2.TabIndex = 48;
            label2.Text = "Confirm Password: ";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(252, 203);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(34, 30);
            pictureBox2.TabIndex = 47;
            pictureBox2.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label3.Location = new Point(122, 203);
            label3.Name = "label3";
            label3.Size = new Size(124, 30);
            label3.TabIndex = 46;
            label3.Text = "Password: ";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(252, 151);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(34, 30);
            pictureBox1.TabIndex = 45;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label4.Location = new Point(107, 150);
            label4.Name = "label4";
            label4.Size = new Size(139, 30);
            label4.TabIndex = 44;
            label4.Text = "User Name :";
            // 
            // lbUserId
            // 
            lbUserId.AutoSize = true;
            lbUserId.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbUserId.Location = new Point(308, 90);
            lbUserId.Name = "lbUserId";
            lbUserId.Size = new Size(21, 28);
            lbUserId.TabIndex = 1;
            lbUserId.Text = "?";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(160, 88);
            label1.Name = "label1";
            label1.Size = new Size(86, 28);
            label1.TabIndex = 0;
            label1.Text = "UserID :";
            // 
            // lbAddEdituseritel
            // 
            lbAddEdituseritel.AutoSize = true;
            lbAddEdituseritel.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbAddEdituseritel.ForeColor = Color.OrangeRed;
            lbAddEdituseritel.Location = new Point(453, 28);
            lbAddEdituseritel.Name = "lbAddEdituseritel";
            lbAddEdituseritel.RightToLeft = RightToLeft.Yes;
            lbAddEdituseritel.Size = new Size(294, 54);
            lbAddEdituseritel.TabIndex = 2;
            lbAddEdituseritel.Text = "Add New User";
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSave.Image = (Image)resources.GetObject("btnSave.Image");
            btnSave.ImageAlign = ContentAlignment.MiddleLeft;
            btnSave.Location = new Point(990, 824);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(148, 44);
            btnSave.TabIndex = 44;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.ImageAlign = ContentAlignment.MiddleLeft;
            btnClose.Location = new Point(836, 824);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(148, 44);
            btnClose.TabIndex = 43;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmAddEditUser
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1163, 887);
            Controls.Add(btnSave);
            Controls.Add(btnClose);
            Controls.Add(lbAddEdituseritel);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "frmAddEditUser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add/Edit User";
            Load += frmAddEditUser_Load;
            tabControl1.ResumeLayout(false);
            tpPersonPage.ResumeLayout(false);
            tpUserPage.ResumeLayout(false);
            tpUserPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tpPersonPage;
        private TabPage tpUserPage;
        private Label lbAddEdituseritel;
        private Button btnNext;
        private Button btnSave;
        private Button btnClose;
        private Label lbUserId;
        private Label label1;
        private CheckBox cbIsActive;
        private PictureBox pictureBox4;
        private TextBox tbConfirmPassword;
        private TextBox tbpassword;
        private TextBox tbUserName;
        private PictureBox pictureBox3;
        private Label label2;
        private PictureBox pictureBox2;
        private Label label3;
        private PictureBox pictureBox1;
        private Label label4;
        private Controls.ctrlPersonCardWithFilter ctrlPersonCardWithFilter1;
        private ErrorProvider errorProvider1;
    }
}