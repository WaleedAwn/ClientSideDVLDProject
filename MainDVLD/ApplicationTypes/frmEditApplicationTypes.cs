using MainDVLD.Controls;
using MainDVLD.Globals;
using MainDVLD.Users.DTOs;
using MainDVLD.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MainDVLD.ApplicationTypes.DTOs;

namespace MainDVLD.ApplicationTypes
{
    public partial class frmEditApplicationTypes : Form
    {

        private ApplicationTypesAPIClint _applicationTypesAPI;
        private int applicationId;
        public enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode;

        public frmEditApplicationTypes(int id)
        {
            applicationId = id;
            _applicationTypesAPI = new ApplicationTypesAPIClint();

            if (applicationId == -1)
                _Mode = enMode.AddNew;
            else
                _Mode = enMode.Update;
            InitializeComponent();
        }
        public async void _LoadData()
        {

            if (_Mode == enMode.AddNew)
            {
                return;
            }
            _Mode = enMode.Update;


            var _ApplicationTypeDto = await _applicationTypesAPI.FindApplicationTypeByID(applicationId);

            if (_ApplicationTypeDto.Result == null)
            {
                MessageBox.Show("This form will be closed because No Application type with ID = " + applicationId);

                this.Close();
                return;
            }

            lbApplicationTypeD.Text = _ApplicationTypeDto.Result.ApplicationTypeID.ToString();
            tbTitel.Text = _ApplicationTypeDto.Result.ApplicationTypeTitle;
            tbFees.Text = ((float)_ApplicationTypeDto.Result.ApplicationFees).ToString();



        }

        private void frmEditApplicationTypes_Load(object sender, EventArgs e)
        {
            _LoadData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }
        bool ValidateInfo()
        {

          bool isValid = true;



            if (!Validation.ValidateTextField(tbTitel))
            {
                errorProvider1.SetError(tbTitel, "Application Type Title required!");
                isValid = false;
            }
            else
            {
                errorProvider1.SetError(tbTitel, "");
            }

            if (!Validation.ValidateTextField(tbFees))
            {
                errorProvider1.SetError(tbFees, "Application Type Fees required!");
                isValid = false;
            }
            else
            {
                errorProvider1.SetError(tbFees, "");
            }

           
            return isValid;
        }


        private async void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateInfo())
                {
                    GlobalFunctions.ShowMessageBox("Validation Error", "Please fill in all required fields correctly.");

                    return;
                }



                if (_Mode == enMode.Update)
                {
                    ApplicationTypesDTO updateApplicationType = new ApplicationTypesDTO();
                    updateApplicationType.ApplicationTypeID = applicationId;
                    updateApplicationType.ApplicationTypeTitle = tbTitel.Text;
                    updateApplicationType.ApplicationFees = decimal.Parse(tbFees.Text);



                    var isUpdated = await _applicationTypesAPI.UpdateApplicationTypeInfo(applicationId, updateApplicationType);
                    if (isUpdated.IsSuccess)
                    {
                        GlobalFunctions.ShowMessageBox( "Saved","Data saved successfully.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                     
                    }
                    else
                    {
                        GlobalFunctions.ShowMessageBox("Error", "Error: Application Type not updated.", MessageBoxButtons.OK, MessageBoxIcon.Error);

                     
                    }
                }

                _Mode = enMode.Update;
                //_LoadData();


            }
            catch (Exception)
            {

                GlobalFunctions.ShowMessageBox("Error", "An error occurred while trying to Update the details. Please try again.");

            }


        }

        private void tbFees_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Validation.OnlyNumbers_KeyPress(sender, e))
            {
                errorProvider1.SetError((TextBox)sender, "You should only enter numbers.");
                System.Media.SystemSounds.Beep.Play();
                e.Handled = true;
            }
            else
            {
                errorProvider1.Clear();
            }
          
        }
        
        
        
        
    }
}
