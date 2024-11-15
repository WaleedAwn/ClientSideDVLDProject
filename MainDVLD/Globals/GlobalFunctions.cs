using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainDVLD.Globals
{
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



    }
}
