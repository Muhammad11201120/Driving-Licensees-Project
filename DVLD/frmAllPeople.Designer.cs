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
            this.dgvAllPeopleList = new System.Windows.Forms.DataGridView();
            this.EditDeleteMenueStripe = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.eDITToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dELETEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddPerson = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllPeopleList)).BeginInit();
            this.EditDeleteMenueStripe.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAllPeopleList
            // 
            this.dgvAllPeopleList.AllowUserToAddRows = false;
            this.dgvAllPeopleList.AllowUserToDeleteRows = false;
            this.dgvAllPeopleList.AllowUserToOrderColumns = true;
            this.dgvAllPeopleList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllPeopleList.ContextMenuStrip = this.EditDeleteMenueStripe;
            this.dgvAllPeopleList.Location = new System.Drawing.Point(12, 72);
            this.dgvAllPeopleList.Name = "dgvAllPeopleList";
            this.dgvAllPeopleList.ReadOnly = true;
            this.dgvAllPeopleList.Size = new System.Drawing.Size(1424, 655);
            this.dgvAllPeopleList.TabIndex = 0;
            // 
            // EditDeleteMenueStripe
            // 
            this.EditDeleteMenueStripe.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eDITToolStripMenuItem,
            this.dELETEToolStripMenuItem});
            this.EditDeleteMenueStripe.Name = "EditDeleteMenueStripe";
            this.EditDeleteMenueStripe.Size = new System.Drawing.Size(113, 48);
            // 
            // eDITToolStripMenuItem
            // 
            this.eDITToolStripMenuItem.Name = "eDITToolStripMenuItem";
            this.eDITToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.eDITToolStripMenuItem.Text = "EDIT";
            this.eDITToolStripMenuItem.Click += new System.EventHandler(this.eDITToolStripMenuItem_Click);
            // 
            // dELETEToolStripMenuItem
            // 
            this.dELETEToolStripMenuItem.Name = "dELETEToolStripMenuItem";
            this.dELETEToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.dELETEToolStripMenuItem.Text = "DELETE";
            this.dELETEToolStripMenuItem.Click += new System.EventHandler(this.dELETEToolStripMenuItem_Click);
            // 
            // btnAddPerson
            // 
            this.btnAddPerson.Location = new System.Drawing.Point(1361, 26);
            this.btnAddPerson.Name = "btnAddPerson";
            this.btnAddPerson.Size = new System.Drawing.Size(75, 40);
            this.btnAddPerson.TabIndex = 1;
            this.btnAddPerson.Text = "Add Person";
            this.btnAddPerson.UseVisualStyleBackColor = true;
            this.btnAddPerson.Click += new System.EventHandler(this.btnAddPerson_Click);
            // 
            // frmAllPeople
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1448, 739);
            this.Controls.Add(this.btnAddPerson);
            this.Controls.Add(this.dgvAllPeopleList);
            this.Name = "frmAllPeople";
            this.Text = "frmAllPeople";
            this.Load += new System.EventHandler(this.frmAllPeople_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllPeopleList)).EndInit();
            this.EditDeleteMenueStripe.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAllPeopleList;
        private System.Windows.Forms.Button btnAddPerson;
        private System.Windows.Forms.ContextMenuStrip EditDeleteMenueStripe;
        private System.Windows.Forms.ToolStripMenuItem eDITToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dELETEToolStripMenuItem;
    }
}