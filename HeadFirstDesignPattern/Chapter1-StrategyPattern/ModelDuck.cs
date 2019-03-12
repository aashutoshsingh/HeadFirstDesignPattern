using System;
using System.Collections.Generic;
using System.Text;

namespace HeadFirstDesignPattern.Chapter1
{
    class ModelDuck : Duck
    {
        public ModelDuck()
        {
            FlyBehaviour = new FlyNoWay();
            QuackBehaviour = new Quackk();
        }
        public override void Display()
        {
            Console.WriteLine("I'm a model duck");
        }
    }
}
