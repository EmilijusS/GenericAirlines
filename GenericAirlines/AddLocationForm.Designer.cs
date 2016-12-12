namespace GenericAirlines
{
    partial class AddLocationForm
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
            this.LocationBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TimezoneBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LocationBox
            // 
            this.LocationBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.LocationBox.Location = new System.Drawing.Point(108, 16);
            this.LocationBox.MaxLength = 3;
            this.LocationBox.Name = "LocationBox";
            this.LocationBox.Size = new System.Drawing.Size(36, 20);
            this.LocationBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "IATA airport code";
            // 
            // TimezoneBox
            // 
            this.TimezoneBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TimezoneBox.FormattingEnabled = true;
            this.TimezoneBox.Location = new System.Drawing.Point(74, 42);
            this.TimezoneBox.Name = "TimezoneBox";
            this.TimezoneBox.Size = new System.Drawing.Size(348, 21);
            this.TimezoneBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Timezone";
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.Location = new System.Drawing.Point(172, 69);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(75, 23);
            this.ConfirmButton.TabIndex = 4;
            this.ConfirmButton.Text = "Confirm";
            this.ConfirmButton.UseVisualStyleBackColor = true;
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // AddLocation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 105);
            this.Controls.Add(this.ConfirmButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TimezoneBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LocationBox);
            this.Name = "AddLocation";
            this.Text = "AddLocation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox LocationBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox TimezoneBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ConfirmButton;
    }
}