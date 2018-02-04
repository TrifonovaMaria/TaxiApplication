using DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebClient.Controllers
{
    public class AuthorizationController : Controller
    {
        public ServiceReference1.WebServiceTaxiSoapClient Client = new ServiceReference1.WebServiceTaxiSoapClient();
        // GET: Authorization
        public ActionResult Index()
        {           
            return View();
        }

        public ActionResult Register()
        {
            var driver = new Driver();
            var auth = new Authorization();
            return View();
        }

        [HttpPost]
        public ActionResult Register(Driver driver, Authorization auth)
        {
            /*auth.Login = "masha";
            auth.Password = "111";
            auth.Role = 1;
            driver.Authorization = auth;*/
            auth.Role = 1;
            DriverAuth driverAuth = new DriverAuth(auth, driver);
            Client.RegistrateDriver(Parser.ParseDriver(driverAuth.Driver), Parser.ParseAuth(driverAuth.Auth));
            return RedirectToAction("Login"); 
        }

        public ActionResult Login()
        {
            //var auth = new Authorization();
            return View();
        }
        [HttpPost]
        public ActionResult Login(Authorization auth)
        {
            Guid id = Client.Authorize(Parser.ParseAuth(auth));
            if (id != Guid.Empty)
            {
                //Driver driver = Parser.GetDriver(Client.FindDriverByAuth(id));
                return RedirectToAction("AllOrders", "Order", new { driverId = id });
            }
            else
                ModelState.AddModelError("", "Неправильно введен логин и/или пароль");
            return View();
        }
    }
}