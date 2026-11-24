using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee_Shop_Refactored
{
    internal class CoffeeShop
    {
        private readonly Menu menu;
        private readonly PaymentProcessor paymentProcessor;

        public CoffeeShop(Menu menu, PaymentProcessor paymentProcessor)
        {
            this.menu = menu;
            this.paymentProcessor = paymentProcessor;
        }

        public void ProcessOrder(string customerName, bool wantsCoffee, bool wantsSandwich)
        {
            double total = CalculateTotal(wantsCoffee, wantsSandwich);

            Console.WriteLine("Order processed for " + customerName);
            Console.WriteLine("Total amount to pay: " + total);
            paymentProcessor.ProcessPayment(total);
        }

        private double CalculateTotal(bool wantsCoffee, bool wantsSandwich)
        {
            double total = 0;
            if (wantsCoffee)
            {
                total += menu.GetCoffeePrice();
            }
            if (wantsSandwich)
            {
                total += menu.GetSandwichPrice();
            }
            return total;
        }

        public void UpdateMenu(double coffeePrice, double sandwichPrice)
        {
            menu.UpdatePrices(coffeePrice, sandwichPrice);
        }
    }


}
