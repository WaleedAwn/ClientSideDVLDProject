using MainDVLD.ApplicationTypes;
using MainDVLD.People;
using MainDVLD.Users;
using System.Reflection;


namespace MainDVLD
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void peopleToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form frm = new frmManagePeople();
            frm.ShowDialog();


        }



        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Form frm = new frmManageUsers();
            frm.ShowDialog();
        }

        private async void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Globals.UserLoginInfo.CurrentUser = null;
            this.Close();


        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmChangeUserPassword(Globals.UserLoginInfo.CurrentUser.UserID, Globals.UserLoginInfo.CurrentUser.PersonID);
            frm.ShowDialog();

        }

        private void currentUserInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmShowUserDetails(Globals.UserLoginInfo.CurrentUser.UserID, Globals.UserLoginInfo.CurrentUser.PersonID);
            frm.ShowDialog();

        }

        private void frmMain_Load(object sender, EventArgs e)
        {

            panel1.BackgroundImage=Image.FromFile("D:\\AbouHadhoud Courses\\DVLD Project Course19 API\\Icons\\Icons\\wallpaper.jpg");

        }

        private void drivingLicensesServicesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("WA drivingLicensesServices Will be here", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        private void manageApplicationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("manageApplications Will be here", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }

        private void detainLicensesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("detainLicenses Will be here", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }

        private void manageApplicationTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
           Form frm =new frmManageApplicationTypes();
            frm.ShowDialog();
        }

        private void manageTestTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("manageTestTypes Will be here", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }
    }
}
