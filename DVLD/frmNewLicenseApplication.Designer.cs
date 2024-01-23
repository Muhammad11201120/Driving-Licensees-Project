namespace DVLD
{
    partial class frmNewLicenseApplication
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider( this.components );
            this.rbtnFemale = new System.Windows.Forms.RadioButton();
            this.rbtnMale = new System.Windows.Forms.RadioButton();
            this.lblRemoveImage = new System.Windows.Forms.Label();
            this.lblImage = new System.Windows.Forms.Label();
            this.cmxCountry = new System.Windows.Forms.ComboBox();
            this.lblCountry = new System.Windows.Forms.Label();
            this.dtmDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.lblDateOfBirth = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblGendor = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAddNewPerson = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblFilters = new System.Windows.Forms.Label();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.cbxFilters = new System.Windows.Forms.ComboBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pbxPerson = new System.Windows.Forms.PictureBox();
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
            ( ( System.ComponentModel.ISupportInitialize ) ( this.errorProvider1 ) ).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ( ( System.ComponentModel.ISupportInitialize ) ( this.pbxPerson ) ).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font( "Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.btnNext.ForeColor = System.Drawing.Color.FromArgb( ( ( int ) ( ( ( byte ) ( 45 ) ) ) ), ( ( int ) ( ( ( byte ) ( 66 ) ) ) ), ( ( int ) ( ( ( byte ) ( 91 ) ) ) ) );
            this.btnNext.Image = global::DVLD.Properties.Resources.Next_32;
            this.btnNext.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNext.Location = new System.Drawing.Point( 498, 789 );
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size( 111, 45 );
            this.btnNext.TabIndex = 164;
            this.btnNext.Text = "NEXT";
            this.btnNext.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler( this.btnNext_Click );
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font( "Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb( ( ( int ) ( ( ( byte ) ( 45 ) ) ) ), ( ( int ) ( ( ( byte ) ( 66 ) ) ) ), ( ( int ) ( ( ( byte ) ( 91 ) ) ) ) );
            this.btnClose.Image = global::DVLD.Properties.Resources.cross_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point( 310, 789 );
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size( 111, 45 );
            this.btnClose.TabIndex = 163;
            this.btnClose.Text = "CLOSE";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler( this.btnClose_Click );
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // rbtnFemale
            // 
            this.rbtnFemale.AutoSize = true;
            this.rbtnFemale.Font = new System.Drawing.Font( "Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.rbtnFemale.ForeColor = System.Drawing.Color.White;
            this.rbtnFemale.Location = new System.Drawing.Point( 326, 360 );
            this.rbtnFemale.Name = "rbtnFemale";
            this.rbtnFemale.Size = new System.Drawing.Size( 77, 20 );
            this.rbtnFemale.TabIndex = 157;
            this.rbtnFemale.Text = "Female";
            this.rbtnFemale.UseVisualStyleBackColor = true;
            this.rbtnFemale.CheckedChanged += new System.EventHandler( this.rbtnFemale_CheckedChanged );
            // 
            // rbtnMale
            // 
            this.rbtnMale.AutoSize = true;
            this.rbtnMale.Checked = true;
            this.rbtnMale.Font = new System.Drawing.Font( "Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.rbtnMale.ForeColor = System.Drawing.Color.White;
            this.rbtnMale.Location = new System.Drawing.Point( 164, 360 );
            this.rbtnMale.Name = "rbtnMale";
            this.rbtnMale.Size = new System.Drawing.Size( 59, 20 );
            this.rbtnMale.TabIndex = 156;
            this.rbtnMale.TabStop = true;
            this.rbtnMale.Text = "Male";
            this.rbtnMale.UseVisualStyleBackColor = true;
            this.rbtnMale.CheckedChanged += new System.EventHandler( this.rbtnMale_CheckedChanged );
            // 
            // lblRemoveImage
            // 
            this.lblRemoveImage.AutoSize = true;
            this.lblRemoveImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRemoveImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblRemoveImage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblRemoveImage.Font = new System.Drawing.Font( "Microsoft YaHei", 11.25F, ( ( System.Drawing.FontStyle ) ( ( System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline ) ) ), System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.lblRemoveImage.ForeColor = System.Drawing.Color.White;
            this.lblRemoveImage.Location = new System.Drawing.Point( 733, 450 );
            this.lblRemoveImage.Name = "lblRemoveImage";
            this.lblRemoveImage.Padding = new System.Windows.Forms.Padding( 10 );
            this.lblRemoveImage.Size = new System.Drawing.Size( 93, 41 );
            this.lblRemoveImage.TabIndex = 154;
            this.lblRemoveImage.Text = "Remove";
            this.lblRemoveImage.Click += new System.EventHandler( this.lblRemoveImage_Click );
            // 
            // lblImage
            // 
            this.lblImage.AutoSize = true;
            this.lblImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblImage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblImage.Font = new System.Drawing.Font( "Microsoft YaHei", 11.25F, ( ( System.Drawing.FontStyle ) ( ( System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline ) ) ), System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.lblImage.ForeColor = System.Drawing.Color.White;
            this.lblImage.Location = new System.Drawing.Point( 480, 450 );
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
            this.cmxCountry.Location = new System.Drawing.Point( 164, 470 );
            this.cmxCountry.Name = "cmxCountry";
            this.cmxCountry.Size = new System.Drawing.Size( 239, 21 );
            this.cmxCountry.TabIndex = 137;
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Font = new System.Drawing.Font( "Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.lblCountry.ForeColor = System.Drawing.Color.White;
            this.lblCountry.Location = new System.Drawing.Point( 21, 472 );
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size( 78, 19 );
            this.lblCountry.TabIndex = 153;
            this.lblCountry.Text = "Country :";
            // 
            // dtmDateOfBirth
            // 
            this.dtmDateOfBirth.CalendarForeColor = System.Drawing.Color.FromArgb( ( ( int ) ( ( ( byte ) ( 0 ) ) ) ), ( ( int ) ( ( ( byte ) ( 117 ) ) ) ), ( ( int ) ( ( ( byte ) ( 214 ) ) ) ) );
            this.dtmDateOfBirth.CalendarTitleForeColor = System.Drawing.Color.FromArgb( ( ( int ) ( ( ( byte ) ( 0 ) ) ) ), ( ( int ) ( ( ( byte ) ( 117 ) ) ) ), ( ( int ) ( ( ( byte ) ( 214 ) ) ) ) );
            this.dtmDateOfBirth.Location = new System.Drawing.Point( 164, 416 );
            this.dtmDateOfBirth.Name = "dtmDateOfBirth";
            this.dtmDateOfBirth.Size = new System.Drawing.Size( 239, 20 );
            this.dtmDateOfBirth.TabIndex = 136;
            // 
            // lblDateOfBirth
            // 
            this.lblDateOfBirth.AutoSize = true;
            this.lblDateOfBirth.Font = new System.Drawing.Font( "Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.lblDateOfBirth.ForeColor = System.Drawing.Color.White;
            this.lblDateOfBirth.Location = new System.Drawing.Point( 21, 418 );
            this.lblDateOfBirth.Name = "lblDateOfBirth";
            this.lblDateOfBirth.Size = new System.Drawing.Size( 115, 19 );
            this.lblDateOfBirth.TabIndex = 152;
            this.lblDateOfBirth.Text = "Date Of Birth :";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font( "Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.lblEmail.ForeColor = System.Drawing.Color.White;
            this.lblEmail.Location = new System.Drawing.Point( 478, 146 );
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size( 58, 19 );
            this.lblEmail.TabIndex = 151;
            this.lblEmail.Text = "Email :";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point( 565, 144 );
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size( 262, 20 );
            this.txtEmail.TabIndex = 141;
            this.txtEmail.Leave += new System.EventHandler( this.txtEmail_Leave );
            // 
            // lblGendor
            // 
            this.lblGendor.AutoSize = true;
            this.lblGendor.Font = new System.Drawing.Font( "Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.lblGendor.ForeColor = System.Drawing.Color.White;
            this.lblGendor.Location = new System.Drawing.Point( 21, 358 );
            this.lblGendor.Name = "lblGendor";
            this.lblGendor.Size = new System.Drawing.Size( 73, 19 );
            this.lblGendor.TabIndex = 150;
            this.lblGendor.Text = "Gendor :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add( this.btnAddNewPerson );
            this.groupBox1.Controls.Add( this.btnSearch );
            this.groupBox1.Controls.Add( this.lblFilters );
            this.groupBox1.Controls.Add( this.txtFilter );
            this.groupBox1.Controls.Add( this.cbxFilters );
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point( 18, 115 );
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size( 848, 89 );
            this.groupBox1.TabIndex = 161;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "FILTER";
            // 
            // btnAddNewPerson
            // 
            this.btnAddNewPerson.Font = new System.Drawing.Font( "Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.btnAddNewPerson.ForeColor = System.Drawing.Color.FromArgb( ( ( int ) ( ( ( byte ) ( 45 ) ) ) ), ( ( int ) ( ( ( byte ) ( 66 ) ) ) ), ( ( int ) ( ( ( byte ) ( 91 ) ) ) ) );
            this.btnAddNewPerson.Location = new System.Drawing.Point( 715, 37 );
            this.btnAddNewPerson.Name = "btnAddNewPerson";
            this.btnAddNewPerson.Size = new System.Drawing.Size( 111, 27 );
            this.btnAddNewPerson.TabIndex = 161;
            this.btnAddNewPerson.Text = "ADD";
            this.btnAddNewPerson.UseVisualStyleBackColor = true;
            this.btnAddNewPerson.Click += new System.EventHandler( this.btnAddNewPerson_Click );
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font( "Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.btnSearch.ForeColor = System.Drawing.Color.FromArgb( ( ( int ) ( ( ( byte ) ( 45 ) ) ) ), ( ( int ) ( ( ( byte ) ( 66 ) ) ) ), ( ( int ) ( ( ( byte ) ( 91 ) ) ) ) );
            this.btnSearch.Location = new System.Drawing.Point( 583, 37 );
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size( 111, 27 );
            this.btnSearch.TabIndex = 160;
            this.btnSearch.Text = "SEARCH";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler( this.btnSearch_Click );
            // 
            // lblFilters
            // 
            this.lblFilters.AutoSize = true;
            this.lblFilters.Font = new System.Drawing.Font( "Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.lblFilters.ForeColor = System.Drawing.Color.White;
            this.lblFilters.Location = new System.Drawing.Point( 21, 41 );
            this.lblFilters.Name = "lblFilters";
            this.lblFilters.Size = new System.Drawing.Size( 70, 16 );
            this.lblFilters.TabIndex = 9;
            this.lblFilters.Text = "Filter By : ";
            // 
            // txtFilter
            // 
            this.txtFilter.Font = new System.Drawing.Font( "Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.txtFilter.Location = new System.Drawing.Point( 333, 39 );
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size( 211, 25 );
            this.txtFilter.TabIndex = 8;
            this.txtFilter.TextChanged += new System.EventHandler( this.txtFilter_TextChanged );
            this.txtFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler( this.txtFilter_KeyPress );
            // 
            // cbxFilters
            // 
            this.cbxFilters.Font = new System.Drawing.Font( "Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.cbxFilters.FormattingEnabled = true;
            this.cbxFilters.Items.AddRange( new object[] {
            "Email",
            "Phone",
            "Personal ID",
            "National Number",
            "User ID",
            "User Name"} );
            this.cbxFilters.Location = new System.Drawing.Point( 115, 37 );
            this.cbxFilters.Name = "cbxFilters";
            this.cbxFilters.Size = new System.Drawing.Size( 211, 27 );
            this.cbxFilters.TabIndex = 7;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font( "Microsoft YaHei", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point( 198, 29 );
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size( 475, 42 );
            this.lblTitle.TabIndex = 160;
            this.lblTitle.Text = "NEW LICENSE APPLICATION";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add( this.rbtnFemale );
            this.groupBox2.Controls.Add( this.rbtnMale );
            this.groupBox2.Controls.Add( this.pbxPerson );
            this.groupBox2.Controls.Add( this.lblRemoveImage );
            this.groupBox2.Controls.Add( this.lblImage );
            this.groupBox2.Controls.Add( this.cmxCountry );
            this.groupBox2.Controls.Add( this.lblCountry );
            this.groupBox2.Controls.Add( this.dtmDateOfBirth );
            this.groupBox2.Controls.Add( this.lblDateOfBirth );
            this.groupBox2.Controls.Add( this.lblEmail );
            this.groupBox2.Controls.Add( this.txtEmail );
            this.groupBox2.Controls.Add( this.lblGendor );
            this.groupBox2.Controls.Add( this.lblPhone );
            this.groupBox2.Controls.Add( this.txtAddress );
            this.groupBox2.Controls.Add( this.lblAddress );
            this.groupBox2.Controls.Add( this.txtPhone );
            this.groupBox2.Controls.Add( this.lblNationalID );
            this.groupBox2.Controls.Add( this.txtNationalID );
            this.groupBox2.Controls.Add( this.txtId );
            this.groupBox2.Controls.Add( this.lblID );
            this.groupBox2.Controls.Add( this.lblLastName );
            this.groupBox2.Controls.Add( this.txtLastName );
            this.groupBox2.Controls.Add( this.lblSecondName );
            this.groupBox2.Controls.Add( this.txtSecondName );
            this.groupBox2.Controls.Add( this.lblThirdName );
            this.groupBox2.Controls.Add( this.txtThirdName );
            this.groupBox2.Controls.Add( this.lblFirstNaame );
            this.groupBox2.Controls.Add( this.txtFirstName );
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point( 18, 224 );
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size( 848, 536 );
            this.groupBox2.TabIndex = 162;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Personal Info :";
            // 
            // pbxPerson
            // 
            this.pbxPerson.Image = global::DVLD.Properties.Resources.male;
            this.pbxPerson.Location = new System.Drawing.Point( 482, 199 );
            this.pbxPerson.Name = "pbxPerson";
            this.pbxPerson.Size = new System.Drawing.Size( 345, 238 );
            this.pbxPerson.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxPerson.TabIndex = 155;
            this.pbxPerson.TabStop = false;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font( "Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.lblPhone.ForeColor = System.Drawing.Color.White;
            this.lblPhone.Location = new System.Drawing.Point( 478, 93 );
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size( 66, 19 );
            this.lblPhone.TabIndex = 149;
            this.lblPhone.Text = "Phone :";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point( 565, 41 );
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size( 262, 20 );
            this.txtAddress.TabIndex = 139;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font( "Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.lblAddress.ForeColor = System.Drawing.Color.White;
            this.lblAddress.Location = new System.Drawing.Point( 478, 40 );
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size( 81, 19 );
            this.lblAddress.TabIndex = 148;
            this.lblAddress.Text = "Address : ";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point( 565, 94 );
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size( 262, 20 );
            this.txtPhone.TabIndex = 140;
            // 
            // lblNationalID
            // 
            this.lblNationalID.AutoSize = true;
            this.lblNationalID.Font = new System.Drawing.Font( "Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.lblNationalID.ForeColor = System.Drawing.Color.White;
            this.lblNationalID.Location = new System.Drawing.Point( 21, 93 );
            this.lblNationalID.Name = "lblNationalID";
            this.lblNationalID.Size = new System.Drawing.Size( 103, 19 );
            this.lblNationalID.TabIndex = 147;
            this.lblNationalID.Text = "National ID :";
            // 
            // txtNationalID
            // 
            this.txtNationalID.Location = new System.Drawing.Point( 164, 91 );
            this.txtNationalID.Name = "txtNationalID";
            this.txtNationalID.Size = new System.Drawing.Size( 239, 20 );
            this.txtNationalID.TabIndex = 131;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point( 164, 38 );
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size( 239, 20 );
            this.txtId.TabIndex = 130;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font( "Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.lblID.ForeColor = System.Drawing.Color.White;
            this.lblID.Location = new System.Drawing.Point( 21, 40 );
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size( 34, 19 );
            this.lblID.TabIndex = 146;
            this.lblID.Text = "ID :";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font( "Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.lblLastName.ForeColor = System.Drawing.Color.White;
            this.lblLastName.Location = new System.Drawing.Point( 21, 305 );
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size( 97, 19 );
            this.lblLastName.TabIndex = 145;
            this.lblLastName.Text = "Last Name :";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point( 164, 303 );
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size( 239, 20 );
            this.txtLastName.TabIndex = 135;
            // 
            // lblSecondName
            // 
            this.lblSecondName.AutoSize = true;
            this.lblSecondName.Font = new System.Drawing.Font( "Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.lblSecondName.ForeColor = System.Drawing.Color.White;
            this.lblSecondName.Location = new System.Drawing.Point( 21, 199 );
            this.lblSecondName.Name = "lblSecondName";
            this.lblSecondName.Size = new System.Drawing.Size( 123, 19 );
            this.lblSecondName.TabIndex = 144;
            this.lblSecondName.Text = "Second Name :";
            // 
            // txtSecondName
            // 
            this.txtSecondName.Location = new System.Drawing.Point( 164, 197 );
            this.txtSecondName.Name = "txtSecondName";
            this.txtSecondName.Size = new System.Drawing.Size( 239, 20 );
            this.txtSecondName.TabIndex = 133;
            // 
            // lblThirdName
            // 
            this.lblThirdName.AutoSize = true;
            this.lblThirdName.Font = new System.Drawing.Font( "Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.lblThirdName.ForeColor = System.Drawing.Color.White;
            this.lblThirdName.Location = new System.Drawing.Point( 21, 252 );
            this.lblThirdName.Name = "lblThirdName";
            this.lblThirdName.Size = new System.Drawing.Size( 106, 19 );
            this.lblThirdName.TabIndex = 143;
            this.lblThirdName.Text = "Third Name :";
            // 
            // txtThirdName
            // 
            this.txtThirdName.Location = new System.Drawing.Point( 164, 250 );
            this.txtThirdName.Name = "txtThirdName";
            this.txtThirdName.Size = new System.Drawing.Size( 239, 20 );
            this.txtThirdName.TabIndex = 134;
            // 
            // lblFirstNaame
            // 
            this.lblFirstNaame.AutoSize = true;
            this.lblFirstNaame.Font = new System.Drawing.Font( "Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.lblFirstNaame.ForeColor = System.Drawing.Color.White;
            this.lblFirstNaame.Location = new System.Drawing.Point( 21, 146 );
            this.lblFirstNaame.Name = "lblFirstNaame";
            this.lblFirstNaame.Size = new System.Drawing.Size( 98, 19 );
            this.lblFirstNaame.TabIndex = 142;
            this.lblFirstNaame.Text = "First Name :";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point( 164, 144 );
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size( 239, 20 );
            this.txtFirstName.TabIndex = 132;
            // 
            // frmNewLicenseApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb( ( ( int ) ( ( ( byte ) ( 24 ) ) ) ), ( ( int ) ( ( ( byte ) ( 30 ) ) ) ), ( ( int ) ( ( ( byte ) ( 54 ) ) ) ) );
            this.ClientSize = new System.Drawing.Size( 881, 870 );
            this.Controls.Add( this.btnNext );
            this.Controls.Add( this.btnClose );
            this.Controls.Add( this.groupBox1 );
            this.Controls.Add( this.lblTitle );
            this.Controls.Add( this.groupBox2 );
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmNewLicenseApplication";
            this.Text = "frmNewLicenseApplication";
            this.Load += new System.EventHandler( this.frmNewLicenseApplication_Load );
            ( ( System.ComponentModel.ISupportInitialize ) ( this.errorProvider1 ) ).EndInit();
            this.groupBox1.ResumeLayout( false );
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout( false );
            this.groupBox2.PerformLayout();
            ( ( System.ComponentModel.ISupportInitialize ) ( this.pbxPerson ) ).EndInit();
            this.ResumeLayout( false );
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAddNewPerson;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblFilters;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.ComboBox cbxFilters;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbtnFemale;
        private System.Windows.Forms.RadioButton rbtnMale;
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
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblSecondName;
        private System.Windows.Forms.TextBox txtSecondName;
        private System.Windows.Forms.Label lblThirdName;
        private System.Windows.Forms.TextBox txtThirdName;
        private System.Windows.Forms.Label lblFirstNaame;
        private System.Windows.Forms.TextBox txtFirstName;
    }
}