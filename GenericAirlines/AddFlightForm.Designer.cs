namespace GenericAirlines
{
    partial class AddFlightForm
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
            this.DepartureTextBox = new System.Windows.Forms.TextBox();
            this.ArrivalTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SelectRouteButton = new System.Windows.Forms.Button();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.DatePicker = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.CheckBox = new System.Windows.Forms.CheckBox();
            this.RepeatBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.MonthBox = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.MonthBox)).BeginInit();
            this.SuspendLayout();
            // 
            // OriginTextBox
            // 
            this.OriginTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.OriginTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.OriginTextBox.Enabled = false;
            this.OriginTextBox.Location = new System.Drawing.Point(46, 25);
            this.OriginTextBox.Name = "OriginTextBox";
            this.OriginTextBox.ReadOnly = true;
            this.OriginTextBox.Size = new System.Drawing.Size(48, 20);
            this.OriginTextBox.TabIndex = 0;
            // 
            // DestinationTextBox
            // 
            this.DestinationTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.DestinationTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.DestinationTextBox.Enabled = false;
            this.DestinationTextBox.Location = new System.Drawing.Point(185, 25);
            this.DestinationTextBox.Name = "DestinationTextBox";
            this.DestinationTextBox.ReadOnly = true;
            this.DestinationTextBox.Size = new System.Drawing.Size(48, 20);
            this.DestinationTextBox.TabIndex = 1;
            // 
            // DepartureTextBox
            // 
            this.DepartureTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.DepartureTextBox.Enabled = false;
            this.DepartureTextBox.Location = new System.Drawing.Point(23, 76);
            this.DepartureTextBox.Name = "DepartureTextBox";
            this.DepartureTextBox.ReadOnly = true;
            this.DepartureTextBox.Size = new System.Drawing.Size(100, 20);
            this.DepartureTextBox.TabIndex = 2;
            // 
            // ArrivalTextBox
            // 
            this.ArrivalTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.ArrivalTextBox.Enabled = false;
            this.ArrivalTextBox.Location = new System.Drawing.Point(159, 76);
            this.ArrivalTextBox.Name = "ArrivalTextBox";
            this.ArrivalTextBox.ReadOnly = true;
            this.ArrivalTextBox.Size = new System.Drawing.Size(100, 20);
            this.ArrivalTextBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Origin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(182, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Destination";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Departure";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(192, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Arrival";
            // 
            // SelectRouteButton
            // 
            this.SelectRouteButton.Location = new System.Drawing.Point(23, 111);
            this.SelectRouteButton.Name = "SelectRouteButton";
            this.SelectRouteButton.Size = new System.Drawing.Size(75, 23);
            this.SelectRouteButton.TabIndex = 8;
            this.SelectRouteButton.Text = "Select route";
            this.SelectRouteButton.UseVisualStyleBackColor = true;
            this.SelectRouteButton.Click += new System.EventHandler(this.SelectRouteButton_Click);
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.Location = new System.Drawing.Point(22, 277);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(75, 23);
            this.ConfirmButton.TabIndex = 9;
            this.ConfirmButton.Text = "Confirm";
            this.ConfirmButton.UseVisualStyleBackColor = true;
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // DatePicker
            // 
            this.DatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DatePicker.Location = new System.Drawing.Point(57, 157);
            this.DatePicker.Name = "DatePicker";
            this.DatePicker.Size = new System.Drawing.Size(75, 20);
            this.DatePicker.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Date";
            // 
            // CheckBox
            // 
            this.CheckBox.AutoSize = true;
            this.CheckBox.Location = new System.Drawing.Point(23, 199);
            this.CheckBox.Name = "CheckBox";
            this.CheckBox.Size = new System.Drawing.Size(90, 17);
            this.CheckBox.TabIndex = 12;
            this.CheckBox.Text = "Repeat every";
            this.CheckBox.UseVisualStyleBackColor = true;
            this.CheckBox.CheckedChanged += new System.EventHandler(this.CheckBox_CheckedChanged);
            // 
            // RepeatBox
            // 
            this.RepeatBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RepeatBox.Enabled = false;
            this.RepeatBox.FormattingEnabled = true;
            this.RepeatBox.Items.AddRange(new object[] {
            "Day",
            "Week"});
            this.RepeatBox.Location = new System.Drawing.Point(119, 197);
            this.RepeatBox.Name = "RepeatBox";
            this.RepeatBox.Size = new System.Drawing.Size(121, 21);
            this.RepeatBox.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "For next";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(118, 233);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "months";
            // 
            // MonthBox
            // 
            this.MonthBox.Enabled = false;
            this.MonthBox.Location = new System.Drawing.Point(71, 231);
            this.MonthBox.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.MonthBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.MonthBox.Name = "MonthBox";
            this.MonthBox.Size = new System.Drawing.Size(41, 20);
            this.MonthBox.TabIndex = 16;
            this.MonthBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // AddFlightForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 321);
            this.Controls.Add(this.MonthBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.RepeatBox);
            this.Controls.Add(this.CheckBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DatePicker);
            this.Controls.Add(this.ConfirmButton);
            this.Controls.Add(this.SelectRouteButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ArrivalTextBox);
            this.Controls.Add(this.DepartureTextBox);
            this.Controls.Add(this.DestinationTextBox);
            this.Controls.Add(this.OriginTextBox);
            this.Name = "AddFlightForm";
            this.Text = "AddFlightForm";
            ((System.ComponentModel.ISupportInitialize)(this.MonthBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox OriginTextBox;
        private System.Windows.Forms.TextBox DestinationTextBox;
        private System.Windows.Forms.TextBox DepartureTextBox;
        private System.Windows.Forms.TextBox ArrivalTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button SelectRouteButton;
        private System.Windows.Forms.Button ConfirmButton;
        private System.Windows.Forms.DateTimePicker DatePicker;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox CheckBox;
        private System.Windows.Forms.ComboBox RepeatBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown MonthBox;
    }
}