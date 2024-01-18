namespace DVLD
{
    partial class frmAllPeople
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvAllPeopleList = new System.Windows.Forms.DataGridView();
            this.EditDeleteMenueStripe = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.eDITToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dELETEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aDDNEWPERSONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sHOWDETAILSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sENDEMAILToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pHONECALLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddPerson = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.cbxFilters = new System.Windows.Forms.ComboBox();
            this.lblFilters = new System.Windows.Forms.Label();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblRecords = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllPeopleList)).BeginInit();
            this.EditDeleteMenueStripe.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAllPeopleList
            // 
            this.dgvAllPeopleList.AllowUserToAddRows = false;
            this.dgvAllPeopleList.AllowUserToDeleteRows = false;
            this.dgvAllPeopleList.AllowUserToOrderColumns = true;
            this.dgvAllPeopleList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAllPeopleList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvAllPeopleList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dgvAllPeopleList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAllPeopleList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAllPeopleList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAllPeopleList.ColumnHeadersHeight = 30;
            this.dgvAllPeopleList.ContextMenuStrip = this.EditDeleteMenueStripe;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAllPeopleList.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAllPeopleList.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvAllPeopleList.Location = new System.Drawing.Point(0, 129);
            this.dgvAllPeopleList.Name = "dgvAllPeopleList";
            this.dgvAllPeopleList.ReadOnly = true;
            this.dgvAllPeopleList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAllPeopleList.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAllPeopleList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAllPeopleList.Size = new System.Drawing.Size(1456, 591);
            this.dgvAllPeopleList.TabIndex = 0;
            // 
            // EditDeleteMenueStripe
            // 
            this.EditDeleteMenueStripe.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.EditDeleteMenueStripe.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.EditDeleteMenueStripe.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eDITToolStripMenuItem,
            this.dELETEToolStripMenuItem,
            this.aDDNEWPERSONToolStripMenuItem,
            this.sHOWDETAILSToolStripMenuItem,
            this.sENDEMAILToolStripMenuItem,
            this.pHONECALLToolStripMenuItem});
            this.EditDeleteMenueStripe.Name = "EditDeleteMenueStripe";
            this.EditDeleteMenueStripe.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.EditDeleteMenueStripe.Size = new System.Drawing.Size(200, 160);
            // 
            // eDITToolStripMenuItem
            // 
            this.eDITToolStripMenuItem.Image = global::DVLD.Properties.Resources.edit;
            this.eDITToolStripMenuItem.Name = "eDITToolStripMenuItem";
            this.eDITToolStripMenuItem.Size = new System.Drawing.Size(199, 26);
            this.eDITToolStripMenuItem.Text = "EDIT";
            this.eDITToolStripMenuItem.Click += new System.EventHandler(this.eDITToolStripMenuItem_Click);
            // 
            // dELETEToolStripMenuItem
            // 
            this.dELETEToolStripMenuItem.Image = global::DVLD.Properties.Resources.delete;
            this.dELETEToolStripMenuItem.Name = "dELETEToolStripMenuItem";
            this.dELETEToolStripMenuItem.Size = new System.Drawing.Size(199, 26);
            this.dELETEToolStripMenuItem.Text = "DELETE";
            this.dELETEToolStripMenuItem.Click += new System.EventHandler(this.dELETEToolStripMenuItem_Click);
            // 
            // aDDNEWPERSONToolStripMenuItem
            // 
            this.aDDNEWPERSONToolStripMenuItem.Image = global::DVLD.Properties.Resources.AddUser;
            this.aDDNEWPERSONToolStripMenuItem.Name = "aDDNEWPERSONToolStripMenuItem";
            this.aDDNEWPERSONToolStripMenuItem.Size = new System.Drawing.Size(199, 26);
            this.aDDNEWPERSONToolStripMenuItem.Text = "ADD NEW PERSON";
            this.aDDNEWPERSONToolStripMenuItem.Click += new System.EventHandler(this.aDDNEWPERSONToolStripMenuItem_Click);
            // 
            // sHOWDETAILSToolStripMenuItem
            // 
            this.sHOWDETAILSToolStripMenuItem.Name = "sHOWDETAILSToolStripMenuItem";
            this.sHOWDETAILSToolStripMenuItem.Size = new System.Drawing.Size(199, 26);
            this.sHOWDETAILSToolStripMenuItem.Text = "SHOW DETAILS";
            this.sHOWDETAILSToolStripMenuItem.Click += new System.EventHandler(this.sHOWDETAILSToolStripMenuItem_Click);
            // 
            // sENDEMAILToolStripMenuItem
            // 
            this.sENDEMAILToolStripMenuItem.Image = global::DVLD.Properties.Resources.mail1;
            this.sENDEMAILToolStripMenuItem.Name = "sENDEMAILToolStripMenuItem";
            this.sENDEMAILToolStripMenuItem.Size = new System.Drawing.Size(199, 26);
            this.sENDEMAILToolStripMenuItem.Text = "SEND EMAIL";
            this.sENDEMAILToolStripMenuItem.Click += new System.EventHandler(this.sENDEMAILToolStripMenuItem_Click);
            // 
            // pHONECALLToolStripMenuItem
            // 
            this.pHONECALLToolStripMenuItem.Image = global::DVLD.Properties.Resources.phone1;
            this.pHONECALLToolStripMenuItem.Name = "pHONECALLToolStripMenuItem";
            this.pHONECALLToolStripMenuItem.Size = new System.Drawing.Size(199, 26);
            this.pHONECALLToolStripMenuItem.Text = "PHONE CALL";
            this.pHONECALLToolStripMenuItem.Click += new System.EventHandler(this.pHONECALLToolStripMenuItem_Click);
            // 
            // btnAddPerson
            // 
            this.btnAddPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPerson.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.btnAddPerson.Location = new System.Drawing.Point(1340, 81);
            this.btnAddPerson.Name = "btnAddPerson";
            this.btnAddPerson.Size = new System.Drawing.Size(108, 40);
            this.btnAddPerson.TabIndex = 1;
            this.btnAddPerson.Text = "Add Person";
            this.btnAddPerson.UseVisualStyleBackColor = true;
            this.btnAddPerson.Click += new System.EventHandler(this.btnAddPerson_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.btnClose.Location = new System.Drawing.Point(1340, 128);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(108, 40);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "CLOSE";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // cbxFilters
            // 
            this.cbxFilters.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxFilters.FormattingEnabled = true;
            this.cbxFilters.Items.AddRange(new object[] {
            "First Name",
            "Second Name",
            "Third Name",
            "Last name",
            "Email",
            "Phone",
            "National Number",
            "Gendor",
            "Person ID",
            "All People"});
            this.cbxFilters.Location = new System.Drawing.Point(79, 96);
            this.cbxFilters.Name = "cbxFilters";
            this.cbxFilters.Size = new System.Drawing.Size(190, 24);
            this.cbxFilters.TabIndex = 3;
            // 
            // lblFilters
            // 
            this.lblFilters.AutoSize = true;
            this.lblFilters.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilters.ForeColor = System.Drawing.Color.White;
            this.lblFilters.Location = new System.Drawing.Point(3, 102);
            this.lblFilters.Name = "lblFilters";
            this.lblFilters.Size = new System.Drawing.Size(70, 16);
            this.lblFilters.TabIndex = 4;
            this.lblFilters.Text = "Filter By : ";
            // 
            // txtFilter
            // 
            this.txtFilter.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilter.Location = new System.Drawing.Point(275, 96);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(190, 25);
            this.txtFilter.TabIndex = 5;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            this.txtFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilter_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Aharoni", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(549, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 35);
            this.label1.TabIndex = 6;
            this.label1.Text = "MANAGE PEOPLE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(12, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "# RECORDS :";
            // 
            // lblRecords
            // 
            this.lblRecords.AutoSize = true;
            this.lblRecords.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecords.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblRecords.Location = new System.Drawing.Point(107, 140);
            this.lblRecords.Name = "lblRecords";
            this.lblRecords.Size = new System.Drawing.Size(17, 19);
            this.lblRecords.TabIndex = 8;
            this.lblRecords.Text = "0";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbxFilters);
            this.panel1.Controls.Add(this.lblFilters);
            this.panel1.Controls.Add(this.txtFilter);
            this.panel1.Controls.Add(this.btnAddPerson);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1456, 126);
            this.panel1.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.lblRecords);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 726);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1456, 180);
            this.panel2.TabIndex = 10;
            // 
            // frmAllPeople
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1456, 906);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvAllPeopleList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAllPeople";
            this.Text = "7";
            this.Load += new System.EventHandler(this.frmAllPeople_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllPeopleList)).EndInit();
            this.EditDeleteMenueStripe.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAllPeopleList;
        private System.Windows.Forms.Button btnAddPerson;
        private System.Windows.Forms.ContextMenuStrip EditDeleteMenueStripe;
        private System.Windows.Forms.ToolStripMenuItem eDITToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dELETEToolStripMenuItem;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ToolStripMenuItem aDDNEWPERSONToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sHOWDETAILSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sENDEMAILToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pHONECALLToolStripMenuItem;
        private System.Windows.Forms.ComboBox cbxFilters;
        private System.Windows.Forms.Label lblFilters;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblRecords;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}