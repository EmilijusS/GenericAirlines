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
        private readonly int EditColumnIndex = 4;
        private readonly int DeleteColumnIndex = 5;
        private readonly int CrewColumnIndex = 6;

        public PlaneForm()
        {
            InitializeComponent();
        }


        private void AddPlane_Click(object sender, EventArgs e)
        {
            var addPlaneForm = new AddEditPlaneForm();
            addPlaneForm.Show();
        }

        private void PlanesDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == EditColumnIndex)
                    EditPlane(e.RowIndex);

                if (e.ColumnIndex == DeleteColumnIndex)
                    DeletePlane(e.RowIndex);

                //if (e.ColumnIndex == CrewColumnIndex)
                    //Crew(e.RowIndex);
            }
        }

        private void DeletePlane(int rowIndex)
        {
            //using (var db = new AirlinesContext())
            //{
            //    db.Plane.Remove(db.Plane.Find(PlanesDataGrid.Rows[rowIndex].Cells[0].Value));
            //    db.SaveChanges();
            //};
        }

        private void EditPlane(int rowIndex)
        {
            //var addPlaneForm = new AddEditPlaneForm((string) PlanesDataGrid.Rows[rowIndex].Cells[0].Value,
            //    (string) PlanesDataGrid.Rows[rowIndex].Cells[1].Value,
            //    (int) PlanesDataGrid.Rows[rowIndex].Cells[2].Value,
            //    (int) PlanesDataGrid.Rows[rowIndex].Cells[3].Value);

            //addPlaneForm.FormClosed += (a, b) => UpdatePlanesDataGrid();
            //addPlaneForm.Show();
        }

        private void PlaneForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet.Plane' table. You can move, or remove it, as needed.
            this.planeTableAdapter.Fill(this.databaseDataSet.Plane);

        }

        private void PlaneDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
