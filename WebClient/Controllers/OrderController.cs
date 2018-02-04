using DataModels;
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
        public ActionResult AllOrders(Guid driverId) //список всех заказов
        {
            
            return View(Client.GetListOfOrders(driverId, 1));
        }

        public ActionResult GetOrder(Guid driverId, Guid orderId) //взять заказ
        {
            Client.GetOrder(driverId, orderId);
            return View();
        }

        public ActionResult ShowOrder(Order order) //подробности о заказе
        {
            Client.ShowOrder(order.ID_Driver);
            return View();
        }

    }
}