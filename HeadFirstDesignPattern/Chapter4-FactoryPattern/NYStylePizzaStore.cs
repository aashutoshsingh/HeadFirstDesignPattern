using System;
using System.Collections.Generic;
using System.Text;

namespace HeadFirstDesignPattern.Chapter4_FactoryPattern
{
    class NYStylePizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            if (string.Compare(type, "Cheese", true) == 0)
                return new NYStylePizza();

            return null;
        }
    }
}
