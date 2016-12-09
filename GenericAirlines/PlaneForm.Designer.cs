namespace GenericAirlines
{
    partial class PlaneForm
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
            this.AddPlane = new System.Windows.Forms.Button();
            this.databaseDataSet = new GenericAirlines.DatabaseDataSet();
            this.planeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.planeTableAdapter = new GenericAirlines.DatabaseDataSetTableAdapters.PlaneTableAdapter();
            this.PlaneDataGrid = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seatcountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.planeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlaneDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // AddPlane
            // 
            this.AddPlane.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddPlane.Location = new System.Drawing.Point(12, 215);
            this.AddPlane.Name = "AddPlane";
            this.AddPlane.Size = new System.Drawing.Size(75, 23);
            this.AddPlane.TabIndex = 1;
            this.AddPlane.Text = "Add plane";
            this.AddPlane.UseVisualStyleBackColor = true;
            this.AddPlane.Click += new System.EventHandler(this.AddPlane_Click);
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "DatabaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // planeBindingSource
            // 
            this.planeBindingSource.DataMember = "Plane";
            this.planeBindingSource.DataSource = this.databaseDataSet;
            // 
            // planeTableAdapter
            // 
            this.planeTableAdapter.ClearBeforeFill = true;
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
            this.idDataGridViewTextBoxColumn,
            this.seatcountDataGridViewTextBoxColumn,
            this.modelDataGridViewTextBoxColumn,
            this.Edit,
            this.Delete});
            this.PlaneDataGrid.DataSource = this.planeBindingSource;
            this.PlaneDataGrid.Location = new System.Drawing.Point(0, 0);
            this.PlaneDataGrid.Name = "PlaneDataGrid";
            this.PlaneDataGrid.ReadOnly = true;
            this.PlaneDataGrid.RowHeadersVisible = false;
            this.PlaneDataGrid.Size = new System.Drawing.Size(427, 209);
            this.PlaneDataGrid.TabIndex = 2;
            this.PlaneDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PlaneDataGrid_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.FillWeight = 60F;
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // seatcountDataGridViewTextBoxColumn
            // 
            this.seatcountDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.seatcountDataGridViewTextBoxColumn.DataPropertyName = "Seat_count";
            this.seatcountDataGridViewTextBoxColumn.FillWeight = 90F;
            this.seatcountDataGridViewTextBoxColumn.HeaderText = "Seat count";
            this.seatcountDataGridViewTextBoxColumn.Name = "seatcountDataGridViewTextBoxColumn";
            this.seatcountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // modelDataGridViewTextBoxColumn
            // 
            this.modelDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.modelDataGridViewTextBoxColumn.DataPropertyName = "Model";
            this.modelDataGridViewTextBoxColumn.FillWeight = 150F;
            this.modelDataGridViewTextBoxColumn.HeaderText = "Model";
            this.modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
            this.modelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Edit
            // 
            this.Edit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Edit.FillWeight = 80F;
            this.Edit.HeaderText = "Edit";
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            this.Edit.Text = "Edit";
            this.Edit.UseColumnTextForButtonValue = true;
            // 
            // Delete
            // 
            this.Delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Delete.FillWeight = 80F;
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Text = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            // 
            // PlaneForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 249);
            this.Controls.Add(this.PlaneDataGrid);
            this.Controls.Add(this.AddPlane);
            this.Name = "PlaneForm";
            this.Text = "Planes";
            this.Load += new System.EventHandler(this.PlaneForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.planeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlaneDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button AddPlane;
        private DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource planeBindingSource;
        private DatabaseDataSetTableAdapters.PlaneTableAdapter planeTableAdapter;
        private System.Windows.Forms.DataGridView PlaneDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn seatcountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}

