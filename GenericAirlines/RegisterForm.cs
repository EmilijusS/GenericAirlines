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
            if (Validation())
            {
                using (var db = new AirlinesContext())
                {
                    var passenger = db.Passengers.Create();
                    if (db.Passengers.Find(EmailBox.Text.ToLower()) == null)
                    {
                        passenger.Name = NameBox.Text;
                        passenger.Surname = SurnameBox.Text;
                        passenger.Email = EmailBox.Text.ToLower();
                        passenger.Password = PasswordBox.Text.Encrypt();

                        db.Passengers.Add(passenger);
                        db.SaveChanges();

                        this.Close();
                    }
                    else
                    {
                        Error.Visible = true;
                        Error.Text = "Email already used";
                    }

                }
            }          
        }

        private bool Validation()
        {
            if (!GenericAirlines.Validation.Name(NameBox.Text))
            {
                Error.Visible = true;
                Error.Text = "Bad name";
                return false;
            }
            else if (!GenericAirlines.Validation.Name(SurnameBox.Text))
            {
                Error.Visible = true;
                Error.Text = "Bad surname";
                return false;
            }
            else if (!GenericAirlines.Validation.Email(EmailBox.Text))
            {
                Error.Visible = true;
                Error.Text = "Bad email";
                return false;
            }
            else if (!GenericAirlines.Validation.Password(PasswordBox.Text))
            {
                Error.Visible = true;
                Error.Text = "Bad password";
                return false;
            }
           
            return true;
        }


    }
}
