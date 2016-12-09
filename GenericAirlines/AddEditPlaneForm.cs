using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenericAirlines
{
    public partial class AddEditPlaneForm : Form
    {

        public AddEditPlaneForm()
        {
            InitializeComponent();
        }

        public AddEditPlaneForm(Plane plane)
        {
            InitializeComponent();

            PlaneId.Text = plane.Id;
            PlaneId.Enabled = false;
            PlaneSeatCount.Value = plane.Seat_count;
            PlaneModel.Text = plane.Model;
        }

        private void ConfirmAddPlane_Click(object sender, EventArgs e)
        {
            using (var db = new AirlinesContext())
            {
                var plane = db.Planes.Create();
                plane.Id = PlaneId.Text;
                plane.Seat_count = (int)PlaneSeatCount.Value;
                plane.Model = PlaneModel.Text;

                if(!PlaneId.Enabled || db.Planes.Find(plane.Id) == null)
                    db.Planes.AddOrUpdate(plane);

                db.SaveChanges();
            }

            this.Close();
        }

        private void AddPlaneForm_Shown(object sender, EventArgs e)
        {
            ConfirmAddPlane.Focus();
        }
    }
}
