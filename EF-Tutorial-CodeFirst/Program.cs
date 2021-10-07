using SalesDbLib.Controllers;
using System;

namespace EF_Tutorial_CodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            var custCtrl = new CustomersController();
            var customers = custCtrl.GetAll();
        }
    }
}
