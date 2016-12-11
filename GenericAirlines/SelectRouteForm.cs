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
    public partial class SelectRouteForm : Form
    {
        private readonly int SelectColumnIndex = 4;
        private readonly int DeleteColumnIndex = 5;

        private Route _route;

        public SelectRouteForm(Route route)
        {
            InitializeComponent();
            _route = route;
        }

        private void SelectRouteForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet.Route' table. You can move, or remove it, as needed.
            this.routeTableAdapter.Fill(this.databaseDataSet.Route);

        }

        private void AddRouteButton_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            var addRouteForm = new AddRouteForm();
            addRouteForm.Closed += (a, b) =>
            {
                SelectRouteForm_Load(a, b);
                this.Enabled = true;
            };

            addRouteForm.Show();
        }

        private void PlaneDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == SelectColumnIndex)
                    SelectRoute(e.RowIndex);

                if (e.ColumnIndex == DeleteColumnIndex)
                    DeleteRoute(e.RowIndex);
            }
        }

        private void DeleteRoute(int rowIndex)
        {
            var d = (DataRowView)PlaneDataGrid.Rows[rowIndex].DataBoundItem;

            using (var db = new AirlinesContext())
            {
                db.Routes.Remove(db.Routes.Find(d.Row[0]));
                db.SaveChanges();
            }

            SelectRouteForm_Load(this, new EventArgs());
        }

        private void SelectRoute(int rowIndex)
        {
            var d = (DataRowView)PlaneDataGrid.Rows[rowIndex].DataBoundItem;
            _route.Id = (int)d.Row[0];
            _route.Departure = (TimeSpan) d.Row[1];
            _route.Arrival = (TimeSpan) d.Row[2];
            _route.Origin = (string) d.Row[3];
            _route.Destination = (string) d.Row[4];

            this.Close();
        }
    }
}
