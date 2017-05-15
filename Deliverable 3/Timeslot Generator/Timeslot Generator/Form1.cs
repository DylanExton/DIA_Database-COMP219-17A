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
            //Time is between 7:00:00 and 19:00:00
            //Date is between 0 and 31 days, skipping every 7th day

            int day = 1;
            int hour = 7;
            int id = 1;
            string dayPr = "";
            string hourPr = "";
            int appID = 1;

            for(day = minDay; day <= maxDay; day++)
            {
                if(day % 6 == 0)
                {
                    id = 1;
                   
                    for(hour = minHour; hour <= maxHour; hour++)
                    {
                        if (day < 10) dayPr = "0" + day.ToString();
                        else dayPr = day.ToString();

                        if (hour < 10) hourPr = "0" + hour.ToString();
                        else hourPr = hour.ToString();
                        SQL.executeQuery("INSERT INTO timeslots VALUES('" + id + "','" + hourPr + ":00:00','2017-01-" + dayPr +" ')");
                        SQL.executeQuery("INSERT INTO appointments VALUES('" + appID + "','','" + id + "','2017-01-" + dayPr + "','" + hourPr + ":00:00',null,null,null,0)");
                        appID++;
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
                            if (day < 10) dayPr = "0" + day.ToString();
                            else dayPr = day.ToString();

                            if (hour < 10) hourPr = "0" + hour.ToString();
                            else hourPr = hour.ToString();
                            SQL.executeQuery("INSERT INTO timeslots VALUES('" + id + "','" + hourPr + ":00:00','2017-01-" + dayPr + "')");
                            SQL.executeQuery("INSERT INTO appointments VALUES('" + appID + "','','" + id + "','2017-01-" + dayPr +"','" + hourPr + ":00:00',null,null,null,0)");
                            appID++;
                        }
                    }
                }
            }
            MessageBox.Show("Timeslots have been created");


        }
    }
}
