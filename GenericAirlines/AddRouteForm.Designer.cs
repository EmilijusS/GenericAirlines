namespace GenericAirlines
{
    partial class AddRouteForm
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
            this.OriginTextBox = new System.Windows.Forms.TextBox();
            this.DestinationTextBox = new System.Windows.Forms.TextBox();
            this.DepartureTimeBox = new System.Windows.Forms.DateTimePicker();
            this.ArrivalTimeBox = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OriginTextBox
            // 
            this.OriginTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.OriginTextBox.Location = new System.Drawing.Point(73, 12);
            this.OriginTextBox.Name = "OriginTextBox";
            this.OriginTextBox.Size = new System.Drawing.Size(54, 20);
            this.OriginTextBox.TabIndex = 0;
            // 
            // DestinationTextBox
            // 
            this.DestinationTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.DestinationTextBox.Location = new System.Drawing.Point(73, 38);
            this.DestinationTextBox.Name = "DestinationTextBox";
            this.DestinationTextBox.Size = new System.Drawing.Size(54, 20);
            this.DestinationTextBox.TabIndex = 1;
            // 
            // DepartureTimeBox
            // 
            this.DepartureTimeBox.CustomFormat = "HH:mm";
            this.DepartureTimeBox.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DepartureTimeBox.Location = new System.Drawing.Point(73, 64);
            this.DepartureTimeBox.Name = "DepartureTimeBox";
            this.DepartureTimeBox.ShowUpDown = true;
            this.DepartureTimeBox.Size = new System.Drawing.Size(54, 20);
            this.DepartureTimeBox.TabIndex = 2;
            this.DepartureTimeBox.Value = new System.DateTime(2016, 12, 10, 0, 0, 0, 0);
            // 
            // ArrivalTimeBox
            // 
            this.ArrivalTimeBox.CustomFormat = "HH:mm";
            this.ArrivalTimeBox.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ArrivalTimeBox.Location = new System.Drawing.Point(73, 90);
            this.ArrivalTimeBox.Name = "ArrivalTimeBox";
            this.ArrivalTimeBox.ShowUpDown = true;
            this.ArrivalTimeBox.Size = new System.Drawing.Size(54, 20);
            this.ArrivalTimeBox.TabIndex = 3;
            this.ArrivalTimeBox.Value = new System.DateTime(2016, 12, 11, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Origin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Destination";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Departure";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Arrival";
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.Location = new System.Drawing.Point(36, 128);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(75, 23);
            this.ConfirmButton.TabIndex = 8;
            this.ConfirmButton.Text = "Confirm";
            this.ConfirmButton.UseVisualStyleBackColor = true;
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // AddRouteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(145, 170);
            this.Controls.Add(this.ConfirmButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ArrivalTimeBox);
            this.Controls.Add(this.DepartureTimeBox);
            this.Controls.Add(this.DestinationTextBox);
            this.Controls.Add(this.OriginTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AddRouteForm";
            this.Text = "Add route";
            this.Shown += new System.EventHandler(this.AddRouteForm_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox OriginTextBox;
        private System.Windows.Forms.TextBox DestinationTextBox;
        private System.Windows.Forms.DateTimePicker DepartureTimeBox;
        private System.Windows.Forms.DateTimePicker ArrivalTimeBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ConfirmButton;
    }
}