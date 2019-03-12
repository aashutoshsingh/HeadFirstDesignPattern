using System;
using System.Collections.Generic;
using System.Text;

namespace HeadFirstDesignPattern.Chapter3_DecoratorPattern
{
    abstract class Beverage
    {
        protected string Description = "Unknown Description";

        public virtual string GetDescription()
        {
            return Description;            
        }

        public abstract double Cost();
    }
}
