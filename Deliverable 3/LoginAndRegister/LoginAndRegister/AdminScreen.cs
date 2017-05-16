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

        private int update = 0;

        private BindingList<string> instructors = new BindingList<string>();
        private BindingList<string> instructorID = new BindingList<string>();
        private BindingList<string> cars2 = new BindingList<string>();
        private BindingList<string> cars = new BindingList<string>();
        private BindingList<string> carID = new BindingList<string>();
        private BindingList<string> carID2 = new BindingList<string>();
        private BindingList<string> appID = new BindingList<string>();
        private BindingList<string> appDate = new BindingList<string>();
        private BindingList<string> appTime = new BindingList<string>();
        private BindingList<string> appInstructors = new BindingList<string>();
        private BindingList<string> appClient = new BindingList<string>();
        private BindingList<string> appCar = new BindingList<string>();
        private BindingList<string> coveredDays = new BindingList<string>();
        private BindingList<string> notCoveredDays = new BindingList<string>();

        public AdminScreen()
        {
            InitializeComponent();
        }

        private void AdminScreen_Load(object sender, EventArgs e)
        {
            labelID.Text = "Logged in as " + fName + " " + sName + " (" + uName + ")";

            //Get the information
            //Instructors
            SQL.selectQuery("SELECT * from instructors");
            if (SQL.read.HasRows)
            {
                while (SQL.read.Read())
                {
                    instructors.Add(SQL.read[2].ToString() + " " + SQL.read[3].ToString());
                    instructorID.Add(SQL.read[0].ToString());
                }
            }
            comboBoxInstructor.DataSource = instructors;
            //Cars
            SQL.selectQuery("SELECT * from cars");
            if (SQL.read.HasRows)
            {
                while (SQL.read.Read())
                {
                    cars.Add(SQL.read[1].ToString() + " | " + SQL.read[0].ToString());
                    cars2.Add(SQL.read[1].ToString() + " | " + SQL.read[0].ToString());
                    carID.Add(SQL.read[0].ToString());
                    carID2.Add(SQL.read[0].ToString());
                }
            }
            comboBoxCar.DataSource = cars;
            comboBoxSpare.DataSource = cars2;
            //Appointments
            SQL.selectQuery("SELECT * from appointments where confirmed = 0 and instructor_id is not null");
            if (SQL.read.HasRows)
            {
                while (SQL.read.Read())
                {
                    appID.Add(SQL.read[0].ToString());
                    appDate.Add(SQL.read[3].ToString());
                    appTime.Add(SQL.read[4].ToString());
                    appClient.Add(SQL.read[5].ToString());
                    appInstructors.Add(SQL.read[7].ToString());
                    appCar.Add(SQL.read[6].ToString());
                }
            }
            listBoxAppID.DataSource = appID;
            listBoxCar.DataSource = appCar;
            listBoxClient.DataSource = appClient;
            listBoxDate.DataSource = appDate;
            listBoxInstructor.DataSource = appInstructors;
            listBoxTime.DataSource = appTime;

            update = 1;
        }

        private void buttonAssignCar_Click(object sender, EventArgs e)
        {
            int carId = comboBoxCar.SelectedIndex;
            int instID = comboBoxInstructor.SelectedIndex;
            string car = carID[carId];
            string username = instructorID[instID];
            SQL.executeQuery("UPDATE appointments set car_id = '" + car + "' where instructor_id like '" + username + "'");
            update = 0;
            appID.Clear();
            appInstructors.Clear();
            appClient.Clear();
            appCar.Clear();
            appDate.Clear();
            appTime.Clear();
            SQL.selectQuery("SELECT * from appointments where confirmed = 0 and instructor_id is not null");
            if (SQL.read.HasRows)
            {
                while (SQL.read.Read())
                {
                    appID.Add(SQL.read[0].ToString());
                    appDate.Add(SQL.read[3].ToString());
                    appTime.Add(SQL.read[4].ToString());
                    appClient.Add(SQL.read[5].ToString());
                    appInstructors.Add(SQL.read[7].ToString());
                    appCar.Add(SQL.read[6].ToString());
                }
            }
            listBoxAppID.DataSource = appID;
            listBoxCar.DataSource = appCar;
            listBoxClient.DataSource = appClient;
            listBoxDate.DataSource = appDate;
            listBoxInstructor.DataSource = appInstructors;
            listBoxTime.DataSource = appTime;
            update = 1;
        }

        private void buttonSpare_Click(object sender, EventArgs e)
        {
            string carId = carID2[comboBoxSpare.SelectedIndex];
            SQL.executeQuery("UPDATE cars set spare = 0");
            SQL.executeQuery("UPDATE cars set spare = 1 where licence_no like '" + carId + "'");
            cars.Clear();
            carID.Clear();
            SQL.selectQuery("SELECT * from cars");
            if (SQL.read.HasRows)
            {
                while (SQL.read.Read())
                {
                    if (SQL.read[2].ToString() != "1")
                    {
                        cars.Add(SQL.read[1].ToString() + " | " + SQL.read[0].ToString());
                        carID.Add(SQL.read[0].ToString());
                    }
                }
            }
        }

        private void buttonConfirmApp_Click(object sender, EventArgs e)
        {
            string appid = appID[listBoxAppID.SelectedIndex];
            if (appCar[listBoxCar.SelectedIndex] != "")
            {
                SQL.executeQuery("UPDATE appointments SET confirmed = 1 where appointment_id like " + appid);

                update = 0;
                appID.Clear();
                appInstructors.Clear();
                appClient.Clear();
                appCar.Clear();
                appDate.Clear();
                appTime.Clear();
                SQL.selectQuery("SELECT * from appointments where confirmed = 0 and instructor_id is not null");
                if (SQL.read.HasRows)
                {
                    while (SQL.read.Read())
                    {
                        appID.Add(SQL.read[0].ToString());
                        appDate.Add(SQL.read[3].ToString());
                        appTime.Add(SQL.read[4].ToString());
                        appClient.Add(SQL.read[5].ToString());
                        appInstructors.Add(SQL.read[7].ToString());
                        appCar.Add(SQL.read[6].ToString());
                    }
                }
                listBoxAppID.DataSource = appID;
                listBoxCar.DataSource = appCar;
                listBoxClient.DataSource = appClient;
                listBoxDate.DataSource = appDate;
                listBoxInstructor.DataSource = appInstructors;
                listBoxTime.DataSource = appTime;
                update = 1;
            }
            else
            {
                MessageBox.Show("Please check that this appointment has a car assigned to it.", "Assigment Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

        }

        private void listBoxAppID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(update == 1) { 
            int i = listBoxAppID.SelectedIndex;
                foreach (Control c in this.Controls)
                {
                    if (c.GetType() == typeof(System.Windows.Forms.ListBox))
                    {
                        ListBox s = c as ListBox;
                        if (s.Name != "listBoxCoveredDays" && s.Name != "listBoxNotCoveredDays")
                            s.SelectedIndex = i;
                    }
                }
            }
        }

        private void listBoxDate_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (update == 1)
            {
                int i = listBoxDate.SelectedIndex;
                foreach (Control c in this.Controls)
                {
                    if (c.GetType() == typeof(System.Windows.Forms.ListBox))
                    {
                        ListBox s = c as ListBox;
                        if (s.Name != "listBoxCoveredDays" && s.Name != "listBoxNotCoveredDays")
                            s.SelectedIndex = i;
                    }
                }
            }
        }
    

        private void listBoxTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (update == 1)
            {
                int i = listBoxTime.SelectedIndex;
                foreach (Control c in this.Controls)
                {
                    if (c.GetType() == typeof(System.Windows.Forms.ListBox))
                    {
                        ListBox s = c as ListBox;
                        if(s.Name != "listBoxCoveredDays" && s.Name != "listBoxNotCoveredDays")
                            s.SelectedIndex = i;
                    }
                }
            }
        }

        private void listBoxInstructor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (update == 1)
            {
                int i = listBoxInstructor.SelectedIndex;
                foreach (Control c in this.Controls)
                {
                    if (c.GetType() == typeof(System.Windows.Forms.ListBox))
                    {
                        ListBox s = c as ListBox;
                        if (s.Name != "listBoxCoveredDays" && s.Name != "listBoxNotCoveredDays")
                            s.SelectedIndex = i;
                    }
                }
            }
        }

        private void listBoxClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (update == 1)
            {
                int i = listBoxClient.SelectedIndex;
                foreach (Control c in this.Controls)
                {
                    if (c.GetType() == typeof(System.Windows.Forms.ListBox))
                    {
                        ListBox s = c as ListBox;
                        if (s.Name != "listBoxCoveredDays" && s.Name != "listBoxNotCoveredDays")
                            s.SelectedIndex = i;
                    }
                }
            }
        }

        private void listBoxCar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (update == 1)
            {
                int i = listBoxCar.SelectedIndex;
                foreach (Control c in this.Controls)
                {
                    if (c.GetType() == typeof(System.Windows.Forms.ListBox))
                    {
                        ListBox s = c as ListBox;
                        if (s.Name != "listBoxCoveredDays" && s.Name != "listBoxNotCoveredDays")
                            s.SelectedIndex = i;
                    }
                }
            }
        }

        private void buttonCheckHours_Click(object sender, EventArgs e)
        {
            List<string> confirmedTime = new List<string>();
            List<string> dates = new List<string>();

            SQL.selectQuery("Select distinct slotDate from appointments");
            if (SQL.read.HasRows)
            {
                while (SQL.read.Read())
                {
                    dates.Add(SQL.read[0].ToString());
                }
            }
            dates.Sort();
            coveredDays.Clear();
            notCoveredDays.Clear();
            listBoxCoveredDays.DataSource = null;
            listBoxNotCoveredDays.DataSource = null;
            foreach (string date in dates)
            {
               confirmedTime.Clear();
               SQL.selectQuery("SELECT distinct slotTime from appointments where confirmed = 1 and slotDate like '"+date+"'");
                if (SQL.read.HasRows)
                {
                    while (SQL.read.Read())
                    {
                        confirmedTime.Add(SQL.read[0].ToString());
                    }
                }
                if (confirmedTime.Count() >= 12)
                {
                    coveredDays.Add(date);
                }
                else
                {
                    notCoveredDays.Add(date);
                }
            }
                listBoxCoveredDays.DataSource = coveredDays;
                listBoxNotCoveredDays.DataSource = notCoveredDays;
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
