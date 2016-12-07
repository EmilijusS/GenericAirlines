namespace GenericAirlines
{
    partial class EmployeesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PilotsDataGrid = new System.Windows.Forms.DataGridView();
            this.PilotId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PilotName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PilotSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PilotPersonalId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PilotBirthDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PilotLicense = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PilotLicenseDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.AttendantsDataGrid = new System.Windows.Forms.DataGridView();
            this.AttendantId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AttendantName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AttendantSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AttendantPersonalId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AttendantBirthDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AttendantGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AttendantHeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.PilotsDataGrid)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AttendantsDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // PilotsDataGrid
            // 
            this.PilotsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PilotsDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PilotId,
            this.PilotName,
            this.PilotSurname,
            this.PilotPersonalId,
            this.PilotBirthDate,
            this.PilotLicense,
            this.PilotLicenseDate});
            this.PilotsDataGrid.Location = new System.Drawing.Point(8, 3);
            this.PilotsDataGrid.Name = "PilotsDataGrid";
            this.PilotsDataGrid.ReadOnly = true;
            this.PilotsDataGrid.RowHeadersVisible = false;
            this.PilotsDataGrid.Size = new System.Drawing.Size(703, 150);
            this.PilotsDataGrid.TabIndex = 0;
            // 
            // PilotId
            // 
            this.PilotId.HeaderText = "Id";
            this.PilotId.Name = "PilotId";
            this.PilotId.ReadOnly = true;
            // 
            // PilotName
            // 
            this.PilotName.HeaderText = "Name";
            this.PilotName.Name = "PilotName";
            this.PilotName.ReadOnly = true;
            // 
            // PilotSurname
            // 
            this.PilotSurname.HeaderText = "Surname";
            this.PilotSurname.Name = "PilotSurname";
            this.PilotSurname.ReadOnly = true;
            // 
            // PilotPersonalId
            // 
            this.PilotPersonalId.HeaderText = "Personal id";
            this.PilotPersonalId.Name = "PilotPersonalId";
            this.PilotPersonalId.ReadOnly = true;
            // 
            // PilotBirthDate
            // 
            this.PilotBirthDate.HeaderText = "Birth date";
            this.PilotBirthDate.Name = "PilotBirthDate";
            this.PilotBirthDate.ReadOnly = true;
            // 
            // PilotLicense
            // 
            this.PilotLicense.HeaderText = "License";
            this.PilotLicense.Name = "PilotLicense";
            this.PilotLicense.ReadOnly = true;
            // 
            // PilotLicenseDate
            // 
            this.PilotLicenseDate.HeaderText = "License date";
            this.PilotLicenseDate.Name = "PilotLicenseDate";
            this.PilotLicenseDate.ReadOnly = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(731, 332);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.PilotsDataGrid);
            this.tabPage1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(723, 306);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Pilots";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.AttendantsDataGrid);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(723, 306);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Attendants";
            // 
            // AttendantsDataGrid
            // 
            this.AttendantsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AttendantsDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AttendantId,
            this.AttendantName,
            this.AttendantSurname,
            this.AttendantPersonalId,
            this.AttendantBirthDate,
            this.AttendantGender,
            this.AttendantHeight});
            this.AttendantsDataGrid.Location = new System.Drawing.Point(8, 3);
            this.AttendantsDataGrid.Name = "AttendantsDataGrid";
            this.AttendantsDataGrid.ReadOnly = true;
            this.AttendantsDataGrid.RowHeadersVisible = false;
            this.AttendantsDataGrid.Size = new System.Drawing.Size(703, 150);
            this.AttendantsDataGrid.TabIndex = 2;
            // 
            // AttendantId
            // 
            this.AttendantId.HeaderText = "Id";
            this.AttendantId.Name = "AttendantId";
            this.AttendantId.ReadOnly = true;
            // 
            // AttendantName
            // 
            this.AttendantName.HeaderText = "Name";
            this.AttendantName.Name = "AttendantName";
            this.AttendantName.ReadOnly = true;
            // 
            // AttendantSurname
            // 
            this.AttendantSurname.HeaderText = "Surname";
            this.AttendantSurname.Name = "AttendantSurname";
            this.AttendantSurname.ReadOnly = true;
            // 
            // AttendantPersonalId
            // 
            this.AttendantPersonalId.HeaderText = "Personal id";
            this.AttendantPersonalId.Name = "AttendantPersonalId";
            this.AttendantPersonalId.ReadOnly = true;
            // 
            // AttendantBirthDate
            // 
            this.AttendantBirthDate.HeaderText = "Birth date";
            this.AttendantBirthDate.Name = "AttendantBirthDate";
            this.AttendantBirthDate.ReadOnly = true;
            // 
            // AttendantGender
            // 
            this.AttendantGender.HeaderText = "Gender";
            this.AttendantGender.Name = "AttendantGender";
            this.AttendantGender.ReadOnly = true;
            // 
            // AttendantHeight
            // 
            this.AttendantHeight.HeaderText = "Height";
            this.AttendantHeight.Name = "AttendantHeight";
            this.AttendantHeight.ReadOnly = true;
            // 
            // EmployeesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 332);
            this.Controls.Add(this.tabControl1);
            this.Name = "EmployeesForm";
            this.Text = "EmployeesForm";
            ((System.ComponentModel.ISupportInitialize)(this.PilotsDataGrid)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AttendantsDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView PilotsDataGrid;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridViewTextBoxColumn PilotId;
        private System.Windows.Forms.DataGridViewTextBoxColumn PilotName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PilotSurname;
        private System.Windows.Forms.DataGridViewTextBoxColumn PilotPersonalId;
        private System.Windows.Forms.DataGridViewTextBoxColumn PilotBirthDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn PilotLicense;
        private System.Windows.Forms.DataGridViewTextBoxColumn PilotLicenseDate;
        private System.Windows.Forms.DataGridView AttendantsDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn AttendantId;
        private System.Windows.Forms.DataGridViewTextBoxColumn AttendantName;
        private System.Windows.Forms.DataGridViewTextBoxColumn AttendantSurname;
        private System.Windows.Forms.DataGridViewTextBoxColumn AttendantPersonalId;
        private System.Windows.Forms.DataGridViewTextBoxColumn AttendantBirthDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn AttendantGender;
        private System.Windows.Forms.DataGridViewTextBoxColumn AttendantHeight;
    }
}