using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MainDVLD.Countries;

namespace MainDVLD.Globals
{
    public class Validation
    {
        //public static void OnlyNumbers_KeyPress(ErrorProvider errorProvider,object sender, KeyPressEventArgs e )
        //{
        //    if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
        //    {
        //        errorProvider.SetError((TextBox)sender, "You should only enter numbers.");
        //        System.Media.SystemSounds.Beep.Play();
        //        e.Handled = true;
        //    }
        //    else
        //    {
        //        errorProvider.Clear();
        //    }

        //}
      
        
        //public static bool ValidateTextField(ErrorProvider errorProvider, TextBox textBox, string errorMessage, bool allowEmpty = false)
        //{
        //    if (string.IsNullOrWhiteSpace(textBox.Text))
        //    {
        //        if (!allowEmpty)
        //        {
        //            errorProvider.SetError(textBox, errorMessage);
        //            return false;
        //        }
        //    }
        //    else
        //    {
        //        errorProvider.SetError(textBox, "");
        //    }
        //    return true;

        //}
       
        
        public static bool OnlyNumbers_KeyPress(object sender, KeyPressEventArgs e)
        {
            return !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
           
        }


        public static bool ValidateTextField(TextBox textBox, bool allowEmpty = false)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                if (allowEmpty)
                {
                    return true;
                }
                return false;
            }
           
            return true;

        }

        public static bool OnlyPositiveNumbers(decimal number)
        { return number > 0;
        }







    }
    public class GlobalFunctions
    {
       public static string FormattedDateOfBirth(DateTime date)
        {
            return date.ToString("dd-MM-yyyy");
        }
        public static string GetGender(short gend)
        {
            return gend == 0 ? "Male" : "Female";
        }
       
        public static string CombineFullName(string f, string S, string Th, string L)
        {
            return f + " " + S + " " + Th + " " + L;
        }

       
            public static void ShowMessageBox(string title, string message, MessageBoxButtons button= MessageBoxButtons.OK, MessageBoxIcon icon= MessageBoxIcon.Error) {
            MessageBox.Show(message,title, button, icon);
        }

    }


}
