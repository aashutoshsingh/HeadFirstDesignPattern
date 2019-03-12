using System;
using System.Collections.Generic;
using System.Text;

namespace HeadFirstDesignPattern.Chapter2_ObserverPattern
{
    interface ISubject
    {
        void RegisterObserver(IObserver o);
        void RemoveObserver(IObserver o);
        void NotifyObserver();
    }
}
