using System;
using System.Collections.Generic;
using System.Text;

namespace HeadFirstDesignPattern.Chapter9_IteratorAndCompositePattern
{
    class Waitress
    {
        MenuComponent MenuComponent;

        public Waitress(MenuComponent menuComponent)
        {
            MenuComponent = menuComponent;
        }

        public void PrintMenu()
        {
            MenuComponent.Print();
        }
    }
}
