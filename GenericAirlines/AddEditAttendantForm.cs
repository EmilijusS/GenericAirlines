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
    public partial class AddEditAttendantForm : Form
    {
        private int? _id;

        public AddEditAttendantForm()
        {
            InitializeComponent();

            _id = null;
            GenderBox.SelectedIndex = 0;
        }

        public AddEditAttendantForm(Attendant attendant)
        {
            InitializeComponent();

            _id = attendant.Id;
            NameTextBox.Text = attendant.Name;
            SurnameTextBox.Text = attendant.Surname;
            BirthDatePicker.Value = attendant.Birth;
            HeightBox.Value = attendant.Height;
            GenderBox.SelectedIndex = GenderBox.Items.IndexOf(attendant.Gender);
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            if (Validation())
            {
                using (var db = new AirlinesContext())
                {
                    var attendant = db.Employees.Create<Attendant>();
                    attendant.Id = _id ?? default(int);
                    attendant.Name = NameTextBox.Text;
                    attendant.Surname = SurnameTextBox.Text;
                    attendant.Birth = BirthDatePicker.Value;
                    attendant.Height = (byte)HeightBox.Value;
                    attendant.Gender = GenderBox.Text;

                    db.Employees.AddOrUpdate(attendant);
                    db.SaveChanges();
                }

                this.Close();
            }          
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

            return true;
        }

        private void AddEditAttendantForm_Shown(object sender, EventArgs e)
        {
            ConfirmButton.Focus();
        }
    }
}
