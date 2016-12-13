namespace GenericAirlines
{
    partial class SearchFlightsForm
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
            this.RouteBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ConfirmButton = new System.Windows.Forms.Button();
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
            this.FlightView.Location = new System.Drawing.Point(3, 66);
            this.FlightView.Name = "FlightView";
            this.FlightView.RowHeadersVisible = false;
            this.FlightView.Size = new System.Drawing.Size(670, 157);
            this.FlightView.TabIndex = 1;
            this.FlightView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.FlightView_CellContentClick);
            // 
            // RouteBox
            // 
            this.RouteBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RouteBox.FormattingEnabled = true;
            this.RouteBox.Location = new System.Drawing.Point(319, 12);
            this.RouteBox.Name = "RouteBox";
            this.RouteBox.Size = new System.Drawing.Size(86, 21);
            this.RouteBox.TabIndex = 2;
            this.RouteBox.SelectedIndexChanged += new System.EventHandler(this.RouteBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(249, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Select route";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Available flights:";
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.Location = new System.Drawing.Point(278, 229);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(108, 23);
            this.ConfirmButton.TabIndex = 5;
            this.ConfirmButton.Text = "Purchase selected";
            this.ConfirmButton.UseVisualStyleBackColor = true;
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // SearchFlightsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 263);
            this.Controls.Add(this.ConfirmButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RouteBox);
            this.Controls.Add(this.FlightView);
            this.Name = "SearchFlightsForm";
            this.Text = "SearchFlightsForm";
            this.Load += new System.EventHandler(this.SearchFlightsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FlightView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView FlightView;
        private System.Windows.Forms.ComboBox RouteBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ConfirmButton;
    }
}