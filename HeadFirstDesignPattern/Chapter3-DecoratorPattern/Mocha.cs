using System;
using System.Collections.Generic;
using System.Text;

namespace HeadFirstDesignPattern.Chapter3_DecoratorPattern
{
    class Mocha : CondimentDecorator
    {
        Beverage Beverage;

        public Mocha(Beverage beverage)
        {
            Beverage = beverage;            
        }

        public override string GetDescription()
        {
            return Beverage.GetDescription() + ", Mocha";
        }

        public override double Cost()
        {
            return .20 + Beverage.Cost();
        }
    }
}
