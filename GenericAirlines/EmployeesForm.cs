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
        private readonly int PilotEditColumnIndex = 5;
        private readonly int PilotDeleteColumnIndex = 6;
        private readonly int AttendantEditColumnIndex = 5;
        private readonly int AttendantDeleteColumnIndex = 6;

        public EmployeesForm()
        {
            InitializeComponent();
        }


        private void AddPilot_Click(object sender, EventArgs e)
        {
            var addPilotForm = new AddEditPilotForm();
            addPilotForm.FormClosed += (a, b) => EmployeesForm_Load(a, b);
            addPilotForm.Show();
        }

        private void AddAttendant_Click(object sender, EventArgs e)
        {
            var addAttendantForm = new AddEditAttendantForm();
            addAttendantForm.FormClosed += (a, b) => EmployeesForm_Load(a, b);
            addAttendantForm.Show();
        }

        private void EmployeesForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet.AttendantInfo' table. You can move, or remove it, as needed.
            this.attendantInfoTableAdapter.Fill(this.databaseDataSet.AttendantInfo);
            // TODO: This line of code loads data into the 'databaseDataSet.PilotInfo' table. You can move, or remove it, as needed.
            this.pilotInfoTableAdapter.Fill(this.databaseDataSet.PilotInfo);

        }

        private void PilotsDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == PilotEditColumnIndex)
                    EditPilot(e.RowIndex);

                if (e.ColumnIndex == PilotDeleteColumnIndex)
                    DeletePilot(e.RowIndex);
            }
        }

        private void AttendantsDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == AttendantEditColumnIndex)
                    EditAttendant(e.RowIndex);

                if (e.ColumnIndex == AttendantDeleteColumnIndex)
                    DeleteAttendant(e.RowIndex);
            }
        }

        private void DeletePilot(int rowIndex)
        {
            var d = (DataRowView)PilotsDataGrid.Rows[rowIndex].DataBoundItem;

            using (var db = new AirlinesContext())
            {
                db.Employees.Remove(db.Employees.Find(d.Row[0]));
                db.SaveChanges();
            }

            EmployeesForm_Load(this, new EventArgs());
        }

        private void DeleteAttendant(int rowIndex)
        {
            var d = (DataRowView)AttendantsDataGrid.Rows[rowIndex].DataBoundItem;

            using (var db = new AirlinesContext())
            {
                db.Employees.Remove(db.Employees.Find(d.Row[0]));
                db.SaveChanges();
            }

            EmployeesForm_Load(this, new EventArgs());
        }

        private void EditPilot(int rowIndex)
        {
            Pilot pilot;
            var d = (DataRowView)PilotsDataGrid.Rows[rowIndex].DataBoundItem;

            using (var db = new AirlinesContext())
            {
                pilot = (Pilot)db.Employees.Find(d.Row[0]);
            }

            var editPlaneForm = new AddEditPilotForm(pilot);

            editPlaneForm.FormClosed += (a, b) => EmployeesForm_Load(a, b);
            editPlaneForm.Show();
        }

        private void EditAttendant(int rowIndex)
        {
            Attendant attendant;
            var d = (DataRowView)AttendantsDataGrid.Rows[rowIndex].DataBoundItem;

            using (var db = new AirlinesContext())
            {
                attendant = (Attendant)db.Employees.Find(d.Row[0]);
            }

            var editAttendantForm = new AddEditAttendantForm(attendant);

            editAttendantForm.FormClosed += (a, b) => EmployeesForm_Load(a, b);
            editAttendantForm.Show();
        }
    }
}
