using System;
using System.Collections.Generic;
using System.Text;

namespace HeadFirstDesignPattern.Chapter1
{
    class FlyWithWings : IFlyBehaviour
    {
        public void Fly()
        {
            Console.WriteLine("I'm flying with my wings");
        }
    }
}
