using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenericAirlines
{
    public partial class AddLocationForm : Form
    {
        private ReadOnlyCollection<TimeZoneInfo> _zones;

        public AddLocationForm()
        {
            InitializeComponent();

            _zones = TimeZoneInfo.GetSystemTimeZones();
            TimezoneBox.DataSource = _zones;
            TimezoneBox.SelectedIndex = 0;
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            using (var db = new AirlinesContext())
            {
                var location = db.Locations.Create();
                location.Airport = LocationBox.Text;
                location.Timezone = _zones[TimezoneBox.SelectedIndex].Id;

                db.Locations.Add(location);
                db.SaveChanges();
            }

            this.Close();
        }
    }
}
