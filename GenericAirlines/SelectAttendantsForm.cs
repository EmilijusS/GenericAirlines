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
    public partial class SelectAttendantsForm : Form
    {
        private const int SelectColumnIndex = 5;
        private Flight _flight;

        public SelectAttendantsForm(Flight flight)
        {
            InitializeComponent();
            _flight = flight;
        }

        private void SelectAttendantsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet.AttendantInfo' table. You can move, or remove it, as needed.
            this.attendantInfoTableAdapter.Fill(this.databaseDataSet.AttendantInfo);

            using (var db = new AirlinesContext())
            {
                var flight = db.Flights.Find(_flight.Id);
                var employeeIds = new HashSet<int>(flight.Employees.Select(x => x.Id));
                //tbh I just want to finish already
                foreach (DataGridViewRow r in AttendantsDataGrid.Rows)
                {
                    var d = (DataRowView)r.DataBoundItem;

                    if (employeeIds.Contains((int)d.Row[0]))
                    {
                        r.Cells[SelectColumnIndex].Value = true;
                    }
                }
            }
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            using (var db = new AirlinesContext())
            {
                var flight = db.Flights.Find(_flight.Id);

                foreach (DataGridViewRow r in AttendantsDataGrid.Rows)
                {
                    var d = (DataRowView)r.DataBoundItem;
                    var employee = db.Employees.Find(d.Row[0]);

                    if (r.Cells[SelectColumnIndex].Value != null &&
                        (bool?)r.Cells[SelectColumnIndex].Value == true)
                        flight.Employees.Add(employee);
                    else
                        flight.Employees.Remove(employee);
                }

                db.SaveChanges();
            }


            this.Close();
        }
    }
}
