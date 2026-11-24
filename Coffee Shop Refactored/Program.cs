using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee_Shop_Refactored
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu(200, 350);
            PaymentProcessor paymentProcessor = new PaymentProcessor();
            CoffeeShop shop = new CoffeeShop(menu, paymentProcessor);

            shop.ProcessOrder("Ali", true, true);    
            shop.UpdateMenu(250, 400);               
            shop.ProcessOrder("Sara", true, false);  
        }
    }
}
