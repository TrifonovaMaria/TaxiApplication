using DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebClient.Controllers
{
    public class HomeController : Controller
    {
        ServiceReference1.WebServiceTaxiSoapClient Сlient;

        public ActionResult Index()
        {
            Сlient = new ServiceReference1.WebServiceTaxiSoapClient();


            var au = new Authorization()
            {
                Login = "111веб",
                Password = "222",
                Role = 2
            };

            var cust = new Customer()
            {
                FirstName = "Оля веб",
                LastName = "Петрова",
                Phone = "123123"
            };

            Сlient.RegistrateCustomer(Parser.ParseCustomer(cust), Parser.ParseAuth(au));

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}