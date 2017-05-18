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
    public partial class ClientScreen : Form
    {
        private string uName, fName, sName;

        private BindingList<string> appointments = new BindingList<string>();
        private BindingList<string> instructorIDs = new BindingList<string>();
        private BindingList<string> instructorNames = new BindingList<string>();
        private BindingList<string> dates = new BindingList<string>();
        private BindingList<string> times = new BindingList<string>();
        private BindingList<string> appID = new BindingList<string>();

        public ClientScreen()
        {
            InitializeComponent();
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

        private void comboBoxInstructor_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateDates();
            UpdateTimes();
        }

        private void comboBoxDate_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateTimes();

        }

        private void buttonBook_Click(object sender, EventArgs e)
        {
            string clientID = uName, appointmentID = appID[comboBoxTime.SelectedIndex];
            try
            {
                SQL.executeQuery("UPDATE appointments SET client_id = '" + clientID+ "' where appointment_id = " + appointmentID);
            }
            catch
            {
                MessageBox.Show("Error with the inputs, please check they are not blank.", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

            UpdateAppointments();
            UpdateDates();
            UpdateTimes();
        }

        private void ClientScreen_Load(object sender, EventArgs e)
        {
            labelID.Text = "Logged in as " + fName + " " + sName + " (" + uName + ")";

            UpdateAppointments();

            SQL.selectQuery("SELECT * from instructors");
            if (SQL.read.HasRows)
            {
                while (SQL.read.Read())
                {
                    instructorIDs.Add(SQL.read[0].ToString());
                    instructorNames.Add(SQL.read[2].ToString() + " " + SQL.read[3].ToString());
                }
            }
            comboBoxInstructor.DataSource = instructorNames;
        }
        public void getInfo(string uname, string fname, string sname)
        {
            uName = uname;
            fName = fname;
            sName = sname;
        }

        private void UpdateDates()
        {
            dates.Clear();
            try
            {
                SQL.selectQuery("SELECT distinct slotDate from appointments where instructor_id like '" + instructorIDs[comboBoxInstructor.SelectedIndex] + "'");
                if (SQL.read.HasRows)
                {
                    while (SQL.read.Read())
                    {
                        dates.Add(SQL.read[0].ToString());
                    }
                }
                comboBoxDate.DataSource = dates;
                comboBoxDate.SelectedIndex = 0;
            }
            catch
            {
            }
        }
        private void UpdateTimes()
        {
            times.Clear();
            appID.Clear();
            try
            {
                SQL.selectQuery("SELECT slotTime, appointment_id from appointments where instructor_id like '" + instructorIDs[comboBoxInstructor.SelectedIndex] +
                    "' and slotDate like '" + dates[comboBoxDate.SelectedIndex] + "' and client_id is null and confirmed = 1");
                if (SQL.read.HasRows)
                {
                    while (SQL.read.Read())
                    {
                        times.Add(SQL.read[0].ToString());
                        appID.Add(SQL.read[1].ToString());
                    }
                }

                comboBoxTime.DataSource = times;
            }
            catch
            {
            }
        }
        private void UpdateAppointments()
        {
            appointments.Clear();
            SQL.selectQuery("SELECT * from appointments where client_id like'" + uName + "'");
            if (SQL.read.HasRows)
            {
                while (SQL.read.Read())
                {
                    appointments.Add(SQL.read[0].ToString() + " " + SQL.read[3].ToString() + " " + SQL.read[4].ToString() + " " + SQL.read[7].ToString());
                }
            }
            listBoxAppointments.DataSource = appointments;
        }
    }
}
