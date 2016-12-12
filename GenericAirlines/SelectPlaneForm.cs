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
    public partial class SelectPlaneForm : Form
    {
        private const int SelectColumnIndex = 3;
        private int _selected = -1;
        private Flight _flight;

        public SelectPlaneForm(Flight flight)
        {
            InitializeComponent();
            _flight = flight;            
        }

        private void ChoosePlaneForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet.Plane' table. You can move, or remove it, as needed.
            this.planeTableAdapter.Fill(this.databaseDataSet.Plane);

            if (_flight.Plane_id != null)
            {
                foreach (DataGridViewRow r in PlaneDataGrid.Rows)
                {
                    if ((string)r.Cells[0].Value == _flight.Plane_id)
                    {
                        r.Cells[SelectColumnIndex].Value = true;
                        _selected = r.Index;
                    }
                }
            }
        }

        private void PlaneDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == SelectColumnIndex)
                {
                    if(_selected != -1)
                        PlaneDataGrid.Rows[_selected].Cells[SelectColumnIndex].Value = false;

                    if (_selected == e.RowIndex)
                        _selected = -1;
                    else
                        _selected = e.RowIndex;
                }                    
            }
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            using (var db = new AirlinesContext())
            {
                var flight = db.Flights.Find(_flight.Id);

                if (_selected == -1)
                    flight.Plane_id = null;
                else
                flight.Plane_id = (string) PlaneDataGrid.Rows[_selected].Cells[0].Value;

                db.SaveChanges();
            }


            this.Close();
        }
    }
}
