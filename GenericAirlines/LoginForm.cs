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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            Console.WriteLine("admin".Encrypt());
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            using (var db = new AirlinesContext())
            {
                Passenger passenger = db.Passengers.Find(EmailTextBox.Text.ToLower());
                Admin admin = db.Admins.Find(EmailTextBox.Text.ToLower());

                if (passenger != null)
                    if (passenger.Password == PasswordTextBox.Text.Encrypt())
                    {
                        var form = new PassengerForm(passenger.Email);
                        form.Closed += (a, b) => this.Close();
                        this.Visible = false;
                        form.Show();
                    }
                    else
                        WrongPassword();                        
                else if (admin != null)
                    if (admin.Password == PasswordTextBox.Text.Encrypt())
                    {
                        var form = new AdminForm();
                        form.Closed += (a, b) => this.Close();
                        this.Visible = false;
                        form.Show();
                    }
                    else
                        WrongPassword();
                else
                    WrongEmail();
            }
        }

        private void WrongEmail()
        {
            Error.Visible = true;
            Error.Text = "Wrong email";
        }

        private void WrongPassword()
        {
            Error.Visible = true;
            Error.Text = "Wrong password";
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            var form = new RegisterForm();
            this.Enabled = false;
            form.Closed += (a, b) => this.Enabled = true;
            form.Show();
        }
    }
}
