namespace GenericAirlines
{
    partial class AddEditPlaneForm
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
            this.PlaneId = new System.Windows.Forms.TextBox();
            this.PlaneModel = new System.Windows.Forms.TextBox();
            this.PlaneSeatCount = new System.Windows.Forms.NumericUpDown();
            this.ConfirmAddPlane = new System.Windows.Forms.Button();
            this.IdLabel = new System.Windows.Forms.Label();
            this.ModelLabel = new System.Windows.Forms.Label();
            this.SeatCountLabel = new System.Windows.Forms.Label();
            this.Error = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PlaneSeatCount)).BeginInit();
            this.SuspendLayout();
            // 
            // PlaneId
            // 
            this.PlaneId.Location = new System.Drawing.Point(102, 35);
            this.PlaneId.Name = "PlaneId";
            this.PlaneId.Size = new System.Drawing.Size(100, 20);
            this.PlaneId.TabIndex = 0;
            this.PlaneId.Tag = "";
            // 
            // PlaneModel
            // 
            this.PlaneModel.Location = new System.Drawing.Point(102, 61);
            this.PlaneModel.Name = "PlaneModel";
            this.PlaneModel.Size = new System.Drawing.Size(100, 20);
            this.PlaneModel.TabIndex = 1;
            // 
            // PlaneSeatCount
            // 
            this.PlaneSeatCount.Location = new System.Drawing.Point(102, 87);
            this.PlaneSeatCount.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.PlaneSeatCount.Name = "PlaneSeatCount";
            this.PlaneSeatCount.Size = new System.Drawing.Size(100, 20);
            this.PlaneSeatCount.TabIndex = 4;
            // 
            // ConfirmAddPlane
            // 
            this.ConfirmAddPlane.Location = new System.Drawing.Point(63, 134);
            this.ConfirmAddPlane.Name = "ConfirmAddPlane";
            this.ConfirmAddPlane.Size = new System.Drawing.Size(75, 23);
            this.ConfirmAddPlane.TabIndex = 6;
            this.ConfirmAddPlane.Text = "Confirm";
            this.ConfirmAddPlane.UseVisualStyleBackColor = true;
            this.ConfirmAddPlane.Click += new System.EventHandler(this.ConfirmAddPlane_Click);
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Location = new System.Drawing.Point(80, 38);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(16, 13);
            this.IdLabel.TabIndex = 7;
            this.IdLabel.Text = "Id";
            // 
            // ModelLabel
            // 
            this.ModelLabel.AutoSize = true;
            this.ModelLabel.Location = new System.Drawing.Point(60, 64);
            this.ModelLabel.Name = "ModelLabel";
            this.ModelLabel.Size = new System.Drawing.Size(36, 13);
            this.ModelLabel.TabIndex = 8;
            this.ModelLabel.Text = "Model";
            // 
            // SeatCountLabel
            // 
            this.SeatCountLabel.AutoSize = true;
            this.SeatCountLabel.Location = new System.Drawing.Point(37, 89);
            this.SeatCountLabel.Name = "SeatCountLabel";
            this.SeatCountLabel.Size = new System.Drawing.Size(59, 13);
            this.SeatCountLabel.TabIndex = 9;
            this.SeatCountLabel.Text = "Seat count";
            // 
            // Error
            // 
            this.Error.AutoSize = true;
            this.Error.ForeColor = System.Drawing.Color.Red;
            this.Error.Location = new System.Drawing.Point(67, 118);
            this.Error.Name = "Error";
            this.Error.Size = new System.Drawing.Size(29, 13);
            this.Error.TabIndex = 28;
            this.Error.Text = "Error";
            this.Error.Visible = false;
            // 
            // AddEditPlaneForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(226, 169);
            this.Controls.Add(this.Error);
            this.Controls.Add(this.SeatCountLabel);
            this.Controls.Add(this.ModelLabel);
            this.Controls.Add(this.IdLabel);
            this.Controls.Add(this.ConfirmAddPlane);
            this.Controls.Add(this.PlaneSeatCount);
            this.Controls.Add(this.PlaneModel);
            this.Controls.Add(this.PlaneId);
            this.Name = "AddEditPlaneForm";
            this.Text = "Plane";
            this.Shown += new System.EventHandler(this.AddPlaneForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.PlaneSeatCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PlaneId;
        private System.Windows.Forms.TextBox PlaneModel;
        private System.Windows.Forms.NumericUpDown PlaneSeatCount;
        private System.Windows.Forms.Button ConfirmAddPlane;
        private System.Windows.Forms.Label IdLabel;
        private System.Windows.Forms.Label ModelLabel;
        private System.Windows.Forms.Label SeatCountLabel;
        private System.Windows.Forms.Label Error;
    }
}