//using MainDVLD.Globals;
//using MainDVLD.People;
//using MainDVLD.Users.DTOs;
//using Microsoft.VisualBasic.ApplicationServices;
//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.DirectoryServices;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;

//namespace MainDVLD.Users
//{
//    public partial class frmManageUsers : Form
//    {
//        private UserAPiClient _allUsersData;


//        public frmManageUsers()
//        {
//            _allUsersData = new UserAPiClient();
//            InitializeComponent();
//        }







//        private async void _RefreshAllUserData()
//        {

//            dgvListAllUsers.Rows.Clear();
//            try
//            {
//                var UsersList = await _allUsersData.GetAllUsers();
//                if (UsersList != null && UsersList.Result?.Count > 0)
//                {

//                    var simplifiedUsers = UsersList.Result.Select(user => new
//                    {
//                        user.UserID,
//                        user.PersonID,
//                        FullName = GlobalFunctions.CombineFullName(
//                            user.Person.FirstName,
//                            user.Person.SecondName,
//                            user.Person.ThirdName,
//                            user.Person.LastName),
//                        user.UserName,
//                        user.IsActive
//                    }).ToList();

//                    dgvListAllUsers.AutoGenerateColumns = false;

//                    dgvListAllUsers.DataSource = simplifiedUsers;


//                    lbNumberOFUsers.Text = UsersList.Result.Count.ToString();
//                }
//                else

//                {
//                    // Show information message if no data is returned
//                    MessageBox.Show("No Users to display.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
//                }
//            }
//            catch (HttpRequestException ex)
//            {
//                // Display message if a network-related error occurs
//                MessageBox.Show("Network error occurred while fetching data. Please check your internet connection.", "Network Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
//            }
//            catch (Exception ex)
//            {
//                // Display message for any other errors
//                MessageBox.Show("  An unexpected error occurred while loading data. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
//            }



//        }


//        private void btnClose_Click(object sender, EventArgs e)
//        {
//            this.Close();
//        }

//        private void frmManageUsers_Load(object sender, EventArgs e)
//        {
//             dgvListAllUsers.ColumnHeaderMouseClick += (s, e) => FilterHelper.SortDataGridView(dgvListAllUsers, e.ColumnIndex);

//            _RefreshAllUserData();
//        }

//        private void OpenForm(Form form, bool refreshAfterClose = false)
//        {
//            form.ShowDialog();
//            if (refreshAfterClose)
//            {
//                _RefreshAllUserData();
//            }
//        }

//        private void ShowDetails()
//        {
//            if (dgvListAllUsers.CurrentRow == null)
//            {
//                MessageBox.Show("No User selected. Please select a user from the list.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
//                return;
//            }

//            int userID = (int)dgvListAllUsers.CurrentRow.Cells[0].Value;
//            int personID = (int)dgvListAllUsers.CurrentRow.Cells[1].Value;

//            OpenForm(new frmShowUserDetails(userID, personID));
//        }



//        private void ShowDetailesToolStripMenuItem_Click(object sender, EventArgs e)
//        {

//            ShowDetails();
//        }

//        private void ChangePasswordToolStripMenuItem_Click(object sender, EventArgs e)
//        {
//            if (dgvListAllUsers.CurrentRow == null)
//            {
//                MessageBox.Show("No User selected for viewing. Please select a person from the list.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
//                return;
//            }

//            try
//            {
//                // Get the PersonID from the selected row
//                int UserID = (int)dgvListAllUsers.CurrentRow.Cells[0].Value;
//                int PersonID = (int)dgvListAllUsers.CurrentRow.Cells[1].Value;


//                // Open the details form for the selected person
//                Form frm = new frmChangeUserPassword(UserID, PersonID);
//                frm.ShowDialog();

//                // Refresh the data after viewing the details
//                //_RefreshAllPeopleData();
//            }
//            catch (Exception ex)
//            {
//                // Handle any potential errors gracefully
//                MessageBox.Show("An error occurred while trying to show the details. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
//            }


//        }

//        private void btnAddNewUser_Click(object sender, EventArgs e)
//        {
//            Form form = new frmAddEditUser(-1);
//            form.ShowDialog();
//            _RefreshAllUserData();
//        }

//        private void AddNewToolStripMenuItem_Click(object sender, EventArgs e)
//        {
//            Form form = new frmAddEditUser(-1);
//            form.ShowDialog();
//            _RefreshAllUserData();
//        }

//        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
//        {
//            if (dgvListAllUsers.CurrentRow == null)
//            {
//                MessageBox.Show("No User selected for Updating. Please select a person from the list.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
//                return;
//            }

//            try
//            {
//                // Get the PersonID from the selected row
//                int UserID = (int)dgvListAllUsers.CurrentRow.Cells[0].Value;

//                // Open the details form for the selected person
//                Form frm = new frmAddEditUser(UserID);
//                frm.ShowDialog();
//                _RefreshAllUserData();
//                // Refresh the data after viewing the details
//                //_RefreshAllPeopleData();
//            }
//            catch (Exception ex)
//            {
//                // Handle any potential errors gracefully
//                MessageBox.Show("An error occurred while trying to show the details. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
//            }

//        }

//        private async void deleteToolStripMenuItem1_Click(object sender, EventArgs e)
//        {

//            if (dgvListAllUsers.CurrentRow == null)
//            {
//                MessageBox.Show("No User selected for Deleting. Please select a person from the list.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
//                return;
//            }

//            try
//            {
//                // Retrieve the PersonID from the selected row
//                int UserID = (int)dgvListAllUsers.CurrentRow.Cells[0].Value;
//                if (UserID == Globals.UserLoginInfo.CurrentUser.UserID)
//                {
//                    MessageBox.Show("You Can not delete this user it is on process now", "Error Deleting", MessageBoxButtons.OK, MessageBoxIcon.Warning);
//                    return;

//                }

//                // Ask for confirmation before deleting
//                if (MessageBox.Show($"Are you sure you want to delete this person [{UserID}]?", "Confirm Delete", MessageBoxButtons.OKCancel) == DialogResult.OK)
//                {
//                    try
//                    {
//                        var isDeleted = await UserAPiClient.DeleteUser(UserID);
//                        if (isDeleted.IsSuccess)
//                        {
//                            MessageBox.Show("User deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
//                            _RefreshAllUserData(); // Refresh the list after deletion
//                        }
//                        else
//                        {
//                            MessageBox.Show("The User could not be deleted. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
//                        }
//                    }
//                    catch (HttpRequestException)
//                    {
//                        MessageBox.Show("Network error occurred while attempting to delete the User. Please check your connection.", "Network Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
//                    }
//                    catch (Exception)
//                    {
//                        MessageBox.Show("An error occurred while attempting to delete the User. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
//                    }
//                }
//            }
//            catch (Exception)
//            {
//                MessageBox.Show("An error occurred while retrieving the User for deletion. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
//            }


//        }


//        private void cbFilterPersonData_SelectedIndexChanged(object sender, EventArgs e)
//        {
//            tbSearchValue.Clear();
//        }

//        private void tbSearchValue_TextChanged(object sender, EventArgs e)
//        {

//        }


//    }
//}


using MainDVLD.Globals;
using MainDVLD.People;
using MainDVLD.Users.DTOs;
using System;
using System.Linq;
using System.Windows.Forms;

namespace MainDVLD.Users
{
    public partial class frmManageUsers : Form
    {
        private UserAPiClient _allUsersData;

        public frmManageUsers()
        {
            _allUsersData = new UserAPiClient();
            InitializeComponent();
        }
        private IEnumerable<object> originalData;
        private async void _RefreshAllUserData()
        {
            try
            {
                var UsersList = await _allUsersData.GetAllUsers();
                if (UsersList?.Result?.Count > 0)
                {
                    var simplifiedUsers = UsersList.Result.Select(user => new
                    {
                        user.UserID,
                        user.PersonID,
                        FullName = GlobalFunctions.CombineFullName(
                            user.Person.FirstName,
                            user.Person.SecondName,
                            user.Person.ThirdName,
                            user.Person.LastName),
                        user.UserName,
                        user.IsActive
                    }).ToList();

                    dgvListAllUsers.AutoGenerateColumns = false;
                    dgvListAllUsers.DataSource = simplifiedUsers;
                    originalData = simplifiedUsers;
                    lbNumberOFUsers.Text = UsersList.Result.Count.ToString();
                }
                else
                {
                    GlobalFunctions.ShowMessageBox("Information", "No Users to display.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (HttpRequestException)
            {
                GlobalFunctions.ShowMessageBox("Network Error", "Network error occurred while fetching data. Please check your internet connection.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                GlobalFunctions.ShowMessageBox("Error", "An unexpected error occurred while loading data. Please try again.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmManageUsers_Load(object sender, EventArgs e)
        {
            dgvListAllUsers.ColumnHeaderMouseClick += (s, e) => FilterHelper.SortDataGridView(dgvListAllUsers, e.ColumnIndex);
            cbFilterUserData.SelectedIndex = 0;
            cbFilterUserActivity.SelectedIndex = 0;

            tbSearchValue.Visible = cbFilterUserData.SelectedIndex != 0;        
            cbFilterUserActivity.Visible = false;
          

            _RefreshAllUserData();
        }

        private void OpenForm(Form form, bool refreshAfterClose = false)
        {
            form.ShowDialog();
            if (refreshAfterClose)
            {
                _RefreshAllUserData();
            }
        }

        private void PerformActionOnSelectedUser(Action<int, int> action, string errorMessage)
        {
            if (dgvListAllUsers.CurrentRow == null)
            {
                GlobalFunctions.ShowMessageBox("No Selection", "No User selected. Please select a user from the list.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int userID = (int)dgvListAllUsers.CurrentRow.Cells[0].Value;
                int personID = (int)dgvListAllUsers.CurrentRow.Cells[1].Value;

                action(userID, personID);
            }
            catch (Exception)
            {
                GlobalFunctions.ShowMessageBox("Error", errorMessage, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ConfirmAction(string message, string title = "Confirm Action")
        {
            return MessageBox.Show(message, title, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK;
        }

        private void ShowDetails()
        {
            PerformActionOnSelectedUser((userID, personID) =>
            {
                OpenForm(new frmShowUserDetails(userID, personID));
            }, "An error occurred while trying to show the details. Please try again.");
        }

        private void ShowDetailesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowDetails();
        }

        private void ChangePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PerformActionOnSelectedUser((userID, personID) =>
            {
                OpenForm(new frmChangeUserPassword(userID, personID));
            }, "An error occurred while trying to change the password. Please try again.");
        }

        private void btnAddNewUser_Click(object sender, EventArgs e)
        {
            OpenForm(new frmAddEditUser(-1), refreshAfterClose: true);
        }

        private void AddNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(new frmAddEditUser(-1), refreshAfterClose: true);
        }

        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PerformActionOnSelectedUser((userID, _) =>
            {
                OpenForm(new frmAddEditUser(userID), refreshAfterClose: true);
            }, "An error occurred while trying to edit the user. Please try again.");
        }

        private async void deleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (dgvListAllUsers.CurrentRow == null)
            {
                GlobalFunctions.ShowMessageBox("No Selection", "No User selected for Deleting. Please select a user from the list.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int userID = (int)dgvListAllUsers.CurrentRow.Cells[0].Value;


                if (userID == Globals.UserLoginInfo.CurrentUser.UserID)
                {
                    GlobalFunctions.ShowMessageBox("Error Deleting", "You cannot delete this user as it is currently in process.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (ConfirmAction($"Are you sure you want to delete this with UserName  [ \"{dgvListAllUsers.CurrentRow.Cells[3].Value} \" ]?", "Confirm Delete"))
                {
                    try
                    {
                        var isDeleted = await UserAPiClient.DeleteUser(userID);

                        if (isDeleted.IsSuccess)
                        {
                            GlobalFunctions.ShowMessageBox("Success", "User deleted successfully.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            _RefreshAllUserData();
                        }
                        else
                        {
                            GlobalFunctions.ShowMessageBox("Error", "The User could not be deleted. Please try again.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (HttpRequestException)
                    {
                        GlobalFunctions.ShowMessageBox("Network Error", "Network error occurred while attempting to delete the User. Please check your connection.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception)
                    {
                        GlobalFunctions.ShowMessageBox("Error", "An error occurred while attempting to delete the User. Please try again.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception)
            {
                GlobalFunctions.ShowMessageBox("Error", "An error occurred while retrieving the User for deletion. Please try again.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void tbSearchValue_TextChanged(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        private void ApplyFilter()
        {
            cbFilterUserActivity.Visible = false;

            string selectedColumn = cbFilterUserData.SelectedItem.ToString();
            string filterValue = tbSearchValue.Text;

            if (cbFilterUserData.SelectedIndex == 0)
            {
                ResetDataGridView();
            }
            else if (cbFilterUserData.SelectedIndex == 4)
            {
                cbFilterUserActivity.Visible = true;
                tbSearchValue.Visible = false;
               
                cbFilterUserActivity.SelectedIndex = 0;

                ApplyUserActivityFilter();

            }
            else
            {
                tbSearchValue.Visible = true;
                cbFilterUserActivity.Visible = false;
                FilterDataGridView(dgvListAllUsers, selectedColumn, filterValue);
            }
        }

        private void FilterDataGridView(DataGridView dataGridView, string selectedColumn, string filterValue)
        {
            if (dataGridView.DataSource == null || string.IsNullOrWhiteSpace(selectedColumn))
                return;

            var data = (dataGridView.DataSource as IEnumerable<object>)?.ToList();
            if (data == null || data.Count == 0)
                return;

            var filteredData = data.Where(item =>
            {
                var property = item.GetType().GetProperty(selectedColumn);
                var value = property?.GetValue(item)?.ToString();
                return !string.IsNullOrEmpty(value) &&
                       value.IndexOf(filterValue, StringComparison.OrdinalIgnoreCase) >= 0;
            }).ToList();

            dataGridView.DataSource = filteredData;
        }

        private void ResetDataGridView()
        {
            if (originalData != null)
            {
                cbFilterUserData.SelectedIndex = 0;
                tbSearchValue.Visible = false;
                cbFilterUserActivity.Visible = false;
                dgvListAllUsers.DataSource = originalData.ToList();
            }
        }

        private void tbSearchValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilterUserData.SelectedIndex == 1 || cbFilterUserData.SelectedIndex == 2)
            {

                if (Validation.OnlyNumbers_KeyPress(sender, e))
                {

                    errorProvider1.SetError(tbSearchValue, "You should only enter numbers.");


                    System.Media.SystemSounds.Beep.Play();


                    e.Handled = true;
                }
                else
                {
                    errorProvider1.Clear();
                }
            }

            else
            {
                errorProvider1.Clear();
            }
        }


        private void ApplyUserActivityFilter()
        {
           
        }

        private void cbFilterUserActivity_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbFilterUserActivity.SelectedIndex == 1) FilterDataGridView(dgvListAllUsers, "IsActive", "1");
            else if (cbFilterUserActivity.SelectedIndex == 2) FilterDataGridView(dgvListAllUsers, "IsActive", "0");
         



        }

        private void cbFilterUserData_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbSearchValue.Clear();
           // if (cbFilterUserData.SelectedIndex == 0)
           // {
           //     ResetDataGridView();
           // }
           //if (cbFilterUserData.SelectedIndex == 4)
           // {
           //     cbFilterUserActivity.Visible = true;
           //     tbSearchValue.Visible = false;
           // }
           // else
           // {
           //     tbSearchValue.Visible = true;
           // }
        }
    }
}
