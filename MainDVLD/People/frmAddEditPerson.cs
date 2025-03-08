using MainDVLD.Globals;
using MainDVLD.People.DTOs;
using MainDVLD.Countries.DTOs;

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
using MainDVLD.Countries;
using System.Resources;

namespace MainDVLD.People
{
    public partial class frmAddEditPerson : Form
    {
        public delegate void DataBackEventHandler(object dender, int PersonID);
        public event DataBackEventHandler DataBack;

        private PersonApiClient _personService;
        private ApiResult<PersonsDTO> _personDto;
        CountriesApiClient _countriesApiClient;

        public enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode;
        int _PersonID = -1;
        public frmAddEditPerson(int PersonID)
        {
            InitializeComponent();
            _countriesApiClient = new CountriesApiClient();
            _personService = new PersonApiClient();

            _PersonID = PersonID;
            if (_PersonID == -1)
                _Mode = enMode.AddNew;
            else
                _Mode = enMode.Update;
        }

        private async void _FillCountriesInComboBox()
        {
            var _CountryResult = await _countriesApiClient.GetAllCountries();

            foreach (var row in _CountryResult.Result)
            {
                combCountry.Items.Add(row.CountryName);
            }
            //_ListOFCountries = _CountryResult.Result;

            combCountry.SelectedItem = "Yemen";
            //combCountry.SelectedIndex = 0;

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
            _FillCountriesInComboBox();
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

            var countryInfo = await _countriesApiClient.FindByCountryID(_personDto.Result.NationalityCountryID);

            combCountry.SelectedIndex = combCountry.FindString(countryInfo.Result?.CountryName);
            //combCountry.SelectedIndex = combCountry.FindString(Globals.Help.FindCountryName(_ListOFCountries, _personDto.Result.NationalityCountryID));

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
                    pbPersonImage.Tag = -2;

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
            pbPersonImage.Tag = -1;
            //pbPersonImage.Image = Properties.Resources.Male_512;
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
            //persons.NationalityCountryID = combCountry.SelectedIndex;
            if (pbPersonImage.ImageLocation != null)
                persons.ImagePath = pbPersonImage.ImageLocation;
            else
                persons.ImagePath = "";
           


            return persons;
        }

        //private async void btnSave_Click(object sender, EventArgs e)
        //{
        //    var _countryInfo = await _countriesApiClient.FindCountryInfoByName(combCountry.Text);

        //    _personDto.Result = SetPersonData();
        //    _personDto.Result.NationalityCountryID = _countryInfo.Result.CountryID;

        //    if (_Mode == enMode.AddNew)
        //    {
        //        var NewPersonInfo = await _personService.AddNewPerson(_personDto.Result);

        //        if (NewPersonInfo.IsSuccess)
        //        {
        //            _PersonID = NewPersonInfo.Result.PersonID;
        //            DataBack?.Invoke(this, _PersonID);
        //            MessageBox.Show("Data Saved Successfully", "Saved", MessageBoxButtons.OK);

        //            MessageBox.Show($"New Person ID {_PersonID} ", "Saved", MessageBoxButtons.OK);


        //        }
        //        else
        //            MessageBox.Show("Error: Person is Not  Saved ", "Error", MessageBoxButtons.OK);


        //    }


        //    else if (_Mode == enMode.Update)
        //    {

        //        _personDto.Result.PersonID = _PersonID;
        //        var isUpdated = await _personService.UpdatePersonInfo(_personDto.Result.PersonID, _personDto.Result);

        //        if (isUpdated.IsSuccess)
        //        {
        //            MessageBox.Show("Data Updated Successfully", "Saved", MessageBoxButtons.OK);
        //        }
        //        else
        //            MessageBox.Show("Error: Person is Not  Updated ", "Error", MessageBoxButtons.OK);

        //    }

        //    _Mode = enMode.Update;


        //    llRemoveImage.Visible = (_personDto.Result.ImagePath != "");

        //    _LoadData();



        //}


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }




        // Valdation
        private bool ValidatePersonInfo()
        {
            bool isValid = true;

            // Validate mandatory fields
            isValid &= ValidateTextField(tbFirstName, "First Name is required.");
            isValid &= ValidateTextField(tbFSecondName, "Second Name is required.");
            isValid &= ValidateTextField(tbThirdName, "Third Name is required.", true);
            isValid &= ValidateTextField(tbLastName, "Last Name is required.");
            isValid &= ValidateTextField(tbAdress, "Address is required.");
            isValid &= ValidateTextField(tbNationalNumber, "National Number is required.");


            // Validate email if provided
            isValid &= ValidateEmailField(tbEmail, "Invalid email address.");

            // Validate phone number
            //if (tbPhone.Text.Length != 9)
            //{
            //    errorProvider1.SetError(tbPhone, "Phone number must be exactly 9 digits.");
            //    tbPhone.ForeColor = SystemColors.ActiveBorder;
            //    tbPhone.BackColor = Color.Red;
            //    isValid = false;
            //}
            //else
            //{
            //    errorProvider1.SetError(tbPhone, "");
            //}

            // Check country selection
            if (combCountry.SelectedItem == null || string.IsNullOrWhiteSpace(combCountry.Text))
            {
                errorProvider1.SetError(combCountry, "Please select a country.");
                isValid = false;
            }
            else
            {
                errorProvider1.SetError(combCountry, "");
            }

            // Gender validation
            if (!rbGenderMale.Checked && !rbGenderFemal.Checked)
            {
                errorProvider1.SetError(rbGenderMale, "Please select a gender.");
                isValid = false;
            }
            else
            {
                errorProvider1.SetError(rbGenderMale, "");
            }

            // Optional: Validate image if provided
            //if (!string.IsNullOrWhiteSpace(pbPersonImage.ImageLocation))
            //{
            //    if (!File.Exists(pbPersonImage.ImageLocation))
            //    {
            //        errorProvider1.SetError(pbPersonImage, "Invalid image file.");
            //        isValid = false;
            //    }
            //    else
            //    {
            //        errorProvider1.SetError(pbPersonImage, "");
            //    }
            //}

            return isValid;
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidatePersonInfo())
            {
                MessageBox.Show("Please fill in all required fields correctly.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Populate DTO
            var _countryInfo = await _countriesApiClient.FindCountryInfoByName(combCountry.Text);

            _personDto.Result = SetPersonData();
            _personDto.Result.NationalityCountryID = _countryInfo.Result.CountryID;

            if (_Mode == enMode.AddNew)
            {
                var newPersonInfo = await _personService.AddNewPerson(_personDto.Result);
                if (newPersonInfo.IsSuccess)
                {
                    _PersonID = newPersonInfo.Result.PersonID;
                    DataBack?.Invoke(this, _PersonID);
                    MessageBox.Show("Data saved successfully.", "Success", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Error: Person data could not be saved.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (_Mode == enMode.Update)
            {
                _personDto.Result.PersonID = _PersonID;
                var isUpdated = await _personService.UpdatePersonInfo(_personDto.Result.PersonID, _personDto.Result);
                if (isUpdated.IsSuccess)
                {
                    MessageBox.Show("Data updated successfully.", "Success", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Error: Person data could not be updated.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            _Mode = enMode.Update;
            _LoadData();
        }

        private bool ValidateMaskedTextField(MaskedTextBox maskedTextBox, string errorMessage, bool allowEmpty = false)
        {
            if (string.IsNullOrWhiteSpace(maskedTextBox.Text))
            {
                if (!allowEmpty)
                {
                    errorProvider1.SetError(maskedTextBox, errorMessage);
                    return false;
                }
            }
            else
            {
                errorProvider1.SetError(maskedTextBox, "");
            }
            return true;
        }

        private bool ValidateTextField(TextBox textBox, string errorMessage, bool allowEmpty = false)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                if (!allowEmpty)
                {
                    errorProvider1.SetError(textBox, errorMessage);
                    return false;
                }
            }
            else
            {
                errorProvider1.SetError(textBox, "");
            }
            return true;
        }

        private bool ValidateEmailField(TextBox textBox, string errorMessage)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text)) return true; // Allow empty email
            var emailRegex = new System.Text.RegularExpressions.Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$");
            if (!emailRegex.IsMatch(textBox.Text))
            {
                errorProvider1.SetError(textBox, errorMessage);
                return false;
            }
            errorProvider1.SetError(textBox, "");
            return true;
        }


        private void tbPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
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

        private void tbPhone_Validating(object sender, CancelEventArgs e)
        {
            var textBox = sender as TextBox;

            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                errorProvider1.SetError(textBox, "Phone number cannot be empty.");
                e.Cancel = true;
            }
            //else if (textBox.Text.Length != 9)
            //{
            //    errorProvider1.SetError(textBox, "Phone number must be exactly 9 digits.");
            //    e.Cancel = true;
            //}
            else
            {
                errorProvider1.SetError(textBox, "");
            }
        }

        private void tbPhone_TextChanged(object sender, EventArgs e)
        {
            tbPhone.BackColor = SystemColors.Window;


        }

        
    }
}
