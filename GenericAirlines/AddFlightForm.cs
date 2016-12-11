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
            DepartureTextBox.TextAlign = HorizontalAlignment.Center;
            ArrivalTextBox.TextAlign = HorizontalAlignment.Center;
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
                DepartureTextBox.Text = _route.Departure.ToString();
                ArrivalTextBox.Text = _route.Arrival.ToString();
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
                var date = DatePicker.Value;

                do
                {
                    flight = db.Flights.Create();
                    flight.Route_id = _route.Id;
                    flight.Date = date;
                    db.Flights.Add(flight);

                    if (RepeatBox.SelectedIndex == 0)
                    {
                        date = date.AddDays(1);
                    }
                    else
                    {
                        date = date.AddDays(7);
                    }

                } while (CheckBox.Checked && DatePicker.Value.AddMonths((int)MonthBox.Value) > date);

                db.SaveChanges();
            }
          
            this.Close();
        }
    }
}
