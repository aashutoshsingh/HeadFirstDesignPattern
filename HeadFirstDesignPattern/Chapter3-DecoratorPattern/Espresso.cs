using System;
using System.Collections.Generic;
using System.Text;

namespace HeadFirstDesignPattern.Chapter3_DecoratorPattern
{
    class Espresso : Beverage
    {
        public Espresso()
        {
            Description = "Espresso";
        }

        public override double Cost()
        {
            return 1.99;
        }
    }
}
