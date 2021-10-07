using SalesDbLib.Controllers;
using System;
using System.Threading.Tasks;

namespace EF_Tutorial_CodeFirst
{
    class Program
    {
        async static Task Main(string[] args)
        {
            var custCtrl = new CustomersController();
            var customers = await custCtrl.GetAll();
            customers.ForEach(c => Console.WriteLine(c.Name));

            var orderCtrl = new OrdersController();
            var orders = await orderCtrl.GetAll();
            orders.ForEach(o => Console.WriteLine($"{o.Description} | {o.Total} | {o.Customer.Name}"));
        }
    }
}
