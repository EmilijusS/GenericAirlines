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

        private void PlanesDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == 4)
                    EditPlane(e.RowIndex);

                if (e.ColumnIndex == 5)
                    DeletePlane(e.RowIndex);
            }
        }

        private void DeletePlane(int rowIndex)
        {
            using (var db = new AirlinesContext())
            {
                db.Planes.Remove(db.Planes.Find(PlanesDataGrid.Rows[rowIndex].Cells[0].Value));
                db.SaveChanges();
            }

            UpdatePlanesDataGrid();
        }

        private void EditPlane(int rowIndex)
        {
            var addPlaneForm = new AddPlaneForm((string) PlanesDataGrid.Rows[rowIndex].Cells[0].Value,
                (string) PlanesDataGrid.Rows[rowIndex].Cells[1].Value,
                (int) PlanesDataGrid.Rows[rowIndex].Cells[2].Value,
                (int) PlanesDataGrid.Rows[rowIndex].Cells[3].Value);

            addPlaneForm.FormClosed += (a, b) => UpdatePlanesDataGrid();
            addPlaneForm.Show();
        }
    }
}
