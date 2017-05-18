namespace LoginAndRegister
{
    partial class ClientScreen
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
            this.label1 = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.comboBoxDate = new System.Windows.Forms.ComboBox();
            this.comboBoxTime = new System.Windows.Forms.ComboBox();
            this.comboBoxInstructor = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.listBoxAppointments = new System.Windows.Forms.ListBox();
            this.buttonBook = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(248, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(14, 21);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(0, 13);
            this.labelID.TabIndex = 1;
            // 
            // buttonLogout
            // 
            this.buttonLogout.Location = new System.Drawing.Point(534, 12);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(58, 26);
            this.buttonLogout.TabIndex = 2;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // comboBoxDate
            // 
            this.comboBoxDate.FormattingEnabled = true;
            this.comboBoxDate.Location = new System.Drawing.Point(268, 111);
            this.comboBoxDate.Name = "comboBoxDate";
            this.comboBoxDate.Size = new System.Drawing.Size(121, 21);
            this.comboBoxDate.TabIndex = 3;
            this.comboBoxDate.SelectedIndexChanged += new System.EventHandler(this.comboBoxDate_SelectedIndexChanged);
            // 
            // comboBoxTime
            // 
            this.comboBoxTime.FormattingEnabled = true;
            this.comboBoxTime.Location = new System.Drawing.Point(446, 111);
            this.comboBoxTime.Name = "comboBoxTime";
            this.comboBoxTime.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTime.TabIndex = 4;
            // 
            // comboBoxInstructor
            // 
            this.comboBoxInstructor.FormattingEnabled = true;
            this.comboBoxInstructor.Location = new System.Drawing.Point(81, 111);
            this.comboBoxInstructor.Name = "comboBoxInstructor";
            this.comboBoxInstructor.Size = new System.Drawing.Size(121, 21);
            this.comboBoxInstructor.TabIndex = 6;
            this.comboBoxInstructor.SelectedIndexChanged += new System.EventHandler(this.comboBoxInstructor_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(229, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(407, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Time:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Instructor:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(197, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(216, 26);
            this.label5.TabIndex = 10;
            this.label5.Text = "Choose an Appointment";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(216, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(173, 26);
            this.label6.TabIndex = 11;
            this.label6.Text = "Your Appointments";
            // 
            // listBoxAppointments
            // 
            this.listBoxAppointments.FormattingEnabled = true;
            this.listBoxAppointments.Location = new System.Drawing.Point(24, 210);
            this.listBoxAppointments.Name = "listBoxAppointments";
            this.listBoxAppointments.Size = new System.Drawing.Size(543, 173);
            this.listBoxAppointments.TabIndex = 12;
            // 
            // buttonBook
            // 
            this.buttonBook.Location = new System.Drawing.Point(24, 138);
            this.buttonBook.Name = "buttonBook";
            this.buttonBook.Size = new System.Drawing.Size(543, 36);
            this.buttonBook.TabIndex = 13;
            this.buttonBook.Text = "Book Appointment";
            this.buttonBook.UseVisualStyleBackColor = true;
            this.buttonBook.Click += new System.EventHandler(this.buttonBook_Click);
            // 
            // ClientScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 395);
            this.Controls.Add(this.buttonBook);
            this.Controls.Add(this.listBoxAppointments);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxInstructor);
            this.Controls.Add(this.comboBoxTime);
            this.Controls.Add(this.comboBoxDate);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.label1);
            this.Name = "ClientScreen";
            this.Text = "Welcome to the Driving Academy Booking Service";
            this.Load += new System.EventHandler(this.ClientScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.ComboBox comboBoxDate;
        private System.Windows.Forms.ComboBox comboBoxTime;
        private System.Windows.Forms.ComboBox comboBoxInstructor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox listBoxAppointments;
        private System.Windows.Forms.Button buttonBook;
    }
}