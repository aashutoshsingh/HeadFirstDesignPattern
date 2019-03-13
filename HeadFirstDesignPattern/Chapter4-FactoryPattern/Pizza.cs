using System.Collections;
using System.Collections.Generic;

namespace HeadFirstDesignPattern.Chapter4_FactoryPattern
{
    internal abstract class Pizza
    {
        protected string Name;
        protected string Dough;
        protected string Sauce;

        protected List<string> Toppings = new List<string>();

        public void Prepare()
        {
            System.Console.WriteLine($"Preparing {Name}");
            System.Console.WriteLine($"Tossing dough....");
            System.Console.WriteLine($"Adding sauce...");
            System.Console.WriteLine($"Adding toppings");
            Toppings.ForEach(x => System.Console.WriteLine($"   {x}"));
        }

        public void Bake()
        {
            System.Console.WriteLine($"Bake for 25 mins at 350");
        }

        public void Cut()
        {
            System.Console.WriteLine($"Cutting pizza into diagnol slices");
        }

        public void Box()
        {
            System.Console.WriteLine($"Place pizza in official pizza store box");
        }

        public string GetName()
        {
            return Name;
        }
        
    }
}