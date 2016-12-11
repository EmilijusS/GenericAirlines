using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenericAirlines
{
    public partial class AddRouteForm : Form
    {

        public AddRouteForm(Route route)
        {
            InitializeComponent();
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            using (var db = new AirlinesContext())
            {
                var route = db.Routes.Create();
                route.Origin = OriginTextBox.Text;
                route.Destination = DestinationTextBox.Text;
                route.Departure = DepartureTimeBox.Value.TimeOfDay;
                route.Arrival = ArrivalTimeBox.Value.TimeOfDay;

                db.Routes.Add(route);
                db.SaveChanges();
            }

            this.Close();
        }

        private void AddRouteForm_Shown(object sender, EventArgs e)
        {
            ConfirmButton.Focus();
        }


    }
}
