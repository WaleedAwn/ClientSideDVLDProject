namespace MainDVLD
{
    partial class frmLoginScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLoginScreen));
            pLeftPanal = new Panel();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            label3 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pRightPanal = new Panel();
            btnCloseButton = new Label();
            cbRemmemberMe = new CheckBox();
            label7 = new Label();
            LbForgetPassword = new LinkLabel();
            btnLogin = new Button();
            PasswordPanal = new Panel();
            pictureBox3 = new PictureBox();
            tbPassword = new TextBox();
            UserNamePanal = new Panel();
            pictureBox2 = new PictureBox();
            tbUserName = new TextBox();
            label6 = new Label();
            errorProvUserLogin = new ErrorProvider(components);
            pLeftPanal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pRightPanal.SuspendLayout();
            PasswordPanal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            UserNamePanal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvUserLogin).BeginInit();
            SuspendLayout();
            // 
            // pLeftPanal
            // 
            pLeftPanal.BackColor = Color.FromArgb(41, 128, 185);
            pLeftPanal.Controls.Add(label5);
            pLeftPanal.Controls.Add(label4);
            pLeftPanal.Controls.Add(label2);
            pLeftPanal.Controls.Add(label3);
            pLeftPanal.Controls.Add(label1);
            pLeftPanal.Controls.Add(pictureBox1);
            pLeftPanal.Dock = DockStyle.Left;
            pLeftPanal.Location = new Point(0, 0);
            pLeftPanal.Name = "pLeftPanal";
            pLeftPanal.Size = new Size(450, 841);
            pLeftPanal.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(12, 767);
            label5.Name = "label5";
            label5.Size = new Size(140, 30);
            label5.TabIndex = 6;
            label5.Text = "Version 1.0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 14F);
            label4.ForeColor = Color.White;
            label4.Location = new Point(78, 651);
            label4.Name = "label4";
            label4.Size = new Size(247, 34);
            label4.TabIndex = 5;
            label4.Text = "Waleed Alhakimi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 14F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(97, 617);
            label2.Name = "label2";
            label2.Size = new Size(197, 34);
            label2.TabIndex = 4;
            label2.Text = "Devloped By:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 15.75F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(97, 376);
            label3.Name = "label3";
            label3.Size = new Size(218, 39);
            label3.TabIndex = 3;
            label3.Text = "DVLD System";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 15.75F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(80, 313);
            label1.Name = "label1";
            label1.Size = new Size(267, 39);
            label1.TabIndex = 1;
            label1.Text = "Welcome to the";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(141, 67);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(173, 131);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pRightPanal
            // 
            pRightPanal.Controls.Add(btnCloseButton);
            pRightPanal.Controls.Add(cbRemmemberMe);
            pRightPanal.Controls.Add(label7);
            pRightPanal.Controls.Add(LbForgetPassword);
            pRightPanal.Controls.Add(btnLogin);
            pRightPanal.Controls.Add(PasswordPanal);
            pRightPanal.Controls.Add(UserNamePanal);
            pRightPanal.Controls.Add(label6);
            pRightPanal.Dock = DockStyle.Right;
            pRightPanal.Font = new Font("Verdana", 15.75F, FontStyle.Bold);
            pRightPanal.ForeColor = Color.FromArgb(41, 128, 185);
            pRightPanal.Location = new Point(447, 0);
            pRightPanal.Name = "pRightPanal";
            pRightPanal.Size = new Size(675, 841);
            pRightPanal.TabIndex = 1;
            // 
            // btnCloseButton
            // 
            btnCloseButton.AutoSize = true;
            btnCloseButton.BackColor = SystemColors.Control;
            btnCloseButton.Cursor = Cursors.Hand;
            btnCloseButton.FlatStyle = FlatStyle.Popup;
            btnCloseButton.Location = new Point(630, 7);
            btnCloseButton.Name = "btnCloseButton";
            btnCloseButton.Size = new Size(41, 38);
            btnCloseButton.TabIndex = 15;
            btnCloseButton.Text = "X";
            btnCloseButton.TextAlign = ContentAlignment.MiddleCenter;
            btnCloseButton.Click += btnCloseButton_Click;
            // 
            // cbRemmemberMe
            // 
            cbRemmemberMe.AutoSize = true;
            cbRemmemberMe.Font = new Font("Verdana", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbRemmemberMe.Location = new Point(82, 454);
            cbRemmemberMe.Name = "cbRemmemberMe";
            cbRemmemberMe.Size = new Size(224, 30);
            cbRemmemberMe.TabIndex = 14;
            cbRemmemberMe.Tag = "0";
            cbRemmemberMe.Text = "Remember Me.";
            cbRemmemberMe.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(41, 128, 185);
            label7.Location = new Point(22, 458);
            label7.Name = "label7";
            label7.Size = new Size(0, 26);
            label7.TabIndex = 13;
            // 
            // LbForgetPassword
            // 
            LbForgetPassword.AutoSize = true;
            LbForgetPassword.Font = new Font("Century Gothic", 8F);
            LbForgetPassword.LinkColor = Color.FromArgb(41, 128, 185);
            LbForgetPassword.Location = new Point(422, 546);
            LbForgetPassword.Name = "LbForgetPassword";
            LbForgetPassword.Size = new Size(150, 21);
            LbForgetPassword.TabIndex = 12;
            LbForgetPassword.TabStop = true;
            LbForgetPassword.Text = "Forget Password ?";
            LbForgetPassword.LinkClicked += LbForgetPassword_LinkClicked;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(41, 128, 185);
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Century Gothic", 10F);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(182, 519);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(222, 54);
            btnLogin.TabIndex = 11;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // PasswordPanal
            // 
            PasswordPanal.Controls.Add(pictureBox3);
            PasswordPanal.Controls.Add(tbPassword);
            PasswordPanal.Font = new Font("Microsoft Sans Serif", 8F);
            PasswordPanal.Location = new Point(0, 364);
            PasswordPanal.Margin = new Padding(4, 5, 4, 5);
            PasswordPanal.Name = "PasswordPanal";
            PasswordPanal.Size = new Size(675, 69);
            PasswordPanal.TabIndex = 10;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.hide_Password;
            pictureBox3.Location = new Point(22, 13);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(54, 43);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 9;
            pictureBox3.TabStop = false;
            pictureBox3.MouseDown += pictureBox3_MouseDown;
            pictureBox3.MouseUp += pictureBox3_MouseUp;
            // 
            // tbPassword
            // 
            tbPassword.BackColor = SystemColors.Control;
            tbPassword.Font = new Font("Century Gothic", 12F);
            tbPassword.ForeColor = Color.FromArgb(41, 128, 185);
            tbPassword.Location = new Point(82, 17);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(555, 37);
            tbPassword.TabIndex = 8;
            tbPassword.UseSystemPasswordChar = true;
            tbPassword.Click += tbPassword_Click;
            tbPassword.Validating += tbPassword_Validating;
            // 
            // UserNamePanal
            // 
            UserNamePanal.BackColor = Color.White;
            UserNamePanal.Controls.Add(pictureBox2);
            UserNamePanal.Controls.Add(tbUserName);
            UserNamePanal.Font = new Font("Microsoft Sans Serif", 8F);
            UserNamePanal.Location = new Point(0, 285);
            UserNamePanal.Margin = new Padding(4, 5, 4, 5);
            UserNamePanal.Name = "UserNamePanal";
            UserNamePanal.Size = new Size(675, 69);
            UserNamePanal.TabIndex = 9;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.Control;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(22, 13);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(54, 43);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // tbUserName
            // 
            tbUserName.BackColor = Color.White;
            tbUserName.Font = new Font("Century Gothic", 12F);
            tbUserName.ForeColor = Color.FromArgb(41, 128, 185);
            tbUserName.Location = new Point(82, 17);
            tbUserName.Name = "tbUserName";
            tbUserName.Size = new Size(555, 37);
            tbUserName.TabIndex = 8;
            tbUserName.Click += tbUserName_Click;
            tbUserName.Validating += tbUserName_Validating;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(41, 128, 185);
            label6.Location = new Point(43, 159);
            label6.Name = "label6";
            label6.Size = new Size(343, 38);
            label6.TabIndex = 7;
            label6.Text = "Login to DVLD system";
            // 
            // errorProvUserLogin
            // 
            errorProvUserLogin.ContainerControl = this;
            // 
            // frmLoginScreen
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1122, 841);
            Controls.Add(pRightPanal);
            Controls.Add(pLeftPanal);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmLoginScreen";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmLoginScreen";
            Load += frmLoginScreen_Load;
            KeyDown += frmLoginScreen_KeyDown;
            pLeftPanal.ResumeLayout(false);
            pLeftPanal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pRightPanal.ResumeLayout(false);
            pRightPanal.PerformLayout();
            PasswordPanal.ResumeLayout(false);
            PasswordPanal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            UserNamePanal.ResumeLayout(false);
            UserNamePanal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvUserLogin).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pLeftPanal;
        private Panel pRightPanal;
        private Label label3;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label5;
        private Label label4;
        private Label label2;
        private Label label6;
        private Panel UserNamePanal;
        private PictureBox pictureBox2;
        private TextBox tbUserName;
        private Panel PasswordPanal;
        private PictureBox pictureBox3;
        private TextBox tbPassword;
        private LinkLabel LbForgetPassword;
        private Button btnLogin;
        private CheckBox cbRemmemberMe;
        private Label label7;
        private Label btnCloseButton;
        private ErrorProvider errorProvUserLogin;
    }
}