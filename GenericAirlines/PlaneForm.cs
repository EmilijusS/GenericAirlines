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
    public partial class PlaneForm : Form
    {
        public PlaneForm()
        {
            InitializeComponent();
            UpdatePlanesDataGrid();
        }

        private void UpdatePlanesDataGrid()
        {
            PlanesDataGrid.Rows.Clear();

            using (var db = new AirlinesContext())
            {
                foreach (var p in db.Planes)
                {
                    PlanesDataGrid.Rows.Add(p.Id, p.Model, p.Seat_count, p.Manufactured.Year);
                }
            }
        }

        private void AddPlane_Click(object sender, EventArgs e)
        {
            var addPlaneForm = new AddPlaneForm();
            addPlaneForm.FormClosed += (a, b) => UpdatePlanesDataGrid();
            addPlaneForm.Show();
        }
    }
}
