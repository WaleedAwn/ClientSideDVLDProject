namespace MainDVLD.People
{
    partial class frmShowPersonDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmShowPersonDetails));
            lbPersonDetails = new Label();
            ctrlPersonCard1 = new ctrlPersonCard();
            btnClose = new Button();
            SuspendLayout();
            // 
            // lbPersonDetails
            // 
            lbPersonDetails.AutoSize = true;
            lbPersonDetails.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbPersonDetails.ForeColor = Color.Red;
            lbPersonDetails.Location = new Point(434, 52);
            lbPersonDetails.Name = "lbPersonDetails";
            lbPersonDetails.Size = new Size(292, 54);
            lbPersonDetails.TabIndex = 0;
            lbPersonDetails.Text = "Person Details";
            // 
            // ctrlPersonCard1
            // 
            ctrlPersonCard1.Location = new Point(21, 151);
            ctrlPersonCard1.Name = "ctrlPersonCard1";
            ctrlPersonCard1.Size = new Size(1066, 425);
            ctrlPersonCard1.TabIndex = 1;
            ctrlPersonCard1.Load += ctrlPersonCard1_Load;
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.ImageAlign = ContentAlignment.MiddleLeft;
            btnClose.Location = new Point(926, 578);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(148, 44);
            btnClose.TabIndex = 2;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // frmShowPersonDetails
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1146, 631);
            Controls.Add(btnClose);
            Controls.Add(ctrlPersonCard1);
            Controls.Add(lbPersonDetails);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "frmShowPersonDetails";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Person Details";
            Load += frmShowPersonDetails_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbPersonDetails;
        private ctrlPersonCard ctrlPersonCard1;
        private Button btnClose;
    }
}