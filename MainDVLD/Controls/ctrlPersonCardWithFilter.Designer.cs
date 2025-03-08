namespace MainDVLD.Controls
{
    partial class ctrlPersonCardWithFilter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctrlPersonCardWithFilter));
            ctrlPersonCard1 = new ctrlPersonCard();
            gbFilterBox = new GroupBox();
            tbSearchValue = new MaskedTextBox();
            label1 = new Label();
            cbFilterPersonData = new ComboBox();
            btnAddNewPerson = new Button();
            btnSearchPerson = new Button();
            errorProvider1 = new ErrorProvider(components);
            gbFilterBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // ctrlPersonCard1
            // 
            ctrlPersonCard1.BorderStyle = BorderStyle.FixedSingle;
            ctrlPersonCard1.Location = new Point(3, 120);
            ctrlPersonCard1.Name = "ctrlPersonCard1";
            ctrlPersonCard1.Size = new Size(1045, 410);
            ctrlPersonCard1.TabIndex = 0;
            // 
            // gbFilterBox
            // 
            gbFilterBox.Controls.Add(tbSearchValue);
            gbFilterBox.Controls.Add(label1);
            gbFilterBox.Controls.Add(cbFilterPersonData);
            gbFilterBox.Controls.Add(btnAddNewPerson);
            gbFilterBox.Controls.Add(btnSearchPerson);
            gbFilterBox.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbFilterBox.Location = new Point(3, 3);
            gbFilterBox.Name = "gbFilterBox";
            gbFilterBox.Size = new Size(1045, 101);
            gbFilterBox.TabIndex = 1;
            gbFilterBox.TabStop = false;
            gbFilterBox.Text = "Filter";
            // 
            // tbSearchValue
            // 
            tbSearchValue.Location = new Point(374, 42);
            tbSearchValue.Name = "tbSearchValue";
            tbSearchValue.Size = new Size(229, 34);
            tbSearchValue.TabIndex = 11;
            tbSearchValue.KeyPress += tbSearchValue_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(10, 39);
            label1.Name = "label1";
            label1.Size = new Size(109, 32);
            label1.TabIndex = 10;
            label1.Text = "Filter By:";
            // 
            // cbFilterPersonData
            // 
            cbFilterPersonData.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbFilterPersonData.FormattingEnabled = true;
            cbFilterPersonData.Items.AddRange(new object[] { "PersonID ", "NationalNo", "FirstName ", "SecondName", "ThirdName ", "LastName", "Phone", "Email" });
            cbFilterPersonData.Location = new Point(126, 40);
            cbFilterPersonData.Name = "cbFilterPersonData";
            cbFilterPersonData.Size = new Size(229, 36);
            cbFilterPersonData.TabIndex = 9;
            cbFilterPersonData.SelectedIndexChanged += cbFilterPersonData_SelectedIndexChanged;
            // 
            // btnAddNewPerson
            // 
            btnAddNewPerson.BackgroundImageLayout = ImageLayout.Zoom;
            btnAddNewPerson.Image = (Image)resources.GetObject("btnAddNewPerson.Image");
            btnAddNewPerson.Location = new Point(693, 30);
            btnAddNewPerson.Name = "btnAddNewPerson";
            btnAddNewPerson.Size = new Size(51, 55);
            btnAddNewPerson.TabIndex = 4;
            btnAddNewPerson.UseVisualStyleBackColor = true;
            btnAddNewPerson.Click += btnAddNewPerson_Click;
            // 
            // btnSearchPerson
            // 
            btnSearchPerson.BackgroundImageLayout = ImageLayout.Zoom;
            btnSearchPerson.Image = (Image)resources.GetObject("btnSearchPerson.Image");
            btnSearchPerson.Location = new Point(618, 30);
            btnSearchPerson.Name = "btnSearchPerson";
            btnSearchPerson.Size = new Size(51, 55);
            btnSearchPerson.TabIndex = 3;
            btnSearchPerson.UseVisualStyleBackColor = true;
            btnSearchPerson.Click += btnSearchPerson_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // ctrlPersonCardWithFilter
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(gbFilterBox);
            Controls.Add(ctrlPersonCard1);
            Name = "ctrlPersonCardWithFilter";
            Size = new Size(1145, 602);
            Load += ctrlPersonCardWithFilter_Load;
            gbFilterBox.ResumeLayout(false);
            gbFilterBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ctrlPersonCard ctrlPersonCard1;
        private GroupBox gbFilterBox;
        private Button btnAddNewPerson;
        private Button btnSearchPerson;
        private Label label1;
        protected ComboBox cbFilterPersonData;
        private ErrorProvider errorProvider1;
        private MaskedTextBox tbSearchValue;
    }
}
