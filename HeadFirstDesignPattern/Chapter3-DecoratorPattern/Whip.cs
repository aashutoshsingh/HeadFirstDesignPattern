using System;
using System.Collections.Generic;
using System.Text;

namespace HeadFirstDesignPattern.Chapter3_DecoratorPattern
{
    class Whip : CondimentDecorator
    {
        Beverage Beverage;

        public Whip(Beverage beverage)
        {
            Beverage = beverage;
        }

        public override string GetDescription()
        {
            return Beverage.GetDescription() + ", Whip";
        }

        public override double Cost()
        {
            return .30 + Beverage.Cost();
        }
    }
}
