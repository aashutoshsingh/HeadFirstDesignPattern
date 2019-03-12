using System;
using System.Collections.Generic;
using System.Text;

namespace HeadFirstDesignPattern.Chapter1
{
    public abstract class Duck
    {
        protected IFlyBehaviour FlyBehaviour;
        protected IQuackBehaviour QuackBehaviour;

        public void SetFlyBehaviour(IFlyBehaviour flyBehaviour)
        {
            FlyBehaviour = flyBehaviour;
        }

        public void SetQuackBehaviour(IQuackBehaviour quackBehaviour)
        {
            QuackBehaviour = quackBehaviour;
        }
        public Duck()
        {

        }

        public abstract void Display();
        public void PerformFly()
        {
            FlyBehaviour.Fly();
        }

        public void PerformQuack()
        {
            QuackBehaviour.Quack();
        }
    }
}
