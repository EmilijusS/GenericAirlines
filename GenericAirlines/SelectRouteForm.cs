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
        public SelectRouteForm()
        {
            InitializeComponent();
        }

        private void SelectRouteForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet.Route' table. You can move, or remove it, as needed.
            this.routeTableAdapter.Fill(this.databaseDataSet.Route);

        }
    }
}
