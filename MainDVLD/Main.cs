using MainDVLD.People;

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
            Form frm =new frmManagePeople();
            frm.ShowDialog();


        }
    }
}
