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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.AddPilot = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.AddAttendant = new System.Windows.Forms.Button();
            this.AttendantsDataGrid = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flightidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.licenseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.licensedateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.databaseDataSetWithViewsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PilotsDataGrid)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AttendantsDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSetWithViewsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // PilotsDataGrid
            // 
            this.PilotsDataGrid.AllowUserToAddRows = false;
            this.PilotsDataGrid.AllowUserToDeleteRows = false;
            this.PilotsDataGrid.AutoGenerateColumns = false;
            this.PilotsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PilotsDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.surnameDataGridViewTextBoxColumn,
            this.birthDataGridViewTextBoxColumn,
            this.flightidDataGridViewTextBoxColumn,
            this.licenseDataGridViewTextBoxColumn,
            this.licensedateDataGridViewTextBoxColumn,
            this.employeeidDataGridViewTextBoxColumn});
            this.PilotsDataGrid.Location = new System.Drawing.Point(8, 3);
            this.PilotsDataGrid.Name = "PilotsDataGrid";
            this.PilotsDataGrid.ReadOnly = true;
            this.PilotsDataGrid.RowHeadersVisible = false;
            this.PilotsDataGrid.Size = new System.Drawing.Size(703, 150);
            this.PilotsDataGrid.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(731, 224);
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
            this.tabPage1.Size = new System.Drawing.Size(723, 198);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Pilots";
            // 
            // AddPilot
            // 
            this.AddPilot.Location = new System.Drawing.Point(9, 160);
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
            this.tabPage2.Size = new System.Drawing.Size(723, 198);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Attendants";
            // 
            // AddAttendant
            // 
            this.AddAttendant.Location = new System.Drawing.Point(9, 160);
            this.AddAttendant.Name = "AddAttendant";
            this.AddAttendant.Size = new System.Drawing.Size(86, 23);
            this.AddAttendant.TabIndex = 3;
            this.AddAttendant.Text = "Add attendant";
            this.AddAttendant.UseVisualStyleBackColor = true;
            // 
            // AttendantsDataGrid
            // 
            this.AttendantsDataGrid.AllowUserToAddRows = false;
            this.AttendantsDataGrid.AllowUserToDeleteRows = false;
            this.AttendantsDataGrid.AutoGenerateColumns = false;
            this.AttendantsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AttendantsDataGrid.DataSource = this.databaseDataSetWithViewsBindingSource;
            this.AttendantsDataGrid.Location = new System.Drawing.Point(8, 3);
            this.AttendantsDataGrid.Name = "AttendantsDataGrid";
            this.AttendantsDataGrid.ReadOnly = true;
            this.AttendantsDataGrid.RowHeadersVisible = false;
            this.AttendantsDataGrid.Size = new System.Drawing.Size(703, 150);
            this.AttendantsDataGrid.TabIndex = 2;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            this.surnameDataGridViewTextBoxColumn.DataPropertyName = "Surname";
            this.surnameDataGridViewTextBoxColumn.HeaderText = "Surname";
            this.surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            this.surnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // birthDataGridViewTextBoxColumn
            // 
            this.birthDataGridViewTextBoxColumn.DataPropertyName = "Birth";
            this.birthDataGridViewTextBoxColumn.HeaderText = "Birth";
            this.birthDataGridViewTextBoxColumn.Name = "birthDataGridViewTextBoxColumn";
            this.birthDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // flightidDataGridViewTextBoxColumn
            // 
            this.flightidDataGridViewTextBoxColumn.DataPropertyName = "Flight_id";
            this.flightidDataGridViewTextBoxColumn.HeaderText = "Flight_id";
            this.flightidDataGridViewTextBoxColumn.Name = "flightidDataGridViewTextBoxColumn";
            this.flightidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // licenseDataGridViewTextBoxColumn
            // 
            this.licenseDataGridViewTextBoxColumn.DataPropertyName = "License";
            this.licenseDataGridViewTextBoxColumn.HeaderText = "License";
            this.licenseDataGridViewTextBoxColumn.Name = "licenseDataGridViewTextBoxColumn";
            this.licenseDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // licensedateDataGridViewTextBoxColumn
            // 
            this.licensedateDataGridViewTextBoxColumn.DataPropertyName = "License_date";
            this.licensedateDataGridViewTextBoxColumn.HeaderText = "License_date";
            this.licensedateDataGridViewTextBoxColumn.Name = "licensedateDataGridViewTextBoxColumn";
            this.licensedateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // employeeidDataGridViewTextBoxColumn
            // 
            this.employeeidDataGridViewTextBoxColumn.DataPropertyName = "Employee_id";
            this.employeeidDataGridViewTextBoxColumn.HeaderText = "Employee_id";
            this.employeeidDataGridViewTextBoxColumn.Name = "employeeidDataGridViewTextBoxColumn";
            this.employeeidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // EmployeesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 224);
            this.Controls.Add(this.tabControl1);
            this.Name = "EmployeesForm";
            this.Text = "EmployeesForm";
            this.Load += new System.EventHandler(this.EmployeesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PilotsDataGrid)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AttendantsDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSetWithViewsBindingSource)).EndInit();
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
        private System.Windows.Forms.BindingSource databaseDataSetWithViewsBindingSource;
    }
}