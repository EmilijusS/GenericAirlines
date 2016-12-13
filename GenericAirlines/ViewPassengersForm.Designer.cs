namespace GenericAirlines
{
    partial class ViewPassengersForm
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
            this.PassengersGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.PassengersGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // PassengersGridView
            // 
            this.PassengersGridView.AllowUserToAddRows = false;
            this.PassengersGridView.AllowUserToDeleteRows = false;
            this.PassengersGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PassengersGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PassengersGridView.Location = new System.Drawing.Point(0, 0);
            this.PassengersGridView.Name = "PassengersGridView";
            this.PassengersGridView.ReadOnly = true;
            this.PassengersGridView.RowHeadersVisible = false;
            this.PassengersGridView.Size = new System.Drawing.Size(373, 273);
            this.PassengersGridView.TabIndex = 0;
            // 
            // ViewPassengersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 273);
            this.Controls.Add(this.PassengersGridView);
            this.Name = "ViewPassengersForm";
            this.Text = "Passengers";
            this.Load += new System.EventHandler(this.ViewPassengersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PassengersGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView PassengersGridView;
    }
}