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
            /*var auth1 = Client.FindAuth(auth.ID);
            if (auth1 == null)
            {*/
            auth.Role = 1;
            DriverAuth driverAuth = new DriverAuth(auth, driver);

            if (Client.RegistrateDriver(Parser.ParseDriver(driverAuth.Driver), Parser.ParseAuth(driverAuth.Auth)) == false)
                ModelState.AddModelError("", "Данный логин уже занят");
            else
            {
                Client.RegistrateDriver(Parser.ParseDriver(driverAuth.Driver), Parser.ParseAuth(driverAuth.Auth));
                return RedirectToAction("Login");
            }
            return View();
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

        public ActionResult Edit(Guid driverId, Guid authId)
        {
            Driver driver = Parser.GetDriver(Client.FindDriver(driverId));
            Authorization auth = Parser.GetAuth(Client.FindAuth(authId));
            DriverAuth driverAuth = new DriverAuth(auth, driver);
            if (Client.EditDriverProfile(Parser.ParseAuth(auth), Parser.ParseDriver(driver)) == false)
                ModelState.AddModelError("", "Данный логин уже занят");
            else
            {
                Client.EditDriverProfile(Parser.ParseAuth(driverAuth.Auth), Parser.ParseDriver(driverAuth.Driver));
            }

            return View(driverAuth); 
        }
    }
}