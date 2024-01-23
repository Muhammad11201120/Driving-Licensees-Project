namespace DVLD
{
    partial class frmChangePassword
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
            this.txtCurrentPass = new System.Windows.Forms.TextBox();
            this.lblCurrentPas = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtConfirmNewPass = new System.Windows.Forms.TextBox();
            this.txtNewPass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider( this.components );
            ( ( System.ComponentModel.ISupportInitialize ) ( this.errorProvider1 ) ).BeginInit();
            this.SuspendLayout();
            // 
            // txtCurrentPass
            // 
            this.txtCurrentPass.Font = new System.Drawing.Font( "Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.txtCurrentPass.Location = new System.Drawing.Point( 313, 153 );
            this.txtCurrentPass.Name = "txtCurrentPass";
            this.txtCurrentPass.Size = new System.Drawing.Size( 239, 25 );
            this.txtCurrentPass.TabIndex = 148;
            // 
            // lblCurrentPas
            // 
            this.lblCurrentPas.AutoSize = true;
            this.lblCurrentPas.Font = new System.Drawing.Font( "Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.lblCurrentPas.ForeColor = System.Drawing.Color.White;
            this.lblCurrentPas.Location = new System.Drawing.Point( 124, 156 );
            this.lblCurrentPas.Name = "lblCurrentPas";
            this.lblCurrentPas.Size = new System.Drawing.Size( 183, 19 );
            this.lblCurrentPas.TabIndex = 150;
            this.lblCurrentPas.Text = "CURRENT PASSWORD :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font( "Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point( 78, 307 );
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size( 229, 19 );
            this.label1.TabIndex = 155;
            this.label1.Text = "CONFIRM NEW PASSWORD : ";
            // 
            // txtConfirmNewPass
            // 
            this.txtConfirmNewPass.Font = new System.Drawing.Font( "Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.txtConfirmNewPass.Location = new System.Drawing.Point( 313, 304 );
            this.txtConfirmNewPass.Name = "txtConfirmNewPass";
            this.txtConfirmNewPass.Size = new System.Drawing.Size( 239, 25 );
            this.txtConfirmNewPass.TabIndex = 153;
            this.txtConfirmNewPass.Leave += new System.EventHandler( this.txtConfirmNewPass_Leave );
            // 
            // txtNewPass
            // 
            this.txtNewPass.Font = new System.Drawing.Font( "Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.txtNewPass.Location = new System.Drawing.Point( 313, 249 );
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.Size = new System.Drawing.Size( 239, 25 );
            this.txtNewPass.TabIndex = 152;
            this.txtNewPass.Leave += new System.EventHandler( this.txtNewPass_Leave );
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font( "Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point( 155, 252 );
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size( 152, 19 );
            this.label2.TabIndex = 154;
            this.label2.Text = "NEW PASSWORD : ";
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font( "Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb( ( ( int ) ( ( ( byte ) ( 45 ) ) ) ), ( ( int ) ( ( ( byte ) ( 66 ) ) ) ), ( ( int ) ( ( ( byte ) ( 91 ) ) ) ) );
            this.btnCancel.Image = global::DVLD.Properties.Resources.cross_32;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point( 313, 370 );
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size( 88, 45 );
            this.btnCancel.TabIndex = 156;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler( this.btnCancel_Click );
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font( "Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb( ( ( int ) ( ( ( byte ) ( 45 ) ) ) ), ( ( int ) ( ( ( byte ) ( 66 ) ) ) ), ( ( int ) ( ( ( byte ) ( 91 ) ) ) ) );
            this.btnSave.Image = global::DVLD.Properties.Resources.Save_32;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point( 444, 370 );
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size( 88, 45 );
            this.btnSave.TabIndex = 157;
            this.btnSave.Text = "SAVE";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler( this.btnSave_Click );
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font( "Microsoft YaHei", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point( 186, 56 );
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size( 369, 42 );
            this.lblTitle.TabIndex = 158;
            this.lblTitle.Text = "CHANGE PASSWORD ";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb( ( ( int ) ( ( ( byte ) ( 46 ) ) ) ), ( ( int ) ( ( ( byte ) ( 51 ) ) ) ), ( ( int ) ( ( ( byte ) ( 73 ) ) ) ) );
            this.ClientSize = new System.Drawing.Size( 757, 450 );
            this.Controls.Add( this.lblTitle );
            this.Controls.Add( this.btnSave );
            this.Controls.Add( this.btnCancel );
            this.Controls.Add( this.label1 );
            this.Controls.Add( this.txtConfirmNewPass );
            this.Controls.Add( this.txtNewPass );
            this.Controls.Add( this.label2 );
            this.Controls.Add( this.txtCurrentPass );
            this.Controls.Add( this.lblCurrentPas );
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmChangePassword";
            this.Text = "frmChangePassword";
            this.Load += new System.EventHandler( this.frmChangePassword_Load );
            ( ( System.ComponentModel.ISupportInitialize ) ( this.errorProvider1 ) ).EndInit();
            this.ResumeLayout( false );
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtCurrentPass;
        private System.Windows.Forms.Label lblCurrentPas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtConfirmNewPass;
        private System.Windows.Forms.TextBox txtNewPass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}