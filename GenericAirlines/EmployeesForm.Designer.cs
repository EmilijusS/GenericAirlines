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
            this.components = new System.ComponentModel.Container();
            this.PilotsDataGrid = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.pilotInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSet = new GenericAirlines.DatabaseDataSet();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.AddPilot = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.AddAttendant = new System.Windows.Forms.Button();
            this.AttendantsDataGrid = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.heightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EditAttendantColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.DeleteAttendantColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.attendantInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pilotInfoTableAdapter = new GenericAirlines.DatabaseDataSetTableAdapters.PilotInfoTableAdapter();
            this.attendantInfoTableAdapter = new GenericAirlines.DatabaseDataSetTableAdapters.AttendantInfoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.PilotsDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pilotInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AttendantsDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendantInfoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // PilotsDataGrid
            // 
            this.PilotsDataGrid.AllowUserToAddRows = false;
            this.PilotsDataGrid.AllowUserToDeleteRows = false;
            this.PilotsDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PilotsDataGrid.AutoGenerateColumns = false;
            this.PilotsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PilotsDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.Edit,
            this.Delete});
            this.PilotsDataGrid.DataSource = this.pilotInfoBindingSource;
            this.PilotsDataGrid.Location = new System.Drawing.Point(0, 3);
            this.PilotsDataGrid.Name = "PilotsDataGrid";
            this.PilotsDataGrid.ReadOnly = true;
            this.PilotsDataGrid.RowHeadersVisible = false;
            this.PilotsDataGrid.Size = new System.Drawing.Size(891, 167);
            this.PilotsDataGrid.TabIndex = 0;
            this.PilotsDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PilotsDataGrid_CellContentClick);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Surname";
            this.dataGridViewTextBoxColumn3.HeaderText = "Surname";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Birth";
            this.dataGridViewTextBoxColumn4.HeaderText = "Birth";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "License";
            this.dataGridViewTextBoxColumn5.HeaderText = "License";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "License_date";
            this.dataGridViewTextBoxColumn6.HeaderText = "License_date";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // Edit
            // 
            this.Edit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Edit.FillWeight = 70F;
            this.Edit.HeaderText = "Edit";
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            this.Edit.Text = "Edit";
            this.Edit.UseColumnTextForButtonValue = true;
            // 
            // Delete
            // 
            this.Delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Delete.FillWeight = 70F;
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Text = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            // 
            // pilotInfoBindingSource
            // 
            this.pilotInfoBindingSource.DataMember = "PilotInfo";
            this.pilotInfoBindingSource.DataSource = this.databaseDataSet;
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "DatabaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(902, 241);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.AddPilot);
            this.tabPage1.Controls.Add(this.PilotsDataGrid);
            this.tabPage1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(894, 215);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Pilots";
            // 
            // AddPilot
            // 
            this.AddPilot.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddPilot.Location = new System.Drawing.Point(9, 177);
            this.AddPilot.Name = "AddPilot";
            this.AddPilot.Size = new System.Drawing.Size(75, 23);
            this.AddPilot.TabIndex = 1;
            this.AddPilot.Text = "Add pilot";
            this.AddPilot.UseVisualStyleBackColor = true;
            this.AddPilot.Click += new System.EventHandler(this.AddPilot_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.AddAttendant);
            this.tabPage2.Controls.Add(this.AttendantsDataGrid);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(894, 215);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Attendants";
            // 
            // AddAttendant
            // 
            this.AddAttendant.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddAttendant.Location = new System.Drawing.Point(9, 177);
            this.AddAttendant.Name = "AddAttendant";
            this.AddAttendant.Size = new System.Drawing.Size(86, 23);
            this.AddAttendant.TabIndex = 3;
            this.AddAttendant.Text = "Add attendant";
            this.AddAttendant.UseVisualStyleBackColor = true;
            this.AddAttendant.Click += new System.EventHandler(this.AddAttendant_Click);
            // 
            // AttendantsDataGrid
            // 
            this.AttendantsDataGrid.AllowUserToAddRows = false;
            this.AttendantsDataGrid.AllowUserToDeleteRows = false;
            this.AttendantsDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AttendantsDataGrid.AutoGenerateColumns = false;
            this.AttendantsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AttendantsDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.heightDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.EditAttendantColumn,
            this.DeleteAttendantColumn});
            this.AttendantsDataGrid.DataSource = this.attendantInfoBindingSource;
            this.AttendantsDataGrid.Location = new System.Drawing.Point(0, 3);
            this.AttendantsDataGrid.Name = "AttendantsDataGrid";
            this.AttendantsDataGrid.ReadOnly = true;
            this.AttendantsDataGrid.RowHeadersVisible = false;
            this.AttendantsDataGrid.Size = new System.Drawing.Size(891, 167);
            this.AttendantsDataGrid.TabIndex = 2;
            this.AttendantsDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AttendantsDataGrid_CellContentClick);
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn9.HeaderText = "Name";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Surname";
            this.dataGridViewTextBoxColumn10.HeaderText = "Surname";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Birth";
            this.dataGridViewTextBoxColumn11.HeaderText = "Birth";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // heightDataGridViewTextBoxColumn
            // 
            this.heightDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.heightDataGridViewTextBoxColumn.DataPropertyName = "Height";
            this.heightDataGridViewTextBoxColumn.HeaderText = "Height";
            this.heightDataGridViewTextBoxColumn.Name = "heightDataGridViewTextBoxColumn";
            this.heightDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            this.genderDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // EditAttendantColumn
            // 
            this.EditAttendantColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EditAttendantColumn.FillWeight = 70F;
            this.EditAttendantColumn.HeaderText = "Edit";
            this.EditAttendantColumn.Name = "EditAttendantColumn";
            this.EditAttendantColumn.ReadOnly = true;
            this.EditAttendantColumn.Text = "Edit";
            this.EditAttendantColumn.UseColumnTextForButtonValue = true;
            // 
            // DeleteAttendantColumn
            // 
            this.DeleteAttendantColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DeleteAttendantColumn.FillWeight = 70F;
            this.DeleteAttendantColumn.HeaderText = "Delete";
            this.DeleteAttendantColumn.Name = "DeleteAttendantColumn";
            this.DeleteAttendantColumn.ReadOnly = true;
            this.DeleteAttendantColumn.Text = "Delete";
            this.DeleteAttendantColumn.UseColumnTextForButtonValue = true;
            // 
            // attendantInfoBindingSource
            // 
            this.attendantInfoBindingSource.DataMember = "AttendantInfo";
            this.attendantInfoBindingSource.DataSource = this.databaseDataSet;
            // 
            // pilotInfoTableAdapter
            // 
            this.pilotInfoTableAdapter.ClearBeforeFill = true;
            // 
            // attendantInfoTableAdapter
            // 
            this.attendantInfoTableAdapter.ClearBeforeFill = true;
            // 
            // EmployeesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 241);
            this.Controls.Add(this.tabControl1);
            this.Name = "EmployeesForm";
            this.Text = "EmployeesForm";
            this.Load += new System.EventHandler(this.EmployeesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PilotsDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pilotInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AttendantsDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendantInfoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView PilotsDataGrid;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView AttendantsDataGrid;
        private System.Windows.Forms.Button AddPilot;
        private System.Windows.Forms.Button AddAttendant;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn flightidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn licenseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn licensedateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeidDataGridViewTextBoxColumn;
        private DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource pilotInfoBindingSource;
        private DatabaseDataSetTableAdapters.PilotInfoTableAdapter pilotInfoTableAdapter;
        private System.Windows.Forms.BindingSource attendantInfoBindingSource;
        private DatabaseDataSetTableAdapters.AttendantInfoTableAdapter attendantInfoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn heightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn EditAttendantColumn;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteAttendantColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}