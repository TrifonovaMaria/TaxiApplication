using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using DataAccess;
using DataModels;

/// <summary>
/// Сводное описание для WebServiceTaxi
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// Чтобы разрешить вызывать веб-службу из скрипта с помощью ASP.NET AJAX, раскомментируйте следующую строку. 
// [System.Web.Script.Services.ScriptService]
public class WebServiceTaxi : System.Web.Services.WebService
{

    public WebServiceTaxi()
    {

        //Раскомментируйте следующую строку в случае использования сконструированных компонентов 
        //InitializeComponent(); 
    }

    [WebMethod]
    public bool RegistrateDriver(string driver, string authorization) // Регистрация водителя
    {
        try
        {
            return Operation.RegistrateDriver(Parser.GetDriver(driver), Parser.GetAuth(authorization));
        }
        catch
        {
            return false;
        }
    }

    [WebMethod]
    public bool RegistrateCustomer(string customer, string authorization) // Регистрация клиента
    {
        try
        {
            return Operation.RegistrateCustomer(Parser.GetCustomer(customer), Parser.GetAuth(authorization));
        }
        catch
        {
            return false;
        }
    }

    [WebMethod]
    public Guid Authorize(string authorization) // Авторизация
    {
        return Operation.Authorize(Parser.GetAuth(authorization));
    }

    [WebMethod]
    public string GetListOfOrders(Guid idClient, int role) // Показать список заказов водителя или клиента
    {
        if (role == 1)
            return Parser.ParseListOrders(Operation.GetListOfOrdersForDriver(idClient));
        if (role == 2)
            return Parser.ParseListOrders(Operation.GetListOfOrdersForCustomer(idClient));
        return null;
    }

    [WebMethod]
    public void GetOrder(Guid idDriver, Guid idOrder)//Взять заказ водителю
    {
        Operation.GetOrder(idDriver, idOrder);
    }

    [WebMethod]
    public void CreateOrder(string order)//Создать заказ клиенту
    {
        Operation.CreateOrder(Parser.GetOrder(order));
    }

    [WebMethod]
    public string ShowOrder(Guid? idClient)// Подробный показ заказа
    {
        return Parser.ParseOrder(Operation.ShowOrder(idClient));
    }

    [WebMethod]
    public void CancellationOfOrder(Guid idClient, Guid idOrder) //Отказ от заказа
    {
        Operation.CancellationOfOrder(idClient, idOrder);
    }

    [WebMethod]
    public void StartTrip(Guid idDriver, Guid idOrder) //Начать поездку от водителя
    {
        Operation.StartTrip(idDriver, idOrder);
    }

    [WebMethod]
    public void FinishTrip(Guid idDriver, Guid idOrder) //Завуршить поездку от водителя
    {
        Operation.FinishTrip(idDriver, idOrder);
    }

    [WebMethod]
     public string GetDriverNumber(Guid idOrder) //Связаться с водителем
     {
         return Operation.GetDriverNumber(idOrder);
     }
 
     [WebMethod]
     public string FindCustomer(Guid idCustomer)// Найти заказчика по id
     {
         return Parser.ParseCustomer(Operation.FindCustomer(idCustomer));
     }
 
     [WebMethod]
     public string FindDriver(Guid idDriver)// Найти водителя по id
     {
         return Parser.ParseDriver(Operation.FindDriver(idDriver));
     }

    [WebMethod]
    public string FindDriverByAuth(Guid idAuth)// Найти водителя по id
    {
        return Parser.ParseDriver(Operation.FindDriverByAuth(idAuth));
    }

    [WebMethod]
     public string FindAuth(Guid id)// Найти авторизацию по id
     {
         return Parser.ParseAuth(Operation.FindAuth(id));
     }
 
     [WebMethod]
     public bool EditCustomerProfile(string auth, string customer) //Редактирование профиля заказчика
     {
         return Operation.EditCustomerProfile(Parser.GetAuth(auth), Parser.GetCustomer(customer));
     }
 
     [WebMethod]
     public bool EditDriverProfile(string auth, string driver) //Редактирование профиля водителя
     {
         return Operation.EditDriverProfile(Parser.GetAuth(auth), Parser.GetDriver(driver));
     }
}
