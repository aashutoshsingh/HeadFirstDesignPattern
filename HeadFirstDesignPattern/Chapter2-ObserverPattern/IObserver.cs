using System;
using System.Collections.Generic;
using System.Text;

namespace HeadFirstDesignPattern.Chapter2_ObserverPattern
{
    interface IObserver
    {
        void Update(float temp, float humidity, float pressure);
    }
}
