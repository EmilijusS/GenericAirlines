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
    public partial class AddPlaneForm : Form
    {
        public AddPlaneForm()
        {
            InitializeComponent();
        }

        private void ConfirmAddPlane_Click(object sender, EventArgs e)
        {
            using (var db = new AirlinesContext())
            {
                var plane = db.Planes.Create();
                plane.Id = PlaneId.Text;
                plane.Seat_count = (int) PlaneSeatCount.Value;
                plane.Model = PlaneModel.Text;
                plane.Manufactured = new DateTime((int) PlaneManufactured.Value, 1, 1);
                db.Planes.Add(plane);
                db.SaveChanges();
            }

            this.Close();
        }

    }
}
