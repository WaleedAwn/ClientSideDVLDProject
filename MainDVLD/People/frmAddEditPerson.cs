using MainDVLD.Globals;
using MainDVLD.People.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace MainDVLD.People
{
    public partial class frmAddEditPerson : Form
    {
        private PersonApiClient _personService;
        private ApiResult<PersonsDTO> _personDto;

        public enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode;
        int _PersonID = -1;
        public frmAddEditPerson(int PersonID)
        {
            InitializeComponent();

            _personService = new PersonApiClient();
            _PersonID = PersonID;
            if (_PersonID == -1)
                _Mode = enMode.AddNew;
            else
                _Mode = enMode.Update;
        }


        private void _SetGender(short Gender)
        {
            if (Gender == 0)
                rbGenderMale.Checked = true;
            else if (Gender == 1)
                rbGenderFemal.Checked = true;


        }
        public async void _LoadData()
        {

            tbFirstName.Focus();



            if (_Mode == enMode.AddNew)
            {
                lbAddEditPersonTitel.Text = "Add New Person ";
                _personDto = new ApiResult<PersonsDTO>();
                //_personDto.Result = new PersonsDTO();

                return;
            }
            _Mode = enMode.Update;
            _personDto = await _personService.FindByPersonID(_PersonID);

            if (_personDto.Result == null)
            {
                MessageBox.Show("This form will be closed because No Person with ID = " + _PersonID);

                this.Close();
                return;
            }

            string formattedDateOfBirth = _personDto.Result.DateOfBirth.ToString("yyyy-MM-dd");
            lbAddEditPersonTitel.Text = "Edit Person Info ";

            lbPersonID.Text = _personDto.Result.PersonID.ToString();
            lbNationalNo.Text = _personDto.Result.NationalNo.ToString();
            tbNationalNumber.Text = _personDto.Result.NationalNo.ToString();

            tbFirstName.Text = _personDto.Result.FirstName.ToString();
            tbFSecondName.Text = _personDto.Result.SecondName.ToString();
            tbThirdName.Text = _personDto.Result.ThirdName.ToString();
            tbLastName.Text = _personDto.Result.LastName.ToString();
            _SetGender(_personDto.Result.Gendor);
            tbEmail.Text = _personDto.Result.Email.ToString();
            tbPhone.Text = _personDto.Result.Phone.ToString();
            tbAdress.Text = _personDto.Result.Address.ToString();
            if (_personDto.Result.ImagePath != "")
            {
                pbPersonImage.Load(_personDto.Result.ImagePath);
            }
            llRemoveImage.Visible = (_personDto.Result.ImagePath != "");

            combCountry.Items.Add(_personDto.Result.NationalityCountryID.ToString());


        }



        private void frmAddEditPerson_Load(object sender, EventArgs e)
        {

            tbDateTimePicker.MaxDate = DateTime.Now;
            tbDateTimePicker.MinDate = DateTime.Today.AddYears(-18);


            _LoadData();
        }



        private void linkSetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            // Directory where the image will be saved
            var uploadDirectory = @"D:\AbouHadhoud Courses\DVLD Project Course19 API\MyUploads";


            if (!Directory.Exists(uploadDirectory))
            {
                Directory.CreateDirectory(uploadDirectory);
            }

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Get the selected file path
                string selectedFilePath = openFileDialog1.FileName;

                // Generate a unique name for the file
                string fileName = Path.GetFileName(selectedFilePath);
                string uniqueFileName = Guid.NewGuid().ToString() + Path.GetExtension(fileName);

                // Full path for the new file
                string newFilePath = Path.Combine(uploadDirectory, uniqueFileName);

                try
                {

                    File.Copy(selectedFilePath, newFilePath);

                    pbPersonImage.Load(newFilePath);

                    pbPersonImage.ImageLocation = newFilePath;
                    //pbPersonImage.Location= newFilePath;
                    // Store the new file path in the database
                    //StoreImagePathInDatabase(newFilePath);

                    // MessageBox.Show("Image uploaded successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }

            }



        }

        private void llRemoveImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pbPersonImage.ImageLocation = "";
            llRemoveImage.Visible = false;

        }



        private PersonsDTO SetPersonData()
        {
            PersonsDTO persons = new PersonsDTO();
            //persons.PersonID=_PersonID;
            persons.NationalNo = tbNationalNumber.Text;
            persons.FirstName = tbFirstName.Text;

            persons.SecondName = tbFSecondName.Text;
            persons.ThirdName = tbThirdName.Text;
            persons.LastName = tbLastName.Text;
            persons.DateOfBirth = tbDateTimePicker.Value;

            short gender = 0;
            if (rbGenderMale.Checked)
                persons.Gendor = 0;
            else if (rbGenderFemal.Checked)
                persons.Gendor = 1;
            persons.Email = tbEmail.Text;
            persons.Address = tbAdress.Text;
            persons.Phone = tbPhone.Text;
            persons.NationalityCountryID = 90;
            persons.ImagePath = pbPersonImage.ImageLocation;





            return persons;
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            _personDto.Result = SetPersonData();


            if (_Mode == enMode.AddNew)
            {

                var NewPersonInfo = await _personService.AddNewPerson(_personDto.Result);


                if (NewPersonInfo.IsSuccess)
                {
                    _PersonID = NewPersonInfo.Result.PersonID;
                    MessageBox.Show("Data Saved Successfully", "Saved", MessageBoxButtons.OK);

                    MessageBox.Show($"New Person ID {_PersonID} ", "Saved", MessageBoxButtons.OK);


                }
                else
                    MessageBox.Show("Error: Person is Not  Saved ", "Error", MessageBoxButtons.OK);


            }


            else if (_Mode == enMode.Update)
            {

                _personDto.Result.PersonID = _PersonID;
                var isUpdated = await _personService.UpdatePersonInfo(_personDto.Result.PersonID, _personDto.Result);

                if (isUpdated.IsSuccess)
                {
                    MessageBox.Show("Data Updated Successfully", "Saved", MessageBoxButtons.OK);
                }
                else
                    MessageBox.Show("Error: Person is Not  Updated ", "Error", MessageBoxButtons.OK);

            }

            _Mode = enMode.Update;


            llRemoveImage.Visible = (_personDto.Result.ImagePath != "");

            _LoadData();



        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void PersonFullName_Validating(MaskedTextBox textBox, string Message, CancelEventArgs e)
        {
            // Regular expression to check if the text contains only letters and spaces
            System.Text.RegularExpressions.Regex regex = new System.Text.RegularExpressions.Regex("^[a-zA-Z ]+$");

            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                //e.Cancel = true;
                errorProvider1.SetError(textBox, Message);
            }
            else if (!regex.IsMatch(textBox.Text)) // Check if text contains only letters
            {
                //e.Cancel = true;
                errorProvider1.SetError(textBox, "Only letters and spaces are allowed.");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(textBox, "");
            }
        }
        private void PersonThirdName_Validating(MaskedTextBox textBox, string Message, CancelEventArgs e)
        {
            // Regular expression to check if the text contains only letters and spaces
            System.Text.RegularExpressions.Regex regex = new System.Text.RegularExpressions.Regex("^[a-zA-Z ]+$");

            if (!regex.IsMatch(textBox.Text)) // Check if text contains only letters
            {
                //e.Cancel = true;
                errorProvider1.SetError(textBox, "Only letters and spaces are allowed.");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(textBox, "");
            }



        }


        private void tbFirstName_Validating(object sender, CancelEventArgs e)
        {
            PersonFullName_Validating((MaskedTextBox)sender, "^Required.FirsName Should Not be Empty", e);

        }

        private void tbFSecondName_Validating(object sender, CancelEventArgs e)
        {
            PersonFullName_Validating((MaskedTextBox)sender, "^Required.SecondName Should Not be Empty", e);

        }

        private void tbThirdName_Validating(object sender, CancelEventArgs e)
        {

            PersonThirdName_Validating((MaskedTextBox)sender, "", e);

        }

        private void tbLastName_Validating(object sender, CancelEventArgs e)
        {
            PersonFullName_Validating((MaskedTextBox)sender, "^Required.LastName Should Not be Empty", e);


        }

        private void tbPhone_Validating(object sender, CancelEventArgs e)
        {
            // Cast the sender to a TextBox (or MaskedTextBox if that's the control type)
            var textBox = sender as TextBox;

            // Regular expression to allow only numbers and specific symbols (+, -, .)
            System.Text.RegularExpressions.Regex regex = new System.Text.RegularExpressions.Regex(@"^[0-9+\-\.]+$");

            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                //e.Cancel = true;
                errorProvider1.SetError(textBox, "Phone number cannot be empty.");
            }
            else if (!regex.IsMatch(textBox.Text)) // Check if input matches the allowed characters
            {
                //e.Cancel = true;
                errorProvider1.SetError(textBox, "Only numbers and symbols (+, -, .) are allowed.");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(textBox, "");
            }
        }

        private void tbThirdName_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
