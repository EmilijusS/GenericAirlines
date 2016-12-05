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
            this.PlaneManufactured = new System.Windows.Forms.NumericUpDown();
            this.ConfirmAddPlane = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PlaneSeatCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlaneManufactured)).BeginInit();
            this.SuspendLayout();
            // 
            // PlaneId
            // 
            this.PlaneId.Location = new System.Drawing.Point(102, 55);
            this.PlaneId.Name = "PlaneId";
            this.PlaneId.Size = new System.Drawing.Size(100, 20);
            this.PlaneId.TabIndex = 0;
            this.PlaneId.Tag = "";
            // 
            // PlaneModel
            // 
            this.PlaneModel.Location = new System.Drawing.Point(102, 116);
            this.PlaneModel.Name = "PlaneModel";
            this.PlaneModel.Size = new System.Drawing.Size(100, 20);
            this.PlaneModel.TabIndex = 1;
            // 
            // PlaneSeatCount
            // 
            this.PlaneSeatCount.Location = new System.Drawing.Point(102, 182);
            this.PlaneSeatCount.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.PlaneSeatCount.Name = "PlaneSeatCount";
            this.PlaneSeatCount.Size = new System.Drawing.Size(100, 20);
            this.PlaneSeatCount.TabIndex = 4;
            // 
            // PlaneManufactured
            // 
            this.PlaneManufactured.Location = new System.Drawing.Point(102, 240);
            this.PlaneManufactured.Maximum = new decimal(new int[] {
            2020,
            0,
            0,
            0});
            this.PlaneManufactured.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.PlaneManufactured.Name = "PlaneManufactured";
            this.PlaneManufactured.Size = new System.Drawing.Size(100, 20);
            this.PlaneManufactured.TabIndex = 5;
            this.PlaneManufactured.Value = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            // 
            // ConfirmAddPlane
            // 
            this.ConfirmAddPlane.Location = new System.Drawing.Point(173, 323);
            this.ConfirmAddPlane.Name = "ConfirmAddPlane";
            this.ConfirmAddPlane.Size = new System.Drawing.Size(75, 23);
            this.ConfirmAddPlane.TabIndex = 6;
            this.ConfirmAddPlane.Text = "Confirm";
            this.ConfirmAddPlane.UseVisualStyleBackColor = true;
            this.ConfirmAddPlane.Click += new System.EventHandler(this.ConfirmAddPlane_Click);
            // 
            // AddPlaneForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 405);
            this.Controls.Add(this.ConfirmAddPlane);
            this.Controls.Add(this.PlaneManufactured);
            this.Controls.Add(this.PlaneSeatCount);
            this.Controls.Add(this.PlaneModel);
            this.Controls.Add(this.PlaneId);
            this.Name = "AddPlaneForm";
            this.Text = "Plane";
            this.Shown += new System.EventHandler(this.AddPlaneForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.PlaneSeatCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlaneManufactured)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PlaneId;
        private System.Windows.Forms.TextBox PlaneModel;
        private System.Windows.Forms.NumericUpDown PlaneSeatCount;
        private System.Windows.Forms.NumericUpDown PlaneManufactured;
        private System.Windows.Forms.Button ConfirmAddPlane;
    }
}