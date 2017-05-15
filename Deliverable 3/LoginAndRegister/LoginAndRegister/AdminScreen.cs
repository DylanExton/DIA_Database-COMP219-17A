using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginAndRegister
{
    public partial class AdminScreen : Form
    {
        private string uName, fName, sName;
        public AdminScreen()
        {
            InitializeComponent();
        }

        private void AdminScreen_Load(object sender, EventArgs e)
        {
            labelID.Text = "Logged in as " + fName + " " + sName + " (" + uName + ")"; ;
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            DialogResult sure = MessageBox.Show("Are you sure you want to logout?", "Logout Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);
            if (sure == DialogResult.Yes)
            {
                this.Hide();
                Login log = new Login();
                log.ShowDialog();
                this.Close();
            }
        }
        public void getInfo(string uname, string fname, string sname)
        {
            uName = uname;
            fName = fname;
            sName = sname;
        }
    }
}
