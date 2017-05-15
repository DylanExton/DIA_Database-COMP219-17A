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
  public partial class Login : Form
  {

        //list that hold the possible user types
        List<string> accounts = new List<string>();
        public static string username;

        /// <summary>
        /// Initialises the form, and creates the list of possible user types
        /// </summary>
        public Login()
    {
            InitializeComponent();
            accounts.Add("adminStaff");
            accounts.Add("instructors");
            accounts.Add("clients");
            
    }

        /// <summary>
        /// Checks the login against the applicable fields 
        /// The displays whether the user has been logged in and their account type
        /// the username and password is checked automatically by the system across all of the account types (the likliness of an instructor and client having the same credentials is miniscule)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butLogin_Click(object sender, EventArgs e)
    {
            //
            string username = "", password = "", firstname = "", lastname = "", userType = "";
            bool loginSuccessful = false;
            int count = 0;
            try
            {
                //Get the users input from the textboxes
                username = textBoxUsername.Text.Trim();
                password = textBoxPassword.Text.Trim();
                


            }
            //Shows the error message
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //check over each of the account types until either the username and password is found, or there is no match
            for(int i = 0;i < accounts.Count;i++) {
            //select the user type to check
            userType = accounts[i];
                count = i;
            //get the data from the database
            SQL.selectQuery("Select * from  " + userType);
                //if there is data
                if (SQL.read.HasRows)
                {
                    //while there is data to be read
                    while (SQL.read.Read())
                    {
                        //check the username and password agains that row of data that has been read
                        if (username.Equals(SQL.read[0].ToString()) && password.Equals(SQL.read[1].ToString()))
                        {
                            loginSuccessful = true;
                            firstname = SQL.read[2].ToString();
                            lastname = SQL.read[3].ToString();
                            break;
                        }
                    }
                }
                //if it is found, stop looking
                if (loginSuccessful) break;
            }
            //if there was a successful login, show the message box with the users name and account type    
          if (loginSuccessful)
            {
                if (userType.Equals("clients")) userType = "Client";
                else if(userType.Equals("adminStaff")) userType = "Administrator";
                else if (userType.Equals("instructors")) userType = "Instructor";
                MessageBox.Show("Hello " + firstname + " " + lastname + ". You are now logged in as a " + userType, "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Show the next screen for the right person
                if (userType == "Administrator")
                {
                    //Send the username across to the next form

                    //Show the administrators screen
                    this.Hide();
                    AdminScreen ad = new AdminScreen();
                    ad. getInfo(username, firstname, lastname);
                    ad.ShowDialog();
                    this.Close();
                }
                else if(userType == "Instructor")
                {   //Send the username over to the next form

                    //Show the instructors screen
                    this.Hide();
                    InstructorScreen ins = new InstructorScreen();
                    ins.getInfo(username, firstname, lastname);
                    ins.ShowDialog();
                    this.Close();
                }
                else
                {
                    //send the username over to the next form

                    //Show the clients screen
                    this.Hide();
                    ClientScreen cli = new ClientScreen();
                    cli.getInfo(username, firstname, lastname);
                    cli.ShowDialog();
                    this.Close();
                }
            }
          //if there was no successful login, show a message box says so
            else
            {
                MessageBox.Show("Login attempt unsuccessful! Please check details");
                textBoxUsername.Focus();
                return;
            }
    }
        /// <summary>
        /// Clears the textboxes and returns focus t the username box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
    private void butClear_Click(object sender, EventArgs e)
    {
      textBoxPassword.Clear();
      textBoxUsername.Clear();
      textBoxUsername.Focus();
    }
    /// <summary>
    /// Takes the user to the register page
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void lnkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      this.Hide();
      Register reg = new Register();
      reg.ShowDialog();
      this.Close();
    }
    }
}
