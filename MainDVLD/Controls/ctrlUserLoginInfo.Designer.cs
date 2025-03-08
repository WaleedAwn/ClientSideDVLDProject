namespace MainDVLD.Controls
{
    partial class ctrlUserLoginInfo
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            lbIsActive = new Label();
            lbUserName = new Label();
            lbUserID = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lbIsActive);
            groupBox1.Controls.Add(lbUserName);
            groupBox1.Controls.Add(lbUserID);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1093, 129);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "login Information";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // lbIsActive
            // 
            lbIsActive.AutoSize = true;
            lbIsActive.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbIsActive.Location = new Point(887, 60);
            lbIsActive.Name = "lbIsActive";
            lbIsActive.Size = new Size(43, 30);
            lbIsActive.TabIndex = 5;
            lbIsActive.Text = "???";
            // 
            // lbUserName
            // 
            lbUserName.AutoSize = true;
            lbUserName.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbUserName.Location = new Point(612, 60);
            lbUserName.Name = "lbUserName";
            lbUserName.Size = new Size(43, 30);
            lbUserName.TabIndex = 4;
            lbUserName.Text = "???";
            // 
            // lbUserID
            // 
            lbUserID.AutoSize = true;
            lbUserID.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbUserID.Location = new Point(269, 60);
            lbUserID.Name = "lbUserID";
            lbUserID.Size = new Size(43, 30);
            lbUserID.TabIndex = 3;
            lbUserID.Text = "???";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label3.Location = new Point(757, 60);
            label3.Name = "label3";
            label3.Size = new Size(109, 30);
            label3.TabIndex = 2;
            label3.Text = "IS Active:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label2.Location = new Point(451, 60);
            label2.Name = "label2";
            label2.Size = new Size(133, 30);
            label2.TabIndex = 1;
            label2.Text = "User Name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label1.Location = new Point(155, 60);
            label1.Name = "label1";
            label1.Size = new Size(95, 30);
            label1.TabIndex = 0;
            label1.Text = "User ID:";
            // 
            // ctrlUserLoginInfo
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox1);
            Name = "ctrlUserLoginInfo";
            Size = new Size(1102, 140);
            Load += ctrlUserLoginInfo_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label lbIsActive;
        private Label lbUserName;
        private Label lbUserID;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}
