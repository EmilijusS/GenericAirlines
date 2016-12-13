namespace GenericAirlines
{
    partial class SelectAttendantsForm
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
            this.AttendantsDataGrid = new System.Windows.Forms.DataGridView();
            this.databaseDataSet = new GenericAirlines.DatabaseDataSet();
            this.attendantInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.attendantInfoTableAdapter = new GenericAirlines.DatabaseDataSetTableAdapters.AttendantInfoTableAdapter();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.heightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Select = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ConfirmButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AttendantsDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendantInfoBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.nameDataGridViewTextBoxColumn,
            this.surnameDataGridViewTextBoxColumn,
            this.birthDataGridViewTextBoxColumn,
            this.heightDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.Select});
            this.AttendantsDataGrid.DataSource = this.attendantInfoBindingSource;
            this.AttendantsDataGrid.Location = new System.Drawing.Point(0, -2);
            this.AttendantsDataGrid.Name = "AttendantsDataGrid";
            this.AttendantsDataGrid.RowHeadersVisible = false;
            this.AttendantsDataGrid.Size = new System.Drawing.Size(663, 222);
            this.AttendantsDataGrid.TabIndex = 2;
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "DatabaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // attendantInfoBindingSource
            // 
            this.attendantInfoBindingSource.DataMember = "AttendantInfo";
            this.attendantInfoBindingSource.DataSource = this.databaseDataSet;
            // 
            // attendantInfoTableAdapter
            // 
            this.attendantInfoTableAdapter.ClearBeforeFill = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            this.surnameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.surnameDataGridViewTextBoxColumn.DataPropertyName = "Surname";
            this.surnameDataGridViewTextBoxColumn.HeaderText = "Surname";
            this.surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            this.surnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // birthDataGridViewTextBoxColumn
            // 
            this.birthDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.birthDataGridViewTextBoxColumn.DataPropertyName = "Birth";
            this.birthDataGridViewTextBoxColumn.HeaderText = "Birth";
            this.birthDataGridViewTextBoxColumn.Name = "birthDataGridViewTextBoxColumn";
            this.birthDataGridViewTextBoxColumn.ReadOnly = true;
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
            // Select
            // 
            this.Select.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Select.HeaderText = "Select";
            this.Select.Name = "Select";
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ConfirmButton.Location = new System.Drawing.Point(12, 227);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(75, 23);
            this.ConfirmButton.TabIndex = 3;
            this.ConfirmButton.Text = "Select attendants";
            this.ConfirmButton.UseVisualStyleBackColor = true;
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // SelectAttendantsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 262);
            this.Controls.Add(this.ConfirmButton);
            this.Controls.Add(this.AttendantsDataGrid);
            this.Name = "SelectAttendantsForm";
            this.Text = "Select attendants";
            this.Load += new System.EventHandler(this.SelectAttendantsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AttendantsDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendantInfoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView AttendantsDataGrid;
        private DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource attendantInfoBindingSource;
        private DatabaseDataSetTableAdapters.AttendantInfoTableAdapter attendantInfoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn heightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Select;
        private System.Windows.Forms.Button ConfirmButton;
    }
}