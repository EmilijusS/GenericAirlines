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

        }

        private void AddPilot_Click(object sender, EventArgs e)
        {
            var addPilotForm = new AddPilotForm();
            addPilotForm.FormClosed += (a, b) => UpdateEmployeesDataGrid();
            addPilotForm.Show();
        }

        private void EmployeesForm_Load(object sender, EventArgs e)
        {

        }
    }
}
