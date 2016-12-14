using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenericAirlines
{
    public partial class AddEditPilotForm : Form
    {
        private int? _id;

        public AddEditPilotForm()
        {
            InitializeComponent();

            _id = null;
        }

        public AddEditPilotForm(Pilot pilot)
        {
            InitializeComponent();

            _id = pilot.Id;
            NameTextBox.Text = pilot.Name;
            SurnameTextBox.Text = pilot.Surname;
            BirthDatePicker.Value = pilot.Birth;
            LicenseTextBox.Text = pilot.License;
            LicenseDatePicker.Value = pilot.License_date;
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            using (var db = new AirlinesContext())
            {
                var pilot = db.Employees.Create<Pilot>();
                pilot.Id = _id ?? default(int);
                pilot.Name = NameTextBox.Text;
                pilot.Surname = SurnameTextBox.Text;
                pilot.Birth = BirthDatePicker.Value;
                pilot.License = LicenseTextBox.Text;
                pilot.License_date = LicenseDatePicker.Value;

                db.Employees.AddOrUpdate(pilot);
                db.SaveChanges();
            }

            this.Close();
        }

        private bool Validation()
        {
            if (!GenericAirlines.Validation.Name(NameTextBox.Text))
            {
                Error.Visible = true;
                Error.Text = "Bad name";
                return false;
            }
            else if (!GenericAirlines.Validation.Name(SurnameTextBox.Text))
            {
                Error.Visible = true;
                Error.Text = "Bad surname";
                return false;
            }
            else if (!GenericAirlines.Validation.License(LicenseTextBox.Text))
            {
                Error.Visible = true;
                Error.Text = "Bad license";
                return false;
            }

            return true;
        }

        private void AddEditPilotForm_Shown(object sender, EventArgs e)
        {
            ConfirmButton.Focus();
        }
    }
}
