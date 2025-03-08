using MainDVLD.Countries;
using MainDVLD.Globals;
using MainDVLD.People;
using MainDVLD.People.DTOs;
using MainDVLD.Users.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainDVLD.Users
{
    public partial class frmAddEditUser : Form
    {

        private UserAPiClient _userApiClient;
        private ApiResult<UsersDTO> _UserDto;

        public enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode;

        int _userID = -1;

        public int _PersonID = -1;

        public frmAddEditUser(int userID)
        {
            _userApiClient = new UserAPiClient();
            InitializeComponent();

            _userID = userID;

            if (_userID == -1)
                _Mode = enMode.AddNew;
            else
                _Mode = enMode.Update;
        }

        public async void _LoadData()
        {

            if (_Mode == enMode.AddNew)
            {
                _UserDto = new ApiResult<UsersDTO>();
                //_personDto.Result = new PersonsDTO();
                return;
            }
            _Mode = enMode.Update;
            lbAddEdituseritel.Text = "Update  User ";

            _UserDto = await _userApiClient.FindByUserID(_userID);

            if (_UserDto.Result == null)
            {
                MessageBox.Show("This form will be closed because No User with ID = " + _userID);
                this.Close();
                return;
            }
            ctrlPersonCardWithFilter1.LoadPersonData(_UserDto.Result.PersonID);
            ctrlPersonCardWithFilter1.DisableGroupBoxFilter(_UserDto.Result.PersonID);
            lbUserId.Text = _UserDto.Result.UserID.ToString();
            tbUserName.Text = _UserDto.Result.UserName;
            tbpassword.Text = _UserDto.Result.Password;
            tbConfirmPassword.Text = _UserDto.Result.Password;

            _PersonID = _UserDto.Result.PersonID;
            if (_UserDto.Result.IsActive == true)
                cbIsActive.Checked = true;

            else cbIsActive.Checked = false;


        }



        private void frmAddEditUser_Load(object sender, EventArgs e)
        {

            _LoadData();

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (_Mode == enMode.AddNew)
            {
                _PersonID = ctrlPersonCardWithFilter1.PersonID;
                if (ctrlPersonCardWithFilter1.PersonID != -1)
                {

                    MessageBox.Show($"Correct PersonID = {_PersonID}");
                    tabControl1.SelectedTab = tpUserPage;
                }
                else
                {
                    MessageBox.Show($"You can not move ,First Enter Person Info . PersonID = {_PersonID}");

                }

            }
            else
            {

                tabControl1.SelectedTab = tpUserPage;
            }


        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        bool GetISActiveValue(CheckBox checkBox) { return checkBox.Checked; }

        UsersDTO GetUserData()
        {
            UsersDTO usersDTO = new UsersDTO();
            usersDTO.UserID = -1;
            usersDTO.UserName = tbUserName.Text;
            usersDTO.PersonID = _PersonID;
            usersDTO.Password = tbpassword.Text;
            usersDTO.IsActive = GetISActiveValue(cbIsActive);
            return usersDTO;
        }

      
        private void tbUserName_Validating(object sender, CancelEventArgs e)
        {
            if (_Mode == enMode.AddNew)
            {
              CheckUserNameExist();
            }
            


        }
        
        private void tbpassword_TextChanged(object sender, EventArgs e)
        {
            CheckPasswordConfirm();
        }

         void CheckPasswordConfirm()
        {
            if (tbConfirmPassword.Text != tbpassword.Text)
            {
                errorProvider1.SetError(tbConfirmPassword, "Password Don not Match");
                btnSave.Enabled = false;
            }
            else
            {
                errorProvider1.Clear();
                btnSave.Enabled = true;

            }
        }
        private void tbConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            CheckPasswordConfirm();

        }

        private void tbConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            CheckPasswordConfirm();

        }



        bool ValidateUserInfo()
        {
            // Clear any previous errors
            errorProvider1.Clear();

            // Check if PersonID is valid
            if (_PersonID == -1)
            {
                errorProvider1.SetError(ctrlPersonCardWithFilter1, "You must select a valid person.");
                return false;
            }

            // Check if UserName is filled
            if (string.IsNullOrWhiteSpace(tbUserName.Text))
            {
                errorProvider1.SetError(tbUserName, "User Name cannot be empty.");
                return false;
            }

            // Check if Password is filled
            if (string.IsNullOrWhiteSpace(tbpassword.Text))
            {
                errorProvider1.SetError(tbpassword, "Password cannot be empty.");
                return false;
            }

            // Check if Confirm Password is filled
            if (string.IsNullOrWhiteSpace(tbConfirmPassword.Text))
            {
                errorProvider1.SetError(tbConfirmPassword, "Confirm Password cannot be empty.");
                return false;
            }

            // Check if Password and Confirm Password match
            if (tbpassword.Text != tbConfirmPassword.Text)
            {
                errorProvider1.SetError(tbConfirmPassword, "Passwords do not match.");
                return false;
            }

            // All synchronous checks passed
            return true;
        }
        private async Task<bool> CheckUserNameExist()
        {
            // If the username is the same as the current username, skip the check
            if (_Mode == enMode.Update && tbUserName.Text == _UserDto.Result.UserName)
            {
                // Username is unchanged, no error
                errorProvider1.Clear();
                return false; // Username is valid
            }

            // Check if the username exists in the system
            var isUserNameExist = await _userApiClient.ISUserUserNameExist(tbUserName.Text);
            if (isUserNameExist.Result)
            {
                errorProvider1.SetError(tbUserName, $"UserName '{tbUserName.Text}' already exists. Please choose another.");
                return true; // Username exists
            }
            else
            {
                errorProvider1.Clear();
                return false; // Username is available
            }
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateUserInfo())
            {
                MessageBox.Show("Please fill all required fields correctly.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check if username already exists (async validation)
            if (await CheckUserNameExist())
            {
                MessageBox.Show("Username already exists. Please choose another.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _UserDto.Result = GetUserData();

            if (_Mode == enMode.AddNew)
            {
                var newUserInfo = await _userApiClient.AddNewUser(_UserDto.Result);
                if (newUserInfo.IsSuccess)
                {
                    _userID = newUserInfo.Result.UserID;
                    MessageBox.Show("Data Saved Successfully", "Saved", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Error: User not saved.", "Error", MessageBoxButtons.OK);
                }
            }
            else if (_Mode == enMode.Update)
            {
                _UserDto.Result.UserID = _userID;
                var isUpdated = await _userApiClient.UpdateUserInfo(_UserDto.Result.UserID, _UserDto.Result);
                if (isUpdated.IsSuccess)
                {
                    MessageBox.Show("Data Updated Successfully", "Saved", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Error: User not updated.", "Error", MessageBoxButtons.OK);
                }
            }

            _Mode = enMode.Update;
            _LoadData();
        }




    }


}
 