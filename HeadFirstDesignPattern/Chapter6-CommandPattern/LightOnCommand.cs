using System;
using System.Collections.Generic;
using System.Text;

namespace HeadFirstDesignPattern.Chapter6_CommandPattern
{
    class LightOnCommand : ICommand
    {
        Light Light = new Light();

        public LightOnCommand(Light light)
        {
            Light = light;
        }

        public void Execute()
        {
            Light.On();
        }
    }
}
