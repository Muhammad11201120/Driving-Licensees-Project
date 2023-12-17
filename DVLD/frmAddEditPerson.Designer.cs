namespace DVLD
{
    partial class frmAddEditPerson
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager( typeof( frmAddEditPerson ) );
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnSave = new System.Windows.Forms.Button();
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
            this.txtGendor = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblNationalID = new System.Windows.Forms.Label();
            this.txtNationalID = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblSecondName = new System.Windows.Forms.Label();
            this.txtSecondName = new System.Windows.Forms.TextBox();
            this.lblThirdName = new System.Windows.Forms.Label();
            this.txtThirdName = new System.Windows.Forms.TextBox();
            this.lblFirstNaame = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider( this.components );
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ( ( System.ComponentModel.ISupportInitialize ) ( this.pbxPerson ) ).BeginInit();
            ( ( System.ComponentModel.ISupportInitialize ) ( this.errorProvider1 ) ).BeginInit();
            ( ( System.ComponentModel.ISupportInitialize ) ( this.pictureBox1 ) ).BeginInit();
            ( ( System.ComponentModel.ISupportInitialize ) ( this.pictureBox2 ) ).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font( "Microsoft Uighur", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.button1.ForeColor = System.Drawing.Color.Crimson;
            this.button1.Location = new System.Drawing.Point( 541, 753 );
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size( 141, 41 );
            this.button1.TabIndex = 62;
            this.button1.Text = "CLOSE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler( this.button1_Click );
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font( "Microsoft Uighur", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.btnSave.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btnSave.Location = new System.Drawing.Point( 255, 753 );
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size( 141, 41 );
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler( this.btnSave_Click );
            // 
            // lblMode
            // 
            this.lblMode.AutoSize = true;
            this.lblMode.Font = new System.Drawing.Font( "Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.lblMode.ForeColor = System.Drawing.Color.Maroon;
            this.lblMode.Location = new System.Drawing.Point( 325, 99 );
            this.lblMode.Name = "lblMode";
            this.lblMode.Size = new System.Drawing.Size( 181, 23 );
            this.lblMode.TabIndex = 124;
            this.lblMode.Text = "This is Place Holder";
            // 
            // pbxPerson
            // 
            this.pbxPerson.Location = new System.Drawing.Point( 475, 379 );
            this.pbxPerson.Name = "pbxPerson";
            this.pbxPerson.Size = new System.Drawing.Size( 345, 238 );
            this.pbxPerson.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxPerson.TabIndex = 123;
            this.pbxPerson.TabStop = false;
            // 
            // lblRemoveImage
            // 
            this.lblRemoveImage.AutoSize = true;
            this.lblRemoveImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRemoveImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblRemoveImage.Font = new System.Drawing.Font( "Microsoft YaHei", 11.25F, ( ( System.Drawing.FontStyle ) ( ( System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline ) ) ), System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.lblRemoveImage.ForeColor = System.Drawing.Color.DarkRed;
            this.lblRemoveImage.Location = new System.Drawing.Point( 726, 630 );
            this.lblRemoveImage.Name = "lblRemoveImage";
            this.lblRemoveImage.Padding = new System.Windows.Forms.Padding( 10 );
            this.lblRemoveImage.Size = new System.Drawing.Size( 93, 41 );
            this.lblRemoveImage.TabIndex = 122;
            this.lblRemoveImage.Text = "Remove";
            this.lblRemoveImage.Click += new System.EventHandler( this.lblRemoveImage_Click );
            // 
            // lblImage
            // 
            this.lblImage.AutoSize = true;
            this.lblImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblImage.Font = new System.Drawing.Font( "Microsoft YaHei", 11.25F, ( ( System.Drawing.FontStyle ) ( ( System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline ) ) ), System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.lblImage.ForeColor = System.Drawing.Color.DarkRed;
            this.lblImage.Location = new System.Drawing.Point( 473, 630 );
            this.lblImage.Name = "lblImage";
            this.lblImage.Padding = new System.Windows.Forms.Padding( 10 );
            this.lblImage.Size = new System.Drawing.Size( 79, 41 );
            this.lblImage.TabIndex = 10;
            this.lblImage.Text = "Image";
            this.lblImage.Click += new System.EventHandler( this.lblImage_Click );
            // 
            // cmxCountry
            // 
            this.cmxCountry.FormattingEnabled = true;
            this.cmxCountry.Location = new System.Drawing.Point( 157, 650 );
            this.cmxCountry.Name = "cmxCountry";
            this.cmxCountry.Size = new System.Drawing.Size( 239, 21 );
            this.cmxCountry.TabIndex = 9;
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Font = new System.Drawing.Font( "Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.lblCountry.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblCountry.Location = new System.Drawing.Point( 14, 652 );
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size( 78, 19 );
            this.lblCountry.TabIndex = 119;
            this.lblCountry.Text = "Country :";
            // 
            // dtmDateOfBirth
            // 
            this.dtmDateOfBirth.Location = new System.Drawing.Point( 157, 596 );
            this.dtmDateOfBirth.Name = "dtmDateOfBirth";
            this.dtmDateOfBirth.Size = new System.Drawing.Size( 239, 20 );
            this.dtmDateOfBirth.TabIndex = 8;
            // 
            // lblDateOfBirth
            // 
            this.lblDateOfBirth.AutoSize = true;
            this.lblDateOfBirth.Font = new System.Drawing.Font( "Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.lblDateOfBirth.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblDateOfBirth.Location = new System.Drawing.Point( 14, 598 );
            this.lblDateOfBirth.Name = "lblDateOfBirth";
            this.lblDateOfBirth.Size = new System.Drawing.Size( 115, 19 );
            this.lblDateOfBirth.TabIndex = 117;
            this.lblDateOfBirth.Text = "Date Of Birth :";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font( "Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.lblEmail.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblEmail.Location = new System.Drawing.Point( 471, 326 );
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size( 58, 19 );
            this.lblEmail.TabIndex = 116;
            this.lblEmail.Text = "Email :";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point( 558, 324 );
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size( 262, 20 );
            this.txtEmail.TabIndex = 13;
            // 
            // lblGendor
            // 
            this.lblGendor.AutoSize = true;
            this.lblGendor.Font = new System.Drawing.Font( "Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.lblGendor.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblGendor.Location = new System.Drawing.Point( 14, 538 );
            this.lblGendor.Name = "lblGendor";
            this.lblGendor.Size = new System.Drawing.Size( 73, 19 );
            this.lblGendor.TabIndex = 114;
            this.lblGendor.Text = "Gendor :";
            // 
            // txtGendor
            // 
            this.txtGendor.Location = new System.Drawing.Point( 157, 536 );
            this.txtGendor.Name = "txtGendor";
            this.txtGendor.Size = new System.Drawing.Size( 239, 20 );
            this.txtGendor.TabIndex = 7;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font( "Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.lblPhone.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblPhone.Location = new System.Drawing.Point( 471, 273 );
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size( 66, 19 );
            this.lblPhone.TabIndex = 112;
            this.lblPhone.Text = "Phone :";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point( 558, 221 );
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size( 262, 20 );
            this.txtAddress.TabIndex = 11;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font( "Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.lblAddress.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblAddress.Location = new System.Drawing.Point( 471, 220 );
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size( 81, 19 );
            this.lblAddress.TabIndex = 110;
            this.lblAddress.Text = "Address : ";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point( 558, 274 );
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size( 262, 20 );
            this.txtPhone.TabIndex = 12;
            // 
            // lblNationalID
            // 
            this.lblNationalID.AutoSize = true;
            this.lblNationalID.Font = new System.Drawing.Font( "Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.lblNationalID.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblNationalID.Location = new System.Drawing.Point( 14, 273 );
            this.lblNationalID.Name = "lblNationalID";
            this.lblNationalID.Size = new System.Drawing.Size( 103, 19 );
            this.lblNationalID.TabIndex = 108;
            this.lblNationalID.Text = "National ID :";
            // 
            // txtNationalID
            // 
            this.txtNationalID.Location = new System.Drawing.Point( 157, 271 );
            this.txtNationalID.Name = "txtNationalID";
            this.txtNationalID.Size = new System.Drawing.Size( 239, 20 );
            this.txtNationalID.TabIndex = 2;
            this.txtNationalID.Leave += new System.EventHandler( this.txtNationalID_Leave );
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point( 157, 218 );
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size( 239, 20 );
            this.txtId.TabIndex = 1;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font( "Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.lblID.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblID.Location = new System.Drawing.Point( 14, 220 );
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size( 34, 19 );
            this.lblID.TabIndex = 105;
            this.lblID.Text = "ID :";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font( "Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.lblLastName.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblLastName.Location = new System.Drawing.Point( 14, 485 );
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size( 97, 19 );
            this.lblLastName.TabIndex = 104;
            this.lblLastName.Text = "Last Name :";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point( 157, 483 );
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size( 239, 20 );
            this.txtLastName.TabIndex = 6;
            // 
            // lblSecondName
            // 
            this.lblSecondName.AutoSize = true;
            this.lblSecondName.Font = new System.Drawing.Font( "Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.lblSecondName.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblSecondName.Location = new System.Drawing.Point( 14, 379 );
            this.lblSecondName.Name = "lblSecondName";
            this.lblSecondName.Size = new System.Drawing.Size( 123, 19 );
            this.lblSecondName.TabIndex = 102;
            this.lblSecondName.Text = "Second Name :";
            // 
            // txtSecondName
            // 
            this.txtSecondName.Location = new System.Drawing.Point( 157, 377 );
            this.txtSecondName.Name = "txtSecondName";
            this.txtSecondName.Size = new System.Drawing.Size( 239, 20 );
            this.txtSecondName.TabIndex = 4;
            // 
            // lblThirdName
            // 
            this.lblThirdName.AutoSize = true;
            this.lblThirdName.Font = new System.Drawing.Font( "Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.lblThirdName.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblThirdName.Location = new System.Drawing.Point( 14, 432 );
            this.lblThirdName.Name = "lblThirdName";
            this.lblThirdName.Size = new System.Drawing.Size( 106, 19 );
            this.lblThirdName.TabIndex = 100;
            this.lblThirdName.Text = "Third Name :";
            // 
            // txtThirdName
            // 
            this.txtThirdName.Location = new System.Drawing.Point( 157, 430 );
            this.txtThirdName.Name = "txtThirdName";
            this.txtThirdName.Size = new System.Drawing.Size( 239, 20 );
            this.txtThirdName.TabIndex = 5;
            // 
            // lblFirstNaame
            // 
            this.lblFirstNaame.AutoSize = true;
            this.lblFirstNaame.Font = new System.Drawing.Font( "Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.lblFirstNaame.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblFirstNaame.Location = new System.Drawing.Point( 14, 326 );
            this.lblFirstNaame.Name = "lblFirstNaame";
            this.lblFirstNaame.Size = new System.Drawing.Size( 98, 19 );
            this.lblFirstNaame.TabIndex = 98;
            this.lblFirstNaame.Text = "First Name :";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point( 157, 324 );
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size( 239, 20 );
            this.txtFirstName.TabIndex = 3;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ( ( System.Drawing.Image ) ( resources.GetObject( "pictureBox1.Image" ) ) );
            this.pictureBox1.Location = new System.Drawing.Point( 12, 43 );
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size( 163, 116 );
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 126;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ( ( System.Drawing.Image ) ( resources.GetObject( "pictureBox2.Image" ) ) );
            this.pictureBox2.Location = new System.Drawing.Point( 656, 58 );
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size( 163, 116 );
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 127;
            this.pictureBox2.TabStop = false;
            // 
            // frmAddEditPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size( 832, 832 );
            this.Controls.Add( this.pictureBox2 );
            this.Controls.Add( this.pictureBox1 );
            this.Controls.Add( this.btnSave );
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
            this.Controls.Add( this.txtGendor );
            this.Controls.Add( this.lblPhone );
            this.Controls.Add( this.txtAddress );
            this.Controls.Add( this.lblAddress );
            this.Controls.Add( this.txtPhone );
            this.Controls.Add( this.lblNationalID );
            this.Controls.Add( this.txtNationalID );
            this.Controls.Add( this.txtId );
            this.Controls.Add( this.lblID );
            this.Controls.Add( this.lblLastName );
            this.Controls.Add( this.txtLastName );
            this.Controls.Add( this.lblSecondName );
            this.Controls.Add( this.txtSecondName );
            this.Controls.Add( this.lblThirdName );
            this.Controls.Add( this.txtThirdName );
            this.Controls.Add( this.lblFirstNaame );
            this.Controls.Add( this.txtFirstName );
            this.Controls.Add( this.button1 );
            this.Name = "frmAddEditPerson";
            this.Text = "frmAddEditPerson";
            this.Load += new System.EventHandler( this.frmAddEditPerson_Load );
            ( ( System.ComponentModel.ISupportInitialize ) ( this.pbxPerson ) ).EndInit();
            ( ( System.ComponentModel.ISupportInitialize ) ( this.errorProvider1 ) ).EndInit();
            ( ( System.ComponentModel.ISupportInitialize ) ( this.pictureBox1 ) ).EndInit();
            ( ( System.ComponentModel.ISupportInitialize ) ( this.pictureBox2 ) ).EndInit();
            this.ResumeLayout( false );
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnSave;
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
        private System.Windows.Forms.TextBox txtGendor;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblNationalID;
        private System.Windows.Forms.TextBox txtNationalID;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblSecondName;
        private System.Windows.Forms.TextBox txtSecondName;
        private System.Windows.Forms.Label lblThirdName;
        private System.Windows.Forms.TextBox txtThirdName;
        private System.Windows.Forms.Label lblFirstNaame;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}