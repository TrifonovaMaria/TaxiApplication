using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebClient.Controllers
{
    public class OrderController : Controller
    {
        public ServiceReference1.WebServiceTaxiSoapClient Client = new ServiceReference1.WebServiceTaxiSoapClient();
        // GET: Order
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult AllOrders(Guid id)
        {
            return View(Client.GetListOfOrders(id, 1));
        }

    }
}