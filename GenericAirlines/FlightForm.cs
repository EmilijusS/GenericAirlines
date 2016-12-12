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
        private const int PlaneColumnIndex = 4;
        private const int PilotsColumnIndex = 5;
        private const int AttendantsColumnIndex = 6;
        private const int PassengersColumnIndex = 7;
        private const int DeleteColumnIndex = 8;

        public FlightForm()
        {
            InitializeComponent();
        }

        private void FlightForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet.FlightInfo' table. You can move, or remove it, as needed.
            this.flightInfoTableAdapter.Fill(this.databaseDataSet.FlightInfo);
        }

        private void AddFlightButton_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            var addFlightForm = new AddFlightForm();
            addFlightForm.FormClosed += (a, b) => {
                FlightForm_Load(a, b);
                this.Enabled = true;
            };
            addFlightForm.Show();
        }

        private void FlightDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                switch (e.ColumnIndex)
                {
                    case DeleteColumnIndex:
                        DeleteFlight(e.RowIndex);
                        break;
                }
            }
        }

        private void DeleteFlight(int rowIndex)
        {
            var d = (DataRowView)FlightDataGrid.Rows[rowIndex].DataBoundItem;

            using (var db = new AirlinesContext())
            {
                db.Flights.Remove(db.Flights.Find(d.Row[0]));
                db.SaveChanges();
            }

            FlightForm_Load(this, new EventArgs());
        }
    }
}
