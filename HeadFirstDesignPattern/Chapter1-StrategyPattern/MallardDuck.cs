using System;
using System.Collections.Generic;
using System.Text;

namespace HeadFirstDesignPattern.Chapter1
{
    class MallardDuck : Duck
    {
        public MallardDuck()
        {
            QuackBehaviour = new Quackk();
            FlyBehaviour = new FlyWithWings();
        }
        public override void Display()
        {
            Console.WriteLine("I'm a real mallard duck");
        }
    }
}
