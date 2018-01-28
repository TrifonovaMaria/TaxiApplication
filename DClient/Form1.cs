
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
    public partial class Form1 : Form
    {
        ServiceReference1.WebServiceTaxiSoapClient Сlient;
        public Form1()
        {
            Сlient = new ServiceReference1.WebServiceTaxiSoapClient();
        }

        private void buttonReg_Click(object sender, EventArgs e)
        {
            var au = new Authorization()
            {
                Login = "111",
                Password = "222",
                Role = 2
            };

            var cust = new Customer()
            {
                FirstName = "Оля",
                LastName = "Петрова",
                Phone = "123123"
            };

            Сlient.RegistrateCustomer(Parser.ParseCustomer(cust), Parser.ParseAuth(au));

        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {

        }
    }
}
