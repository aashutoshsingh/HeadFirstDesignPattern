using System;
using System.Collections.Generic;
using System.Text;

namespace HeadFirstDesignPattern.Chapter9_IteratorAndCompositePattern
{
    class MenuItem : MenuComponent
    {
        public MenuItem(string name, string desc, bool veg, double price)
        {
            Name = name;
            Description = desc;
            Vegetarian = veg;
            Price = price;
        }

        public string Name { get;}
        public string Description { get; }
        public bool Vegetarian { get; }
        public double Price { get; }

        override public string GetName() => Name;
        override public string GetDescription() => Description;
        override public bool IsVegeterian() => Vegetarian;
        override public double GetPrice() => Price;

        public override void Print()
        {
            Console.WriteLine(" " + Name);
            if(Vegetarian)
                Console.Write("(V)");
            Console.WriteLine(", " + Price);
            Console.WriteLine("    -- " + Description);
        }
    }
}
