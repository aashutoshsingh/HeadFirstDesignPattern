using System;
using System.Collections.Generic;
using System.Text;

namespace HeadFirstDesignPattern.Chapter6_CommandPattern
{
    class GarageDoorOpenCommand : ICommand
    {
        GarageDoor GarageDoor = new GarageDoor();

        public GarageDoorOpenCommand(GarageDoor garageDoor)
        {
            GarageDoor = garageDoor;
        }

        public void Execute()
        {
            GarageDoor.Open();
        }
    }
}
