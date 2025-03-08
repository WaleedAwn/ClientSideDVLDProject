using MainDVLD.Globals;
using MainDVLD.People;
using MainDVLD.People.DTOs;
using System;
using System.Buffers;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace MainDVLD.Controls
{
    public partial class ctrlFindByFilter : UserControl
    {

        private PersonApiClient _personApiClient;
       

        public delegate void FilterChangedEventHandler(string columnName, object searchValue);
        public event FilterChangedEventHandler FilterChanged;

  

        //string _columnName = "";
        //object _searchValue;
        enum FilterValue
        {
            None = 0,
            PersonID = 1,
            NationalNo = 2,
            FirstName = 3,
            SecondName = 4,
            ThirdName = 5,
            LastName = 6,
            Address = 7,
            Gendor = 8,
            Phone = 9,
            Email = 10,
            NationalityCountryID = 11

        }


        public ctrlFindByFilter()
        {
            _personApiClient=new PersonApiClient();
           
            InitializeComponent();
        }


        private async void ctrlFindByFilter_Load(object sender, EventArgs e)
        {
            cbFilterPersonData.SelectedIndex = 0;
          
        }


        string GetColumnName(FilterValue filterenum)
        {
            switch (filterenum)
            {
                case FilterValue.None:
                    return "";
                    break;
                case FilterValue.PersonID:
                case FilterValue.NationalNo:
                case FilterValue.FirstName:
                case FilterValue.SecondName:
                case FilterValue.ThirdName:
                case FilterValue.LastName:
                case FilterValue.Address:
                case FilterValue.Gendor:
                case FilterValue.Phone:
                case FilterValue.Email:
                case FilterValue.NationalityCountryID:
                    return filterenum.ToString();
                default:
                    break;
            }
            return "";

        }

        object GetTextBoxValue(TextBox textBox)
        {
            if (cbFilterPersonData.SelectedIndex == 0)
            {
              
                return "";
            }


            if (cbFilterPersonData.SelectedIndex == 1 || cbFilterPersonData.SelectedIndex == 11)
            {
                if (int.TryParse(textBox.Text, out int intValue))
                {
                    return intValue;
                }

                return "";

            }

            if (cbFilterPersonData.SelectedIndex == 8)
            {
                if (textBox.Text.ToLower() == "male" || textBox.Text.ToLower() == "0")
                    return (short)0;
                else if (textBox.Text.ToLower() == "female" || textBox.Text.ToLower() == "1")
                    return (short)1;

                return "";
            }




            return textBox.Text;
        }


        private void tbSearchValue_TextChanged_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbSearchValue.Text) || cbFilterPersonData.SelectedIndex==0) { 
              FilterChanged?.Invoke("", null);
            }
            else
            FilterChanged?.Invoke(GetColumnName((FilterValue)cbFilterPersonData.SelectedIndex), GetTextBoxValue((TextBox)sender));
        
        
        }

        private void cbFilterPersonData_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            
            tbSearchValue.Visible = cbFilterPersonData.SelectedIndex != 0;
            tbSearchValue.Clear();
            

        }

        private void tbSearchValue_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (cbFilterPersonData.SelectedIndex == 1 || cbFilterPersonData.SelectedIndex == 11)
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

            else
            {
                errorProvider1.Clear();
            }

        }
    
    
     
    }


}
