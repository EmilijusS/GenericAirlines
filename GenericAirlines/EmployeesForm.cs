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
    public partial class EmployeesForm : Form
    {
        public EmployeesForm()
        {
            InitializeComponent();
            UpdateEmployeesDataGrid();
        }

        private void UpdateEmployeesDataGrid()
        {
            PilotsDataGrid.Rows.Clear();
            AttendantsDataGrid.Rows.Clear();

            using (var db = new AirlinesContext())
            {
                foreach (var p in db.Pilots)
                {
                    PilotsDataGrid.Rows.Add(p.Id, p.Employee.Name, p.Employee.Surname, p.Employee.PersonalId,
                        p.Employee.Birth, p.License, p.License_date);
                }

                foreach (var a in db.Attendants)
                {
                    PilotsDataGrid.Rows.Add(a.Id, a.Employee.Name, a.Employee.Surname, a.Employee.PersonalId,
                        a.Employee.Birth, a.Gender, a.Height);
                }
            }
        }

    }
}
