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
    public partial class FlightForm : Form
    {
        public FlightForm()
        {
            InitializeComponent();
        }

        private void FlightForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet.FlightInfo' table. You can move, or remove it, as needed.
            this.flightInfoTableAdapter.Fill(this.databaseDataSet.FlightInfo);
            // TODO: This line of code loads data into the 'databaseDataSet1.FlightInfo' table. You can move, or remove it, as needed.
            this.flightInfoTableAdapter.Fill(this.databaseDataSet1.FlightInfo);
            // TODO: This line of code loads data into the 'databaseDataSet.Flight' table. You can move, or remove it, as needed.
            this.flightTableAdapter.Fill(this.databaseDataSet.Flight);

        }
    }
}
