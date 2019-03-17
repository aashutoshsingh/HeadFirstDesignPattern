namespace HeadFirstDesignPattern.Chapter6_CommandPattern
{
    internal class Light
    {
        public Light()
        {

        }

        public void On()
        {
            System.Console.WriteLine("Light is on");
        }

        public void Off()
        {
            System.Console.WriteLine("Light is off");
        }
    }
}