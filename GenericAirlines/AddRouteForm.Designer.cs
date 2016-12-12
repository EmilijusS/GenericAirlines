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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.AddLocationButton = new System.Windows.Forms.Button();
            this.OriginBox = new System.Windows.Forms.ComboBox();
            this.DestinationBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
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
            // AddLocationButton
            // 
            this.AddLocationButton.Location = new System.Drawing.Point(28, 64);
            this.AddLocationButton.Name = "AddLocationButton";
            this.AddLocationButton.Size = new System.Drawing.Size(99, 23);
            this.AddLocationButton.TabIndex = 9;
            this.AddLocationButton.Text = "Add new location";
            this.AddLocationButton.UseVisualStyleBackColor = true;
            this.AddLocationButton.Click += new System.EventHandler(this.AddLocationButton_Click);
            // 
            // OriginBox
            // 
            this.OriginBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.OriginBox.FormattingEnabled = true;
            this.OriginBox.Location = new System.Drawing.Point(73, 12);
            this.OriginBox.Name = "OriginBox";
            this.OriginBox.Size = new System.Drawing.Size(52, 21);
            this.OriginBox.TabIndex = 10;
            // 
            // DestinationBox
            // 
            this.DestinationBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DestinationBox.FormattingEnabled = true;
            this.DestinationBox.Location = new System.Drawing.Point(73, 38);
            this.DestinationBox.Name = "DestinationBox";
            this.DestinationBox.Size = new System.Drawing.Size(52, 21);
            this.DestinationBox.TabIndex = 11;
            // 
            // AddRouteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(145, 170);
            this.Controls.Add(this.DestinationBox);
            this.Controls.Add(this.OriginBox);
            this.Controls.Add(this.AddLocationButton);
            this.Controls.Add(this.ConfirmButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AddRouteForm";
            this.Text = "Add route";
            this.Shown += new System.EventHandler(this.AddRouteForm_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ConfirmButton;
        private System.Windows.Forms.Button AddLocationButton;
        private System.Windows.Forms.ComboBox OriginBox;
        private System.Windows.Forms.ComboBox DestinationBox;
    }
}