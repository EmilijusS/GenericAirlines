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

                _flights = passenger.Flights.Select(x => new FlightModel
                {
                    DestinationLocation = x.Route.DestinationLocation,
                    OriginLocation = x.Route.OriginLocation,
                    Arrival = x.Arrival,
                    Departure = x.Departure,
                    PlaneModel = x.Plane.Model
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
                _flights.PlaneModel
            }).ToArray();          
        }

        private void FormatFlightGrid()
        {
            foreach (DataGridViewColumn c in FlightView.Columns)
            {
                c.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

            FlightView.Columns["FlightDuration"].DefaultCellStyle.Format = "hh\\ \\h\\ mm\\ \\m";
            FlightView.Columns["FlightDuration"].HeaderText = "Flight duration";
            FlightView.Columns["PlaneModel"].HeaderText = "Plane model";
        }
    }
}
