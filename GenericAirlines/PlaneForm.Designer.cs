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
            this.PlanesDataGrid = new System.Windows.Forms.DataGridView();
            this.AddPlane = new System.Windows.Forms.Button();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Seat_count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Manufactured = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.PlanesDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // PlanesDataGrid
            // 
            this.PlanesDataGrid.AllowUserToAddRows = false;
            this.PlanesDataGrid.AllowUserToDeleteRows = false;
            this.PlanesDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PlanesDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Model,
            this.Seat_count,
            this.Manufactured,
            this.Edit,
            this.Delete});
            this.PlanesDataGrid.Location = new System.Drawing.Point(27, 30);
            this.PlanesDataGrid.MultiSelect = false;
            this.PlanesDataGrid.Name = "PlanesDataGrid";
            this.PlanesDataGrid.ReadOnly = true;
            this.PlanesDataGrid.RowHeadersVisible = false;
            this.PlanesDataGrid.ShowCellErrors = false;
            this.PlanesDataGrid.ShowCellToolTips = false;
            this.PlanesDataGrid.ShowEditingIcon = false;
            this.PlanesDataGrid.ShowRowErrors = false;
            this.PlanesDataGrid.Size = new System.Drawing.Size(604, 179);
            this.PlanesDataGrid.TabIndex = 0;
            this.PlanesDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PlanesDataGrid_CellContentClick);
            // 
            // AddPlane
            // 
            this.AddPlane.Location = new System.Drawing.Point(27, 248);
            this.AddPlane.Name = "AddPlane";
            this.AddPlane.Size = new System.Drawing.Size(75, 23);
            this.AddPlane.TabIndex = 1;
            this.AddPlane.Text = "Add plane";
            this.AddPlane.UseVisualStyleBackColor = true;
            this.AddPlane.Click += new System.EventHandler(this.AddPlane_Click);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // Model
            // 
            this.Model.HeaderText = "Model";
            this.Model.Name = "Model";
            this.Model.ReadOnly = true;
            // 
            // Seat_count
            // 
            this.Seat_count.HeaderText = "Seat_count";
            this.Seat_count.Name = "Seat_count";
            this.Seat_count.ReadOnly = true;
            // 
            // Manufactured
            // 
            this.Manufactured.HeaderText = "Manufactured";
            this.Manufactured.Name = "Manufactured";
            this.Manufactured.ReadOnly = true;
            // 
            // Edit
            // 
            this.Edit.HeaderText = "Edit";
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            this.Edit.Text = "Edit";
            this.Edit.UseColumnTextForButtonValue = true;
            // 
            // Delete
            // 
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
            this.ClientSize = new System.Drawing.Size(951, 541);
            this.Controls.Add(this.AddPlane);
            this.Controls.Add(this.PlanesDataGrid);
            this.Name = "PlaneForm";
            this.Text = "Planes";
            ((System.ComponentModel.ISupportInitialize)(this.PlanesDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button AddPlane;
        private System.Windows.Forms.DataGridView PlanesDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Model;
        private System.Windows.Forms.DataGridViewTextBoxColumn Seat_count;
        private System.Windows.Forms.DataGridViewTextBoxColumn Manufactured;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}

