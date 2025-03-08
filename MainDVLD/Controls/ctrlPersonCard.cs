using MainDVLD.Globals;
using MainDVLD.People;
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
using static System.Net.Mime.MediaTypeNames;

namespace MainDVLD
{
    public partial class ctrlPersonCard : UserControl
    {
        private ApiResult<PersonsDTO> _apiResult;
        private PersonApiClient _personApiClient;

         public  int _personId=-1;
        public ctrlPersonCard()
        {
            InitializeComponent();
            _apiResult = new ApiResult<PersonsDTO>();
            _personApiClient = new PersonApiClient();

        
            
        }


        private async void _FillPersonInfo()        
        {
            _personId = _apiResult.Result.PersonID;
            linlEditPerson.Enabled = true;

            lbPersonID.Text = _apiResult.Result.PersonID.ToString();
            lbNationalNo.Text = _apiResult.Result.NationalNo;
            lbPersonName.Text = GlobalFunctions.CombineFullName(_apiResult.Result.FirstName, _apiResult.Result.SecondName, _apiResult.Result.ThirdName, _apiResult.Result.LastName);

            lbgender.Text = GlobalFunctions.GetGender(_apiResult.Result.Gendor);
            lbEmail.Text = _apiResult.Result.Email.ToString();
            lbAdress.Text = _apiResult.Result.Address.ToString();

            lbDateOfBrith.Text = GlobalFunctions.FormattedDateOfBirth(_apiResult.Result.DateOfBirth);
            lbPhone.Text = _apiResult.Result.Phone.ToString();
           var countryResult =  await Countries.CountriesApiClient.FindByCountryIDstatic(_apiResult.Result.NationalityCountryID);
            lbCountry.Text = countryResult.Result.CountryName;
            
            if (_apiResult.Result.ImagePath != "")
            {
                pbPersonImage.Load(_apiResult.Result.ImagePath);
            }



        }

        private void _ResetPersonInfo()
        {
            _personId = -1;
            linlEditPerson.Enabled = false;

            string empetyValue = "???";

            lbPersonID.Text = empetyValue;
            lbNationalNo.Text = empetyValue;
            lbPersonName.Text = empetyValue;
            lbgender.Text = empetyValue;
            lbEmail.Text = empetyValue;
            lbAdress.Text = empetyValue;

            lbDateOfBrith.Text = empetyValue;
            lbPhone.Text = empetyValue;
            lbCountry.Text = empetyValue;

            //pbPersonImage.Load();


           



        }


        public async Task LoadPersoneData(int personID)
        {
            if (personID==-1)
            {
                _ResetPersonInfo();
                return;
            }

            _apiResult = await _personApiClient.FindByPersonID(personID);

            if (_apiResult.Result != null )
            {
                _FillPersonInfo();
               _personId = personID;
                linlEditPerson.Enabled = true;

            }
            else
            {
                _ResetPersonInfo();
                return;
            }



        }


      

     

        private async void linlEditPerson_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAddEditPerson form = new frmAddEditPerson(_personId);
            form.ShowDialog();

            await LoadPersoneData(_personId);
           
        }






    
    
    
    }

}
