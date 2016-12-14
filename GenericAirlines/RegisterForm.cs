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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            using (var db = new AirlinesContext())
            {
                var passenger = db.Passengers.Create();
                passenger.Name = NameBox.Text;
                passenger.Surname = SurnameBox.Text;
                passenger.Email = EmailBox.Text;
                passenger.Password = PasswordBox.Text.Encrypt();

                db.Passengers.Add(passenger);
                db.SaveChanges();
            }

            this.Close();
        }
    }
}
