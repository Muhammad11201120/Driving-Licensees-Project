namespace DVLD
{
    partial class frmIssueTest
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
            this.label6 = new System.Windows.Forms.Label();
            this.rdbtnPass = new System.Windows.Forms.RadioButton();
            this.rbtnFail = new System.Windows.Forms.RadioButton();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.ctrTests1 = new DVLD.ctrTests();
            ( ( System.ComponentModel.ISupportInitialize ) ( this.pictureBox3 ) ).BeginInit();
            ( ( System.ComponentModel.ISupportInitialize ) ( this.pictureBox2 ) ).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font( "Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point( 63, 638 );
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size( 65, 17 );
            this.label6.TabIndex = 16;
            this.label6.Text = "RESULT : ";
            // 
            // rdbtnPass
            // 
            this.rdbtnPass.AutoSize = true;
            this.rdbtnPass.Font = new System.Drawing.Font( "Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.rdbtnPass.ForeColor = System.Drawing.Color.FromArgb( ( ( int ) ( ( ( byte ) ( 0 ) ) ) ), ( ( int ) ( ( ( byte ) ( 192 ) ) ) ), ( ( int ) ( ( ( byte ) ( 0 ) ) ) ) );
            this.rdbtnPass.Location = new System.Drawing.Point( 205, 653 );
            this.rdbtnPass.Name = "rdbtnPass";
            this.rdbtnPass.Size = new System.Drawing.Size( 60, 19 );
            this.rdbtnPass.TabIndex = 17;
            this.rdbtnPass.TabStop = true;
            this.rdbtnPass.Text = "PASS";
            this.rdbtnPass.UseVisualStyleBackColor = true;
            // 
            // rbtnFail
            // 
            this.rbtnFail.AutoSize = true;
            this.rbtnFail.Font = new System.Drawing.Font( "Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.rbtnFail.ForeColor = System.Drawing.Color.Red;
            this.rbtnFail.Location = new System.Drawing.Point( 296, 653 );
            this.rbtnFail.Name = "rbtnFail";
            this.rbtnFail.Size = new System.Drawing.Size( 53, 19 );
            this.rbtnFail.TabIndex = 18;
            this.rbtnFail.TabStop = true;
            this.rbtnFail.Text = "FAIL";
            this.rbtnFail.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point( 159, 731 );
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size( 521, 117 );
            this.richTextBox1.TabIndex = 20;
            this.richTextBox1.Text = "";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font( "Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label9.Location = new System.Drawing.Point( 63, 713 );
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size( 54, 17 );
            this.label9.TabIndex = 19;
            this.label9.Text = "NOTE : ";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font( "Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb( ( ( int ) ( ( ( byte ) ( 46 ) ) ) ), ( ( int ) ( ( ( byte ) ( 51 ) ) ) ), ( ( int ) ( ( ( byte ) ( 73 ) ) ) ) );
            this.btnSave.Image = global::DVLD.Properties.Resources.Save_32;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point( 296, 854 );
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size( 96, 36 );
            this.btnSave.TabIndex = 31;
            this.btnSave.Text = "SAVE";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler( this.btnSave_Click );
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font( "Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb( ( ( int ) ( ( ( byte ) ( 46 ) ) ) ), ( ( int ) ( ( ( byte ) ( 51 ) ) ) ), ( ( int ) ( ( ( byte ) ( 73 ) ) ) ) );
            this.btnClose.Image = global::DVLD.Properties.Resources.cross_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point( 424, 854 );
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size( 96, 36 );
            this.btnClose.TabIndex = 30;
            this.btnClose.Text = "CLOSE";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler( this.btnClose_Click );
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::DVLD.Properties.Resources.ApplicationType1;
            this.pictureBox3.Location = new System.Drawing.Point( 123, 638 );
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size( 49, 34 );
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 22;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::DVLD.Properties.Resources.Notes_32;
            this.pictureBox2.Location = new System.Drawing.Point( 123, 713 );
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size( 30, 34 );
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            // 
            // ctrTests1
            // 
            this.ctrTests1.BackColor = System.Drawing.Color.FromArgb( ( ( int ) ( ( ( byte ) ( 46 ) ) ) ), ( ( int ) ( ( ( byte ) ( 51 ) ) ) ), ( ( int ) ( ( ( byte ) ( 73 ) ) ) ) );
            this.ctrTests1.Location = new System.Drawing.Point( 99, 2 );
            this.ctrTests1.Name = "ctrTests1";
            this.ctrTests1.Size = new System.Drawing.Size( 581, 591 );
            this.ctrTests1.TabIndex = 32;
            this.ctrTests1.TestTypeID = DVLD_BusinessLayer.clsTestTypes.enTestTypes.VisionTest;
            // 
            // frmIssueTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb( ( ( int ) ( ( ( byte ) ( 46 ) ) ) ), ( ( int ) ( ( ( byte ) ( 51 ) ) ) ), ( ( int ) ( ( ( byte ) ( 73 ) ) ) ) );
            this.ClientSize = new System.Drawing.Size( 750, 902 );
            this.Controls.Add( this.ctrTests1 );
            this.Controls.Add( this.btnSave );
            this.Controls.Add( this.btnClose );
            this.Controls.Add( this.pictureBox3 );
            this.Controls.Add( this.pictureBox2 );
            this.Controls.Add( this.richTextBox1 );
            this.Controls.Add( this.label9 );
            this.Controls.Add( this.rbtnFail );
            this.Controls.Add( this.rdbtnPass );
            this.Controls.Add( this.label6 );
            this.Name = "frmIssueTest";
            this.Text = "7";
            this.Load += new System.EventHandler( this.frmIssueTest_Load );
            ( ( System.ComponentModel.ISupportInitialize ) ( this.pictureBox3 ) ).EndInit();
            ( ( System.ComponentModel.ISupportInitialize ) ( this.pictureBox2 ) ).EndInit();
            this.ResumeLayout( false );
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rdbtnPass;
        private System.Windows.Forms.RadioButton rbtnFail;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private ctrTests ctrTests1;
    }
}