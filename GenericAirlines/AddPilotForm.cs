using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenericAirlines
{
    public partial class AddPilotForm : Form
    {
        public AddPilotForm()
        {
            InitializeComponent();
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            using (var db = new AirlinesContext())
            {
                //var pilot = db.Pilots.Create();
                //var employee = db.Employees.Create();
                //employee.Name = NameTextBox.Text;
                //employee.Surname = SurnameTextBox.Text;
                //employee.PersonalId = PersonalIdTextBox.Text;
                //employee.Birth = BirthDatePicker.Value;
                //pilot.License = LicenseTextBox.Text;
                //pilot.License_date = LicenseDatePicker.Value;
                ////?????
                ////db.Planes.Add(plane);
                //db.SaveChanges();
            }
        }
    }
}
