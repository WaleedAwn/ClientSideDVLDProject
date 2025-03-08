using MainDVLD.Globals;
using MainDVLD.Users;
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
using System.Xml;

namespace MainDVLD
{
    public partial class frmLoginScreen : Form
    {
        string filePath = @"D:\AbouHadhoud Courses\DVLD Project Course19 API\ClientSideDVLDProject\MainDVLD\Users\userLogin.txt";


        //string filePath = @"\Users\userLogin.txt";



        private UserAPiClient _user;
        private ApiResult<UsersDTO> _UserApiResult;

        public frmLoginScreen()
        {
            _user = new UserAPiClient();
            _UserApiResult = new ApiResult<UsersDTO>();
            InitializeComponent();
            this.KeyPreview = true; // Enable form-level key handling
            //this.KeyDown += frmLoginScreen_KeyDown; // Attach KeyDown event handler
        }

        private void tbUserName_Click(object sender, EventArgs e)
        {
            tbUserName.BackColor = Color.White;
            UserNamePanal.BackColor = Color.White;
            PasswordPanal.BackColor = SystemColors.Control;
            tbPassword.BackColor = SystemColors.Control;
        }

        private void tbPassword_Click(object sender, EventArgs e)
        {
            tbPassword.BackColor = Color.White;
            PasswordPanal.BackColor = Color.White;
            UserNamePanal.BackColor = SystemColors.Control;
            tbUserName.BackColor = SystemColors.Control;
        }




        private void UserLogin_Validating(TextBox textBox, string Message, CancelEventArgs e)
        {

            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                //e.Cancel = true;
                errorProvUserLogin.SetError(textBox, Message);
            }
            else
            {
                e.Cancel = false;
                errorProvUserLogin.SetError(textBox, "");
            }
        }

        private void tbUserName_Validating(object sender, CancelEventArgs e)
        {

            UserLogin_Validating((TextBox)sender, "UserName Should Have Value!", e);


        }
        private void tbPassword_Validating(object sender, CancelEventArgs e)
        {
            UserLogin_Validating((TextBox)sender, "Password Should Have Value!", e);
        }


        private async void btnLogin_Click(object sender, EventArgs e)
        {
            _UserApiResult = await _user.FindByUserName(tbUserName.Text);
            if (_UserApiResult.IsSuccess && _UserApiResult.Result != null)
            {
                if ((_UserApiResult.Result.UserName.ToLower() == tbUserName.Text.ToLower()) &&
                    (_UserApiResult.Result.Password.ToLower() == tbPassword.Text.ToLower()))
                {
                    if (_UserApiResult.Result.IsActive == true)
                    {
                        if (cbRemmemberMe.Checked)
                        {
                            WriteUserLoginToFile(_UserApiResult.Result.UserName, _UserApiResult.Result.Password);


                        }
                        else
                        {
                            WriteUserLoginToFile("", "");

                        }

                        Globals.UserLoginInfo.CurrentUser = _UserApiResult.Result;

                        Form frm = new frmMain();

                        frm.ShowDialog();


                    }
                    else
                    {
                        MessageBox.Show("Access Denied! this user is not active in the system.", "LoginError", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                else
                {
                    MessageBox.Show("Invalid Username/Password", "LoginError", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("No User With this Information", "LoginError", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }




        private void WriteUserLoginToFile(string username, string password)
        {

            string content = username + "#//#" + password;
            string directoryPath = Path.GetDirectoryName(filePath);
            if (!string.IsNullOrEmpty(directoryPath) && !Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }
            using (StreamWriter sw = new StreamWriter(filePath))
            {
                sw.WriteLine(content);
            }
        }



        private void LoadUserRememberInf0()
        {

            var userLogin = ReadUserLoginFromFile(filePath);
            if (!string.IsNullOrEmpty(userLogin.Username))
            {
                cbRemmemberMe.Checked = true;
                tbUserName.Text = userLogin.Username.Trim();
                tbPassword.Text = userLogin.Password.Trim();
            }
        }
        private (string Username, string Password) ReadUserLoginFromFile(string filePath)
        {
            // Check if the file exists
            if (File.Exists(filePath))
            {
                // Read the single line from the file using StreamReader
                using (StreamReader sr = new StreamReader(filePath))
                {
                    string content = sr.ReadToEnd(); // Read the entire content of the file

                    // Split the content using the "#//#" delimiter
                    string[] parts = content.Split(new[] { "#//#" }, StringSplitOptions.None);

                    if (parts.Length == 2) // Ensure the format is valid
                    {
                        string username = parts[0];
                        string password = parts[1];

                        return (username, password);
                    }
                    else
                    {
                        // Invalid format
                        return ("", "");
                    }
                }
            }
            else
            {
                // File does not exist
                return ("", "");
            }
        }

        private void frmLoginScreen_Load(object sender, EventArgs e)
        {
            LoadUserRememberInf0();

        }



        private void btnCloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void frmLoginScreen_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
                //btnLogin_Click(sender,e); // Trigger Login button click
                e.Handled = true; // Mark the event as handled
            }
        }





        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            tbPassword.UseSystemPasswordChar = false;
            pictureBox3.Image = Properties.Resources.Show_Password;

        }
        private void pictureBox3_MouseUp(object sender, MouseEventArgs e)
        {
            tbPassword.UseSystemPasswordChar = true;

            pictureBox3.Image = Properties.Resources.hide_Password;
        }

        private void LbForgetPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
