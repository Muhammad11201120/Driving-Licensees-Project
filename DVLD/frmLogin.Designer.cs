namespace DVLD
{
    partial class frmLogin
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
            System.Windows.Forms.GroupBox groupBox1;
            this.lblClose = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbxIsActive = new System.Windows.Forms.GroupBox();
            this.rdbtnNo = new System.Windows.Forms.RadioButton();
            this.rdbtnYes = new System.Windows.Forms.RadioButton();
            this.btnLogin = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNewRigester = new System.Windows.Forms.Label();
            groupBox1 = new System.Windows.Forms.GroupBox();
            groupBox1.SuspendLayout();
            ( ( System.ComponentModel.ISupportInitialize ) ( this.pictureBox1 ) ).BeginInit();
            this.gbxIsActive.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            groupBox1.BackColor = System.Drawing.Color.SteelBlue;
            groupBox1.Controls.Add( this.lblClose );
            groupBox1.Controls.Add( this.panel2 );
            groupBox1.Controls.Add( this.panel1 );
            groupBox1.Controls.Add( this.txtUserName );
            groupBox1.Controls.Add( this.label2 );
            groupBox1.Controls.Add( this.label1 );
            groupBox1.Controls.Add( this.txtPassword );
            groupBox1.Controls.Add( this.btnClose );
            groupBox1.Controls.Add( this.pictureBox1 );
            groupBox1.Controls.Add( this.gbxIsActive );
            groupBox1.Controls.Add( this.btnLogin );
            groupBox1.Controls.Add( this.label3 );
            groupBox1.Controls.Add( this.lblNewRigester );
            groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            groupBox1.Location = new System.Drawing.Point( 0, 0 );
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size( 415, 540 );
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            // 
            // lblClose
            // 
            this.lblClose.AutoSize = true;
            this.lblClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblClose.Font = new System.Drawing.Font( "Microsoft Sans Serif", 14.25F, ( ( System.Drawing.FontStyle ) ( ( System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline ) ) ), System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.lblClose.ForeColor = System.Drawing.Color.FromArgb( ( ( int ) ( ( ( byte ) ( 0 ) ) ) ), ( ( int ) ( ( ( byte ) ( 117 ) ) ) ), ( ( int ) ( ( ( byte ) ( 214 ) ) ) ) );
            this.lblClose.Location = new System.Drawing.Point( 388, 0 );
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size( 25, 24 );
            this.lblClose.TabIndex = 11;
            this.lblClose.Text = "X";
            this.lblClose.Click += new System.EventHandler( this.lblClose_Click );
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb( ( ( int ) ( ( ( byte ) ( 0 ) ) ) ), ( ( int ) ( ( ( byte ) ( 117 ) ) ) ), ( ( int ) ( ( ( byte ) ( 214 ) ) ) ) );
            this.panel2.Location = new System.Drawing.Point( 145, 232 );
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size( 236, 1 );
            this.panel2.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb( ( ( int ) ( ( ( byte ) ( 0 ) ) ) ), ( ( int ) ( ( ( byte ) ( 117 ) ) ) ), ( ( int ) ( ( ( byte ) ( 214 ) ) ) ) );
            this.panel1.Location = new System.Drawing.Point( 145, 273 );
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size( 236, 1 );
            this.panel1.TabIndex = 9;
            // 
            // txtUserName
            // 
            this.txtUserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUserName.Font = new System.Drawing.Font( "Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.txtUserName.ForeColor = System.Drawing.Color.FromArgb( ( ( int ) ( ( ( byte ) ( 0 ) ) ) ), ( ( int ) ( ( ( byte ) ( 117 ) ) ) ), ( ( int ) ( ( ( byte ) ( 214 ) ) ) ) );
            this.txtUserName.Location = new System.Drawing.Point( 144, 208 );
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size( 235, 18 );
            this.txtUserName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font( "Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.label2.ForeColor = System.Drawing.Color.FromArgb( ( ( int ) ( ( ( byte ) ( 45 ) ) ) ), ( ( int ) ( ( ( byte ) ( 66 ) ) ) ), ( ( int ) ( ( ( byte ) ( 91 ) ) ) ) );
            this.label2.Location = new System.Drawing.Point( 38, 253 );
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size( 100, 19 );
            this.label2.TabIndex = 3;
            this.label2.Text = "PASSWORD : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font( "Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.label1.ForeColor = System.Drawing.Color.FromArgb( ( ( int ) ( ( ( byte ) ( 45 ) ) ) ), ( ( int ) ( ( ( byte ) ( 66 ) ) ) ), ( ( int ) ( ( ( byte ) ( 91 ) ) ) ) );
            this.label1.Location = new System.Drawing.Point( 38, 209 );
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size( 100, 19 );
            this.label1.TabIndex = 0;
            this.label1.Text = "USER NAME : ";
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font( "Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb( ( ( int ) ( ( ( byte ) ( 0 ) ) ) ), ( ( int ) ( ( ( byte ) ( 117 ) ) ) ), ( ( int ) ( ( ( byte ) ( 214 ) ) ) ) );
            this.txtPassword.Location = new System.Drawing.Point( 145, 249 );
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size( 235, 18 );
            this.txtPassword.TabIndex = 4;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Font = new System.Drawing.Font( "Microsoft YaHei", 9.75F, ( ( System.Drawing.FontStyle ) ( ( System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline ) ) ), System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb( ( ( int ) ( ( ( byte ) ( 45 ) ) ) ), ( ( int ) ( ( ( byte ) ( 66 ) ) ) ), ( ( int ) ( ( ( byte ) ( 91 ) ) ) ) );
            this.btnClose.Location = new System.Drawing.Point( 43, 427 );
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size( 338, 43 );
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "CLOSE";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler( this.btnClose_Click );
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLD.Properties.Resources.login1;
            this.pictureBox1.Location = new System.Drawing.Point( 163, 36 );
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size( 75, 72 );
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // gbxIsActive
            // 
            this.gbxIsActive.Controls.Add( this.rdbtnNo );
            this.gbxIsActive.Controls.Add( this.rdbtnYes );
            this.gbxIsActive.Font = new System.Drawing.Font( "Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.gbxIsActive.ForeColor = System.Drawing.Color.FromArgb( ( ( int ) ( ( ( byte ) ( 45 ) ) ) ), ( ( int ) ( ( ( byte ) ( 66 ) ) ) ), ( ( int ) ( ( ( byte ) ( 91 ) ) ) ) );
            this.gbxIsActive.Location = new System.Drawing.Point( 43, 296 );
            this.gbxIsActive.Name = "gbxIsActive";
            this.gbxIsActive.Size = new System.Drawing.Size( 338, 61 );
            this.gbxIsActive.TabIndex = 2;
            this.gbxIsActive.TabStop = false;
            this.gbxIsActive.Text = "IS ACTIVE ? : ";
            // 
            // rdbtnNo
            // 
            this.rdbtnNo.AutoSize = true;
            this.rdbtnNo.Font = new System.Drawing.Font( "Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.rdbtnNo.ForeColor = System.Drawing.Color.FromArgb( ( ( int ) ( ( ( byte ) ( 45 ) ) ) ), ( ( int ) ( ( ( byte ) ( 66 ) ) ) ), ( ( int ) ( ( ( byte ) ( 91 ) ) ) ) );
            this.rdbtnNo.Location = new System.Drawing.Point( 281, 24 );
            this.rdbtnNo.Name = "rdbtnNo";
            this.rdbtnNo.Size = new System.Drawing.Size( 49, 23 );
            this.rdbtnNo.TabIndex = 1;
            this.rdbtnNo.Text = "NO";
            this.rdbtnNo.UseVisualStyleBackColor = true;
            // 
            // rdbtnYes
            // 
            this.rdbtnYes.AutoSize = true;
            this.rdbtnYes.Checked = true;
            this.rdbtnYes.Font = new System.Drawing.Font( "Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.rdbtnYes.ForeColor = System.Drawing.Color.FromArgb( ( ( int ) ( ( ( byte ) ( 45 ) ) ) ), ( ( int ) ( ( ( byte ) ( 66 ) ) ) ), ( ( int ) ( ( ( byte ) ( 91 ) ) ) ) );
            this.rdbtnYes.Location = new System.Drawing.Point( 101, 24 );
            this.rdbtnYes.Name = "rdbtnYes";
            this.rdbtnYes.Size = new System.Drawing.Size( 50, 23 );
            this.rdbtnYes.TabIndex = 0;
            this.rdbtnYes.TabStop = true;
            this.rdbtnYes.Text = "YES";
            this.rdbtnYes.UseVisualStyleBackColor = true;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb( ( ( int ) ( ( ( byte ) ( 45 ) ) ) ), ( ( int ) ( ( ( byte ) ( 66 ) ) ) ), ( ( int ) ( ( ( byte ) ( 91 ) ) ) ) );
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.Font = new System.Drawing.Font( "Microsoft YaHei", 9.75F, ( ( System.Drawing.FontStyle ) ( ( System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline ) ) ), System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point( 42, 378 );
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size( 338, 43 );
            this.btnLogin.TabIndex = 7;
            this.btnLogin.Text = "LOGIN";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler( this.btnLogin_Click );
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font( "Lucida Handwriting", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.label3.ForeColor = System.Drawing.Color.FromArgb( ( ( int ) ( ( ( byte ) ( 45 ) ) ) ), ( ( int ) ( ( ( byte ) ( 66 ) ) ) ), ( ( int ) ( ( ( byte ) ( 91 ) ) ) ) );
            this.label3.Location = new System.Drawing.Point( 118, 131 );
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size( 174, 45 );
            this.label3.TabIndex = 5;
            this.label3.Text = "LOG IN ";
            // 
            // lblNewRigester
            // 
            this.lblNewRigester.AutoSize = true;
            this.lblNewRigester.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblNewRigester.Font = new System.Drawing.Font( "Microsoft YaHei", 9.75F, ( ( System.Drawing.FontStyle ) ( ( System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline ) ) ), System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.lblNewRigester.ForeColor = System.Drawing.Color.FromArgb( ( ( int ) ( ( ( byte ) ( 45 ) ) ) ), ( ( int ) ( ( ( byte ) ( 66 ) ) ) ), ( ( int ) ( ( ( byte ) ( 91 ) ) ) ) );
            this.lblNewRigester.Location = new System.Drawing.Point( 167, 485 );
            this.lblNewRigester.Name = "lblNewRigester";
            this.lblNewRigester.Size = new System.Drawing.Size( 212, 19 );
            this.lblNewRigester.TabIndex = 6;
            this.lblNewRigester.Text = "DO NOT HAVE AN ACCOUNT ?";
            this.lblNewRigester.Click += new System.EventHandler( this.lblNewRigester_Click );
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size( 415, 540 );
            this.Controls.Add( groupBox1 );
            this.Font = new System.Drawing.Font( "Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLogin";
            this.Load += new System.EventHandler( this.frmLogin_Load );
            groupBox1.ResumeLayout( false );
            groupBox1.PerformLayout();
            ( ( System.ComponentModel.ISupportInitialize ) ( this.pictureBox1 ) ).EndInit();
            this.gbxIsActive.ResumeLayout( false );
            this.gbxIsActive.PerformLayout();
            this.ResumeLayout( false );

        }

        #endregion

        private System.Windows.Forms.Label lblNewRigester;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.GroupBox gbxIsActive;
        private System.Windows.Forms.RadioButton rdbtnNo;
        private System.Windows.Forms.RadioButton rdbtnYes;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblClose;
    }
}