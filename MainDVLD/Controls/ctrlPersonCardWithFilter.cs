using MainDVLD.Globals;
using MainDVLD.People;
using MainDVLD.People.DTOs;
using MainDVLD.Users;
using MainDVLD.Users.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace MainDVLD.Controls
{
    public partial class ctrlPersonCardWithFilter : UserControl
    {


        private PersonApiClient _personData;

        private ApiResult<List<PersonsDTO>> _PersonResultDto;

        public int PersonID = -1;

        public ctrlPersonCardWithFilter()
        {
            _personData = new PersonApiClient();
            InitializeComponent();
        }


      

        private void cbFilterPersonData_SelectedIndexChanged(object sender, EventArgs e)
        { 
            tbSearchValue.Clear();
        }

        // Update this to Not Use PersonDTO
        PersonsDTO GetTextBoxValue(MaskedTextBox textBox)
        {
            PersonID = -1;
            PersonsDTO personsDTO = new PersonsDTO();

            if (cbFilterPersonData.SelectedIndex == 0)
            {
                if (int.TryParse(textBox.Text, out int intValue))
                {
                    personsDTO.PersonID = intValue;
                }
                else
                {
                   
                    personsDTO.PersonID = -1;

                }
            }

            else if (cbFilterPersonData.SelectedIndex == 1)
                personsDTO.NationalNo = textBox.Text;
            return personsDTO;

        }

        int FilterOperation(List<PersonsDTO> personList, PersonsDTO value)
        {
            // Validate inputs
            if (cbFilterPersonData == null || personList == null || value == null)
                return -1;
            // Select the filtering criteria
            Func<PersonsDTO, bool> filterCriteria = cbFilterPersonData.SelectedIndex switch
            {
                0 => x => x.PersonID == value.PersonID,      // Filter by PersonID
                1 => x => x.NationalNo == value.NationalNo,  // Filter by NationalNo
                _ => null                                    // Invalid selection
            };

            // If invalid selection, return -1
            if (filterCriteria == null)
                return -1;

            // Find the person based on the criteria
            var person = personList.FirstOrDefault(filterCriteria);

            // Return the PersonID if found, otherwise -1
            return person?.PersonID ?? -1;
        }


        private async void btnSearchPerson_Click(object sender, EventArgs e)
        {

            if (_PersonResultDto.Result != null)
            {
                PersonID = FilterOperation(_PersonResultDto.Result, GetTextBoxValue(tbSearchValue));
             
                if (PersonID != -1)
                {
                    var IsPersonExistAsUser = await UserAPiClient.IsPersonExistAsUser(PersonID);

                    if (IsPersonExistAsUser.Result)
                    {
                        ctrlPersonCard1?.LoadPersoneData(-1);
                        MessageBox.Show(" This Person was add as user before","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        return;
                    }
                    else
                    ctrlPersonCard1?.LoadPersoneData(PersonID);
                }
                else
                {
                    ctrlPersonCard1?.LoadPersoneData(-1);
                    MessageBox.Show("No Person Found ");
                }

            }
            else
            {
                MessageBox.Show("Error On Fetching  Person Data ");
            }

        }

        private async void ctrlPersonCardWithFilter_Load(object sender, EventArgs e)
        {
            _PersonResultDto = await _personData.GetAllPeople();
            cbFilterPersonData.SelectedIndex = 0;
        }



        public void LoadPersonData(int personID)
        {
            ctrlPersonCard1.LoadPersoneData(personID);
        }

        public void DisableGroupBoxFilter(int personID)
        {
            if (personID!=-1)
            {
                cbFilterPersonData.SelectedIndex = 0;
                tbSearchValue.Text = personID.ToString();

                gbFilterBox.Enabled = false;
            }
          
        }


        private void tbSearchValue_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (cbFilterPersonData.SelectedIndex == 0)
            {

                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
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
        
        
        }

        //Delegate

        private void btnAddNewPerson_Click(object sender, EventArgs e)
        {
            frmAddEditPerson frm = new frmAddEditPerson(-1);

            frm.DataBack += Form2_Datback; // Subscribe to the Event that found in the Form2
            frm.ShowDialog();
            ctrlPersonCard1?.LoadPersoneData(PersonID);
            DisableGroupBoxFilter(PersonID);

        }
        private void Form2_Datback(object sender, int personid)
        {
            PersonID = personid;


        }
       
    }
}
