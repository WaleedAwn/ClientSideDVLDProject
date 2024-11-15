using MainDVLD.Globals;
using MainDVLD.HttpConnection;
using MainDVLD.People.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MainDVLD.People
{
    public partial class frmManagePeople : Form
    {
        
       
        private PersonApiClient _personApiClient;
        public frmManagePeople()
        {
            InitializeComponent();
            _personApiClient = new PersonApiClient();
        }


      


        private async void _RefreshAllPeopleData(string ColumnName="",object Value=null )
        {
            dgvListAllPeople.Rows.Clear(); // Clear existing rows before refreshing

            try
            {
                

               

                var peopleList = await _personApiClient.GetAllPeople();              
                if (peopleList != null && peopleList.Result?.Count > 0)
                {
                    if(Value != "" )
                    peopleList.Result= Globals.FilterHelper.Filter(peopleList.Result, ColumnName, Value);

                    foreach (var person in peopleList.Result)
                    {
                        dgvListAllPeople.Rows.Add(person.PersonID, person.NationalNo, person.FirstName,
                            person.SecondName, person.ThirdName, person.LastName, GlobalFunctions.GetGender(person.Gendor),
                            GlobalFunctions.FormattedDateOfBirth(person.DateOfBirth), person.NationalityCountryID, person.Phone, person.Email);
                    }
                    lnNumberOFPeople.Text = peopleList.Result.Count.ToString();
                }
                else

                {
                    // Show information message if no data is returned
                    MessageBox.Show("No people to display.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
           
            }
            catch (HttpRequestException ex)
            {
                // Display message if a network-related error occurs
                MessageBox.Show("Network error occurred while fetching data. Please check your internet connection.", "Network Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                // Display message for any other errors
                MessageBox.Show(" Waleed An unexpected error occurred while loading data. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void frmManagePeople_Load(object sender, EventArgs e)
        {
            ctrlFindByFilter1.FilterChanged +=  _RefreshAllPeopleData;

            _RefreshAllPeopleData();
        }
        private void btnAddNewPerson_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddEditPerson(-1);
            frm.ShowDialog();
            _RefreshAllPeopleData();
        }


        private void ShowDetailesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Guard clause: Check if no row is selected, show a message, and return early.
            if (dgvListAllPeople.CurrentRow == null)
            {
                MessageBox.Show("No person selected for viewing. Please select a person from the list.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Get the PersonID from the selected row
                int PersonID = (int)dgvListAllPeople.CurrentRow.Cells[0].Value;

                // Open the details form for the selected person
                Form frm = new frmShowPersonDetails(PersonID);
                frm.ShowDialog();

                // Refresh the data after viewing the details
                _RefreshAllPeopleData();
            }
            catch (Exception ex)
            {
                // Handle any potential errors gracefully
                MessageBox.Show("An error occurred while trying to show the details. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddEditPerson((int)dgvListAllPeople.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _RefreshAllPeopleData();

        }

        private async void deleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // Guard clause: If no row is selected, show a message and exit early.
            if (dgvListAllPeople.CurrentRow == null)
            {
                MessageBox.Show("No person selected for deletion. Please select a person from the list.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Retrieve the PersonID from the selected row
                int personId = (int)dgvListAllPeople.CurrentRow.Cells[0].Value;

                // Ask for confirmation before deleting
                if (MessageBox.Show($"Are you sure you want to delete this person [{personId}]?", "Confirm Delete", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    try
                    {
                        var isDeleted = await _personApiClient.DeletePerson(personId);
                        if (isDeleted.IsSuccess)
                        {
                            MessageBox.Show("Person deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            _RefreshAllPeopleData(); // Refresh the list after deletion
                        }
                        else
                        {
                            MessageBox.Show("The person could not be deleted. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (HttpRequestException)
                    {
                        MessageBox.Show("Network error occurred while attempting to delete the person. Please check your connection.", "Network Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("An error occurred while attempting to delete the person. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("An error occurred while retrieving the person for deletion. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        
    }
}
