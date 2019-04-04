using System;
using System.Collections.Generic;
using System.Text;

namespace HeadFirstDesignPattern.Chapter9_IteratorAndCompositePattern
{
    class Menu : MenuComponent
    {
        public string Name { get; }
        public string Description { get; }
        List<MenuComponent> menuComponents = new List<MenuComponent>();

        public Menu(string name, string desc)
        {
            Name = name;
            Description = desc;            
        }       

        override public string GetName() => Name;
        override public string GetDescription() => Description;

        public override void Add(MenuComponent menuComponent)
        {
            menuComponents.Add(menuComponent);
        }

        public override void Remove(MenuComponent menuComponent)
        {
            menuComponents.Remove(menuComponent);
        }

        public override MenuComponent GetChild(int i)
        {
            return menuComponents.Count > i ? menuComponents[i] : null;
        }

        public override void Print()
        {
            Console.WriteLine(" " + Name);
            Console.WriteLine(", " + Description);
            Console.WriteLine("----------------------------------");

            var iterator = menuComponents.GetEnumerator();
            while(iterator.MoveNext())
            {
                var childMenu = iterator.Current;
                childMenu.Print();
            }
        }
    }
}
