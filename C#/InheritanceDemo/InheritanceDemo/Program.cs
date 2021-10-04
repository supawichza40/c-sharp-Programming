using System;

namespace InheritanceDemo
{
    class Program
    {
        //Inheritance allow the reuse of code with your or other people code
        static void Main(string[] args)
        {
            Radio myRadio = new Radio(false, "Sony");
            TV myTV = new TV(false, "Samsung");

            myRadio.SwitchOn();
            myTV.SwitchOn();

            myRadio.ListenRadio();
            myTV.WatchTV();
        }
    }
}
