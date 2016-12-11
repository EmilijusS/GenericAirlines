﻿namespace GenericAirlines
{
    partial class FlightForm
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
            this.PlaneDataGrid = new System.Windows.Forms.DataGridView();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arrivalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.originDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destinationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Plane = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Pilots = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Attendants = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Passengers = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.flightInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSet = new GenericAirlines.DatabaseDataSet();
            this.AddFlightButton = new System.Windows.Forms.Button();
            this.flightInfoTableAdapter = new GenericAirlines.DatabaseDataSetTableAdapters.FlightInfoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.PlaneDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // PlaneDataGrid
            // 
            this.PlaneDataGrid.AllowUserToAddRows = false;
            this.PlaneDataGrid.AllowUserToDeleteRows = false;
            this.PlaneDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PlaneDataGrid.AutoGenerateColumns = false;
            this.PlaneDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PlaneDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dateDataGridViewTextBoxColumn,
            this.departureDataGridViewTextBoxColumn,
            this.arrivalDataGridViewTextBoxColumn,
            this.originDataGridViewTextBoxColumn,
            this.destinationDataGridViewTextBoxColumn,
            this.Plane,
            this.Pilots,
            this.Attendants,
            this.Passengers,
            this.Delete});
            this.PlaneDataGrid.DataSource = this.flightInfoBindingSource;
            this.PlaneDataGrid.Location = new System.Drawing.Point(0, -1);
            this.PlaneDataGrid.Name = "PlaneDataGrid";
            this.PlaneDataGrid.ReadOnly = true;
            this.PlaneDataGrid.RowHeadersVisible = false;
            this.PlaneDataGrid.Size = new System.Drawing.Size(1293, 209);
            this.PlaneDataGrid.TabIndex = 3;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // departureDataGridViewTextBoxColumn
            // 
            this.departureDataGridViewTextBoxColumn.DataPropertyName = "Departure";
            this.departureDataGridViewTextBoxColumn.HeaderText = "Departure";
            this.departureDataGridViewTextBoxColumn.Name = "departureDataGridViewTextBoxColumn";
            this.departureDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // arrivalDataGridViewTextBoxColumn
            // 
            this.arrivalDataGridViewTextBoxColumn.DataPropertyName = "Arrival";
            this.arrivalDataGridViewTextBoxColumn.HeaderText = "Arrival";
            this.arrivalDataGridViewTextBoxColumn.Name = "arrivalDataGridViewTextBoxColumn";
            this.arrivalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // originDataGridViewTextBoxColumn
            // 
            this.originDataGridViewTextBoxColumn.DataPropertyName = "Origin";
            this.originDataGridViewTextBoxColumn.HeaderText = "Origin";
            this.originDataGridViewTextBoxColumn.Name = "originDataGridViewTextBoxColumn";
            this.originDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // destinationDataGridViewTextBoxColumn
            // 
            this.destinationDataGridViewTextBoxColumn.DataPropertyName = "Destination";
            this.destinationDataGridViewTextBoxColumn.HeaderText = "Destination";
            this.destinationDataGridViewTextBoxColumn.Name = "destinationDataGridViewTextBoxColumn";
            this.destinationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Plane
            // 
            this.Plane.DataPropertyName = "Id";
            this.Plane.HeaderText = "Plane";
            this.Plane.Name = "Plane";
            this.Plane.ReadOnly = true;
            // 
            // Pilots
            // 
            this.Pilots.HeaderText = "Pilots";
            this.Pilots.Name = "Pilots";
            this.Pilots.ReadOnly = true;
            // 
            // Attendants
            // 
            this.Attendants.DataPropertyName = "Id";
            this.Attendants.HeaderText = "Attendants";
            this.Attendants.Name = "Attendants";
            this.Attendants.ReadOnly = true;
            // 
            // Passengers
            // 
            this.Passengers.DataPropertyName = "Id";
            this.Passengers.HeaderText = "Passengers";
            this.Passengers.Name = "Passengers";
            this.Passengers.ReadOnly = true;
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
            // flightInfoBindingSource
            // 
            this.flightInfoBindingSource.DataMember = "FlightInfo";
            this.flightInfoBindingSource.DataSource = this.databaseDataSet;
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "DatabaseDataSet";
            this.databaseDataSet.EnforceConstraints = false;
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // AddFlightButton
            // 
            this.AddFlightButton.Location = new System.Drawing.Point(12, 214);
            this.AddFlightButton.Name = "AddFlightButton";
            this.AddFlightButton.Size = new System.Drawing.Size(75, 23);
            this.AddFlightButton.TabIndex = 4;
            this.AddFlightButton.Text = "Add flight";
            this.AddFlightButton.UseVisualStyleBackColor = true;
            this.AddFlightButton.Click += new System.EventHandler(this.AddFlightButton_Click);
            // 
            // flightInfoTableAdapter
            // 
            this.flightInfoTableAdapter.ClearBeforeFill = true;
            // 
            // FlightForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1305, 360);
            this.Controls.Add(this.AddFlightButton);
            this.Controls.Add(this.PlaneDataGrid);
            this.Name = "FlightForm";
            this.Text = "FlightForm";
            this.Load += new System.EventHandler(this.FlightForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PlaneDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView PlaneDataGrid;
        private System.Windows.Forms.Button AddFlightButton;
        private DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource flightInfoBindingSource;
        private DatabaseDataSetTableAdapters.FlightInfoTableAdapter flightInfoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departureDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn arrivalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn originDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn destinationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Plane;
        private System.Windows.Forms.DataGridViewButtonColumn Pilots;
        private System.Windows.Forms.DataGridViewButtonColumn Attendants;
        private System.Windows.Forms.DataGridViewButtonColumn Passengers;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}