﻿namespace MainDVLD.Controls
{
    partial class ctrlFindByFilter
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
            components = new System.ComponentModel.Container();
            errorProvider1 = new ErrorProvider(components);
            tbSearchValue = new TextBox();
            label1 = new Label();
            cbFilterPersonData = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // tbSearchValue
            // 
            tbSearchValue.Location = new Point(377, 19);
            tbSearchValue.Multiline = true;
            tbSearchValue.Name = "tbSearchValue";
            tbSearchValue.Size = new Size(243, 34);
            tbSearchValue.TabIndex = 8;
            tbSearchValue.TextChanged += tbSearchValue_TextChanged_1;
            tbSearchValue.KeyPress += tbSearchValue_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(17, 16);
            label1.Name = "label1";
            label1.Size = new Size(109, 32);
            label1.TabIndex = 7;
            label1.Text = "Filter By:";
            // 
            // cbFilterPersonData
            // 
            cbFilterPersonData.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbFilterPersonData.FormattingEnabled = true;
            cbFilterPersonData.Items.AddRange(new object[] { "None", "PersonID ", "NationalNo", "FirstName ", "SecondName", "ThirdName ", "LastName", "Address", "Gendor", "Phone", "Email", "NationalityCountryID " });
            cbFilterPersonData.Location = new Point(133, 17);
            cbFilterPersonData.Name = "cbFilterPersonData";
            cbFilterPersonData.Size = new Size(229, 36);
            cbFilterPersonData.TabIndex = 6;
            cbFilterPersonData.SelectedIndexChanged += cbFilterPersonData_SelectedIndexChanged_1;
            // 
            // ctrlFindByFilter
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tbSearchValue);
            Controls.Add(label1);
            Controls.Add(cbFilterPersonData);
            Name = "ctrlFindByFilter";
            Size = new Size(640, 63);
            Load += ctrlFindByFilter_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ErrorProvider errorProvider1;
        private TextBox tbSearchValue;
        private Label label1;
        protected ComboBox cbFilterPersonData;
    }
}
