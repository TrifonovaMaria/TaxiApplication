using DataModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    // Add comments here
    public static class Operation
    {
        private static ModelsTaxi db = new ModelsTaxi();

        public static bool RegistrateDriver(Driver driver, Authorization authorization)
        {
            if (db.Authorization.Count(a => a.Login == authorization.Login) != 0)
                return false;
            driver.ID =  Guid.NewGuid();
            driver.ID_Auth = authorization.ID = Guid.NewGuid();
            db.Authorization.Add(authorization);
            db.Driver.Add(driver);
            db.SaveChanges();
            return true;
        }


        public static bool RegistrateCustomer(Customer customer, Authorization authorization)

        {
            try
            {
                if (db.Authorization.Count(a => a.Login == authorization.Login) != 0)
                    return false;
                customer.ID = Guid.NewGuid();
                customer.ID_Auth = authorization.ID = Guid.NewGuid();
                db.Authorization.Add(authorization);
                db.Customer.Add(customer);
                db.SaveChanges();
                return true;
            }
            catch(System.Exception e)
            {
                var s = e.Message;
                return false;
            }
        }

        public static Guid Authorize(Authorization authorization)
        {
            var user = db.Authorization
                .FirstOrDefault(au => au.Login == authorization.Login
                && au.Password == authorization.Password);
            if (user != null)
            {
                var cl = db.Customer.FirstOrDefault(i => i.ID_Auth == user.ID);
                if (cl == null)
                {
                    var cll = db.Driver.FirstOrDefault(i => i.ID_Auth == user.ID);
                    return cll.ID;
                }
                else
                return cl.ID;
              }
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

        public static Order ShowOrder(Guid? idClient)// Подробный показ заказа
        {
            int r = 0;
            var cl = db.Customer.FirstOrDefault(i => i.ID == idClient);
            if (cl == null)
            {
                var cll = db.Driver.FirstOrDefault(i => i.ID == idClient);
                r = 1;
            }
            else
                r = 2; 
            //Authorization client = db.Authorization.FirstOrDefault(c => c.ID == cl.ID_Auth);
            if (r == 2) //customer
                return db.Order.FirstOrDefault(o => o.ID_Customer == idClient
                && o.Status != "3"//Отмененный
                && o.Status != "5");//Законченный
            if (r == 1) //driver
                return db.Order.FirstOrDefault(o => o.ID_Driver == idClient
                && o.Status == "2"//Текущий
                && o.Status == "4");//Начатый
            return null;
        }

        public static void CancellationOfOrder(Guid idClient, Guid idOrder) //Отказ от заказа
        {
            int r = 0;
            var cl = db.Customer.FirstOrDefault(i => i.ID == idClient);
            if (cl == null)
            {
                var cll = db.Driver.FirstOrDefault(i => i.ID == idClient);
                r = 1;
             }
            else
                r = 2;
            Order order = db.Order.FirstOrDefault(o => o.ID == idOrder);
            if (order.Status == "1" || order.Status == "2")
            {
                if (r == 2) //customer
                {
                    order.Status = "3";
                    db.Entry(order).State = EntityState.Modified;
                    db.SaveChanges();
                }
                if (r == 1) //driver
                {
                    order.Status = "1";
                    db.Entry(order).State = EntityState.Modified;
                    db.SaveChanges();
                }
            }
        }

        public static string GetDriverNumber(Guid idOrder)// Связаться с водителем
         {
            Order order = db.Order.FirstOrDefault(o => o.ID == idOrder);
            if (order.ID_Driver == null)
                 return null;
             Driver driver = db.Driver.FirstOrDefault(d => d.ID == order.ID_Driver);
             return driver.Phone;
         }
 
         public static Customer FindCustomer(Guid idCustomer)// Найти заказчика по id
         {
             return db.Customer.FirstOrDefault(c => c.ID == idCustomer);
         }
 
         public static Driver FindDriver(Guid idDriver)// Найти водителя по id
         {
             return db.Driver.FirstOrDefault(c => c.ID == idDriver);
         }

        public static Driver FindDriverByAuth(Guid idAuth)// Найти водителя по id авторизации
        {
            return db.Driver.FirstOrDefault(c => c.ID_Auth == idAuth);
        }

        public static Authorization FindAuth(Guid id)// Найти авторизацию по id
         {
             return db.Authorization.FirstOrDefault(a => a.ID == id);
         }
 
         public static bool EditCustomerProfile(Authorization auth, Customer customer) //Редактирование профиля заказчика
         {
             if (db.Authorization.Count(a => a.Login == auth.Login) != 0)
                 return false;
             db.Entry(auth).State = EntityState.Modified;
             db.Entry(customer).State = EntityState.Modified;
             db.SaveChanges();
             return true;
         }
 
         public static bool EditDriverProfile(Authorization auth, Driver driver) //Редактирование профиля водителя
         {
             if (db.Authorization.Count(a => a.Login == auth.Login) != 0)
                 return false;
             db.Entry(auth).State = EntityState.Modified;
             db.Entry(driver).State = EntityState.Modified;
             db.SaveChanges();
            return true;
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

        public static void FinishTrip(Guid idDriver, Guid idOrder) //Завершить поездку от водителя
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
