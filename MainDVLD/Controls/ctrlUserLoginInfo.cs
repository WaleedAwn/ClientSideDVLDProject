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
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainDVLD.Controls
{
    public partial class ctrlUserLoginInfo : UserControl
    {
        private ApiResult<UsersDTO> _apiResult;

        private UserAPiClient _UserAPiClient;
        public ctrlUserLoginInfo()
        {
            _UserAPiClient = new UserAPiClient();
            _apiResult = new ApiResult<UsersDTO>();
            InitializeComponent();
        }

        private void _FillUserInfo()
        {

            lbUserID.Text = _apiResult.Result?.UserID.ToString();
            lbUserName.Text = _apiResult.Result?.UserName.ToString();
            if (_apiResult.Result.IsActive)

                lbIsActive.Text = "Yes";
            else
                lbIsActive.Text = "No";
        }


        public async Task LoadUserData(int UserID)
        {
            _apiResult = await _UserAPiClient.FindByUserID(UserID);

            if (_apiResult != null)
            {
                _FillUserInfo();

            }
            else
            {
                return;
            }



        }


        private void ctrlUserLoginInfo_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
