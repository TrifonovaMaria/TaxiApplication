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
    public partial class FormMain : Form
    {
        ServiceReference1.WebServiceTaxiSoapClient Сlient;

        public FormMain()
        {
            InitializeComponent();
        }

        public void GetControlsForNewOrder()
        {
            tabControlWindows.TabPages[2].Text = "Офомить заказ";

            textBoxAdres1.Text = "";
            textBoxAdres2.Text = "";
            comboBoxClass.Text = "";
            comboBoxPayMethod.Text = "";
            textBoxNumberCard.Text = "";

            buttonOrder.Visible = true;
            labelStatus.Visible = false;
            textBoxStatus.Visible = false;
            buttonGetPhone.Visible = false;
            textBoxPhone.Visible = false;
            buttonRefuse.Visible = false;
            textBoxClass.Visible = false;
            textBoxPayMethod.Visible = false;
            comboBoxClass.Visible = true;
            comboBoxPayMethod.Visible = true;

            textBoxAdres1.ReadOnly = false;
            textBoxAdres2.ReadOnly = false;
            textBoxStatus.ReadOnly = false;
        }

        public void GetControlsForCurrentOrder(Order order)
        {
            tabControlWindows.TabPages[2].Text = "Текущий заказ";

            buttonOrder.Visible = false;
            labelStatus.Visible = true;
            textBoxStatus.Visible = true;
            buttonGetPhone.Visible = true;
            textBoxPhone.Visible = true;
            buttonRefuse.Visible = true;
            textBoxClass.Visible = true;
            textBoxPayMethod.Visible = true;
            comboBoxClass.Visible = false;
            comboBoxPayMethod.Visible = false;

            textBoxAdres1.Text = order.DepartureAddress;
            textBoxAdres2.Text = order.DestinationAddress;
            textBoxClass.Text = order.CarClass;
            textBoxPayMethod.Text = order.PaymentMethod;
            textBoxNumberCard.Text = order.CardNumber;
            textBoxStatus.Text = order.Status;

            textBoxAdres1.ReadOnly = true;
            textBoxAdres2.ReadOnly = true;
            textBoxStatus.ReadOnly = true;
            textBoxPayMethod.ReadOnly = true;
            textBoxNumberCard.ReadOnly = true;
            textBoxStatus.ReadOnly = true;
            textBoxPhone.ReadOnly = true;
        }

        public void GetOrdersTable()
        {
            List<Order> list = Parser.GetListOrders(Сlient.GetListOfOrders(Program.userID, 1));
            dataGridViewOrders.Rows.Clear();
            foreach (var order in list)
                dataGridViewOrders.Rows.Add(order.Date, order.DepartureAddress, order.DestinationAddress, GetStatus(Convert.ToInt32(order.Status)));
        }

        public void GetControlsForProfile()
        {
            Customer custumer = Parser.GetCustomer(Сlient.FindCustomer(Program.userID));
            Authorization auth = Parser.GetAuth(Сlient.FindAuth(custumer.ID_Auth));

            textBoxFName.Text = custumer.FirstName;
            textBoxLName.Text = custumer.LastName;
            textBoxCustomerPhone.Text = custumer.Phone;
            textBoxLogin.Text = auth.Login;
            textBoxPassword.Text = auth.Password;
            textBoxPasswordR.Text = auth.Password;
        }

        public string GetStatus (int i)
        {
            switch (i)
            {
                case 1:
                    return "Поиск водителя";
                case 2:
                    return "Ожидайте водителя";
                case 3:
                    return "Отменен";
                case 4:
                    return "В поездке";
                case 5:
                    return "Законченный";
            }
            return "error";
        }

        private void buttonOrder_Click(object sender, EventArgs e)
        {
            var order = new Order()
            {
                ID = Guid.NewGuid(),
                ID_Customer = Program.userID,
                DepartureAddress = textBoxAdres1.Text,
                DestinationAddress = textBoxAdres2.Text,
                CarClass = comboBoxClass.Text,
                PaymentMethod = comboBoxPayMethod.Text,
                //CardNumber = textBoxNumberCard,
                Status = "1",
                Date = DateTime.Now,
                Price = 0
            };

            Сlient.CreateOrder(Parser.ParseOrder(order));
        }

        private void tabControlWindows_Selecting(object sender, TabControlCancelEventArgs e)
        {
            switch (tabControlWindows.SelectedIndex)
            {
                case 0:
                    GetControlsForProfile();
                    break;
                case 1:
                    GetOrdersTable();
                    break;
                case 2:
                    Order order = Parser.GetOrder(Сlient.ShowOrder(Program.userID));
                    if (order == null)
                        GetControlsForNewOrder();
                    else
                        GetControlsForCurrentOrder(order);
                    break;
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            Сlient = new ServiceReference1.WebServiceTaxiSoapClient();
            tabControlWindows.SelectedIndex = 2;

            Order order = Parser.GetOrder(Сlient.ShowOrder(Program.userID));

            if (order == null)
                GetControlsForNewOrder();
            else
                GetControlsForCurrentOrder(order);
        }

        private void buttonGetPhone_Click(object sender, EventArgs e)
        {
            Order order = Parser.GetOrder(Сlient.ShowOrder(Program.userID));
            if (order.Status != "1") 
                textBoxPhone.Text = Сlient.GetDriverNumber(order.ID);
        }

        private void buttonRefuse_Click(object sender, EventArgs e)
        {
            Order order = Parser.GetOrder(Сlient.ShowOrder(Program.userID));
            Сlient.CancellationOfOrder(Program.userID, order.ID);
            GetControlsForNewOrder();
        }

        private void buttonChangeProfile_Click(object sender, EventArgs e)
        {
            if (textBoxPassword.Text != textBoxPasswordR.Text)
            {
                MessageBox.Show("Пароль введен неправильно.");
                return;
            }
            
            var cust = Parser.GetCustomer(Сlient.FindCustomer(Program.userID));
            cust.FirstName = textBoxFName.Text;
            cust.LastName = textBoxLName.Text;
            cust.Phone = textBoxCustomerPhone.Text;

            var au = Parser.GetAuth(Сlient.FindAuth(cust.ID_Auth));
            au.Login = textBoxLogin.Text;
            au.Password = textBoxPassword.Text;

            if (Сlient.EditCustomerProfile(Parser.ParseAuth(au), Parser.ParseCustomer(cust)) == false)
                MessageBox.Show("Такой логин уже используется.");
            else
                MessageBox.Show("Изменения сохранены.");
        }
    }
}
