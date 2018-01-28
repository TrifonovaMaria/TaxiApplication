using DataModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public static class Operation
    {
        private static ModelsTaxi db = new ModelsTaxi();
        public static void RegistrateDriver(Driver driver, Authorization authorization)
        {
            driver.ID = authorization.ID = Guid.NewGuid();
            db.Driver.Add(driver);
            db.Authorization.Add(authorization);
            db.SaveChanges();
        }

        public static void RegistrateCustomer(Customer customer, Authorization authorization)
        {
            try
            {
                customer.ID = Guid.NewGuid();
                customer.ID_Auth = authorization.ID = Guid.NewGuid();
                db.Authorization.Add(authorization);
                db.Customer.Add(customer);
                db.SaveChanges();
            }
            catch(System.Exception e)
            {
                var s = e.Message;
            }
        }

        public static Guid Authorize(Authorization authorization)
        {
            var user = db.Authorization
                .FirstOrDefault(au => au.Login == authorization.Login
                && au.Password == authorization.Password);
            if (user != null)
                return user.ID;
            return Guid.Empty;
        }

        public static List<Order> GetListOfOrdersForCustomer(Guid idCustomer)//История заказов заказчика
        {
            List<Order> orders = new List<Order>();
            orders = db.Order
                .Where(o => o.ID_Customer == idCustomer)
                .ToList();
            return orders;
        }

        public static List<Order> GetListOfOrdersForDriver(Guid idDriver)//Список доступных заказов для водителя
        {
            Driver driver = db.Driver.FirstOrDefault(d => d.ID == idDriver);

            List<Order> orders = new List<Order>();
            orders = db.Order
                .Where(o => o.ID_Driver == null
                && o.CarClass == driver.CarClass).ToList();
            return orders;
        }

        public static void GetOrder(Guid idDriver, Guid idOrder)//Взять заказ водителю
        {
            Driver driver = db.Driver.FirstOrDefault(d => d.ID == idDriver);
            Order order = db.Order.FirstOrDefault(o => o.ID == idOrder);
            order.ID_Driver = idDriver;
            order.Status = "2";
            db.Entry(order).State = EntityState.Modified;
            db.SaveChanges();
        }

        public static void CreateOrder(Order order)//Создать заказ клиенту
        {
            order.Status = "1";
            db.Order.Add(order);
            db.SaveChanges();
        }

        public static Order ShowOrder(Guid idClient)// Подробный показ заказа
        {
            Authorization client = db.Authorization.FirstOrDefault(cl => cl.ID == idClient);
            if (client.Role == 2) //customer
                return db.Order.FirstOrDefault(o => o.ID_Customer == idClient 
                && o.Status != "3"//Отмененный
                && o.Status != "5");//Законченный
            if (client.Role == 1) //driver
                return db.Order.FirstOrDefault(o => o.ID_Customer == idClient
                && o.Status == "2"//Текущий
                && o.Status == "4");//Начатый
            return null;
        }

        public static void CancellationOfOrder(Guid idClient, Guid idOrder) //Отказ от заказа
        {
            Authorization client = db.Authorization.FirstOrDefault(cl => cl.ID == idClient);
            Order order = db.Order.FirstOrDefault(o => o.ID == idOrder);
            if (order.Status == "1" || order.Status == "2")
            {
                if (client.Role == 2) //customer
                {
                    order.Status = "3";
                    db.Entry(order).State = EntityState.Modified;
                    db.SaveChanges();
                }
                if (client.Role == 1) //driver
                {
                    order.Status = "1";
                    db.Entry(order).State = EntityState.Modified;
                    db.SaveChanges();
                }
            }
        }

        public static void StartTrip(Guid idDriver, Guid idOrder) //Начать поездку от водителя
        {
            Driver driver = db.Driver.FirstOrDefault(cl => cl.ID == idDriver);
            Order order = db.Order.FirstOrDefault(o => o.ID == idOrder);
            if (order.Status == "3")
            {
                order.Status = "4";
                db.Entry(order).State = EntityState.Modified;
                db.SaveChanges();
            }
        }

        public static void FinishTrip(Guid idDriver, Guid idOrder) //Завуршить поездку от водителя
        {
            Driver driver = db.Driver.FirstOrDefault(cl => cl.ID == idDriver);
            Order order = db.Order.FirstOrDefault(o => o.ID == idOrder);
            if (order.Status == "4")
            {
                order.Status = "5";
                db.Entry(order).State = EntityState.Modified;
                db.SaveChanges();
            }
        }
    }
}
