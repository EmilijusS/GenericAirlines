namespace GenericAirlines
{
    partial class PassengerForm
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
            this.FlightView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.FlightView)).BeginInit();
            this.SuspendLayout();
            // 
            // FlightView
            // 
            this.FlightView.AllowUserToAddRows = false;
            this.FlightView.AllowUserToDeleteRows = false;
            this.FlightView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FlightView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FlightView.Location = new System.Drawing.Point(1, 1);
            this.FlightView.Name = "FlightView";
            this.FlightView.ReadOnly = true;
            this.FlightView.RowHeadersVisible = false;
            this.FlightView.Size = new System.Drawing.Size(582, 106);
            this.FlightView.TabIndex = 0;
            // 
            // PassengerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 159);
            this.Controls.Add(this.FlightView);
            this.Name = "PassengerForm";
            this.Text = "Passenger";
            this.Load += new System.EventHandler(this.PassengerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FlightView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView FlightView;
    }
}