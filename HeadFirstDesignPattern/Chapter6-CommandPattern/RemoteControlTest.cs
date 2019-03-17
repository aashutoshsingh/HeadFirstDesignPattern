using System;
using System.Collections.Generic;
using System.Text;

namespace HeadFirstDesignPattern.Chapter6_CommandPattern
{
    class RemoteControlTest
    {
        internal static void Main(string[] args)
        {
            SimpleRemoteControl remote = new SimpleRemoteControl();

            Light light = new Light();
            LightOnCommand lightOn = new LightOnCommand(light);

            GarageDoor garageDoor = new GarageDoor();
            GarageDoorOpenCommand openCommand = new GarageDoorOpenCommand(garageDoor);
                       

            remote.SetCommand(lightOn);
            remote.ButtonWasPressed();
            remote.SetCommand(openCommand);
            remote.ButtonWasPressed();

        }
    }
}
