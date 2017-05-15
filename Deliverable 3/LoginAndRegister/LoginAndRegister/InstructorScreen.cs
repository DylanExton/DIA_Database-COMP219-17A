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
    public partial class InstructorScreen : Form
    {
        private string uName, fName, sName;
        private BindingList<string> timeslotIDs = new BindingList<string>();
        private List<string> timeslotTimes = new List<string>();
        private List<string> timeslotDates = new List<string>();

        private BindingList<string> bookedDates = new BindingList<string>();
        private BindingList<string> bookedTimes = new BindingList<string>();
        private BindingList<string> bookedCars = new BindingList<string>();
        private BindingList<string> bookedClients = new BindingList<string>();
        private BindingList<string> bookedIDs = new BindingList<string>();
        private BindingList<string> bookedConfirmed = new BindingList<string>();

        private int update = 0;


        public InstructorScreen()
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

        private void comboBoxDates_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedDate = timeslotDates[comboBoxDates.SelectedIndex];
            timeslotTimes.Clear();
            SQL.selectQuery("select distinct slotTime from appointments where slotDate like '" + selectedDate + "' and instructor_id is null ");
            if (SQL.read.HasRows)
            {
                while (SQL.read.Read())
                {
                    timeslotTimes.Add(SQL.read[0].ToString());
                }
            }
            comboBoxTimes.DataSource = timeslotTimes;
            comboBoxTimes.SelectedIndex = 1;
            comboBoxTimes.SelectedIndex = 0;
            
        }


        private void comboBoxTimes_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedTime = timeslotTimes[comboBoxTimes.SelectedIndex];
            string selectedDate = timeslotDates[comboBoxDates.SelectedIndex];
            timeslotIDs.Clear();

            SQL.selectQuery("select slot_id from appointments where slotDate like '" + selectedDate + "' and slotTime like '" + selectedTime + "' and instructor_id is null");
            if (SQL.read.HasRows)
            {
                while (SQL.read.Read())
                {
                    timeslotIDs.Add(SQL.read[0].ToString());
                }
            }
            comboBoxSlots.DataSource = timeslotIDs;
        }

        private void buttonCreateAppointment_Click(object sender, EventArgs e)
        {
            string slotDate, slotTime, slot;
            

            try
            {
                slot = timeslotIDs[comboBoxSlots.SelectedIndex];
                slotDate = timeslotDates[comboBoxDates.SelectedIndex];
                slotTime = timeslotTimes[comboBoxTimes.SelectedIndex];
                SQL.executeQuery("UPDATE appointments SET instructor_id ='"+uName + "' where slotDate like '"+slotDate+"' and slotTime like '"+slotTime+"' and slot_id like "+slot);

                comboBoxTimes.SelectedIndex = 1;
                comboBoxTimes.SelectedIndex = 0;

                bookedCars.Clear();
                bookedClients.Clear();
                bookedConfirmed.Clear();
                bookedDates.Clear();
                bookedIDs.Clear();
                bookedTimes.Clear();

                SQL.selectQuery("SELECT * from appointments where instructor_id like '" + uName+"'");
                if (SQL.read.HasRows)
                {
                    while (SQL.read.Read())
                    {
                        bookedIDs.Add(SQL.read[0].ToString());
                        bookedDates.Add(SQL.read[3].ToString());
                        bookedTimes.Add(SQL.read[4].ToString());
                        bookedCars.Add(SQL.read[6].ToString());
                        bookedClients.Add(SQL.read[5].ToString());
                        bookedConfirmed.Add(SQL.read[8].ToString());
                    }
                }
            }
            catch
            {
                MessageBox.Show("Error, please check the inputs for blanks", "Error",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
            }
        }

        private void buttonDeleteApp_Click(object sender, EventArgs e)
        {
            try
            {
                int i = listBoxAppID.SelectedIndex;
                if (int.Parse(bookedConfirmed[i]) == 1)
                {
                    MessageBox.Show("You cannot delete this appointment, it has been confirmed.", "Confirmed Booking", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return;
                }

                SQL.executeQuery("update appointments set instructor_id = NULL where appointment_id like " + bookedIDs[i]);
            }
            catch
            {
                MessageBox.Show("Nothing left to delete", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

            bookedCars.Clear();
            bookedClients.Clear();
            bookedConfirmed.Clear();
            bookedDates.Clear();
            bookedIDs.Clear();
            bookedTimes.Clear();

            comboBoxTimes.SelectedIndex = 1;
            comboBoxTimes.SelectedIndex = 0;

            SQL.selectQuery("SELECT * from appointments where instructor_id like '" + uName + "'");
            if (SQL.read.HasRows)
            {
                while (SQL.read.Read())
                {
                    bookedIDs.Add(SQL.read[0].ToString());
                    bookedDates.Add(SQL.read[3].ToString());
                    bookedTimes.Add(SQL.read[4].ToString());
                    bookedCars.Add(SQL.read[6].ToString());
                    bookedClients.Add(SQL.read[5].ToString());
                    bookedConfirmed.Add(SQL.read[8].ToString());
                }
            }

            listBoxAppID.DataSource = bookedIDs;
            listBoxCar.DataSource = bookedCars;
            listBoxClient.DataSource = bookedClients;
            listBoxDate.DataSource = bookedDates;
            listBoxTime.DataSource = bookedTimes;
            listBoxConfirmed.DataSource = bookedConfirmed;

        }

        private void listBoxAppID_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = listBoxAppID.SelectedIndex;
            if (i >= 0 && update == 1)
            {
                listBoxCar.SelectedIndex = i;
                listBoxClient.SelectedIndex = i;
                listBoxConfirmed.SelectedIndex = i;
                listBoxDate.SelectedIndex = i;
                listBoxTime.SelectedIndex = i;
            }
        }

        private void listBoxTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = listBoxTime.SelectedIndex;
            if (i >= 0 && update == 1)
            {
                listBoxCar.SelectedIndex = i;
                listBoxClient.SelectedIndex = i;
                listBoxConfirmed.SelectedIndex = i;
                listBoxDate.SelectedIndex = i;
                listBoxAppID.SelectedIndex = i;
            }
        }

        private void listBoxCar_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = listBoxCar.SelectedIndex;
            if (i >= 0 && update == 1)
            {
                listBoxAppID.SelectedIndex = i;
                listBoxClient.SelectedIndex = i;
                listBoxConfirmed.SelectedIndex = i;
                listBoxDate.SelectedIndex = i;
                listBoxTime.SelectedIndex = i;
            }
        }

        private void listBoxClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = listBoxClient.SelectedIndex;
            if (i >= 0 && update == 1)
            {
                listBoxCar.SelectedIndex = i;
                listBoxAppID.SelectedIndex = i;
                listBoxConfirmed.SelectedIndex = i;
                listBoxDate.SelectedIndex = i;
                listBoxTime.SelectedIndex = i;
            }
        }

        private void listBoxConfirmed_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = listBoxConfirmed.SelectedIndex;
            if (i >= 0 && update == 1)
            {
                listBoxCar.SelectedIndex = i;
                listBoxClient.SelectedIndex = i;
                listBoxAppID.SelectedIndex = i;
                listBoxDate.SelectedIndex = i;
                listBoxTime.SelectedIndex = i;
            }
        }

        private void listBoxDate_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = listBoxDate.SelectedIndex;
            if (i >= 0 && update == 1)
            {
                listBoxCar.SelectedIndex = i;
                listBoxClient.SelectedIndex = i;
                listBoxConfirmed.SelectedIndex = i;
                listBoxAppID.SelectedIndex = i;
                listBoxTime.SelectedIndex = i;
            }
        }

        private void InstructorScreen_Load(object sender, EventArgs e)
        {
            //Update the label to show whos logged in to the screen
            labelID.Text = "Logged in as " + fName + " " + sName + " (" + uName + ")";
            //Get the available Timeslots
            SQL.selectQuery("select distinct slotDate from appointments");
            if (SQL.read.HasRows)
            {
                while (SQL.read.Read())
                {
                    timeslotDates.Add(SQL.read[0].ToString());

                }
            }
            timeslotDates.Sort();
            comboBoxDates.DataSource = timeslotDates;

            SQL.selectQuery("SELECT * from appointments where instructor_id like '" + uName + "'");
            if (SQL.read.HasRows)
            {
                while (SQL.read.Read())
                {
                    bookedIDs.Add(SQL.read[0].ToString());
                    bookedDates.Add(SQL.read[3].ToString());
                    bookedTimes.Add(SQL.read[4].ToString());
                    bookedCars.Add(SQL.read[6].ToString());
                    bookedClients.Add(SQL.read[5].ToString());
                    bookedConfirmed.Add(SQL.read[8].ToString());
                }
            }

            listBoxAppID.DataSource = bookedIDs;
            listBoxCar.DataSource = bookedCars;
            listBoxClient.DataSource = bookedClients;
            listBoxDate.DataSource = bookedDates;
            listBoxTime.DataSource = bookedTimes;
            listBoxConfirmed.DataSource = bookedConfirmed;

            update = 1;
        }

        public void getInfo(string uname, string fname, string sname)
        {
            uName = uname;
            fName = fname;
            sName = sname;
        }
    }
}
