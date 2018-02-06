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
            List<Order> orders = Parser.GetListOrders(Client.GetListOfOrders(driverId, 1));
            if (orders != null)
            {
                List<OrderDriver> ordersDriver = new List<OrderDriver>();
                for (int i = 0; i < orders.Count; i++)
                {
                    ordersDriver.Add(new OrderDriver(orders[i], Parser.GetDriver(Client.FindDriver(driverId))));
                }
                return View(ordersDriver);
            }
            else return View(orders);
        }

        /*public ActionResult GetOrder(Guid driverId, Guid orderId) //взять заказ
        {
            OrderDriver orderDriver = new OrderDriver(Parser.GetOrder(Client.FindOrder(orderId)), Parser.GetDriver(Client.FindDriver(driverId)));
            Client.GetOrder(orderDriver.Driver.ID, orderDriver.Order.ID);
            //Order orderToDo = Parser.GetOrder(Client.FindOrder(orderId));
            return RedirectToAction("ShowOrder", new { order = orderDriver.Order }); 
        }*/

        /*public ActionResult ShowOrder(Guid idOrder, Guid idDriver)
        {
            Order order = Parser.GetOrder(Client.FindOrder(idOrder));
            Driver driver = Parser.GetDriver(Client.FindDriver(idDriver));
            OrderDriver orderDriver = new OrderDriver(order, driver);
            return View(orderDriver);
        }*/

       // [HttpPost]
        public ActionResult ShowOrder(Guid orderId, Guid driverId, string act) //подробности о заказе
        {
            Client = new ServiceReference1.WebServiceTaxiSoapClient();
            if (act == "ShowOrder")
            {
                Client.GetOrder(driverId, orderId);
                Order order = Parser.GetOrder(Client.FindOrder(orderId));
                Driver driver = Parser.GetDriver(Client.FindDriver(driverId));
                OrderDriver orderDriver = new OrderDriver(order, driver);
                //Client.GetOrder(orderDriver.Driver.ID, orderDriver.Order.ID);
                //Order order = Client.ShowOrder(orderDriver.Order.ID_Driver);
                //return View(orderDriver);               
                return View(orderDriver);
            }
            if (act == "StartTrip")
            {
                Client.StartTrip(driverId, orderId);
                Order order = Parser.GetOrder(Client.FindOrder(orderId));
                Driver driver = Parser.GetDriver(Client.FindDriver(driverId));
                OrderDriver orderDriver = new OrderDriver(order, driver);
                return View(orderDriver);
            }
            if (act == "FinishTrip")
            {
                Client.FinishTrip(driverId, orderId);
                Order order = Parser.GetOrder(Client.FindOrder(orderId));
                Driver driver = Parser.GetDriver(Client.FindDriver(driverId));
                OrderDriver orderDriver = new OrderDriver(order, driver);
                return View(orderDriver);
            }
            if (act == "Update")
            {
                Order order = Parser.GetOrder(Client.FindOrder(orderId));
                Driver driver = Parser.GetDriver(Client.FindDriver(driverId));
                OrderDriver orderDriver = new OrderDriver(order, driver);
                if (orderDriver.Order.Status == "3")
                {
                    //order1 = null;
                    return View(orderDriver);
                }
            }
            return View();
        }

        public ActionResult CancelOrder(Guid orderId, Guid driverId)
        {
            Client.GetOrder(driverId, orderId);
            Order order = Parser.GetOrder(Client.FindOrder(orderId));
            Driver driver = Parser.GetDriver(Client.FindDriver(driverId));
            OrderDriver orderDriver = new OrderDriver(order, driver);
            Client.CancellationOfOrder(orderDriver.Driver.ID, orderDriver.Order.ID);
            return View(orderDriver);
        }

        /*[HttpGet]
        public PartialViewResult GetCancelPartial(OrderDriver orderDriver)
        {
            Client.CancellationOfOrder(orderDriver.Driver.ID, orderDriver.Order.ID);
            return PartialView("Cancel", orderDriver);
        }*/

        public OrderDriver StartTrip(Guid orderId, Guid driverId)
        {
            
            Client.StartTrip(driverId, orderId);
            Order order = Parser.GetOrder(Client.FindOrder(orderId));
            Driver driver = Parser.GetDriver(Client.FindDriver(driverId));
            OrderDriver orderDriver = new OrderDriver(order, driver);
            //return View(orderDriver);
            return orderDriver;
        }

        public OrderDriver FinishTrip(Guid orderId, Guid driverId)
        {
            Client.FinishTrip(driverId, orderId);
            Order order = Parser.GetOrder(Client.FindOrder(orderId));
            Driver driver = Parser.GetDriver(Client.FindDriver(driverId));
            OrderDriver orderDriver = new OrderDriver(order, driver);
            //return View(orderDriver);
            return orderDriver;
        }
    }
}