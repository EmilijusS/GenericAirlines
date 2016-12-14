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
    public partial class PassengerForm : Form
    {
        private readonly string _email;
        private List<FlightModel> _flights;

        public PassengerForm(string email)
        {
            InitializeComponent();
            _email = email;
        }

        private void PassengerForm_Load(object sender, EventArgs e)
        {          
            LoadFlights();
            LoadFlightGrid();
            FormatFlightGrid();
        }

        private void LoadFlights()
        {
            using (var db = new AirlinesContext())
            {
                var passenger = db.Passengers.Find(_email);

                _flights = passenger.Tickets.Select(x => new FlightModel
                {
                    DestinationLocation = x.Flight.Route.DestinationLocation,
                    OriginLocation = x.Flight.Route.OriginLocation,
                    Arrival = x.Flight.Arrival,
                    Departure = x.Flight.Departure,
                    PlaneModel = x.Flight.Plane.Model,
                    TicketCount = x.Count
                }).ToList();
            }

            foreach (var f in _flights)
            {
                f.FlightDuration = f.Arrival -
                                   TimeZoneInfo.ConvertTimeBySystemTimeZoneId(f.Departure, f.OriginLocation.Timezone,
                                       f.DestinationLocation.Timezone);
            }
        }

        private void LoadFlightGrid()
        {
            FlightView.DataSource = _flights.Select(_flights => new
            {
                Origin = _flights.OriginLocation.Airport,
                Destination = _flights.DestinationLocation.Airport,
                _flights.Departure,
                _flights.Arrival,
                _flights.FlightDuration,
                _flights.TicketCount,
                _flights.PlaneModel
            }).ToArray();          
        }

        private void FormatFlightGrid()
        {
            foreach (DataGridViewColumn c in FlightView.Columns)
            {
                c.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

            FlightView.Columns["Departure"].DefaultCellStyle.Format = "yyyy-MM-dd HH:mm";
            FlightView.Columns["Arrival"].DefaultCellStyle.Format = "yyyy-MM-dd HH:mm";
            FlightView.Columns["FlightDuration"].DefaultCellStyle.Format = "hh\\ \\h\\ mm\\ \\m";
            FlightView.Columns["FlightDuration"].HeaderText = "Flight duration";
            FlightView.Columns["PlaneModel"].HeaderText = "Plane model";
            FlightView.Columns["TicketCount"].HeaderText = "Ticket count";
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            var searchFlightsForm = new SearchFlightsForm(_email);
            searchFlightsForm.FormClosed += (a, b) => {
                PassengerForm_Load(a, b);
                this.Enabled = true;
            };
            searchFlightsForm.Show();
        }
    }
}
