using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenericAirlines
{
    public partial class AddRouteForm : Form
    {
        private BindingList<string> _locations;

        public AddRouteForm()
        {
            InitializeComponent();
            _locations = new BindingList<string>();
            OriginBox.DataSource = _locations;
            // Without this line both combo boxes are bound together
            DestinationBox.BindingContext = new BindingContext();
            DestinationBox.DataSource = _locations;
            UpdateLocations();

            if (_locations.Count > 0)
            {
                OriginBox.SelectedIndex = 0;
                DestinationBox.SelectedIndex = 0;
            }

        }

        private void UpdateLocations()
        {
            _locations.Clear();

            using (var db = new AirlinesContext())
            {
                foreach (var l in db.Locations)
                {
                    _locations.Add(l.Airport);
                }
            }
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            using (var db = new AirlinesContext())
            {
                var route = db.Routes.Create();
                route.Origin = OriginBox.Text;
                route.Destination = DestinationBox.Text;

                db.Routes.AddOrUpdate(route);
                db.SaveChanges();
            }

            this.Close();
        }

        private void AddRouteForm_Shown(object sender, EventArgs e)
        {
            ConfirmButton.Focus();
        }

        private void AddLocationButton_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            var addLocationForm = new AddLocationForm();

            addLocationForm.Closed += (a, b) => { this.Enabled = true; UpdateLocations(); };

            addLocationForm.Show();
        }
    }
}
