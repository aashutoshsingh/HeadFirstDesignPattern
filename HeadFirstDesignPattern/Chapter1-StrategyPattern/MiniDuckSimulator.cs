using System;
using System.Collections.Generic;
using System.Text;

namespace HeadFirstDesignPattern.Chapter1
{
    class MiniDuckSimulator
    {
        static void Main(string[] args)
        {
            Duck mallardDuck = new MallardDuck();
            mallardDuck.PerformFly();
            mallardDuck.PerformQuack();

            Duck modelDuck = new ModelDuck();
            modelDuck.PerformFly();
            modelDuck.SetFlyBehaviour(new FlyRocketPowered());
            modelDuck.PerformFly();

        }
    }
}
