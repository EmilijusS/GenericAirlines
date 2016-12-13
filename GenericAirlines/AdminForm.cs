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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void EmployeesButton_Click(object sender, EventArgs e)
        {
            StartForm(new EmployeesForm());
        }

        private void PlanesButton_Click(object sender, EventArgs e)
        {
            StartForm(new PlaneForm());
        }

        private void FlightsButton_Click(object sender, EventArgs e)
        {
            StartForm(new FlightForm());
        }

        private void StartForm(Form form)
        {
            this.Visible = false;
            form.FormClosed += (a, b) => this.Visible = true;
            form.Show();
        }
    }
}
