using System;
using System.Collections.Generic;
using System.Text;

namespace HeadFirstDesignPattern.Chapter1
{
    class FlyNoWay : IFlyBehaviour
    {
        public void Fly()
        {
            Console.WriteLine("I cannot fly :(");
        }
    }
}
