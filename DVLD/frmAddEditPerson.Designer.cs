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
            this.button1 = new System.Windows.Forms.Button();
            this.ctrShowPersonDetails1 = new DVLD.ctrShowPersonDetails();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font( "Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.button1.ForeColor = System.Drawing.Color.FromArgb( ( ( int ) ( ( ( byte ) ( 0 ) ) ) ), ( ( int ) ( ( ( byte ) ( 117 ) ) ) ), ( ( int ) ( ( ( byte ) ( 214 ) ) ) ) );
            this.button1.Location = new System.Drawing.Point( 243, 692 );
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size( 141, 41 );
            this.button1.TabIndex = 62;
            this.button1.Text = "CLOSE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler( this.button1_Click );
            // 
            // ctrShowPersonDetails1
            // 
            this.ctrShowPersonDetails1.BackColor = System.Drawing.Color.FromArgb( ( ( int ) ( ( ( byte ) ( 0 ) ) ) ), ( ( int ) ( ( ( byte ) ( 117 ) ) ) ), ( ( int ) ( ( ( byte ) ( 214 ) ) ) ) );
            this.ctrShowPersonDetails1.Location = new System.Drawing.Point( 0, -2 );
            this.ctrShowPersonDetails1.Name = "ctrShowPersonDetails1";
            this.ctrShowPersonDetails1.PersonID = 0;
            this.ctrShowPersonDetails1.Size = new System.Drawing.Size( 842, 665 );
            this.ctrShowPersonDetails1.TabIndex = 63;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font( "Microsoft YaHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb( ( ( int ) ( ( ( byte ) ( 0 ) ) ) ), ( ( int ) ( ( ( byte ) ( 117 ) ) ) ), ( ( int ) ( ( ( byte ) ( 214 ) ) ) ) );
            this.btnSave.Location = new System.Drawing.Point( 458, 692 );
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size( 141, 41 );
            this.btnSave.TabIndex = 64;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler( this.btnSave_Click );
            // 
            // frmAddEditPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb( ( ( int ) ( ( ( byte ) ( 0 ) ) ) ), ( ( int ) ( ( ( byte ) ( 117 ) ) ) ), ( ( int ) ( ( ( byte ) ( 214 ) ) ) ) );
            this.ClientSize = new System.Drawing.Size( 843, 782 );
            this.Controls.Add( this.btnSave );
            this.Controls.Add( this.ctrShowPersonDetails1 );
            this.Controls.Add( this.button1 );
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAddEditPerson";
            this.Text = "frmAddEditPerson";
            this.Load += new System.EventHandler( this.frmAddEditPerson_Load );
            this.ResumeLayout( false );

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private ctrShowPersonDetails ctrShowPersonDetails1;
        private System.Windows.Forms.Button btnSave;
    }
}