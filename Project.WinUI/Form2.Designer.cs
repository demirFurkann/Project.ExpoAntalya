namespace Project.WinUI
{
    partial class Form2
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
			this.rdbMedium = new System.Windows.Forms.RadioButton();
			this.rdbLow = new System.Windows.Forms.RadioButton();
			this.rdbHigh = new System.Windows.Forms.RadioButton();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.btnContinue = new System.Windows.Forms.Button();
			this.txtPhoneNumber = new System.Windows.Forms.TextBox();
			this.txtCompanyName = new System.Windows.Forms.TextBox();
			this.txtDetails = new System.Windows.Forms.TextBox();
			this.lstIssues = new System.Windows.Forms.ListBox();
			this.lstStands = new System.Windows.Forms.ListBox();
			this.lblDescription = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.lblActivity = new System.Windows.Forms.Label();
			this.cmbIssueType = new System.Windows.Forms.ComboBox();
			this.label10 = new System.Windows.Forms.Label();
			this.lblSaloon = new System.Windows.Forms.Label();
			this.btnAddIssue = new System.Windows.Forms.Button();
			this.chbCafe = new System.Windows.Forms.CheckBox();
			this.cmbSaloon = new System.Windows.Forms.ComboBox();
			this.chbTouilet = new System.Windows.Forms.CheckBox();
			this.grpExtra = new System.Windows.Forms.GroupBox();
			this.chbMeetingRoom = new System.Windows.Forms.CheckBox();
			this.chbTv = new System.Windows.Forms.CheckBox();
			this.lblTeslim = new System.Windows.Forms.Label();
			this.grpExtra.SuspendLayout();
			this.SuspendLayout();
			// 
			// rdbMedium
			// 
			this.rdbMedium.AutoSize = true;
			this.rdbMedium.Location = new System.Drawing.Point(201, 344);
			this.rdbMedium.Name = "rdbMedium";
			this.rdbMedium.Size = new System.Drawing.Size(62, 17);
			this.rdbMedium.TabIndex = 75;
			this.rdbMedium.Text = "Medium";
			this.rdbMedium.UseVisualStyleBackColor = true;
			// 
			// rdbLow
			// 
			this.rdbLow.AutoSize = true;
			this.rdbLow.Checked = true;
			this.rdbLow.Location = new System.Drawing.Point(201, 367);
			this.rdbLow.Name = "rdbLow";
			this.rdbLow.Size = new System.Drawing.Size(45, 17);
			this.rdbLow.TabIndex = 74;
			this.rdbLow.TabStop = true;
			this.rdbLow.Text = "Low";
			this.rdbLow.UseVisualStyleBackColor = true;
			// 
			// rdbHigh
			// 
			this.rdbHigh.AutoSize = true;
			this.rdbHigh.Location = new System.Drawing.Point(201, 319);
			this.rdbHigh.Name = "rdbHigh";
			this.rdbHigh.Size = new System.Drawing.Size(47, 17);
			this.rdbHigh.TabIndex = 73;
			this.rdbHigh.Text = "High";
			this.rdbHigh.UseVisualStyleBackColor = true;
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Location = new System.Drawing.Point(1026, 520);
			this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(171, 20);
			this.dateTimePicker1.TabIndex = 72;
			
			// 
			// btnContinue
			// 
			this.btnContinue.Location = new System.Drawing.Point(316, 582);
			this.btnContinue.Margin = new System.Windows.Forms.Padding(2);
			this.btnContinue.Name = "btnContinue";
			this.btnContinue.Size = new System.Drawing.Size(70, 24);
			this.btnContinue.TabIndex = 71;
			this.btnContinue.Text = "Continue";
			this.btnContinue.UseVisualStyleBackColor = true;
			this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
			// 
			// txtPhoneNumber
			// 
			this.txtPhoneNumber.Location = new System.Drawing.Point(9, 162);
			this.txtPhoneNumber.Margin = new System.Windows.Forms.Padding(2);
			this.txtPhoneNumber.Name = "txtPhoneNumber";
			this.txtPhoneNumber.Size = new System.Drawing.Size(171, 20);
			this.txtPhoneNumber.TabIndex = 70;
			// 
			// txtCompanyName
			// 
			this.txtCompanyName.Location = new System.Drawing.Point(8, 61);
			this.txtCompanyName.Margin = new System.Windows.Forms.Padding(2);
			this.txtCompanyName.Name = "txtCompanyName";
			this.txtCompanyName.Size = new System.Drawing.Size(171, 20);
			this.txtCompanyName.TabIndex = 68;
			// 
			// txtDetails
			// 
			this.txtDetails.Location = new System.Drawing.Point(853, 135);
			this.txtDetails.Margin = new System.Windows.Forms.Padding(2);
			this.txtDetails.Name = "txtDetails";
			this.txtDetails.Size = new System.Drawing.Size(361, 20);
			this.txtDetails.TabIndex = 67;
			// 
			// lstIssues
			// 
			this.lstIssues.FormattingEnabled = true;
			this.lstIssues.Location = new System.Drawing.Point(857, 233);
			this.lstIssues.Margin = new System.Windows.Forms.Padding(2);
			this.lstIssues.Name = "lstIssues";
			this.lstIssues.Size = new System.Drawing.Size(359, 225);
			this.lstIssues.TabIndex = 66;
			
			// 
			// lstStands
			// 
			this.lstStands.FormattingEnabled = true;
			this.lstStands.Location = new System.Drawing.Point(295, 36);
			this.lstStands.Margin = new System.Windows.Forms.Padding(2);
			this.lstStands.Name = "lstStands";
			this.lstStands.Size = new System.Drawing.Size(431, 186);
			this.lstStands.TabIndex = 65;
			
			// 
			// lblDescription
			// 
			this.lblDescription.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.lblDescription.Location = new System.Drawing.Point(46, 523);
			this.lblDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblDescription.Name = "lblDescription";
			this.lblDescription.Size = new System.Drawing.Size(428, 55);
			this.lblDescription.TabIndex = 63;
			this.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(7, 136);
			this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(172, 24);
			this.label4.TabIndex = 62;
			this.label4.Text = "Phone Number";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label15
			// 
			this.label15.Location = new System.Drawing.Point(1027, 494);
			this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(170, 24);
			this.label15.TabIndex = 60;
			this.label15.Text = "Expo Date";
			this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(6, 36);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(172, 24);
			this.label2.TabIndex = 59;
			this.label2.Text = "Company Name";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(988, 106);
			this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(92, 24);
			this.label5.TabIndex = 58;
			this.label5.Text = "Details";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(855, 48);
			this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(80, 24);
			this.label8.TabIndex = 57;
			this.label8.Text = "Issue Type";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label13
			// 
			this.label13.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label13.Location = new System.Drawing.Point(201, 0);
			this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(8, 216);
			this.label13.TabIndex = 55;
			this.label13.Text = "Saloon";
			this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label12
			// 
			this.label12.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label12.Location = new System.Drawing.Point(800, 53);
			this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(8, 509);
			this.label12.TabIndex = 54;
			this.label12.Text = "Saloon";
			this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblActivity
			// 
			this.lblActivity.Location = new System.Drawing.Point(198, 282);
			this.lblActivity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblActivity.Name = "lblActivity";
			this.lblActivity.Size = new System.Drawing.Size(92, 24);
			this.lblActivity.TabIndex = 52;
			this.lblActivity.Text = "Select Activity";
			this.lblActivity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// cmbIssueType
			// 
			this.cmbIssueType.FormattingEnabled = true;
			this.cmbIssueType.Location = new System.Drawing.Point(857, 74);
			this.cmbIssueType.Margin = new System.Windows.Forms.Padding(2);
			this.cmbIssueType.Name = "cmbIssueType";
			this.cmbIssueType.Size = new System.Drawing.Size(123, 21);
			this.cmbIssueType.TabIndex = 48;
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(319, 266);
			this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(170, 19);
			this.label10.TabIndex = 51;
			this.label10.Text = "Select Extra";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblSaloon
			// 
			this.lblSaloon.Location = new System.Drawing.Point(22, 276);
			this.lblSaloon.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblSaloon.Name = "lblSaloon";
			this.lblSaloon.Size = new System.Drawing.Size(170, 19);
			this.lblSaloon.TabIndex = 50;
			this.lblSaloon.Text = "Select Saloon";
			this.lblSaloon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnAddIssue
			// 
			this.btnAddIssue.Location = new System.Drawing.Point(1135, 173);
			this.btnAddIssue.Margin = new System.Windows.Forms.Padding(2);
			this.btnAddIssue.Name = "btnAddIssue";
			this.btnAddIssue.Size = new System.Drawing.Size(78, 25);
			this.btnAddIssue.TabIndex = 42;
			this.btnAddIssue.Text = "Add Issue";
			this.btnAddIssue.UseVisualStyleBackColor = true;
			this.btnAddIssue.Click += new System.EventHandler(this.btnAddIssue_Click);
			// 
			// chbCafe
			// 
			this.chbCafe.AutoSize = true;
			this.chbCafe.Location = new System.Drawing.Point(27, 75);
			this.chbCafe.Name = "chbCafe";
			this.chbCafe.Size = new System.Drawing.Size(48, 17);
			this.chbCafe.TabIndex = 76;
			this.chbCafe.Tag = "200";
			this.chbCafe.Text = "Cafe";
			this.chbCafe.UseVisualStyleBackColor = true;
			// 
			// cmbSaloon
			// 
			this.cmbSaloon.FormattingEnabled = true;
			this.cmbSaloon.Location = new System.Drawing.Point(49, 298);
			this.cmbSaloon.Name = "cmbSaloon";
			this.cmbSaloon.Size = new System.Drawing.Size(121, 21);
			this.cmbSaloon.TabIndex = 77;
			this.cmbSaloon.SelectedIndexChanged += new System.EventHandler(this.cmbSaloon_SelectedIndexChanged);
			// 
			// chbTouilet
			// 
			this.chbTouilet.AutoSize = true;
			this.chbTouilet.Location = new System.Drawing.Point(27, 55);
			this.chbTouilet.Name = "chbTouilet";
			this.chbTouilet.Size = new System.Drawing.Size(58, 17);
			this.chbTouilet.TabIndex = 76;
			this.chbTouilet.Tag = "100";
			this.chbTouilet.Text = "Touilet";
			this.chbTouilet.UseVisualStyleBackColor = true;
			// 
			// grpExtra
			// 
			this.grpExtra.Controls.Add(this.chbMeetingRoom);
			this.grpExtra.Controls.Add(this.chbCafe);
			this.grpExtra.Controls.Add(this.chbTv);
			this.grpExtra.Controls.Add(this.chbTouilet);
			this.grpExtra.Location = new System.Drawing.Point(295, 288);
			this.grpExtra.Name = "grpExtra";
			this.grpExtra.Size = new System.Drawing.Size(245, 193);
			this.grpExtra.TabIndex = 78;
			this.grpExtra.TabStop = false;
			this.grpExtra.Text = "Extra";
			// 
			// chbMeetingRoom
			// 
			this.chbMeetingRoom.AutoSize = true;
			this.chbMeetingRoom.Location = new System.Drawing.Point(113, 75);
			this.chbMeetingRoom.Name = "chbMeetingRoom";
			this.chbMeetingRoom.Size = new System.Drawing.Size(95, 17);
			this.chbMeetingRoom.TabIndex = 76;
			this.chbMeetingRoom.Tag = "300";
			this.chbMeetingRoom.Text = "Meeting Room";
			this.chbMeetingRoom.UseVisualStyleBackColor = true;
			// 
			// chbTv
			// 
			this.chbTv.AutoSize = true;
			this.chbTv.Location = new System.Drawing.Point(113, 55);
			this.chbTv.Name = "chbTv";
			this.chbTv.Size = new System.Drawing.Size(39, 17);
			this.chbTv.TabIndex = 76;
			this.chbTv.Tag = "150";
			this.chbTv.Text = "Tv";
			this.chbTv.UseVisualStyleBackColor = true;
			// 
			// lblTeslim
			// 
			this.lblTeslim.AutoSize = true;
			this.lblTeslim.Location = new System.Drawing.Point(558, 246);
			this.lblTeslim.Name = "lblTeslim";
			this.lblTeslim.Size = new System.Drawing.Size(66, 13);
			this.lblTeslim.TabIndex = 79;
			this.lblTeslim.Text = "Teslim Tarihi";
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1324, 652);
			this.Controls.Add(this.lblTeslim);
			this.Controls.Add(this.grpExtra);
			this.Controls.Add(this.cmbSaloon);
			this.Controls.Add(this.rdbMedium);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.rdbLow);
			this.Controls.Add(this.rdbHigh);
			this.Controls.Add(this.dateTimePicker1);
			this.Controls.Add(this.btnContinue);
			this.Controls.Add(this.txtPhoneNumber);
			this.Controls.Add(this.txtCompanyName);
			this.Controls.Add(this.txtDetails);
			this.Controls.Add(this.lstIssues);
			this.Controls.Add(this.lstStands);
			this.Controls.Add(this.lblDescription);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label15);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.lblActivity);
			this.Controls.Add(this.cmbIssueType);
			this.Controls.Add(this.lblSaloon);
			this.Controls.Add(this.btnAddIssue);
			this.Name = "Form2";
			this.Text = "Form2";
			this.Load += new System.EventHandler(this.Form2_Load);
			this.grpExtra.ResumeLayout(false);
			this.grpExtra.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdbMedium;
        private System.Windows.Forms.RadioButton rdbLow;
        private System.Windows.Forms.RadioButton rdbHigh;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtCompanyName;
        private System.Windows.Forms.TextBox txtDetails;
        private System.Windows.Forms.ListBox lstIssues;
        private System.Windows.Forms.ListBox lstStands;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblActivity;
        private System.Windows.Forms.ComboBox cmbIssueType;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblSaloon;
        private System.Windows.Forms.Button btnAddIssue;
        private System.Windows.Forms.CheckBox chbCafe;
        private System.Windows.Forms.ComboBox cmbSaloon;
        private System.Windows.Forms.CheckBox chbTouilet;
        private System.Windows.Forms.GroupBox grpExtra;
        private System.Windows.Forms.CheckBox chbMeetingRoom;
        private System.Windows.Forms.CheckBox chbTv;
		private System.Windows.Forms.Label lblTeslim;
	}
}