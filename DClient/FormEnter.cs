
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Json;
using System.IO;
using DataModels;

namespace DClient
{
    public partial class FormEnter : Form
    {
        ServiceReference1.WebServiceTaxiSoapClient Сlient;
        public FormEnter()
        {
            InitializeComponent();
            Сlient = new ServiceReference1.WebServiceTaxiSoapClient();
        }

        private void buttonReg_Click(object sender, EventArgs e)
        {
            Program.formRegistrate.Show();
            Hide();

        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            var au = new Authorization()
            {
                Login = textBoxLogin.Text,
                Password = textBoxPassword.Text,
                Role = 1
            };

            Program.userID = Сlient.Authorize(Parser.ParseAuth(au));
            if (Program.userID == Guid.Empty)
                MessageBox.Show("Логин или пароль введены неправильно.");
            else
            {
                Program.formMain.Show();
                Hide();
            }
        }
        
    }
}
