using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenericAirlines
{
    public partial class ViewPassengersForm : Form
    {
        private Flight _flight;

        public ViewPassengersForm(Flight flight)
        {
            InitializeComponent();
            _flight = flight;
        }

        private void ViewPassengersForm_Load(object sender, EventArgs e)
        {
            string query =
                $"SELECT A.Name, A.Surname, A.Email FROM Passenger A, Ticket B WHERE B.Flight_id = {_flight.Id} AND B.Passenger_email = A.Email";
            DataTable passengers = new DataTable();
            var bindingSource = new BindingSource();

            using (var db = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["Database"].ConnectionString))
            using (var adapter = new SqlDataAdapter(query, db))
            {                
                adapter.Fill(passengers);
            }

            bindingSource.DataSource = passengers;
            PassengersGridView.DataSource = bindingSource;

            foreach (DataGridViewColumn c in PassengersGridView.Columns)
            {
                c.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }
    }
}
