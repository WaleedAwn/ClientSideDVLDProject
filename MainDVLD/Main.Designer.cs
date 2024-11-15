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
            toolStripMenuItem1 = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripMenuItem();
            MSAccountSettings = new ToolStripMenuItem();
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
            menuStrip1.Size = new Size(1644, 72);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // MSApplications
            // 
            MSApplications.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MSApplications.Image = (Image)resources.GetObject("MSApplications.Image");
            MSApplications.ImageAlign = ContentAlignment.MiddleLeft;
            MSApplications.ImageScaling = ToolStripItemImageScaling.None;
            MSApplications.Name = "MSApplications";
            MSApplications.Size = new Size(244, 68);
            MSApplications.Text = "Applications ";
            MSApplications.TextAlign = ContentAlignment.MiddleRight;
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
            // 
            // MSAccountSettings
            // 
            MSAccountSettings.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MSAccountSettings.Image = (Image)resources.GetObject("MSAccountSettings.Image");
            MSAccountSettings.ImageAlign = ContentAlignment.MiddleLeft;
            MSAccountSettings.ImageScaling = ToolStripItemImageScaling.None;
            MSAccountSettings.Name = "MSAccountSettings";
            MSAccountSettings.Size = new Size(288, 68);
            MSAccountSettings.Text = "Account Settings";
            MSAccountSettings.TextAlign = ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 72);
            panel1.Name = "panel1";
            panel1.Size = new Size(1644, 838);
            panel1.TabIndex = 1;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1644, 910);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            Name = "frmMain";
            Text = "Main";
            WindowState = FormWindowState.Maximized;
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
    }
}
