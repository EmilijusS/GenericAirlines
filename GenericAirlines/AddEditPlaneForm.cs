using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        private bool IsEdited = false;

        public AddEditPlaneForm()
        {
            InitializeComponent();
        }

        public AddEditPlaneForm(string id, string model, int seatCount, int manufactured)
        {
            InitializeComponent();

            PlaneId.Text = id;
            PlaneId.Enabled = false;
            PlaneSeatCount.Value = seatCount;
            PlaneModel.Text = model;
            PlaneManufactured.Value = manufactured;
            IsEdited = true;
        }

        private void ConfirmAddPlane_Click(object sender, EventArgs e)
        {

            if (!IsEdited)
                Add();
            else
                Edit();

            this.Close();
        }

        private void Add()
        {
            using (var db = new AirlinesContext())
            {
                var plane = db.Planes.Create();
                plane.Id = PlaneId.Text;
                plane.Seat_count = (int)PlaneSeatCount.Value;
                plane.Model = PlaneModel.Text;
                plane.Manufactured = new DateTime((int)PlaneManufactured.Value, 1, 1);
                db.Planes.Add(plane);
                db.SaveChanges();
            }
        }

        private void Edit()
        {
            using (var db = new AirlinesContext())
            {
                var plane = db.Planes.Find(PlaneId.Text);
                plane.Seat_count = (int)PlaneSeatCount.Value;
                plane.Model = PlaneModel.Text;
                plane.Manufactured = new DateTime((int)PlaneManufactured.Value, 1, 1);
                db.SaveChanges();
            }
        }

        private void AddPlaneForm_Shown(object sender, EventArgs e)
        {
            ConfirmAddPlane.Focus();
        }
    }
}
