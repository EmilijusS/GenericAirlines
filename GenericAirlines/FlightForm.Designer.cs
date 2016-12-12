namespace GenericAirlines
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
            this.FlightDataGrid = new System.Windows.Forms.DataGridView();
            this.AddFlightButton = new System.Windows.Forms.Button();
            this.databaseDataSet = new GenericAirlines.DatabaseDataSet();
            this.flightInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.flightInfoTableAdapter = new GenericAirlines.DatabaseDataSetTableAdapters.FlightInfoTableAdapter();
            this.departureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arrivalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.originDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destinationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Plane = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Pilots = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Attendants = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Passengers = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.FlightDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightInfoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // FlightDataGrid
            // 
            this.FlightDataGrid.AllowUserToAddRows = false;
            this.FlightDataGrid.AllowUserToDeleteRows = false;
            this.FlightDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FlightDataGrid.AutoGenerateColumns = false;
            this.FlightDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FlightDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.departureDataGridViewTextBoxColumn,
            this.arrivalDataGridViewTextBoxColumn,
            this.originDataGridViewTextBoxColumn,
            this.destinationDataGridViewTextBoxColumn,
            this.Plane,
            this.Pilots,
            this.Attendants,
            this.Passengers,
            this.Delete});
            this.FlightDataGrid.DataSource = this.flightInfoBindingSource;
            this.FlightDataGrid.Location = new System.Drawing.Point(0, -1);
            this.FlightDataGrid.Name = "FlightDataGrid";
            this.FlightDataGrid.ReadOnly = true;
            this.FlightDataGrid.RowHeadersVisible = false;
            this.FlightDataGrid.Size = new System.Drawing.Size(1052, 320);
            this.FlightDataGrid.TabIndex = 3;
            this.FlightDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.FlightDataGrid_CellContentClick);
            // 
            // AddFlightButton
            // 
            this.AddFlightButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddFlightButton.Location = new System.Drawing.Point(12, 325);
            this.AddFlightButton.Name = "AddFlightButton";
            this.AddFlightButton.Size = new System.Drawing.Size(75, 23);
            this.AddFlightButton.TabIndex = 4;
            this.AddFlightButton.Text = "Add flight";
            this.AddFlightButton.UseVisualStyleBackColor = true;
            this.AddFlightButton.Click += new System.EventHandler(this.AddFlightButton_Click);
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "DatabaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // flightInfoBindingSource
            // 
            this.flightInfoBindingSource.DataMember = "FlightInfo";
            this.flightInfoBindingSource.DataSource = this.databaseDataSet;
            // 
            // flightInfoTableAdapter
            // 
            this.flightInfoTableAdapter.ClearBeforeFill = true;
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
            this.Plane.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Plane.DataPropertyName = "Id";
            this.Plane.HeaderText = "Plane";
            this.Plane.Name = "Plane";
            this.Plane.ReadOnly = true;
            this.Plane.Text = "Plane";
            this.Plane.UseColumnTextForButtonValue = true;
            // 
            // Pilots
            // 
            this.Pilots.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Pilots.HeaderText = "Pilots";
            this.Pilots.Name = "Pilots";
            this.Pilots.ReadOnly = true;
            this.Pilots.Text = "Pilots";
            this.Pilots.UseColumnTextForButtonValue = true;
            // 
            // Attendants
            // 
            this.Attendants.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Attendants.DataPropertyName = "Id";
            this.Attendants.HeaderText = "Attendants";
            this.Attendants.Name = "Attendants";
            this.Attendants.ReadOnly = true;
            this.Attendants.Text = "Attendants";
            this.Attendants.UseColumnTextForButtonValue = true;
            // 
            // Passengers
            // 
            this.Passengers.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Passengers.DataPropertyName = "Id";
            this.Passengers.HeaderText = "Passengers";
            this.Passengers.Name = "Passengers";
            this.Passengers.ReadOnly = true;
            this.Passengers.Text = "Passengers";
            this.Passengers.UseColumnTextForButtonValue = true;
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
            // FlightForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 360);
            this.Controls.Add(this.AddFlightButton);
            this.Controls.Add(this.FlightDataGrid);
            this.Name = "FlightForm";
            this.Text = "Flights";
            this.Load += new System.EventHandler(this.FlightForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FlightDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightInfoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView FlightDataGrid;
        private System.Windows.Forms.Button AddFlightButton;
        private DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource flightInfoBindingSource;
        private DatabaseDataSetTableAdapters.FlightInfoTableAdapter flightInfoTableAdapter;
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