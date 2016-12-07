namespace GenericAirlines
{
    partial class AddPilotForm
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
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.SurnameTextBox = new System.Windows.Forms.TextBox();
            this.PersonalIdTextBox = new System.Windows.Forms.TextBox();
            this.LicenseTextBox = new System.Windows.Forms.TextBox();
            this.BirthDatePicker = new System.Windows.Forms.DateTimePicker();
            this.LicenseDatePicker = new System.Windows.Forms.DateTimePicker();
            this.NameLabel = new System.Windows.Forms.Label();
            this.SurnameLabel = new System.Windows.Forms.Label();
            this.PersonalIdLabel = new System.Windows.Forms.Label();
            this.BirthDateLabel = new System.Windows.Forms.Label();
            this.LicenseIdLabel = new System.Windows.Forms.Label();
            this.LicenseDateLabel = new System.Windows.Forms.Label();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(85, 12);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(144, 20);
            this.NameTextBox.TabIndex = 0;
            // 
            // SurnameTextBox
            // 
            this.SurnameTextBox.Location = new System.Drawing.Point(85, 38);
            this.SurnameTextBox.Name = "SurnameTextBox";
            this.SurnameTextBox.Size = new System.Drawing.Size(144, 20);
            this.SurnameTextBox.TabIndex = 1;
            // 
            // PersonalIdTextBox
            // 
            this.PersonalIdTextBox.Location = new System.Drawing.Point(85, 64);
            this.PersonalIdTextBox.Name = "PersonalIdTextBox";
            this.PersonalIdTextBox.Size = new System.Drawing.Size(144, 20);
            this.PersonalIdTextBox.TabIndex = 2;
            // 
            // LicenseTextBox
            // 
            this.LicenseTextBox.Location = new System.Drawing.Point(85, 116);
            this.LicenseTextBox.Name = "LicenseTextBox";
            this.LicenseTextBox.Size = new System.Drawing.Size(144, 20);
            this.LicenseTextBox.TabIndex = 3;
            // 
            // BirthDatePicker
            // 
            this.BirthDatePicker.Location = new System.Drawing.Point(85, 90);
            this.BirthDatePicker.Name = "BirthDatePicker";
            this.BirthDatePicker.Size = new System.Drawing.Size(147, 20);
            this.BirthDatePicker.TabIndex = 4;
            // 
            // LicenseDatePicker
            // 
            this.LicenseDatePicker.Location = new System.Drawing.Point(85, 142);
            this.LicenseDatePicker.Name = "LicenseDatePicker";
            this.LicenseDatePicker.Size = new System.Drawing.Size(147, 20);
            this.LicenseDatePicker.TabIndex = 5;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(44, 15);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(35, 13);
            this.NameLabel.TabIndex = 6;
            this.NameLabel.Text = "Name";
            // 
            // SurnameLabel
            // 
            this.SurnameLabel.AutoSize = true;
            this.SurnameLabel.Location = new System.Drawing.Point(30, 41);
            this.SurnameLabel.Name = "SurnameLabel";
            this.SurnameLabel.Size = new System.Drawing.Size(49, 13);
            this.SurnameLabel.TabIndex = 7;
            this.SurnameLabel.Text = "Surname";
            // 
            // PersonalIdLabel
            // 
            this.PersonalIdLabel.AutoSize = true;
            this.PersonalIdLabel.Location = new System.Drawing.Point(20, 67);
            this.PersonalIdLabel.Name = "PersonalIdLabel";
            this.PersonalIdLabel.Size = new System.Drawing.Size(59, 13);
            this.PersonalIdLabel.TabIndex = 8;
            this.PersonalIdLabel.Text = "Personal id";
            // 
            // BirthDateLabel
            // 
            this.BirthDateLabel.AutoSize = true;
            this.BirthDateLabel.Location = new System.Drawing.Point(27, 93);
            this.BirthDateLabel.Name = "BirthDateLabel";
            this.BirthDateLabel.Size = new System.Drawing.Size(52, 13);
            this.BirthDateLabel.TabIndex = 9;
            this.BirthDateLabel.Text = "Birth date";
            // 
            // LicenseIdLabel
            // 
            this.LicenseIdLabel.AutoSize = true;
            this.LicenseIdLabel.Location = new System.Drawing.Point(35, 119);
            this.LicenseIdLabel.Name = "LicenseIdLabel";
            this.LicenseIdLabel.Size = new System.Drawing.Size(44, 13);
            this.LicenseIdLabel.TabIndex = 10;
            this.LicenseIdLabel.Text = "License";
            // 
            // LicenseDateLabel
            // 
            this.LicenseDateLabel.AutoSize = true;
            this.LicenseDateLabel.Location = new System.Drawing.Point(11, 145);
            this.LicenseDateLabel.Name = "LicenseDateLabel";
            this.LicenseDateLabel.Size = new System.Drawing.Size(68, 13);
            this.LicenseDateLabel.TabIndex = 11;
            this.LicenseDateLabel.Text = "License date";
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.Location = new System.Drawing.Point(85, 168);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(75, 23);
            this.ConfirmButton.TabIndex = 12;
            this.ConfirmButton.Text = "Confirm";
            this.ConfirmButton.UseVisualStyleBackColor = true;
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // AddPilotForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 203);
            this.Controls.Add(this.ConfirmButton);
            this.Controls.Add(this.LicenseDateLabel);
            this.Controls.Add(this.LicenseIdLabel);
            this.Controls.Add(this.BirthDateLabel);
            this.Controls.Add(this.PersonalIdLabel);
            this.Controls.Add(this.SurnameLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.LicenseDatePicker);
            this.Controls.Add(this.BirthDatePicker);
            this.Controls.Add(this.LicenseTextBox);
            this.Controls.Add(this.PersonalIdTextBox);
            this.Controls.Add(this.SurnameTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Name = "AddPilotForm";
            this.Text = "AddPilotForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox SurnameTextBox;
        private System.Windows.Forms.TextBox PersonalIdTextBox;
        private System.Windows.Forms.TextBox LicenseTextBox;
        private System.Windows.Forms.DateTimePicker BirthDatePicker;
        private System.Windows.Forms.DateTimePicker LicenseDatePicker;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label SurnameLabel;
        private System.Windows.Forms.Label PersonalIdLabel;
        private System.Windows.Forms.Label BirthDateLabel;
        private System.Windows.Forms.Label LicenseIdLabel;
        private System.Windows.Forms.Label LicenseDateLabel;
        private System.Windows.Forms.Button ConfirmButton;
    }
}