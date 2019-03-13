using System;
using System.Collections.Generic;
using System.Text;

namespace HeadFirstDesignPattern.Chapter4_FactoryPattern
{
    abstract class PizzaStore
    {
        Pizza pizza;

        public Pizza OrderPizza(string type)
        {
            pizza = CreatePizza(type);

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            return pizza;
        }

        protected abstract Pizza CreatePizza(string type);
    }
}
