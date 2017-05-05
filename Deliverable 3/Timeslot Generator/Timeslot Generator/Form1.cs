using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timeslot_Generator
{
    public partial class Form1 : Form
    {
        //CONSTANTS
        int minHour = 7, maxHour = 19, minDay = 1, maxDay = 31;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ID can be between 1 to 4 on weekdays(1-5), and 1 on Saturdays(6)
            //Time is between 7:00:00 and 20:00:00
            //Date is between 0 and 31 days, skipping every 7th day

            int day = 1;
            int hour = 7;
            int id = 1;

            for(day = minDay; day <= maxDay; day++)
            {
                if(day % 6 == 0)
                {
                    id = 1;
                   
                    for(hour = minHour; hour <= maxHour; hour++)
                    {
                        SQL.executeQuery("INSERT INTO timeslots VALUES('" + id + "','" + hour.ToString() + ":00:00','2017-01-" + day.ToString() +" ')");
                    }
                }
                else if(day % 7 == 0)
                {
                    
                }
                else
                {
                    id = 1;
                  
                    for(hour = minHour; hour <= maxHour; hour++)
                    {
                        for(id = 1; id <= 4; id++)
                        {
                            SQL.executeQuery("INSERT INTO timeslots VALUES('" + id + "','" + hour.ToString() + ":00:00','2017-01-" + day.ToString() + " ')");
                        }
                    }
                }
            }
        }
    }
}
