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
            InitializeComponent();

        }


        private void ctrlFindByFilter_Load(object sender, EventArgs e)
        {
            cbFilterPersonData.SelectedIndex = 0;
        }


        //private void SetFilterInfo()
        //{

        //     tbSearchValue.Visible = cbFilterPersonData.SelectedIndex != 0;
        //    _columnName = cbFilterPersonData.Text;

        //    switch (cbFilterPersonData.SelectedIndex)
        //    {
        //        case 0: // No filter
        //            _columnName = "";
        //            tbSearchValue.Clear();
        //            _searchValue = null;
        //            break;

        //        case 1: // Integer-based filters (e.g., PersonID)
        //        case 8:
        //        case 11:
        //            if (int.TryParse(tbSearchValue.Text, out int intValue))
        //            {
        //                _searchValue = intValue;
        //            }
        //            else
        //            {
        //                _searchValue = null; // Reset if invalid input
        //                //ShowValidationError("Please enter a valid integer.");
        //            }
        //            break;

        //        default: // String-based filters
        //            _searchValue = tbSearchValue.Text;
        //            break;
        //    }

        //}


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

        private void cbFilterPersonData_SelectedIndexChanged(object sender, EventArgs e)
        {
            //SetFilterInfo();


            tbSearchValue.Visible = cbFilterPersonData.SelectedIndex != 0;

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
                    errorProvider1.SetError(tbSearchValue,"You Should Enter Numbers");

                    return intValue;
                }

                return "";

            }
            if (cbFilterPersonData.SelectedIndex == 8)
            {
                if (short.TryParse(textBox.Text, out short shortValue))
                    return shortValue;

                return "";
            }




            return textBox.Text;
        }
        private void tbSearchValue_TextChanged(object sender, EventArgs e)
        {
            FilterChanged?.Invoke(GetColumnName((FilterValue)cbFilterPersonData.SelectedIndex), GetTextBoxValue((TextBox)sender));
        }

       
    }


}
