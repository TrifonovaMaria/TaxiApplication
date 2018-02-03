using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModels
{
    public static class Parser
    {
        public static string ParseAuth(Authorization au)
        {
            if (au == null)
                return null;
            string str = Convert.ToString(au.ID) + '/' + au.Login + '/' + au.Password + '/' + au.Role;
            return str;
        }

        public static Authorization GetAuth (string str)
        {
            if (str == null)
                return null;
            var strSplit = str.Split('/');
            var au = new Authorization
            {
                ID = Guid.Parse(strSplit[0]),
                Login = strSplit[1],
                Password = strSplit[2],
                Role = Convert.ToInt32(strSplit[3])
            };
            return au;
        }

        public static string ParseDriver(Driver dr)
        {
            if (dr == null)
                return null;
            string str =
                Convert.ToString(dr.ID)
                + '/' + dr.FirstName
                + '/' + dr.LastName
                + '/' + dr.Birthday
                + '/' + dr.Phone
                + '/' + dr.License
                + '/' + dr.CarNumber
                + '/' + dr.CarClass
                + '/' + Convert.ToString(dr.ID_Auth);
            return str;
        }

        public static Driver GetDriver(string str)
        {
            if (str == null)
                return null;
            var strSplit = str.Split('/');
            var dr = new Driver
            {
                ID = Guid.Parse(strSplit[0]),
                FirstName = strSplit[1],
                LastName = strSplit[2],
                Birthday = Convert.ToDateTime(strSplit[3]),
                Phone = strSplit[4],
                License = strSplit[5],
                CarNumber = strSplit[6],
                CarClass = strSplit[7],
                ID_Auth = Guid.Parse(strSplit[8])
            };
            return dr;
        }

        public static string ParseCustomer(Customer cust)
        {
            if (cust == null)
                return null;
            string str =
                Convert.ToString(cust.ID)
                + '/' + cust.FirstName
                + '/' + cust.LastName
                + '/' + cust.Phone
                + '/' + Convert.ToString(cust.ID_Auth);
            return str;
        }

        public static Customer GetCustomer(string str)
        {
            if (str == null)
                return null;
            var strSplit = str.Split('/');
            var cust = new Customer
            {
                ID = Guid.Parse(strSplit[0]),
                FirstName = strSplit[1],
                LastName = strSplit[2],
                Phone = strSplit[3],
                ID_Auth = Guid.Parse(strSplit[4])
            };
            return cust;
        }

        public static string ParseOrder(Order or)
        {
            if (or == null)
                return null;
            string str =
                Convert.ToString(or.ID)
                + '/' + or.ID_Customer
                + '/' + or.DepartureAddress
                + '/' + or.DestinationAddress
                + '/' + or.CarClass
                + '/' + or.PaymentMethod
                + '/' + or.CardNumber
                + '/' + or.Status
                + '/' + or.ID_Driver
                + '/' + or.Date
                + '/' + or.Price;
            return str;
        }

        public static Order GetOrder(string str)
        {
            if (str == null)
                return null;
            var strSplit = str.Split('/');
            var or = new Order
            {
                ID = Guid.Parse(strSplit[0]),
                ID_Customer = Guid.Parse(strSplit[1]),
                DepartureAddress = strSplit[2],
                DestinationAddress = strSplit[3],
                CarClass = strSplit[4],
                PaymentMethod = strSplit[5],
                CardNumber = strSplit[6],
                Status = strSplit[7],
                //ID_Driver = Guid.Parse(strSplit[8]),
                Date = Convert.ToDateTime(strSplit[9]),
                Price = Convert.ToInt32(strSplit[10])
            };
            if (strSplit[8] == "")
                or.ID_Driver = null;

            return or;
        }

        public static string ParseListOrders(List<Order> list)
        {
            if (list.Count == 0)
                return null;
            var massString = new string[list.Count];
            string str = "";
            foreach (var order in list)
                str += '*' + Parser.ParseOrder(order) + '*';
            str = str.Substring(1, str.Length - 2);
            return str;
        }

        public static List<Order> GetListOrders(string str)
        {
            if (str == null)
                return null;
            var strSplit = str.Split('*');
            var list = new List<Order>();
            foreach (var or in strSplit)
                list.Add(Parser.GetOrder(or));
            return list;
        }
    }
}
