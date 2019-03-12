using System;
using System.Collections.Generic;
using System.Text;

namespace HeadFirstDesignPattern.Chapter1
{
    class MuteQuack : IQuackBehaviour
    {
        public void Quack()
        {
            Console.WriteLine("Silence.......");
        }
    }
}
