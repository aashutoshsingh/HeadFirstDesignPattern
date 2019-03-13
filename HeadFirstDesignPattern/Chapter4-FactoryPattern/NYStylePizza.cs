using System;
using System.Collections.Generic;
using System.Text;

namespace HeadFirstDesignPattern.Chapter4_FactoryPattern
{
    class NYStylePizza : Pizza
    {
        public NYStylePizza()
        {
            Name = "NY style sauce and cheese pizza";
            Dough = "Thin crust dough";
            Sauce = "Marinara sauce";

            Toppings.Add("Grated Reggiano Cheese");

        }
    }
}
