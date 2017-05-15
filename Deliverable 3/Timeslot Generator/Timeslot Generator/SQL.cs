using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Timeslot_Generator
{
    class SQL
    {
        //Creates a conneection to the database
        public static SqlConnection con = new SqlConnection(@"Data Source=np:\\.\pipe\LOCALDB#21501B51\tsql\query;Database=master;Integrated Security=True");
        public static SqlCommand cmd = new SqlCommand();
        public static SqlDataReader read;

        /// <summary>
        /// Executes the query provided in the database
        /// used when we don't need to read anything from the database,
        /// just insert, delete or update the database
        /// </summary>
        /// <param name="q"></param>
        public static void executeQuery(string q)
        {
            try
            {
                con.Close();            //Closes the current connection 
                cmd.Connection = con;   //sets the commands connection to the SQL connection
                con.Open();             //Re-opens the connection
                cmd.CommandText = q;    //Send the query text through to the command in the database
                cmd.ExecuteNonQuery();  //Executes the command
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "An Error Has Occured", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }
        }

        /// <summary>
        /// Is used for the select SQL queries
        /// </summary>
        /// <param name="q"></param>
        public static void selectQuery(string q)
        {
            try
            {
                con.Close();
                cmd.Connection = con;
                con.Open();
                cmd.CommandText = q;
                read = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "An Error Has Occured", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }
        }
    }
}
