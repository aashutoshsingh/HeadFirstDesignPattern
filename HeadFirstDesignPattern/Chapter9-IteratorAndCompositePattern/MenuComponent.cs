using System;
using System.Collections.Generic;
using System.Text;

namespace HeadFirstDesignPattern.Chapter9_IteratorAndCompositePattern
{
    abstract class MenuComponent
    {
        virtual public void Add(MenuComponent menuComponent)
        {
            throw new NotSupportedException();
        }

        virtual public void Remove(MenuComponent menuComponent)
        {
            throw new NotSupportedException();
        }

        virtual public MenuComponent GetChild(int i)
        {
            throw new NotSupportedException();
        }

        virtual public string GetName()
        {
            throw new NotSupportedException();
        }

        virtual public string GetDescription()
        {
            throw new NotSupportedException();
        }

        virtual public double GetPrice()
        {
            throw new NotSupportedException();
        }

        virtual public bool IsVegeterian()
        {
            throw new NotSupportedException();
        }

        virtual public void Print()
        {
            throw new NotSupportedException();
        }        
    }
}
