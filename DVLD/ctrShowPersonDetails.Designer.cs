namespace DVLD
{
    public partial class ctrShowPersonDetails
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager( typeof( ctrShowPersonDetails ) );
            this.rbtnFemale = new System.Windows.Forms.RadioButton();
            this.rbtnMale = new System.Windows.Forms.RadioButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblMode = new System.Windows.Forms.Label();
            this.pbxPerson = new System.Windows.Forms.PictureBox();
            this.lblRemoveImage = new System.Windows.Forms.Label();
            this.lblImage = new System.Windows.Forms.Label();
            this.cmxCountry = new System.Windows.Forms.ComboBox();
            this.lblCountry = new System.Windows.Forms.Label();
            this.dtmDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.lblDateOfBirth = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblGendor = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblNationalID = new System.Windows.Forms.Label();
            this.txtNationalID = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblSecondName = new System.Windows.Forms.Label();
            this.txtSecondName = new System.Windows.Forms.TextBox();
            this.lblThirdName = new System.Windows.Forms.Label();
            this.txtThirdName = new System.Windows.Forms.TextBox();
            this.lblFirstNaame = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider( this.components );
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ( ( System.ComponentModel.ISupportInitialize ) ( this.pictureBox2 ) ).BeginInit();
            ( ( System.ComponentModel.ISupportInitialize ) ( this.pictureBox1 ) ).BeginInit();
            ( ( System.ComponentModel.ISupportInitialize ) ( this.pbxPerson ) ).BeginInit();
            ( ( System.ComponentModel.ISupportInitialize ) ( this.errorProvider1 ) ).BeginInit();
            this.SuspendLayout();
            // 
            // rbtnFemale
            // 
            this.rbtnFemale.AutoSize = true;
            this.rbtnFemale.Font = new System.Drawing.Font( "Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.rbtnFemale.ForeColor = System.Drawing.Color.White;
            this.rbtnFemale.Location = new System.Drawing.Point( 308, 498 );
            this.rbtnFemale.Name = "rbtnFemale";
            this.rbtnFemale.Size = new System.Drawing.Size( 77, 20 );
            this.rbtnFemale.TabIndex = 159;
            this.rbtnFemale.Text = "Female";
            this.rbtnFemale.UseVisualStyleBackColor = true;
            // 
            // rbtnMale
            // 
            this.rbtnMale.AutoSize = true;
            this.rbtnMale.Checked = true;
            this.rbtnMale.Font = new System.Drawing.Font( "Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.rbtnMale.ForeColor = System.Drawing.Color.White;
            this.rbtnMale.Location = new System.Drawing.Point( 146, 498 );
            this.rbtnMale.Name = "rbtnMale";
            this.rbtnMale.Size = new System.Drawing.Size( 59, 20 );
            this.rbtnMale.TabIndex = 158;
            this.rbtnMale.TabStop = true;
            this.rbtnMale.Text = "Male";
            this.rbtnMale.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ( ( System.Drawing.Image ) ( resources.GetObject( "pictureBox2.Image" ) ) );
            this.pictureBox2.Location = new System.Drawing.Point( 651, 1 );
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size( 163, 116 );
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 157;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ( ( System.Drawing.Image ) ( resources.GetObject( "pictureBox1.Image" ) ) );
            this.pictureBox1.Location = new System.Drawing.Point( 1, 1 );
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size( 163, 116 );
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 156;
            this.pictureBox1.TabStop = false;
            // 
            // lblMode
            // 
            this.lblMode.AutoSize = true;
            this.lblMode.Font = new System.Drawing.Font( "Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.lblMode.ForeColor = System.Drawing.Color.White;
            this.lblMode.Location = new System.Drawing.Point( 314, 57 );
            this.lblMode.Name = "lblMode";
            this.lblMode.Size = new System.Drawing.Size( 181, 23 );
            this.lblMode.TabIndex = 155;
            this.lblMode.Text = "This is Place Holder";
            // 
            // pbxPerson
            // 
            this.pbxPerson.Image = global::DVLD.Properties.Resources.male;
            this.pbxPerson.Location = new System.Drawing.Point( 464, 337 );
            this.pbxPerson.Name = "pbxPerson";
            this.pbxPerson.Size = new System.Drawing.Size( 345, 238 );
            this.pbxPerson.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxPerson.TabIndex = 154;
            this.pbxPerson.TabStop = false;
            // 
            // lblRemoveImage
            // 
            this.lblRemoveImage.AutoSize = true;
            this.lblRemoveImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRemoveImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblRemoveImage.Font = new System.Drawing.Font( "Microsoft YaHei", 11.25F, ( ( System.Drawing.FontStyle ) ( ( System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline ) ) ), System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.lblRemoveImage.ForeColor = System.Drawing.Color.White;
            this.lblRemoveImage.Location = new System.Drawing.Point( 715, 588 );
            this.lblRemoveImage.Name = "lblRemoveImage";
            this.lblRemoveImage.Padding = new System.Windows.Forms.Padding( 10 );
            this.lblRemoveImage.Size = new System.Drawing.Size( 93, 41 );
            this.lblRemoveImage.TabIndex = 153;
            this.lblRemoveImage.Text = "Remove";
            this.lblRemoveImage.Click += new System.EventHandler( this.lblRemoveImage_Click );
            // 
            // lblImage
            // 
            this.lblImage.AutoSize = true;
            this.lblImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblImage.Font = new System.Drawing.Font( "Microsoft YaHei", 11.25F, ( ( System.Drawing.FontStyle ) ( ( System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline ) ) ), System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.lblImage.ForeColor = System.Drawing.Color.White;
            this.lblImage.Location = new System.Drawing.Point( 462, 588 );
            this.lblImage.Name = "lblImage";
            this.lblImage.Padding = new System.Windows.Forms.Padding( 10 );
            this.lblImage.Size = new System.Drawing.Size( 79, 41 );
            this.lblImage.TabIndex = 138;
            this.lblImage.Text = "Image";
            this.lblImage.Click += new System.EventHandler( this.lblImage_Click );
            // 
            // cmxCountry
            // 
            this.cmxCountry.FormattingEnabled = true;
            this.cmxCountry.Location = new System.Drawing.Point( 146, 608 );
            this.cmxCountry.Name = "cmxCountry";
            this.cmxCountry.Size = new System.Drawing.Size( 239, 21 );
            this.cmxCountry.TabIndex = 137;
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Font = new System.Drawing.Font( "Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.lblCountry.ForeColor = System.Drawing.Color.White;
            this.lblCountry.Location = new System.Drawing.Point( 3, 610 );
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size( 78, 19 );
            this.lblCountry.TabIndex = 152;
            this.lblCountry.Text = "Country :";
            // 
            // dtmDateOfBirth
            // 
            this.dtmDateOfBirth.Location = new System.Drawing.Point( 146, 554 );
            this.dtmDateOfBirth.Name = "dtmDateOfBirth";
            this.dtmDateOfBirth.Size = new System.Drawing.Size( 239, 20 );
            this.dtmDateOfBirth.TabIndex = 136;
            // 
            // lblDateOfBirth
            // 
            this.lblDateOfBirth.AutoSize = true;
            this.lblDateOfBirth.Font = new System.Drawing.Font( "Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.lblDateOfBirth.ForeColor = System.Drawing.Color.White;
            this.lblDateOfBirth.Location = new System.Drawing.Point( 3, 556 );
            this.lblDateOfBirth.Name = "lblDateOfBirth";
            this.lblDateOfBirth.Size = new System.Drawing.Size( 115, 19 );
            this.lblDateOfBirth.TabIndex = 151;
            this.lblDateOfBirth.Text = "Date Of Birth :";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font( "Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.lblEmail.ForeColor = System.Drawing.Color.White;
            this.lblEmail.Location = new System.Drawing.Point( 460, 284 );
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size( 58, 19 );
            this.lblEmail.TabIndex = 150;
            this.lblEmail.Text = "Email :";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point( 547, 282 );
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size( 262, 20 );
            this.txtEmail.TabIndex = 141;
            // 
            // lblGendor
            // 
            this.lblGendor.AutoSize = true;
            this.lblGendor.Font = new System.Drawing.Font( "Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.lblGendor.ForeColor = System.Drawing.Color.White;
            this.lblGendor.Location = new System.Drawing.Point( 3, 496 );
            this.lblGendor.Name = "lblGendor";
            this.lblGendor.Size = new System.Drawing.Size( 73, 19 );
            this.lblGendor.TabIndex = 149;
            this.lblGendor.Text = "Gendor :";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font( "Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.lblPhone.ForeColor = System.Drawing.Color.White;
            this.lblPhone.Location = new System.Drawing.Point( 460, 231 );
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size( 66, 19 );
            this.lblPhone.TabIndex = 148;
            this.lblPhone.Text = "Phone :";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point( 547, 179 );
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size( 262, 20 );
            this.txtAddress.TabIndex = 139;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font( "Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.lblAddress.ForeColor = System.Drawing.Color.White;
            this.lblAddress.Location = new System.Drawing.Point( 460, 178 );
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size( 81, 19 );
            this.lblAddress.TabIndex = 147;
            this.lblAddress.Text = "Address : ";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point( 547, 232 );
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size( 262, 20 );
            this.txtPhone.TabIndex = 140;
            // 
            // lblNationalID
            // 
            this.lblNationalID.AutoSize = true;
            this.lblNationalID.Font = new System.Drawing.Font( "Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.lblNationalID.ForeColor = System.Drawing.Color.White;
            this.lblNationalID.Location = new System.Drawing.Point( 3, 231 );
            this.lblNationalID.Name = "lblNationalID";
            this.lblNationalID.Size = new System.Drawing.Size( 103, 19 );
            this.lblNationalID.TabIndex = 146;
            this.lblNationalID.Text = "National ID :";
            // 
            // txtNationalID
            // 
            this.txtNationalID.Location = new System.Drawing.Point( 146, 229 );
            this.txtNationalID.Name = "txtNationalID";
            this.txtNationalID.Size = new System.Drawing.Size( 239, 20 );
            this.txtNationalID.TabIndex = 131;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point( 146, 176 );
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size( 239, 20 );
            this.txtId.TabIndex = 130;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font( "Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.lblLastName.ForeColor = System.Drawing.Color.White;
            this.lblLastName.Location = new System.Drawing.Point( 3, 443 );
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size( 97, 19 );
            this.lblLastName.TabIndex = 145;
            this.lblLastName.Text = "Last Name :";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point( 146, 441 );
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size( 239, 20 );
            this.txtLastName.TabIndex = 135;
            // 
            // lblSecondName
            // 
            this.lblSecondName.AutoSize = true;
            this.lblSecondName.Font = new System.Drawing.Font( "Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.lblSecondName.ForeColor = System.Drawing.Color.White;
            this.lblSecondName.Location = new System.Drawing.Point( 3, 337 );
            this.lblSecondName.Name = "lblSecondName";
            this.lblSecondName.Size = new System.Drawing.Size( 123, 19 );
            this.lblSecondName.TabIndex = 144;
            this.lblSecondName.Text = "Second Name :";
            // 
            // txtSecondName
            // 
            this.txtSecondName.Location = new System.Drawing.Point( 146, 335 );
            this.txtSecondName.Name = "txtSecondName";
            this.txtSecondName.Size = new System.Drawing.Size( 239, 20 );
            this.txtSecondName.TabIndex = 133;
            // 
            // lblThirdName
            // 
            this.lblThirdName.AutoSize = true;
            this.lblThirdName.Font = new System.Drawing.Font( "Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.lblThirdName.ForeColor = System.Drawing.Color.White;
            this.lblThirdName.Location = new System.Drawing.Point( 3, 390 );
            this.lblThirdName.Name = "lblThirdName";
            this.lblThirdName.Size = new System.Drawing.Size( 106, 19 );
            this.lblThirdName.TabIndex = 143;
            this.lblThirdName.Text = "Third Name :";
            // 
            // txtThirdName
            // 
            this.txtThirdName.Location = new System.Drawing.Point( 146, 388 );
            this.txtThirdName.Name = "txtThirdName";
            this.txtThirdName.Size = new System.Drawing.Size( 239, 20 );
            this.txtThirdName.TabIndex = 134;
            // 
            // lblFirstNaame
            // 
            this.lblFirstNaame.AutoSize = true;
            this.lblFirstNaame.Font = new System.Drawing.Font( "Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.lblFirstNaame.ForeColor = System.Drawing.Color.White;
            this.lblFirstNaame.Location = new System.Drawing.Point( 3, 284 );
            this.lblFirstNaame.Name = "lblFirstNaame";
            this.lblFirstNaame.Size = new System.Drawing.Size( 98, 19 );
            this.lblFirstNaame.TabIndex = 142;
            this.lblFirstNaame.Text = "First Name :";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point( 146, 282 );
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size( 239, 20 );
            this.txtFirstName.TabIndex = 132;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // ctrShowPersonDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb( ( ( int ) ( ( ( byte ) ( 24 ) ) ) ), ( ( int ) ( ( ( byte ) ( 30 ) ) ) ), ( ( int ) ( ( ( byte ) ( 54 ) ) ) ) );
            this.Controls.Add( this.rbtnFemale );
            this.Controls.Add( this.rbtnMale );
            this.Controls.Add( this.pictureBox2 );
            this.Controls.Add( this.pictureBox1 );
            this.Controls.Add( this.lblMode );
            this.Controls.Add( this.pbxPerson );
            this.Controls.Add( this.lblRemoveImage );
            this.Controls.Add( this.lblImage );
            this.Controls.Add( this.cmxCountry );
            this.Controls.Add( this.lblCountry );
            this.Controls.Add( this.dtmDateOfBirth );
            this.Controls.Add( this.lblDateOfBirth );
            this.Controls.Add( this.lblEmail );
            this.Controls.Add( this.txtEmail );
            this.Controls.Add( this.lblGendor );
            this.Controls.Add( this.lblPhone );
            this.Controls.Add( this.txtAddress );
            this.Controls.Add( this.lblAddress );
            this.Controls.Add( this.txtPhone );
            this.Controls.Add( this.lblNationalID );
            this.Controls.Add( this.txtNationalID );
            this.Controls.Add( this.txtId );
            this.Controls.Add( this.lblLastName );
            this.Controls.Add( this.txtLastName );
            this.Controls.Add( this.lblSecondName );
            this.Controls.Add( this.txtSecondName );
            this.Controls.Add( this.lblThirdName );
            this.Controls.Add( this.txtThirdName );
            this.Controls.Add( this.lblFirstNaame );
            this.Controls.Add( this.txtFirstName );
            this.Name = "ctrShowPersonDetails";
            this.Size = new System.Drawing.Size( 814, 631 );
            ( ( System.ComponentModel.ISupportInitialize ) ( this.pictureBox2 ) ).EndInit();
            ( ( System.ComponentModel.ISupportInitialize ) ( this.pictureBox1 ) ).EndInit();
            ( ( System.ComponentModel.ISupportInitialize ) ( this.pbxPerson ) ).EndInit();
            ( ( System.ComponentModel.ISupportInitialize ) ( this.errorProvider1 ) ).EndInit();
            this.ResumeLayout( false );
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbtnFemale;
        private System.Windows.Forms.RadioButton rbtnMale;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblMode;
        private System.Windows.Forms.PictureBox pbxPerson;
        private System.Windows.Forms.Label lblRemoveImage;
        private System.Windows.Forms.Label lblImage;
        private System.Windows.Forms.ComboBox cmxCountry;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.DateTimePicker dtmDateOfBirth;
        private System.Windows.Forms.Label lblDateOfBirth;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblGendor;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblNationalID;
        private System.Windows.Forms.TextBox txtNationalID;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblSecondName;
        private System.Windows.Forms.TextBox txtSecondName;
        private System.Windows.Forms.Label lblThirdName;
        private System.Windows.Forms.TextBox txtThirdName;
        private System.Windows.Forms.Label lblFirstNaame;
        private System.Windows.Forms.TextBox txtFirstName;

        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}
