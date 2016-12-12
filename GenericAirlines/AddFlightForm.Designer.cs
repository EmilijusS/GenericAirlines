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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SelectRouteButton = new System.Windows.Forms.Button();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.CheckBox = new System.Windows.Forms.CheckBox();
            this.RepeatBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.MonthBox = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DepartureBox = new System.Windows.Forms.DateTimePicker();
            this.ArrivalBox = new System.Windows.Forms.DateTimePicker();
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
            // SelectRouteButton
            // 
            this.SelectRouteButton.Location = new System.Drawing.Point(104, 56);
            this.SelectRouteButton.Name = "SelectRouteButton";
            this.SelectRouteButton.Size = new System.Drawing.Size(75, 23);
            this.SelectRouteButton.TabIndex = 8;
            this.SelectRouteButton.Text = "Select route";
            this.SelectRouteButton.UseVisualStyleBackColor = true;
            this.SelectRouteButton.Click += new System.EventHandler(this.SelectRouteButton_Click);
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.Location = new System.Drawing.Point(104, 238);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(75, 23);
            this.ConfirmButton.TabIndex = 9;
            this.ConfirmButton.Text = "Confirm";
            this.ConfirmButton.UseVisualStyleBackColor = true;
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // CheckBox
            // 
            this.CheckBox.AutoSize = true;
            this.CheckBox.Location = new System.Drawing.Point(20, 169);
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
            this.RepeatBox.Location = new System.Drawing.Point(116, 167);
            this.RepeatBox.Name = "RepeatBox";
            this.RepeatBox.Size = new System.Drawing.Size(121, 21);
            this.RepeatBox.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "For next";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(115, 203);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "months";
            // 
            // MonthBox
            // 
            this.MonthBox.Enabled = false;
            this.MonthBox.Location = new System.Drawing.Point(68, 201);
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Departure";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Arrival";
            // 
            // DepartureBox
            // 
            this.DepartureBox.CustomFormat = "yyyy-MM-dd HH:mm";
            this.DepartureBox.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DepartureBox.Location = new System.Drawing.Point(104, 97);
            this.DepartureBox.Name = "DepartureBox";
            this.DepartureBox.Size = new System.Drawing.Size(108, 20);
            this.DepartureBox.TabIndex = 17;
            this.DepartureBox.Value = new System.DateTime(2016, 12, 12, 20, 56, 12, 0);
            // 
            // ArrivalBox
            // 
            this.ArrivalBox.CustomFormat = "yyyy-MM-dd HH:mm";
            this.ArrivalBox.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ArrivalBox.Location = new System.Drawing.Point(104, 130);
            this.ArrivalBox.Name = "ArrivalBox";
            this.ArrivalBox.Size = new System.Drawing.Size(108, 20);
            this.ArrivalBox.TabIndex = 18;
            this.ArrivalBox.Value = new System.DateTime(2016, 12, 12, 20, 56, 17, 0);
            // 
            // AddFlightForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 271);
            this.Controls.Add(this.ArrivalBox);
            this.Controls.Add(this.DepartureBox);
            this.Controls.Add(this.MonthBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.RepeatBox);
            this.Controls.Add(this.CheckBox);
            this.Controls.Add(this.ConfirmButton);
            this.Controls.Add(this.SelectRouteButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SelectRouteButton;
        private System.Windows.Forms.Button ConfirmButton;
        private System.Windows.Forms.CheckBox CheckBox;
        private System.Windows.Forms.ComboBox RepeatBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown MonthBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker DepartureBox;
        private System.Windows.Forms.DateTimePicker ArrivalBox;
    }
}