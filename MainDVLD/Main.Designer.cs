namespace MainDVLD
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            menuStrip1 = new MenuStrip();
            MSApplications = new ToolStripMenuItem();
            drivingLicensesServicesToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            manageApplicationsToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            detainLicensesToolStripMenuItem = new ToolStripMenuItem();
            manageApplicationTypesToolStripMenuItem = new ToolStripMenuItem();
            manageTestTypesToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripMenuItem();
            MSAccountSettings = new ToolStripMenuItem();
            currentUserInfoToolStripMenuItem = new ToolStripMenuItem();
            changePasswordToolStripMenuItem = new ToolStripMenuItem();
            signOutToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { MSApplications, toolStripMenuItem1, toolStripMenuItem2, toolStripMenuItem3, MSAccountSettings });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1676, 72);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // MSApplications
            // 
            MSApplications.DropDownItems.AddRange(new ToolStripItem[] { drivingLicensesServicesToolStripMenuItem, toolStripSeparator1, manageApplicationsToolStripMenuItem, toolStripSeparator2, detainLicensesToolStripMenuItem, manageApplicationTypesToolStripMenuItem, manageTestTypesToolStripMenuItem });
            MSApplications.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MSApplications.Image = (Image)resources.GetObject("MSApplications.Image");
            MSApplications.ImageAlign = ContentAlignment.MiddleLeft;
            MSApplications.ImageScaling = ToolStripItemImageScaling.None;
            MSApplications.Name = "MSApplications";
            MSApplications.Size = new Size(244, 68);
            MSApplications.Text = "Applications ";
            MSApplications.TextAlign = ContentAlignment.MiddleRight;
            // 
            // drivingLicensesServicesToolStripMenuItem
            // 
            drivingLicensesServicesToolStripMenuItem.Image = (Image)resources.GetObject("drivingLicensesServicesToolStripMenuItem.Image");
            drivingLicensesServicesToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            drivingLicensesServicesToolStripMenuItem.Name = "drivingLicensesServicesToolStripMenuItem";
            drivingLicensesServicesToolStripMenuItem.Size = new Size(462, 74);
            drivingLicensesServicesToolStripMenuItem.Text = "Driving Licenses Services";
            drivingLicensesServicesToolStripMenuItem.Click += drivingLicensesServicesToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(459, 6);
            // 
            // manageApplicationsToolStripMenuItem
            // 
            manageApplicationsToolStripMenuItem.Image = (Image)resources.GetObject("manageApplicationsToolStripMenuItem.Image");
            manageApplicationsToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            manageApplicationsToolStripMenuItem.Name = "manageApplicationsToolStripMenuItem";
            manageApplicationsToolStripMenuItem.Size = new Size(462, 74);
            manageApplicationsToolStripMenuItem.Text = "ManageApplications";
            manageApplicationsToolStripMenuItem.Click += manageApplicationsToolStripMenuItem_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(459, 6);
            // 
            // detainLicensesToolStripMenuItem
            // 
            detainLicensesToolStripMenuItem.Image = (Image)resources.GetObject("detainLicensesToolStripMenuItem.Image");
            detainLicensesToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            detainLicensesToolStripMenuItem.Name = "detainLicensesToolStripMenuItem";
            detainLicensesToolStripMenuItem.Size = new Size(462, 74);
            detainLicensesToolStripMenuItem.Text = "Detain Licenses";
            detainLicensesToolStripMenuItem.Click += detainLicensesToolStripMenuItem_Click;
            // 
            // manageApplicationTypesToolStripMenuItem
            // 
            manageApplicationTypesToolStripMenuItem.Image = (Image)resources.GetObject("manageApplicationTypesToolStripMenuItem.Image");
            manageApplicationTypesToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            manageApplicationTypesToolStripMenuItem.Name = "manageApplicationTypesToolStripMenuItem";
            manageApplicationTypesToolStripMenuItem.Size = new Size(462, 74);
            manageApplicationTypesToolStripMenuItem.Text = "Manage Application Types";
            manageApplicationTypesToolStripMenuItem.Click += manageApplicationTypesToolStripMenuItem_Click;
            // 
            // manageTestTypesToolStripMenuItem
            // 
            manageTestTypesToolStripMenuItem.Image = (Image)resources.GetObject("manageTestTypesToolStripMenuItem.Image");
            manageTestTypesToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            manageTestTypesToolStripMenuItem.Name = "manageTestTypesToolStripMenuItem";
            manageTestTypesToolStripMenuItem.Size = new Size(462, 74);
            manageTestTypesToolStripMenuItem.Text = "Manage Test Types";
            manageTestTypesToolStripMenuItem.Click += manageTestTypesToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            toolStripMenuItem1.Image = (Image)resources.GetObject("toolStripMenuItem1.Image");
            toolStripMenuItem1.ImageAlign = ContentAlignment.MiddleLeft;
            toolStripMenuItem1.ImageScaling = ToolStripItemImageScaling.None;
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(171, 68);
            toolStripMenuItem1.Text = "People";
            toolStripMenuItem1.TextAlign = ContentAlignment.MiddleRight;
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            toolStripMenuItem2.Image = (Image)resources.GetObject("toolStripMenuItem2.Image");
            toolStripMenuItem2.ImageAlign = ContentAlignment.MiddleLeft;
            toolStripMenuItem2.ImageScaling = ToolStripItemImageScaling.None;
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(176, 68);
            toolStripMenuItem2.Text = "Drivers";
            toolStripMenuItem2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            toolStripMenuItem3.Image = (Image)resources.GetObject("toolStripMenuItem3.Image");
            toolStripMenuItem3.ImageAlign = ContentAlignment.MiddleLeft;
            toolStripMenuItem3.ImageScaling = ToolStripItemImageScaling.None;
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(156, 68);
            toolStripMenuItem3.Text = "Users";
            toolStripMenuItem3.TextAlign = ContentAlignment.MiddleRight;
            toolStripMenuItem3.Click += toolStripMenuItem3_Click;
            // 
            // MSAccountSettings
            // 
            MSAccountSettings.DropDownItems.AddRange(new ToolStripItem[] { currentUserInfoToolStripMenuItem, changePasswordToolStripMenuItem, signOutToolStripMenuItem });
            MSAccountSettings.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MSAccountSettings.Image = (Image)resources.GetObject("MSAccountSettings.Image");
            MSAccountSettings.ImageAlign = ContentAlignment.MiddleLeft;
            MSAccountSettings.ImageScaling = ToolStripItemImageScaling.None;
            MSAccountSettings.Name = "MSAccountSettings";
            MSAccountSettings.Size = new Size(288, 68);
            MSAccountSettings.Text = "Account Settings";
            MSAccountSettings.TextAlign = ContentAlignment.MiddleRight;
            // 
            // currentUserInfoToolStripMenuItem
            // 
            currentUserInfoToolStripMenuItem.Image = (Image)resources.GetObject("currentUserInfoToolStripMenuItem.Image");
            currentUserInfoToolStripMenuItem.Name = "currentUserInfoToolStripMenuItem";
            currentUserInfoToolStripMenuItem.Size = new Size(318, 40);
            currentUserInfoToolStripMenuItem.Text = "Current UserInfo";
            currentUserInfoToolStripMenuItem.Click += currentUserInfoToolStripMenuItem_Click;
            // 
            // changePasswordToolStripMenuItem
            // 
            changePasswordToolStripMenuItem.Image = (Image)resources.GetObject("changePasswordToolStripMenuItem.Image");
            changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            changePasswordToolStripMenuItem.Size = new Size(318, 40);
            changePasswordToolStripMenuItem.Text = "Change Password";
            changePasswordToolStripMenuItem.Click += changePasswordToolStripMenuItem_Click;
            // 
            // signOutToolStripMenuItem
            // 
            signOutToolStripMenuItem.Image = (Image)resources.GetObject("signOutToolStripMenuItem.Image");
            signOutToolStripMenuItem.Name = "signOutToolStripMenuItem";
            signOutToolStripMenuItem.Size = new Size(318, 40);
            signOutToolStripMenuItem.Text = "Sign Out";
            signOutToolStripMenuItem.Click += signOutToolStripMenuItem_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 72);
            panel1.Name = "panel1";
            panel1.Size = new Size(1676, 941);
            panel1.TabIndex = 1;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1676, 1013);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            Name = "frmMain";
            Text = "Main";
            WindowState = FormWindowState.Maximized;
            Load += frmMain_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem MSApplications;
        private ToolStripMenuItem MSAccountSettings;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem toolStripMenuItem3;
        private Panel panel1;
        private ToolStripMenuItem currentUserInfoToolStripMenuItem;
        private ToolStripMenuItem changePasswordToolStripMenuItem;
        private ToolStripMenuItem signOutToolStripMenuItem;
        private ToolStripMenuItem drivingLicensesServicesToolStripMenuItem;
        private ToolStripMenuItem manageApplicationsToolStripMenuItem;
        private ToolStripMenuItem detainLicensesToolStripMenuItem;
        private ToolStripMenuItem manageApplicationTypesToolStripMenuItem;
        private ToolStripMenuItem manageTestTypesToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripSeparator toolStripSeparator2;
    }
}
