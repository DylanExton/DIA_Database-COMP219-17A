namespace LoginAndRegister
{
    partial class AdminScreen
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
            this.label2 = new System.Windows.Forms.Label();
            this.buttonAssignCar = new System.Windows.Forms.Button();
            this.comboBoxInstructor = new System.Windows.Forms.ComboBox();
            this.comboBoxCar = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxSpare = new System.Windows.Forms.ComboBox();
            this.buttonSpare = new System.Windows.Forms.Button();
            this.listBoxAppID = new System.Windows.Forms.ListBox();
            this.listBoxInstructor = new System.Windows.Forms.ListBox();
            this.listBoxClient = new System.Windows.Forms.ListBox();
            this.listBoxTime = new System.Windows.Forms.ListBox();
            this.listBoxDate = new System.Windows.Forms.ListBox();
            this.buttonConfirmApp = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.listBoxCar = new System.Windows.Forms.ListBox();
            this.buttonCheckHours = new System.Windows.Forms.Button();
            this.listBoxNotCoveredDays = new System.Windows.Forms.ListBox();
            this.listBoxCoveredDays = new System.Windows.Forms.ListBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
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
            this.buttonLogout.Location = new System.Drawing.Point(697, 9);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(51, 23);
            this.buttonLogout.TabIndex = 1;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(160, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 34);
            this.label1.TabIndex = 2;
            this.label1.Text = "Confirm Appointments";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(220, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 34);
            this.label2.TabIndex = 3;
            this.label2.Text = "Assign Cars";
            // 
            // buttonAssignCar
            // 
            this.buttonAssignCar.Location = new System.Drawing.Point(226, 79);
            this.buttonAssignCar.Name = "buttonAssignCar";
            this.buttonAssignCar.Size = new System.Drawing.Size(75, 58);
            this.buttonAssignCar.TabIndex = 4;
            this.buttonAssignCar.Text = "Assign Instructor Car";
            this.buttonAssignCar.UseVisualStyleBackColor = true;
            this.buttonAssignCar.Click += new System.EventHandler(this.buttonAssignCar_Click);
            // 
            // comboBoxInstructor
            // 
            this.comboBoxInstructor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxInstructor.FormattingEnabled = true;
            this.comboBoxInstructor.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboBoxInstructor.Location = new System.Drawing.Point(80, 79);
            this.comboBoxInstructor.Name = "comboBoxInstructor";
            this.comboBoxInstructor.Size = new System.Drawing.Size(121, 21);
            this.comboBoxInstructor.TabIndex = 5;
            // 
            // comboBoxCar
            // 
            this.comboBoxCar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCar.FormattingEnabled = true;
            this.comboBoxCar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboBoxCar.Location = new System.Drawing.Point(80, 116);
            this.comboBoxCar.Name = "comboBoxCar";
            this.comboBoxCar.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCar.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Instructor:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Car:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(351, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Spare Car:";
            // 
            // comboBoxSpare
            // 
            this.comboBoxSpare.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSpare.FormattingEnabled = true;
            this.comboBoxSpare.Location = new System.Drawing.Point(414, 99);
            this.comboBoxSpare.Name = "comboBoxSpare";
            this.comboBoxSpare.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSpare.TabIndex = 10;
            // 
            // buttonSpare
            // 
            this.buttonSpare.Location = new System.Drawing.Point(424, 126);
            this.buttonSpare.Name = "buttonSpare";
            this.buttonSpare.Size = new System.Drawing.Size(98, 23);
            this.buttonSpare.TabIndex = 11;
            this.buttonSpare.Text = "Assign Spare";
            this.buttonSpare.UseVisualStyleBackColor = true;
            this.buttonSpare.Click += new System.EventHandler(this.buttonSpare_Click);
            // 
            // listBoxAppID
            // 
            this.listBoxAppID.FormattingEnabled = true;
            this.listBoxAppID.Location = new System.Drawing.Point(9, 234);
            this.listBoxAppID.Name = "listBoxAppID";
            this.listBoxAppID.Size = new System.Drawing.Size(50, 186);
            this.listBoxAppID.TabIndex = 12;
            this.listBoxAppID.SelectedIndexChanged += new System.EventHandler(this.listBoxAppID_SelectedIndexChanged);
            // 
            // listBoxInstructor
            // 
            this.listBoxInstructor.FormattingEnabled = true;
            this.listBoxInstructor.Location = new System.Drawing.Point(246, 234);
            this.listBoxInstructor.Name = "listBoxInstructor";
            this.listBoxInstructor.Size = new System.Drawing.Size(73, 186);
            this.listBoxInstructor.TabIndex = 13;
            this.listBoxInstructor.SelectedIndexChanged += new System.EventHandler(this.listBoxInstructor_SelectedIndexChanged);
            // 
            // listBoxClient
            // 
            this.listBoxClient.FormattingEnabled = true;
            this.listBoxClient.Location = new System.Drawing.Point(325, 234);
            this.listBoxClient.Name = "listBoxClient";
            this.listBoxClient.Size = new System.Drawing.Size(73, 186);
            this.listBoxClient.TabIndex = 14;
            this.listBoxClient.SelectedIndexChanged += new System.EventHandler(this.listBoxClient_SelectedIndexChanged);
            // 
            // listBoxTime
            // 
            this.listBoxTime.FormattingEnabled = true;
            this.listBoxTime.Location = new System.Drawing.Point(167, 234);
            this.listBoxTime.Name = "listBoxTime";
            this.listBoxTime.Size = new System.Drawing.Size(73, 186);
            this.listBoxTime.TabIndex = 16;
            this.listBoxTime.SelectedIndexChanged += new System.EventHandler(this.listBoxTime_SelectedIndexChanged);
            // 
            // listBoxDate
            // 
            this.listBoxDate.FormattingEnabled = true;
            this.listBoxDate.Location = new System.Drawing.Point(65, 234);
            this.listBoxDate.Name = "listBoxDate";
            this.listBoxDate.Size = new System.Drawing.Size(96, 186);
            this.listBoxDate.TabIndex = 15;
            this.listBoxDate.SelectedIndexChanged += new System.EventHandler(this.listBoxDate_SelectedIndexChanged);
            // 
            // buttonConfirmApp
            // 
            this.buttonConfirmApp.Location = new System.Drawing.Point(9, 426);
            this.buttonConfirmApp.Name = "buttonConfirmApp";
            this.buttonConfirmApp.Size = new System.Drawing.Size(468, 37);
            this.buttonConfirmApp.TabIndex = 17;
            this.buttonConfirmApp.Text = "Confirm Appointment";
            this.buttonConfirmApp.UseVisualStyleBackColor = true;
            this.buttonConfirmApp.Click += new System.EventHandler(this.buttonConfirmApp_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(-2, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Appointment ID:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(253, 218);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Instructor:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(337, 218);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Client:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(184, 218);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Time:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(91, 219);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Date:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(416, 218);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(26, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "Car:";
            // 
            // listBoxCar
            // 
            this.listBoxCar.FormattingEnabled = true;
            this.listBoxCar.Location = new System.Drawing.Point(404, 234);
            this.listBoxCar.Name = "listBoxCar";
            this.listBoxCar.Size = new System.Drawing.Size(73, 186);
            this.listBoxCar.TabIndex = 23;
            this.listBoxCar.SelectedIndexChanged += new System.EventHandler(this.listBoxCar_SelectedIndexChanged);
            // 
            // buttonCheckHours
            // 
            this.buttonCheckHours.Location = new System.Drawing.Point(497, 243);
            this.buttonCheckHours.Name = "buttonCheckHours";
            this.buttonCheckHours.Size = new System.Drawing.Size(70, 52);
            this.buttonCheckHours.TabIndex = 25;
            this.buttonCheckHours.Text = "Check Main Hours";
            this.buttonCheckHours.UseVisualStyleBackColor = true;
            this.buttonCheckHours.Click += new System.EventHandler(this.buttonCheckHours_Click);
            // 
            // listBoxNotCoveredDays
            // 
            this.listBoxNotCoveredDays.FormattingEnabled = true;
            this.listBoxNotCoveredDays.Location = new System.Drawing.Point(573, 281);
            this.listBoxNotCoveredDays.Name = "listBoxNotCoveredDays";
            this.listBoxNotCoveredDays.Size = new System.Drawing.Size(175, 173);
            this.listBoxNotCoveredDays.TabIndex = 26;
            // 
            // listBoxCoveredDays
            // 
            this.listBoxCoveredDays.FormattingEnabled = true;
            this.listBoxCoveredDays.Location = new System.Drawing.Point(573, 79);
            this.listBoxCoveredDays.Name = "listBoxCoveredDays";
            this.listBoxCoveredDays.Size = new System.Drawing.Size(175, 173);
            this.listBoxCoveredDays.TabIndex = 27;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(570, 63);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(107, 13);
            this.label12.TabIndex = 28;
            this.label12.Text = "Main Hours Covered:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(570, 263);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(127, 13);
            this.label13.TabIndex = 29;
            this.label13.Text = "Main Hours Not Covered:";
            // 
            // AdminScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 467);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.listBoxCoveredDays);
            this.Controls.Add(this.listBoxNotCoveredDays);
            this.Controls.Add(this.buttonCheckHours);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.listBoxCar);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonConfirmApp);
            this.Controls.Add(this.listBoxTime);
            this.Controls.Add(this.listBoxDate);
            this.Controls.Add(this.listBoxClient);
            this.Controls.Add(this.listBoxInstructor);
            this.Controls.Add(this.listBoxAppID);
            this.Controls.Add(this.buttonSpare);
            this.Controls.Add(this.comboBoxSpare);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxCar);
            this.Controls.Add(this.comboBoxInstructor);
            this.Controls.Add(this.buttonAssignCar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.labelID);
            this.Name = "AdminScreen";
            this.Text = "Administrator";
            this.Load += new System.EventHandler(this.AdminScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonAssignCar;
        private System.Windows.Forms.ComboBox comboBoxInstructor;
        private System.Windows.Forms.ComboBox comboBoxCar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxSpare;
        private System.Windows.Forms.Button buttonSpare;
        private System.Windows.Forms.ListBox listBoxAppID;
        private System.Windows.Forms.ListBox listBoxInstructor;
        private System.Windows.Forms.ListBox listBoxClient;
        private System.Windows.Forms.ListBox listBoxTime;
        private System.Windows.Forms.ListBox listBoxDate;
        private System.Windows.Forms.Button buttonConfirmApp;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ListBox listBoxCar;
        private System.Windows.Forms.Button buttonCheckHours;
        private System.Windows.Forms.ListBox listBoxNotCoveredDays;
        private System.Windows.Forms.ListBox listBoxCoveredDays;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
    }
}