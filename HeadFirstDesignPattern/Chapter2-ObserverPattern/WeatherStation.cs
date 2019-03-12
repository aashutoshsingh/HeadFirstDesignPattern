using System;
using System.Collections.Generic;
using System.Text;

namespace HeadFirstDesignPattern.Chapter2_ObserverPattern
{
    class WeatherStation
    {
        public static void Main(string[] args)
        {
            WeatherData weatherData = new WeatherData();

            CurrentConditionsDisplay currentDisplay = new CurrentConditionsDisplay(weatherData);

            weatherData.SetMeasurements(23, 45, 67);
            weatherData.SetMeasurements(12.4f,23.2f,43.2f);
            weatherData.RemoveObserver(currentDisplay);
        }
    }
}
