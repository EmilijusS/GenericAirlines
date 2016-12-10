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
        }


        private void AddPilot_Click(object sender, EventArgs e)
        {
            var addPilotForm = new AddPilotForm();
            addPilotForm.FormClosed += (a, b) => EmployeesForm_Load(a, b);
            addPilotForm.Show();
        }

        private void EmployeesForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet.AttendantInfo' table. You can move, or remove it, as needed.
            this.attendantInfoTableAdapter.Fill(this.databaseDataSet.AttendantInfo);
            // TODO: This line of code loads data into the 'databaseDataSet.PilotInfo' table. You can move, or remove it, as needed.
            this.pilotInfoTableAdapter.Fill(this.databaseDataSet.PilotInfo);

        }
    }
}
