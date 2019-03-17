using System;
using System.Collections.Generic;
using System.Text;

namespace HeadFirstDesignPattern.Chapter6_CommandPattern
{
    class SimpleRemoteControl
    {
        ICommand slot;

        public void SetCommand(ICommand command)
        {
            slot = command;
        }

        public void ButtonWasPressed()
        {
            slot.Execute();
        }
    }
}
