namespace GenericAirlines
{
    partial class AddEditAttendantForm
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
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.LicenseDateLabel = new System.Windows.Forms.Label();
            this.LicenseIdLabel = new System.Windows.Forms.Label();
            this.BirthDateLabel = new System.Windows.Forms.Label();
            this.SurnameLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.BirthDatePicker = new System.Windows.Forms.DateTimePicker();
            this.SurnameTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.GenderBox = new System.Windows.Forms.ComboBox();
            this.HeightBox = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.HeightBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.Location = new System.Drawing.Point(83, 142);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(75, 23);
            this.ConfirmButton.TabIndex = 23;
            this.ConfirmButton.Text = "Confirm";
            this.ConfirmButton.UseVisualStyleBackColor = true;
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // LicenseDateLabel
            // 
            this.LicenseDateLabel.AutoSize = true;
            this.LicenseDateLabel.Location = new System.Drawing.Point(35, 118);
            this.LicenseDateLabel.Name = "LicenseDateLabel";
            this.LicenseDateLabel.Size = new System.Drawing.Size(42, 13);
            this.LicenseDateLabel.TabIndex = 22;
            this.LicenseDateLabel.Text = "Gender";
            // 
            // LicenseIdLabel
            // 
            this.LicenseIdLabel.AutoSize = true;
            this.LicenseIdLabel.Location = new System.Drawing.Point(39, 93);
            this.LicenseIdLabel.Name = "LicenseIdLabel";
            this.LicenseIdLabel.Size = new System.Drawing.Size(38, 13);
            this.LicenseIdLabel.TabIndex = 21;
            this.LicenseIdLabel.Text = "Height";
            // 
            // BirthDateLabel
            // 
            this.BirthDateLabel.AutoSize = true;
            this.BirthDateLabel.Location = new System.Drawing.Point(25, 67);
            this.BirthDateLabel.Name = "BirthDateLabel";
            this.BirthDateLabel.Size = new System.Drawing.Size(52, 13);
            this.BirthDateLabel.TabIndex = 20;
            this.BirthDateLabel.Text = "Birth date";
            // 
            // SurnameLabel
            // 
            this.SurnameLabel.AutoSize = true;
            this.SurnameLabel.Location = new System.Drawing.Point(28, 41);
            this.SurnameLabel.Name = "SurnameLabel";
            this.SurnameLabel.Size = new System.Drawing.Size(49, 13);
            this.SurnameLabel.TabIndex = 19;
            this.SurnameLabel.Text = "Surname";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(42, 15);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(35, 13);
            this.NameLabel.TabIndex = 18;
            this.NameLabel.Text = "Name";
            // 
            // BirthDatePicker
            // 
            this.BirthDatePicker.Location = new System.Drawing.Point(83, 64);
            this.BirthDatePicker.Name = "BirthDatePicker";
            this.BirthDatePicker.Size = new System.Drawing.Size(144, 20);
            this.BirthDatePicker.TabIndex = 16;
            this.BirthDatePicker.Value = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            // 
            // SurnameTextBox
            // 
            this.SurnameTextBox.Location = new System.Drawing.Point(83, 38);
            this.SurnameTextBox.Name = "SurnameTextBox";
            this.SurnameTextBox.Size = new System.Drawing.Size(144, 20);
            this.SurnameTextBox.TabIndex = 14;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(83, 12);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(144, 20);
            this.NameTextBox.TabIndex = 13;
            // 
            // GenderBox
            // 
            this.GenderBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GenderBox.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Agender",
            "Androgyne",
            "Androgynous",
            "Bigender",
            "Cis",
            "Cisgender",
            "Cis Female",
            "Cis Male",
            "Cis Man",
            "Cis Woman",
            "Cisgender Female",
            "Cisgender Male",
            "Cisgender Man",
            "Cisgender Woman",
            "Female to Male",
            "FTM",
            "Gender Fluid",
            "Gender Nonconforming",
            "Gender Questioning",
            "Gender Variant",
            "Genderqueer",
            "Intersex",
            "Male to Female",
            "MTF",
            "Neither",
            "Neutrois",
            "Non-binary",
            "Other",
            "Pangender",
            "Trans",
            "Trans*",
            "Trans Female",
            "Trans* Female",
            "Trans Male",
            "Trans* Male",
            "Trans Man",
            "Trans* Man",
            "Trans Person",
            "Trans* Person",
            "Trans Woman",
            "Trans* Woman",
            "Transfeminine",
            "Transgender",
            "Transgender Female",
            "Transgender Male",
            "Transgender Man",
            "Transgender Person",
            "Transgender Woman",
            "Transmasculine",
            "Transsexual",
            "Transsexual Female",
            "Transsexual Male",
            "Transsexual Man",
            "Transsexual Person",
            "Transsexual Woman",
            "Two-Spirit"});
            this.GenderBox.Location = new System.Drawing.Point(83, 115);
            this.GenderBox.Name = "GenderBox";
            this.GenderBox.Size = new System.Drawing.Size(144, 21);
            this.GenderBox.TabIndex = 24;
            // 
            // HeightBox
            // 
            this.HeightBox.Location = new System.Drawing.Point(83, 91);
            this.HeightBox.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.HeightBox.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.HeightBox.Name = "HeightBox";
            this.HeightBox.Size = new System.Drawing.Size(144, 20);
            this.HeightBox.TabIndex = 25;
            this.HeightBox.Value = new decimal(new int[] {
            180,
            0,
            0,
            0});
            // 
            // AddEditAttendantForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 181);
            this.Controls.Add(this.HeightBox);
            this.Controls.Add(this.GenderBox);
            this.Controls.Add(this.ConfirmButton);
            this.Controls.Add(this.LicenseDateLabel);
            this.Controls.Add(this.LicenseIdLabel);
            this.Controls.Add(this.BirthDateLabel);
            this.Controls.Add(this.SurnameLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.BirthDatePicker);
            this.Controls.Add(this.SurnameTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Name = "AddEditAttendantForm";
            this.Text = "AddEditAttendantForm";
            this.Shown += new System.EventHandler(this.AddEditAttendantForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.HeightBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ConfirmButton;
        private System.Windows.Forms.Label LicenseDateLabel;
        private System.Windows.Forms.Label LicenseIdLabel;
        private System.Windows.Forms.Label BirthDateLabel;
        private System.Windows.Forms.Label SurnameLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.DateTimePicker BirthDatePicker;
        private System.Windows.Forms.TextBox SurnameTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.ComboBox GenderBox;
        private System.Windows.Forms.NumericUpDown HeightBox;
    }
}