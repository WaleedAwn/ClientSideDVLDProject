using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainDVLD.Users
{
    public partial class frmShowUserDetails : Form
    {
        int _UserID;
        int _PersonID;

        public frmShowUserDetails(int UserId, int PrsonID)
        {
            _UserID = UserId;
            _PersonID = PrsonID;

            InitializeComponent();
           
        }

        private void frmShowUserDetails_Load(object sender, EventArgs e)
        {
           
            

            ctrlPersonCard1.LoadPersoneData(_PersonID);
            ctrlUserLoginInfo1.LoadUserData(_UserID);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
