namespace DVLD
{
    partial class frmVisionTestAppointment
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
            this.label3 = new System.Windows.Forms.Label();
            this.lblRecords = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvAppoinments = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAddNewAppointment = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ctrApplicationInfo1 = new DVLD.ctrApplicationInfo();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppoinments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(318, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(321, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "VISION TEST APPOINTMENT";
            // 
            // lblRecords
            // 
            this.lblRecords.AutoSize = true;
            this.lblRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecords.ForeColor = System.Drawing.Color.White;
            this.lblRecords.Location = new System.Drawing.Point(162, 941);
            this.lblRecords.Name = "lblRecords";
            this.lblRecords.Size = new System.Drawing.Size(29, 20);
            this.lblRecords.TabIndex = 15;
            this.lblRecords.Text = "??";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(32, 941);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "# RECORDS : ";
            // 
            // dgvAppoinments
            // 
            this.dgvAppoinments.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.dgvAppoinments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAppoinments.Location = new System.Drawing.Point(36, 643);
            this.dgvAppoinments.Name = "dgvAppoinments";
            this.dgvAppoinments.Size = new System.Drawing.Size(879, 281);
            this.dgvAppoinments.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(32, 603);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "APPOINTMENTS : ";
            // 
            // btnClose
            // 
            this.btnClose.Image = global::DVLD.Properties.Resources.cross_32;
            this.btnClose.Location = new System.Drawing.Point(842, 930);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(73, 45);
            this.btnClose.TabIndex = 17;
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnAddNewAppointment
            // 
            this.btnAddNewAppointment.Image = global::DVLD.Properties.Resources.AddAppointment_32;
            this.btnAddNewAppointment.Location = new System.Drawing.Point(842, 592);
            this.btnAddNewAppointment.Name = "btnAddNewAppointment";
            this.btnAddNewAppointment.Size = new System.Drawing.Size(73, 45);
            this.btnAddNewAppointment.TabIndex = 16;
            this.btnAddNewAppointment.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = global::DVLD.Properties.Resources.Vision_512;
            this.pictureBox1.InitialImage = global::DVLD.Properties.Resources.Vision_512;
            this.pictureBox1.Location = new System.Drawing.Point(409, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(137, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // ctrApplicationInfo1
            // 
            this.ctrApplicationInfo1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ctrApplicationInfo1.Location = new System.Drawing.Point(36, 154);
            this.ctrApplicationInfo1.Name = "ctrApplicationInfo1";
            this.ctrApplicationInfo1.Size = new System.Drawing.Size(879, 419);
            this.ctrApplicationInfo1.TabIndex = 18;
            // 
            // frmVisionTestAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(955, 1043);
            this.Controls.Add(this.ctrApplicationInfo1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAddNewAppointment);
            this.Controls.Add(this.lblRecords);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvAppoinments);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Name = "frmVisionTestAppointment";
            this.Text = "frmVisionTestAppointment";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppoinments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnAddNewAppointment;
        private System.Windows.Forms.Label lblRecords;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvAppoinments;
        private System.Windows.Forms.Label label1;
        private ctrApplicationInfo ctrApplicationInfo1;
    }
}