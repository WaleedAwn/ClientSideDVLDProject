using MainDVLD.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MainDVLD.Users
{
    public partial class frmChangeUserPassword : Form
    {
        int _PersonID, _userID;
        public frmChangeUserPassword(int userID, int personId)
        {
            _PersonID = personId;
            _userID = userID;
            InitializeComponent();
        }

        private void frmChangeUserPassword_Load(object sender, EventArgs e)
        {
            ctrlPersonCard1.LoadPersoneData(_PersonID);
            ctrlUserLoginInfo1.LoadUserData(_userID);

        }

        private void tbCurrentPassword_Validating(object sender, CancelEventArgs e)
        {
           

            if (string.IsNullOrWhiteSpace(tbCurrentPassword.Text))
            {
              

                errorProvider1.SetError(tbCurrentPassword, "Can't be empty.Must have value");
            }
            else if (Globals.UserLoginInfo.CurrentUser.Password != tbCurrentPassword.Text)
            {


                errorProvider1.SetError(tbCurrentPassword, " password does not match the CurrentPassword ");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(tbCurrentPassword, "");
            }


        }

        private void tbNewPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbNewPassword.Text))
            {
               
                errorProvider1.SetError(tbNewPassword, "Can't be empty.Must have value");
            }
            //else if ( tbNewPassword.Text != tbConfirmPassword.Text )
            //{
            //    errorProvider1.SetError(tbNewPassword, "New password does not match the Confirm Password ");


            //}
            else
            {
              
                errorProvider1.SetError(tbNewPassword, "");
            }

        }

        private void tbConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbConfirmPassword.Text))
            {

                errorProvider1.SetError(tbConfirmPassword, "Can't be empty.Must have value");
            }
            else if (tbConfirmPassword.Text!=tbNewPassword.Text)
            {
                errorProvider1.SetError(tbConfirmPassword, "Confirm password does not match the New Password ");


            }
           

            else
            {
                e.Cancel = false;

                errorProvider1.SetError(tbConfirmPassword, "");
            }
        }
    
    
    
    }



}
