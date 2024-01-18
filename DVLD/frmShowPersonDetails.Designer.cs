namespace DVLD
{
    partial class frmShowPersonDetails
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if ( disposing && ( components != null ) )
            {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblPersonID = new System.Windows.Forms.Label();
            this.lblPersonIDValue = new System.Windows.Forms.Label();
            this.lblEditPerson = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblAddressValue = new System.Windows.Forms.Label();
            this.lblCountryValue = new System.Windows.Forms.Label();
            this.lblEmailValue = new System.Windows.Forms.Label();
            this.lblPhoneValue = new System.Windows.Forms.Label();
            this.lblLastNameValue = new System.Windows.Forms.Label();
            this.lblThirdNameVaalue = new System.Windows.Forms.Label();
            this.lblSecondNameValue = new System.Windows.Forms.Label();
            this.lblFirstNaameValue = new System.Windows.Forms.Label();
            this.pbxImagePath = new System.Windows.Forms.PictureBox();
            this.lblNationalNO = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblDateOfBirth = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.lblGendorValue = new System.Windows.Forms.Label();
            this.lblGendor = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSecondName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagePath)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPersonID
            // 
            this.lblPersonID.AutoSize = true;
            this.lblPersonID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonID.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblPersonID.Location = new System.Drawing.Point(19, 49);
            this.lblPersonID.Name = "lblPersonID";
            this.lblPersonID.Size = new System.Drawing.Size(97, 16);
            this.lblPersonID.TabIndex = 0;
            this.lblPersonID.Text = "PERSON ID :";
            // 
            // lblPersonIDValue
            // 
            this.lblPersonIDValue.AutoSize = true;
            this.lblPersonIDValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonIDValue.ForeColor = System.Drawing.Color.White;
            this.lblPersonIDValue.Location = new System.Drawing.Point(122, 49);
            this.lblPersonIDValue.Name = "lblPersonIDValue";
            this.lblPersonIDValue.Size = new System.Drawing.Size(33, 16);
            this.lblPersonIDValue.TabIndex = 1;
            this.lblPersonIDValue.Text = "N/A";
            // 
            // lblEditPerson
            // 
            this.lblEditPerson.AutoSize = true;
            this.lblEditPerson.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEditPerson.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblEditPerson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblEditPerson.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditPerson.ForeColor = System.Drawing.Color.White;
            this.lblEditPerson.Location = new System.Drawing.Point(621, 46);
            this.lblEditPerson.Name = "lblEditPerson";
            this.lblEditPerson.Padding = new System.Windows.Forms.Padding(5);
            this.lblEditPerson.Size = new System.Drawing.Size(122, 31);
            this.lblEditPerson.TabIndex = 3;
            this.lblEditPerson.Text = "EDIT ACCOUNT";
            this.lblEditPerson.Click += new System.EventHandler(this.lblEditPerson_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.btnClose.Location = new System.Drawing.Point(626, 569);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(117, 37);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "CLOSE";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblAddressValue);
            this.groupBox1.Controls.Add(this.lblCountryValue);
            this.groupBox1.Controls.Add(this.lblEmailValue);
            this.groupBox1.Controls.Add(this.lblPhoneValue);
            this.groupBox1.Controls.Add(this.lblLastNameValue);
            this.groupBox1.Controls.Add(this.lblThirdNameVaalue);
            this.groupBox1.Controls.Add(this.lblSecondNameValue);
            this.groupBox1.Controls.Add(this.lblFirstNaameValue);
            this.groupBox1.Controls.Add(this.pbxImagePath);
            this.groupBox1.Controls.Add(this.lblNationalNO);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lblDateOfBirth);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblCountry);
            this.groupBox1.Controls.Add(this.lblGendorValue);
            this.groupBox1.Controls.Add(this.lblGendor);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblLastName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblSecondName);
            this.groupBox1.Controls.Add(this.lblFirstName);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(22, 106);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(721, 442);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ACCOUNT INFO : ";
            // 
            // lblAddressValue
            // 
            this.lblAddressValue.AutoSize = true;
            this.lblAddressValue.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddressValue.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblAddressValue.Location = new System.Drawing.Point(483, 390);
            this.lblAddressValue.Name = "lblAddressValue";
            this.lblAddressValue.Size = new System.Drawing.Size(14, 14);
            this.lblAddressValue.TabIndex = 33;
            this.lblAddressValue.Text = "?";
            // 
            // lblCountryValue
            // 
            this.lblCountryValue.AutoSize = true;
            this.lblCountryValue.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountryValue.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblCountryValue.Location = new System.Drawing.Point(483, 349);
            this.lblCountryValue.Name = "lblCountryValue";
            this.lblCountryValue.Size = new System.Drawing.Size(14, 14);
            this.lblCountryValue.TabIndex = 32;
            this.lblCountryValue.Text = "?";
            // 
            // lblEmailValue
            // 
            this.lblEmailValue.AutoSize = true;
            this.lblEmailValue.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailValue.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblEmailValue.Location = new System.Drawing.Point(125, 390);
            this.lblEmailValue.Name = "lblEmailValue";
            this.lblEmailValue.Size = new System.Drawing.Size(14, 14);
            this.lblEmailValue.TabIndex = 31;
            this.lblEmailValue.Text = "?";
            // 
            // lblPhoneValue
            // 
            this.lblPhoneValue.AutoSize = true;
            this.lblPhoneValue.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneValue.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblPhoneValue.Location = new System.Drawing.Point(125, 351);
            this.lblPhoneValue.Name = "lblPhoneValue";
            this.lblPhoneValue.Size = new System.Drawing.Size(14, 14);
            this.lblPhoneValue.TabIndex = 30;
            this.lblPhoneValue.Text = "?";
            // 
            // lblLastNameValue
            // 
            this.lblLastNameValue.AutoSize = true;
            this.lblLastNameValue.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastNameValue.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblLastNameValue.Location = new System.Drawing.Point(125, 227);
            this.lblLastNameValue.Name = "lblLastNameValue";
            this.lblLastNameValue.Size = new System.Drawing.Size(14, 14);
            this.lblLastNameValue.TabIndex = 29;
            this.lblLastNameValue.Text = "?";
            // 
            // lblThirdNameVaalue
            // 
            this.lblThirdNameVaalue.AutoSize = true;
            this.lblThirdNameVaalue.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThirdNameVaalue.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblThirdNameVaalue.Location = new System.Drawing.Point(125, 183);
            this.lblThirdNameVaalue.Name = "lblThirdNameVaalue";
            this.lblThirdNameVaalue.Size = new System.Drawing.Size(14, 14);
            this.lblThirdNameVaalue.TabIndex = 28;
            this.lblThirdNameVaalue.Text = "?";
            // 
            // lblSecondNameValue
            // 
            this.lblSecondNameValue.AutoSize = true;
            this.lblSecondNameValue.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecondNameValue.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblSecondNameValue.Location = new System.Drawing.Point(125, 132);
            this.lblSecondNameValue.Name = "lblSecondNameValue";
            this.lblSecondNameValue.Size = new System.Drawing.Size(14, 14);
            this.lblSecondNameValue.TabIndex = 27;
            this.lblSecondNameValue.Text = "?";
            // 
            // lblFirstNaameValue
            // 
            this.lblFirstNaameValue.AutoSize = true;
            this.lblFirstNaameValue.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstNaameValue.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblFirstNaameValue.Location = new System.Drawing.Point(128, 84);
            this.lblFirstNaameValue.Name = "lblFirstNaameValue";
            this.lblFirstNaameValue.Size = new System.Drawing.Size(14, 14);
            this.lblFirstNaameValue.TabIndex = 26;
            this.lblFirstNaameValue.Text = "?";
            // 
            // pbxImagePath
            // 
            this.pbxImagePath.Image = global::DVLD.Properties.Resources.male;
            this.pbxImagePath.Location = new System.Drawing.Point(436, 79);
            this.pbxImagePath.Name = "pbxImagePath";
            this.pbxImagePath.Size = new System.Drawing.Size(266, 208);
            this.pbxImagePath.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxImagePath.TabIndex = 23;
            this.pbxImagePath.TabStop = false;
            // 
            // lblNationalNO
            // 
            this.lblNationalNO.AutoSize = true;
            this.lblNationalNO.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNationalNO.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblNationalNO.Location = new System.Drawing.Point(142, 39);
            this.lblNationalNO.Name = "lblNationalNO";
            this.lblNationalNO.Size = new System.Drawing.Size(31, 14);
            this.lblNationalNO.TabIndex = 22;
            this.lblNationalNO.Text = "000";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(8, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 14);
            this.label6.TabIndex = 21;
            this.label6.Text = "National Number : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(386, 390);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 14);
            this.label5.TabIndex = 19;
            this.label5.Text = "Address : ";
            // 
            // lblDateOfBirth
            // 
            this.lblDateOfBirth.AutoSize = true;
            this.lblDateOfBirth.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateOfBirth.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblDateOfBirth.Location = new System.Drawing.Point(128, 312);
            this.lblDateOfBirth.Name = "lblDateOfBirth";
            this.lblDateOfBirth.Size = new System.Drawing.Size(65, 14);
            this.lblDateOfBirth.TabIndex = 18;
            this.lblDateOfBirth.Text = "00/00/00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(3, 312);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 14);
            this.label4.TabIndex = 17;
            this.label4.Text = "Date Of Birth : ";
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountry.ForeColor = System.Drawing.Color.White;
            this.lblCountry.Location = new System.Drawing.Point(386, 349);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(72, 14);
            this.lblCountry.TabIndex = 15;
            this.lblCountry.Text = "Country : ";
            // 
            // lblGendorValue
            // 
            this.lblGendorValue.AutoSize = true;
            this.lblGendorValue.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGendorValue.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblGendorValue.Location = new System.Drawing.Point(128, 273);
            this.lblGendorValue.Name = "lblGendorValue";
            this.lblGendorValue.Size = new System.Drawing.Size(39, 14);
            this.lblGendorValue.TabIndex = 14;
            this.lblGendorValue.Text = "Male";
            // 
            // lblGendor
            // 
            this.lblGendor.AutoSize = true;
            this.lblGendor.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGendor.ForeColor = System.Drawing.Color.White;
            this.lblGendor.Location = new System.Drawing.Point(22, 273);
            this.lblGendor.Name = "lblGendor";
            this.lblGendor.Size = new System.Drawing.Size(66, 14);
            this.lblGendor.TabIndex = 13;
            this.lblGendor.Text = "Gendor : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(26, 347);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 14);
            this.label2.TabIndex = 12;
            this.label2.Text = "Phone : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(27, 388);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 14);
            this.label1.TabIndex = 10;
            this.label1.Text = "Email : ";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.ForeColor = System.Drawing.Color.White;
            this.lblLastName.Location = new System.Drawing.Point(12, 227);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(86, 14);
            this.lblLastName.TabIndex = 8;
            this.lblLastName.Text = "Last Name : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(6, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 14);
            this.label3.TabIndex = 4;
            this.label3.Text = "Third Name  : ";
            // 
            // lblSecondName
            // 
            this.lblSecondName.AutoSize = true;
            this.lblSecondName.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecondName.ForeColor = System.Drawing.Color.White;
            this.lblSecondName.Location = new System.Drawing.Point(3, 132);
            this.lblSecondName.Name = "lblSecondName";
            this.lblSecondName.Size = new System.Drawing.Size(105, 14);
            this.lblSecondName.TabIndex = 2;
            this.lblSecondName.Text = "Second Name : ";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.ForeColor = System.Drawing.Color.White;
            this.lblFirstName.Location = new System.Drawing.Point(11, 84);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(88, 14);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "First Name : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(284, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(200, 26);
            this.label7.TabIndex = 6;
            this.label7.Text = "PERSONAL DETAILS";
            // 
            // frmShowPersonDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.ClientSize = new System.Drawing.Size(768, 618);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblPersonIDValue);
            this.Controls.Add(this.lblPersonID);
            this.Controls.Add(this.lblEditPerson);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmShowPersonDetails";
            this.Text = "SfrmShowPersonDetails";
            this.Load += new System.EventHandler(this.frmShowPersonDetails_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagePath)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPersonID;
        private System.Windows.Forms.Label lblPersonIDValue;
        private ctrShowPersonDetails ctrShowPersonDetails1;
        private System.Windows.Forms.Label lblEditPerson;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pbxImagePath;
        private System.Windows.Forms.Label lblNationalNO;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblDateOfBirth;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label lblGendorValue;
        private System.Windows.Forms.Label lblGendor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSecondName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblAddressValue;
        private System.Windows.Forms.Label lblCountryValue;
        private System.Windows.Forms.Label lblEmailValue;
        private System.Windows.Forms.Label lblPhoneValue;
        private System.Windows.Forms.Label lblLastNameValue;
        private System.Windows.Forms.Label lblThirdNameVaalue;
        private System.Windows.Forms.Label lblSecondNameValue;
        private System.Windows.Forms.Label lblFirstNaameValue;
    }
}