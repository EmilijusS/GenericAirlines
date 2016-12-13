namespace GenericAirlines
{
    partial class AdminForm
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
            this.EmployeesButton = new System.Windows.Forms.Button();
            this.PlanesButton = new System.Windows.Forms.Button();
            this.FlightsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EmployeesButton
            // 
            this.EmployeesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeesButton.Location = new System.Drawing.Point(34, 27);
            this.EmployeesButton.Name = "EmployeesButton";
            this.EmployeesButton.Size = new System.Drawing.Size(154, 61);
            this.EmployeesButton.TabIndex = 0;
            this.EmployeesButton.Text = "Employees";
            this.EmployeesButton.UseVisualStyleBackColor = true;
            this.EmployeesButton.Click += new System.EventHandler(this.EmployeesButton_Click);
            // 
            // PlanesButton
            // 
            this.PlanesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlanesButton.Location = new System.Drawing.Point(34, 94);
            this.PlanesButton.Name = "PlanesButton";
            this.PlanesButton.Size = new System.Drawing.Size(154, 61);
            this.PlanesButton.TabIndex = 1;
            this.PlanesButton.Text = "Planes";
            this.PlanesButton.UseVisualStyleBackColor = true;
            this.PlanesButton.Click += new System.EventHandler(this.PlanesButton_Click);
            // 
            // FlightsButton
            // 
            this.FlightsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FlightsButton.Location = new System.Drawing.Point(34, 161);
            this.FlightsButton.Name = "FlightsButton";
            this.FlightsButton.Size = new System.Drawing.Size(154, 61);
            this.FlightsButton.TabIndex = 2;
            this.FlightsButton.Text = "Flights";
            this.FlightsButton.UseVisualStyleBackColor = true;
            this.FlightsButton.Click += new System.EventHandler(this.FlightsButton_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(228, 262);
            this.Controls.Add(this.FlightsButton);
            this.Controls.Add(this.PlanesButton);
            this.Controls.Add(this.EmployeesButton);
            this.Name = "AdminForm";
            this.Text = "Administrator";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button EmployeesButton;
        private System.Windows.Forms.Button PlanesButton;
        private System.Windows.Forms.Button FlightsButton;
    }
}