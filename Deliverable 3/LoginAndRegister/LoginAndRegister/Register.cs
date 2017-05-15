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
  public partial class Register : Form
  {
    //Creates the list that hold the driver types
    List<string> types = new List<string>();
        //Create the account types list to allow the usert to select their account type to register
        List<string> accountType = new List<string>();
    public Register()
    {
      InitializeComponent();
            types.Add("New");
            types.Add("Experienced");
            types.Add("Not Applicable");
            accountType.Add("Client");
            accountType.Add("Administrator");
            accountType.Add("Instructor");
            comboBoxType.DataSource = types;
            comboBoxAccountType.DataSource = accountType;
            textBoxPassword1.PasswordChar = '*';
            textBoxPassword1.MaxLength = 16;
            textBoxPassword2.PasswordChar = '*';
            textBoxPassword2.MaxLength = 16;
        }
        /// <summary>
        /// This will take the user back to the login screen
        /// if they don't want to register or already have an account
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lnkLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Login log = new Login();
            log.ShowDialog();
            this.Close();
        }
        /// <summary>
        /// Allows the users to register as clients to the database.
        /// Gets the information they have ebtered in the registration form and sends it to the database where it is stored.
        /// Any error are handled nicely.
        /// Also makes sure there is data in all of the fields as this is needed for the DIA
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonRegister_Click(object sender, EventArgs e)
        {
            //Creates variables used to store all of the users input from the registration form
            string username = "", password = "", password2 = "", firstname = "", lastname = "", email = "", phone = "", drivertype = "", account = "";
            //Check that all of the textboxes have data in them
            if (!hasText())
            {
                //If there is no data in one or more text box, display a message and return
                MessageBox.Show("Please make sure all fields are filled in correctly");
                textBoxUsername.Focus();
                return;
            }
            //Using a try catch as users input may be invalid
            try
            {
                //Get all of the data from  the textboxes
                username = textBoxUsername.Text.Trim();
                password = textBoxPassword1.Text.Trim();
                password2 = textBoxPassword2.Text.Trim();
                firstname = textBoxFName.Text.Trim();
                lastname = textBoxLName.Text.Trim();
                email = textBoxEmail.Text.Trim();
                phone = textBoxPhone.Text.Trim();
                account = accountType[comboBoxAccountType.SelectedIndex].ToString();
                drivertype = types[comboBoxType.SelectedIndex].ToString();

                //Check to see if the passwords match, if not then display a message telling them,
                //Clear the textboxes and refocus on the first password textbox
                if (!password.Equals(password2))
                {
                    MessageBox.Show("Passwords do not match!", "Password Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBoxPassword1.Clear();
                    textBoxPassword2.Clear();
                    textBoxPassword1.Focus();
                    return;
                }

            }
            //if the input is in the wrong format then catch it here
            catch
            {
                MessageBox.Show("Error: input in the wrong format", "Oops, an error has occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //send the users input to the database
            try
            {
                //Check which table to add the user to
                if (account == "Client")
                    SQL.executeQuery("INSERT INTO clients VALUES('" + username + "','" + password + "','" + firstname + "','" + lastname + "','" + email + "','" + phone + "','" + drivertype + "')");
                else if (account == "Instructor")
                    SQL.executeQuery("insert into instructors values('" + username + "','" + password + "','" + firstname + "','" + lastname + "','" + email + "','" + phone + "')");
                else if (account == "Administrator")
                    SQL.executeQuery("insert into adminStaff values('" + username + "','" + password + "','" + firstname + "','" + lastname + "','" + email + "')");
                else MessageBox.Show("Please select an account type", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
            }
            //If there is an error wit the data being sent to the database 
            catch
            {
                MessageBox.Show("Input doesn't match the database input structure", "Oops, an error has occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //This is only show if the user successfully registers as all the other options have a return, so will terminate before this point
            MessageBox.Show("Thank-you " + firstname + " " + lastname + " for registering, yor registration was successful under the username " + username ,
                "Successful Registeration!", MessageBoxButtons.OK,MessageBoxIcon.Information);

            //Takes the user back to the login screen for them to login using the account they just created
            this.Hide();
            Login log = new Login();
            log.ShowDialog();
            this.Close();

        }

        /// <summary>
        /// Checks whether all of the textboxes have data in them
        /// </summary>
        /// <returns></returns>
        private bool hasText()
        {
            bool hasData = true;
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    if ("".Equals((c as TextBox).Text.Trim()))
                    {
                        hasData = false;
                    }
                }
            }
            return hasData;
        }

        /// <summary>
        /// Clears all of the textboxes in the form
        /// </summary>
        private void clearTextboxes()
        {
            foreach(Control t in this.Controls)
            {
                if (t is TextBox)
                    (t as TextBox).Clear();
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            clearTextboxes();
        }

        private void comboBoxAccountType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string type = accountType[comboBoxAccountType.SelectedIndex].ToString();

            if(type != "Client")
            {
                comboBoxType.SelectedIndex = 2;
                comboBoxType.Enabled = false;
            }
            else
            {
                comboBoxType.Enabled = true;
            }
        }
    }
    }

