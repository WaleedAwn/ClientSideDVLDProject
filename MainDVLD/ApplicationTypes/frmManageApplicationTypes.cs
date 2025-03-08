using MainDVLD.Globals;
using MainDVLD.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainDVLD.ApplicationTypes
{
    public partial class frmManageApplicationTypes : Form
    {
        private ApplicationTypesAPIClint _applicationtypes;
        public frmManageApplicationTypes()
        {
            _applicationtypes = new ApplicationTypesAPIClint();
            InitializeComponent();
        }


        async void _RefreshAllApplicationTypes()
        {
            dgvListAllApplicationTypes.Rows.Clear();
            try
            {
                var _apiResult = await _applicationtypes.GetAllApplicationTypes();

                if (_apiResult != null && _apiResult.Result?.Count > 0)
                {
                    foreach (var applicationType in _apiResult.Result)
                    {

                        dgvListAllApplicationTypes.Rows.Add(applicationType.ApplicationTypeID, applicationType.ApplicationTypeTitle,
                            applicationType.ApplicationFees);
                    }
                    lbNumberOFApplicationTypes.Text = _apiResult.Result.Count.ToString();
                }

                else
                {
                    Globals.GlobalFunctions.ShowMessageBox("Error", "There is No Data! This Form Will Closed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {

                Globals.GlobalFunctions.ShowMessageBox("Error", "There is Error on Fetching Data", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }



        }
        private void _loadData()
        {
            _RefreshAllApplicationTypes();
        }
        private void frmManageApplicationTypes_Load(object sender, EventArgs e)
        {
            _loadData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvListAllApplicationTypes.CurrentRow == null)
            {
                GlobalFunctions.ShowMessageBox("No Selection", "No User selected for Updating. Please select a Application Type from the list.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
              
                return;
            }

            try
            {
                Form frm = new frmEditApplicationTypes((int)dgvListAllApplicationTypes.CurrentRow.Cells[0].Value);
                frm.ShowDialog();
                _RefreshAllApplicationTypes();
            }
            catch (Exception ex)
            {
                GlobalFunctions.ShowMessageBox("Error","An error occurred while trying to show the details. Please try again.");
              
            }


        }
    }
}
