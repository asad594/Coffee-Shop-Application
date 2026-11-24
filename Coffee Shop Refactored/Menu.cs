using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee_Shop_Refactored
{
    internal class Menu
    {
        private double coffeePrice;
        private double sandwichPrice;

        public Menu(double coffeePrice, double sandwichPrice)
        {
            this.coffeePrice = coffeePrice;
            this.sandwichPrice = sandwichPrice;
        }

        public double GetCoffeePrice()
        {
            return coffeePrice;
        }

        public double GetSandwichPrice()
        {
            return sandwichPrice;
        }

        public void UpdatePrices(double coffeePrice, double sandwichPrice)
        {
            this.coffeePrice = coffeePrice;
            this.sandwichPrice = sandwichPrice;
        }
    }
}
