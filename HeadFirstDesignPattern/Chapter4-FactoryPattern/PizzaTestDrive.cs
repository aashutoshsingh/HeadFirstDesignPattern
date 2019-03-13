using System;
using System.Collections.Generic;
using System.Text;

namespace HeadFirstDesignPattern.Chapter4_FactoryPattern
{
    class PizzaTestDrive
    {
        internal static void Main(string[] args)
        {
            PizzaStore nyPizzaStore = new NYStylePizzaStore();

            Pizza pizza = nyPizzaStore.OrderPizza("cheese");
        }
    }
}
