namespace MainDVLD.Users
{
    partial class frmShowUserDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmShowUserDetails));
            ctrlPersonCard1 = new ctrlPersonCard();
            lbPersonDetails = new Label();
            ctrlUserLoginInfo1 = new Controls.ctrlUserLoginInfo();
            btnClose = new Button();
            SuspendLayout();
            // 
            // ctrlPersonCard1
            // 
            ctrlPersonCard1.Location = new Point(79, 151);
            ctrlPersonCard1.Name = "ctrlPersonCard1";
            ctrlPersonCard1.Size = new Size(1064, 422);
            ctrlPersonCard1.TabIndex = 0;
            // 
            // lbPersonDetails
            // 
            lbPersonDetails.AutoSize = true;
            lbPersonDetails.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbPersonDetails.ForeColor = Color.Red;
            lbPersonDetails.Location = new Point(447, 28);
            lbPersonDetails.Name = "lbPersonDetails";
            lbPersonDetails.Size = new Size(249, 54);
            lbPersonDetails.TabIndex = 1;
            lbPersonDetails.Text = "User Details";
            // 
            // ctrlUserLoginInfo1
            // 
            ctrlUserLoginInfo1.BorderStyle = BorderStyle.FixedSingle;
            ctrlUserLoginInfo1.Location = new Point(79, 624);
            ctrlUserLoginInfo1.Name = "ctrlUserLoginInfo1";
            ctrlUserLoginInfo1.Size = new Size(1064, 126);
            ctrlUserLoginInfo1.TabIndex = 2;
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.ImageAlign = ContentAlignment.MiddleLeft;
            btnClose.Location = new Point(995, 774);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(148, 44);
            btnClose.TabIndex = 42;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // frmShowUserDetails
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1156, 825);
            Controls.Add(btnClose);
            Controls.Add(ctrlUserLoginInfo1);
            Controls.Add(lbPersonDetails);
            Controls.Add(ctrlPersonCard1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "frmShowUserDetails";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "User Details";
            Load += frmShowUserDetails_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ctrlPersonCard ctrlPersonCard1;
        private Label lbPersonDetails;
        private Controls.ctrlUserLoginInfo ctrlUserLoginInfo1;
        private Button btnClose;
    }
}