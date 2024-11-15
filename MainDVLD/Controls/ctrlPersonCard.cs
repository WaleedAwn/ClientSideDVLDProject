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

      public  int _personId;
        public ctrlPersonCard()
        {
            InitializeComponent();
            _apiResult = new ApiResult<PersonsDTO>();
            _personApiClient = new PersonApiClient();
        }



        private void _FillPersonInfo()
        {


            _personId = _apiResult.Result.PersonID;

            lbPersonID.Text = _apiResult.Result.PersonID.ToString();
            lbNationalNo.Text = _apiResult.Result.NationalNo;
            lbPersonName.Text = GlobalFunctions.CombineFullName(_apiResult.Result.FirstName, _apiResult.Result.SecondName, _apiResult.Result.ThirdName, _apiResult.Result.LastName);

            lbgender.Text = GlobalFunctions.GetGender(_apiResult.Result.Gendor);
            lbEmail.Text = _apiResult.Result.Email.ToString();
            lbAdress.Text = _apiResult.Result.Address.ToString();

            lbDateOfBrith.Text = GlobalFunctions.FormattedDateOfBirth(_apiResult.Result.DateOfBirth);
            lbPhone.Text = _apiResult.Result.Phone.ToString();
            lbCountry.Text = _apiResult.Result.NationalityCountryID.ToString();
            if (_apiResult.Result.ImagePath != "")
            {

                pbPersonImage.Load(_apiResult.Result.ImagePath);
            }



        }


        public async Task LoadPersoneData(int personID)
        {
            _apiResult = await _personApiClient.FindByPersonID(personID);

            if (_apiResult != null)
            {
                _FillPersonInfo();

            }
            else
            {
                return;
            }



        }


        private void gbctrlPersonCard_Enter_1(object sender, EventArgs e)
        {


        }

        private void linlEditPerson_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form form = new frmAddEditPerson(_personId);
            form.ShowDialog();
           
        }
    }
}
