using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericAirlines
{
    class FlightModel
    {
        public int Id { get; set; }
        public System.DateTime Departure { get; set; }
        public System.DateTime Arrival { get; set; }
        public Location OriginLocation { get; set; }
        public Location DestinationLocation { get; set; }
        public TimeSpan FlightDuration { get; set; }
        public int TicketCount { get; set; }
        public string PlaneModel { get; set; }
    }
}
