using DataModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DClient
{
    public partial class FormRegistrate : Form
    {
        ServiceReference1.WebServiceTaxiSoapClient Сlient;

        public FormRegistrate()
        {
            InitializeComponent();
            Сlient = new ServiceReference1.WebServiceTaxiSoapClient();
        }

        private void buttonRegistrate_Click(object sender, EventArgs e)
        {
            if (textBoxPassword.Text != textBoxPasswordR.Text)
            {
                MessageBox.Show("Пароль введен неправильно.");
                return;
            }

            var au = new Authorization()
            {
                Login = textBoxLogin.Text,
                Password = textBoxPassword.Text,
                Role = 1
            };

            var cust = new Customer()
            {
                FirstName = textBoxFName.Text,
                LastName = textBoxLName.Text,
                Phone = textBoxPhone.Text
            };

            if (Сlient.RegistrateCustomer(Parser.ParseCustomer(cust), Parser.ParseAuth(au)) == false)
                MessageBox.Show("Такой логин уже используется");
            else
            {
                Program.userID = Сlient.Authorize(Parser.ParseAuth(au));
                Program.formEnter.Show();
                Hide();
            }

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Program.formEnter.Show();
            Hide();
        }
    }
}
