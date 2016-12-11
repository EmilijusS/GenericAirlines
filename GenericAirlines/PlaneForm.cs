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
    public partial class PlaneForm : Form
    {
        private readonly int EditColumnIndex = 3;
        private readonly int DeleteColumnIndex = 4;

        public PlaneForm()
        {
            InitializeComponent();
        }


        private void AddPlane_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            var addPlaneForm = new AddEditPlaneForm();
            addPlaneForm.FormClosed += (a, b) => { PlaneForm_Load(a, b);
                this.Enabled = true;
            };
            addPlaneForm.Show();
        }

        private void PlaneDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == EditColumnIndex)
                    EditPlane(e.RowIndex);

                if (e.ColumnIndex == DeleteColumnIndex)
                    DeletePlane(e.RowIndex);
            }
        }

        private void DeletePlane(int rowIndex)
        {
            var d = (DataRowView)PlaneDataGrid.Rows[rowIndex].DataBoundItem;

            using (var db = new AirlinesContext())
            {
                db.Planes.Remove(db.Planes.Find(d.Row[0]));
                db.SaveChanges();
            }

            PlaneForm_Load(this, new EventArgs());
        }

        private void EditPlane(int rowIndex)
        {
            Plane plane;
            var d = (DataRowView)PlaneDataGrid.Rows[rowIndex].DataBoundItem;

            using (var db = new AirlinesContext())
            {
                plane = db.Planes.Find(d.Row[0]);
            }
                
            var editPlaneForm = new AddEditPlaneForm(plane);

            editPlaneForm.FormClosed += (a, b) => PlaneForm_Load(a, b);
            editPlaneForm.Show();
        }

        private void PlaneForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet.Plane' table. You can move, or remove it, as needed.
            this.planeTableAdapter.Fill(this.databaseDataSet.Plane);
        }
    }
}
