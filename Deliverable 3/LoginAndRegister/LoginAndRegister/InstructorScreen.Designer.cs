namespace LoginAndRegister
{
    partial class InstructorScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelID = new System.Windows.Forms.Label();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxDates = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxTimes = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxSlots = new System.Windows.Forms.ComboBox();
            this.buttonCreateAppointment = new System.Windows.Forms.Button();
            this.listBoxAppID = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.listBoxCar = new System.Windows.Forms.ListBox();
            this.listBoxDate = new System.Windows.Forms.ListBox();
            this.listBoxTime = new System.Windows.Forms.ListBox();
            this.listBoxClient = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.listBoxConfirmed = new System.Windows.Forms.ListBox();
            this.label11 = new System.Windows.Forms.Label();
            this.buttonDeleteApp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(12, 9);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(0, 13);
            this.labelID.TabIndex = 0;
            // 
            // buttonLogout
            // 
            this.buttonLogout.Location = new System.Drawing.Point(618, 12);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(55, 23);
            this.buttonLogout.TabIndex = 1;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(220, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 34);
            this.label1.TabIndex = 2;
            this.label1.Text = "Available Timeslots";
            // 
            // comboBoxDates
            // 
            this.comboBoxDates.FormattingEnabled = true;
            this.comboBoxDates.Location = new System.Drawing.Point(129, 52);
            this.comboBoxDates.Name = "comboBoxDates";
            this.comboBoxDates.Size = new System.Drawing.Size(87, 21);
            this.comboBoxDates.TabIndex = 3;
            this.comboBoxDates.SelectedIndexChanged += new System.EventHandler(this.comboBoxDates_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Date:";
            // 
            // comboBoxTimes
            // 
            this.comboBoxTimes.FormattingEnabled = true;
            this.comboBoxTimes.Location = new System.Drawing.Point(304, 52);
            this.comboBoxTimes.Name = "comboBoxTimes";
            this.comboBoxTimes.Size = new System.Drawing.Size(87, 21);
            this.comboBoxTimes.TabIndex = 5;
            this.comboBoxTimes.SelectedIndexChanged += new System.EventHandler(this.comboBoxTimes_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(265, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Time:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(425, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Slots:";
            // 
            // comboBoxSlots
            // 
            this.comboBoxSlots.FormattingEnabled = true;
            this.comboBoxSlots.Location = new System.Drawing.Point(464, 52);
            this.comboBoxSlots.Name = "comboBoxSlots";
            this.comboBoxSlots.Size = new System.Drawing.Size(87, 21);
            this.comboBoxSlots.TabIndex = 7;
            // 
            // buttonCreateAppointment
            // 
            this.buttonCreateAppointment.Location = new System.Drawing.Point(290, 93);
            this.buttonCreateAppointment.Name = "buttonCreateAppointment";
            this.buttonCreateAppointment.Size = new System.Drawing.Size(118, 23);
            this.buttonCreateAppointment.TabIndex = 9;
            this.buttonCreateAppointment.Text = "Create Appointment";
            this.buttonCreateAppointment.UseVisualStyleBackColor = true;
            this.buttonCreateAppointment.Click += new System.EventHandler(this.buttonCreateAppointment_Click);
            // 
            // listBoxAppID
            // 
            this.listBoxAppID.FormattingEnabled = true;
            this.listBoxAppID.Location = new System.Drawing.Point(12, 218);
            this.listBoxAppID.Name = "listBoxAppID";
            this.listBoxAppID.Size = new System.Drawing.Size(106, 199);
            this.listBoxAppID.TabIndex = 10;
            this.listBoxAppID.SelectedIndexChanged += new System.EventHandler(this.listBoxAppID_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(228, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(230, 34);
            this.label5.TabIndex = 11;
            this.label5.Text = "Your Appointments:";
            // 
            // listBoxCar
            // 
            this.listBoxCar.FormattingEnabled = true;
            this.listBoxCar.Location = new System.Drawing.Point(333, 218);
            this.listBoxCar.Name = "listBoxCar";
            this.listBoxCar.Size = new System.Drawing.Size(120, 199);
            this.listBoxCar.TabIndex = 12;
            this.listBoxCar.SelectedIndexChanged += new System.EventHandler(this.listBoxCar_SelectedIndexChanged);
            // 
            // listBoxDate
            // 
            this.listBoxDate.FormattingEnabled = true;
            this.listBoxDate.Location = new System.Drawing.Point(222, 218);
            this.listBoxDate.Name = "listBoxDate";
            this.listBoxDate.Size = new System.Drawing.Size(105, 199);
            this.listBoxDate.TabIndex = 13;
            this.listBoxDate.SelectedIndexChanged += new System.EventHandler(this.listBoxDate_SelectedIndexChanged);
            // 
            // listBoxTime
            // 
            this.listBoxTime.FormattingEnabled = true;
            this.listBoxTime.Location = new System.Drawing.Point(124, 218);
            this.listBoxTime.Name = "listBoxTime";
            this.listBoxTime.Size = new System.Drawing.Size(92, 199);
            this.listBoxTime.TabIndex = 14;
            this.listBoxTime.SelectedIndexChanged += new System.EventHandler(this.listBoxTime_SelectedIndexChanged);
            // 
            // listBoxClient
            // 
            this.listBoxClient.FormattingEnabled = true;
            this.listBoxClient.Location = new System.Drawing.Point(459, 218);
            this.listBoxClient.Name = "listBoxClient";
            this.listBoxClient.Size = new System.Drawing.Size(138, 199);
            this.listBoxClient.TabIndex = 15;
            this.listBoxClient.SelectedIndexChanged += new System.EventHandler(this.listBoxClient_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Appointment ID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(126, 202);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Appointment Time";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(231, 202);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Appointment Date";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(371, 202);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Car ID";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(504, 202);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Client ID";
            // 
            // listBoxConfirmed
            // 
            this.listBoxConfirmed.FormattingEnabled = true;
            this.listBoxConfirmed.Location = new System.Drawing.Point(603, 218);
            this.listBoxConfirmed.Name = "listBoxConfirmed";
            this.listBoxConfirmed.Size = new System.Drawing.Size(70, 199);
            this.listBoxConfirmed.TabIndex = 21;
            this.listBoxConfirmed.SelectedIndexChanged += new System.EventHandler(this.listBoxConfirmed_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(615, 202);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Confirmed";
            // 
            // buttonDeleteApp
            // 
            this.buttonDeleteApp.Location = new System.Drawing.Point(12, 423);
            this.buttonDeleteApp.Name = "buttonDeleteApp";
            this.buttonDeleteApp.Size = new System.Drawing.Size(661, 23);
            this.buttonDeleteApp.TabIndex = 23;
            this.buttonDeleteApp.Text = "Delete Appointment";
            this.buttonDeleteApp.UseVisualStyleBackColor = true;
            this.buttonDeleteApp.Click += new System.EventHandler(this.buttonDeleteApp_Click);
            // 
            // InstructorScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 453);
            this.Controls.Add(this.buttonDeleteApp);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.listBoxConfirmed);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.listBoxClient);
            this.Controls.Add(this.listBoxTime);
            this.Controls.Add(this.listBoxDate);
            this.Controls.Add(this.listBoxCar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listBoxAppID);
            this.Controls.Add(this.buttonCreateAppointment);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxSlots);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxTimes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxDates);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.labelID);
            this.Name = "InstructorScreen";
            this.Text = "Welcome Instructors";
            this.Load += new System.EventHandler(this.InstructorScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxDates;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxTimes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxSlots;
        private System.Windows.Forms.Button buttonCreateAppointment;
        private System.Windows.Forms.ListBox listBoxAppID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listBoxCar;
        private System.Windows.Forms.ListBox listBoxDate;
        private System.Windows.Forms.ListBox listBoxTime;
        private System.Windows.Forms.ListBox listBoxClient;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListBox listBoxConfirmed;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button buttonDeleteApp;
    }
}