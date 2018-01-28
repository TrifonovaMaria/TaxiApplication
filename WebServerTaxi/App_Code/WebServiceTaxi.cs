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
            Operation.RegistrateDriver(Parser.GetDriver(driver), Parser.GetAuth(authorization));
            return true;
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
            Operation.RegistrateCustomer(Parser.GetCustomer(customer), Parser.GetAuth(authorization));
            return true;
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
    public string ShowOrder(Guid idClient)// Подробный показ заказа
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

}
