using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenericAirlines
{
    public partial class AddFlightForm : Form
    {
        private Route _route = new Route();

        public AddFlightForm()
        {
            InitializeComponent();
            OriginTextBox.TextAlign = HorizontalAlignment.Center;
            DestinationTextBox.TextAlign = HorizontalAlignment.Center;
            RepeatBox.SelectedIndex = 0;
        }

        private void SelectRouteButton_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            var selectRouteForm = new SelectRouteForm(_route);

            selectRouteForm.Closed += (a, b) =>
            {
                OriginTextBox.Text = _route.Origin;
                DestinationTextBox.Text = _route.Destination;
                this.Enabled = true;
            };

            selectRouteForm.Show();
        }

        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox.Checked)
            {
                RepeatBox.Enabled = true;
                MonthBox.Enabled = true;
            }
            else
            {
                RepeatBox.Enabled = false;
                MonthBox.Enabled = false;
            }
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {

            using (var db = new AirlinesContext())
            {
                Flight flight;
                var date1 = DepartureBox.Value;
                var date2 = ArrivalBox.Value;

                do
                {
                    flight = db.Flights.Create();
                    flight.Route_id = _route.Id;
                    flight.Departure = date1;
                    flight.Arrival = date2;
                    db.Flights.Add(flight);

                    if (RepeatBox.SelectedIndex == 0)
                    {
                        date1 = date1.AddDays(1);
                        date2 = date2.AddDays(1);
                    }
                    else
                    {
                        date1 = date1.AddDays(7);
                        date2 = date2.AddDays(7);
                    }

                } while (CheckBox.Checked && DepartureBox.Value.AddMonths((int)MonthBox.Value) > date1);

                db.SaveChanges();
            }
          
            this.Close();
        }
    }
}
