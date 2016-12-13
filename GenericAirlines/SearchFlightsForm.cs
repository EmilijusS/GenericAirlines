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
    public partial class SearchFlightsForm : Form
    {
        private List<RouteModel> _routes;
        private List<FlightModel> _flights;
        private string _email;
        private int _selected = -1;

        public SearchFlightsForm(string email)
        {
            InitializeComponent();

            _email = email;
        }

        private void SearchFlightsForm_Load(object sender, EventArgs e)
        {
            using (var db = new AirlinesContext())
            {
                _routes =
                    db.Routes.Select(
                        x =>
                            new RouteModel
                            {
                                Id = x.Id,
                                Origin = x.OriginLocation.Airport,
                                Destination = x.DestinationLocation.Airport
                            }).ToList();
            }

            RouteBox.DataSource = _routes.Select(x => x.Origin + " -> " + x.Destination).ToArray();

            RouteBox_SelectedIndexChanged(this, new EventArgs());

            DataGridViewCheckBoxColumn Select = new DataGridViewCheckBoxColumn();
            Select.HeaderText = "Select";
            Select.Name = "Select";
            FlightView.Columns.Add(Select);
        }

        private void RouteBox_SelectedIndexChanged(object sender, EventArgs e)
        {    
            LoadFlights();
            LoadFlightGrid();
            FormatFlightGrid();
        }

        private void LoadFlights()
        {
            using (var db = new AirlinesContext())
            {
                var routeId = _routes[RouteBox.SelectedIndex].Id;
                var passenger = db.Passengers.Find(_email);

                //&& x.Passengers.All(y => y != passenger
                _flights =
                    db.Flights.Where(x => x.Route.Id == routeId && x.Plane != null)
                        .Select(x => new FlightModel
                        {
                            Id = x.Id,
                            DestinationLocation = x.Route.DestinationLocation,
                            OriginLocation = x.Route.OriginLocation,
                            Arrival = x.Arrival,
                            Departure = x.Departure,
                            PlaneModel = x.Plane.Model
                        })
                        .OrderBy(x => x.Departure)
                        .ToList();
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
                _flights.Id,
                Origin = _flights.OriginLocation.Airport,
                Destination = _flights.DestinationLocation.Airport,
                _flights.Departure,
                _flights.Arrival,
                _flights.FlightDuration,
                _flights.PlaneModel
            }).ToArray();

            FlightView.Columns["Id"].Visible = false;

        }

        private void FormatFlightGrid()
        {
            foreach (DataGridViewColumn c in FlightView.Columns)
            {
                c.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                if (c.Name != "Select")
                    c.ReadOnly = true;
            }

            FlightView.Columns["Departure"].DefaultCellStyle.Format = "yyyy-MM-dd HH:mm";
            FlightView.Columns["Arrival"].DefaultCellStyle.Format = "yyyy-MM-dd HH:mm";
            FlightView.Columns["FlightDuration"].DefaultCellStyle.Format = "hh\\ \\h\\ mm\\ \\m";
            FlightView.Columns["FlightDuration"].HeaderText = "Flight duration";
            FlightView.Columns["PlaneModel"].HeaderText = "Plane model";
        }

        private void FlightView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == FlightView.Columns["Select"].Index)
                {
                    if (_selected != -1)
                        FlightView.Rows[_selected].Cells[FlightView.Columns["Select"].Index].Value = false;

                    if (_selected == e.RowIndex)
                        _selected = -1;
                    else
                        _selected = e.RowIndex;
                }
            }
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            using (var db = new AirlinesContext())
            {
                var passenger = db.Passengers.Find(_email);

                if (_selected != -1)
                    passenger.Flights.Add(db.Flights.Find((int)FlightView.Rows[_selected].Cells["Id"].Value));

                db.SaveChanges();
            }

            this.Close();
        }
    }
}
