namespace MainDVLD.Users
{
    partial class frmChangeUserPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChangeUserPassword));
            ctrlUserLoginInfo1 = new Controls.ctrlUserLoginInfo();
            ctrlPersonCard1 = new ctrlPersonCard();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            pictureBox3 = new PictureBox();
            label2 = new Label();
            tbCurrentPassword = new TextBox();
            tbNewPassword = new TextBox();
            tbConfirmPassword = new TextBox();
            errorProvider1 = new ErrorProvider(components);
            btnSave = new Button();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // ctrlUserLoginInfo1
            // 
            ctrlUserLoginInfo1.BorderStyle = BorderStyle.FixedSingle;
            ctrlUserLoginInfo1.Location = new Point(28, 476);
            ctrlUserLoginInfo1.Name = "ctrlUserLoginInfo1";
            ctrlUserLoginInfo1.Size = new Size(1064, 126);
            ctrlUserLoginInfo1.TabIndex = 4;
            // 
            // ctrlPersonCard1
            // 
            ctrlPersonCard1.BorderStyle = BorderStyle.FixedSingle;
            ctrlPersonCard1.Location = new Point(28, 49);
            ctrlPersonCard1.Name = "ctrlPersonCard1";
            ctrlPersonCard1.Size = new Size(1064, 422);
            ctrlPersonCard1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(245, 626);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(34, 30);
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label3.Location = new Point(30, 625);
            label3.Name = "label3";
            label3.Size = new Size(209, 30);
            label3.TabIndex = 13;
            label3.Text = "Current Password: ";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(245, 678);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(34, 30);
            pictureBox2.TabIndex = 16;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label1.Location = new Point(62, 678);
            label1.Name = "label1";
            label1.Size = new Size(177, 30);
            label1.TabIndex = 15;
            label1.Text = "New Password: ";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(245, 732);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(34, 30);
            pictureBox3.TabIndex = 18;
            pictureBox3.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label2.Location = new Point(26, 731);
            label2.Name = "label2";
            label2.Size = new Size(213, 30);
            label2.TabIndex = 17;
            label2.Text = "Confirm Password: ";
            // 
            // tbCurrentPassword
            // 
            tbCurrentPassword.Location = new Point(292, 626);
            tbCurrentPassword.Name = "tbCurrentPassword";
            tbCurrentPassword.PasswordChar = '*';
            tbCurrentPassword.Size = new Size(220, 31);
            tbCurrentPassword.TabIndex = 41;
            tbCurrentPassword.Validating += tbCurrentPassword_Validating;
            // 
            // tbNewPassword
            // 
            tbNewPassword.Location = new Point(292, 679);
            tbNewPassword.Name = "tbNewPassword";
            tbNewPassword.PasswordChar = '*';
            tbNewPassword.Size = new Size(220, 31);
            tbNewPassword.TabIndex = 42;
            tbNewPassword.Validating += tbNewPassword_Validating;
            // 
            // tbConfirmPassword
            // 
            tbConfirmPassword.Location = new Point(292, 732);
            tbConfirmPassword.Name = "tbConfirmPassword";
            tbConfirmPassword.PasswordChar = '*';
            tbConfirmPassword.Size = new Size(220, 31);
            tbConfirmPassword.TabIndex = 43;
            tbConfirmPassword.Validating += tbConfirmPassword_Validating;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSave.Image = (Image)resources.GetObject("btnSave.Image");
            btnSave.ImageAlign = ContentAlignment.MiddleLeft;
            btnSave.Location = new Point(950, 774);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(148, 44);
            btnSave.TabIndex = 45;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.ImageAlign = ContentAlignment.MiddleLeft;
            btnClose.Location = new Point(777, 774);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(148, 44);
            btnClose.TabIndex = 44;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            // 
            // frmChangeUserPassword
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1117, 828);
            Controls.Add(btnSave);
            Controls.Add(btnClose);
            Controls.Add(tbConfirmPassword);
            Controls.Add(tbNewPassword);
            Controls.Add(tbCurrentPassword);
            Controls.Add(pictureBox3);
            Controls.Add(label2);
            Controls.Add(pictureBox2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(ctrlUserLoginInfo1);
            Controls.Add(ctrlPersonCard1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "frmChangeUserPassword";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Change Password";
            Load += frmChangeUserPassword_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Controls.ctrlUserLoginInfo ctrlUserLoginInfo1;
        private ctrlPersonCard ctrlPersonCard1;
        private PictureBox pictureBox1;
        private Label label3;
        private PictureBox pictureBox2;
        private Label label1;
        private PictureBox pictureBox3;
        private Label label2;
        private TextBox tbCurrentPassword;
        private TextBox tbNewPassword;
        private TextBox tbConfirmPassword;
        private ErrorProvider errorProvider1;
        private Button btnSave;
        private Button btnClose;
    }
}