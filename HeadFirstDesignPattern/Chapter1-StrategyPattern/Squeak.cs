using System;
using System.Collections.Generic;
using System.Text;

namespace HeadFirstDesignPattern.Chapter1
{
    class Squeak : IQuackBehaviour
    {
        public void Quack()
        {
            Console.WriteLine("Squeak");
        }
    }
}
