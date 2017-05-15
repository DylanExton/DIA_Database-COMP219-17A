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
            this.buttonLogout.Location = new System.Drawing.Point(504, 12);
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
            // 
            // comboBoxInstructor
            // 
            this.comboBoxInstructor.FormattingEnabled = true;
            this.comboBoxInstructor.Location = new System.Drawing.Point(80, 79);
            this.comboBoxInstructor.Name = "comboBoxInstructor";
            this.comboBoxInstructor.Size = new System.Drawing.Size(121, 21);
            this.comboBoxInstructor.TabIndex = 5;
            // 
            // comboBoxCar
            // 
            this.comboBoxCar.FormattingEnabled = true;
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
            // 
            // AdminScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 471);
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
    }
}