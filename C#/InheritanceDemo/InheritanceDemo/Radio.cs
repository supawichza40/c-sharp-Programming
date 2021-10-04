using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    //all class in the same namespace and be call within the project.
    class Radio : ElectricalDevice
    {


        //this just mean that we pass the parameter from radio -> base(electricaldevice) constructor
        //And we do not to make another redundant code
        public Radio(bool isOn, string brand) : base(isOn, brand)
        { 
        
        }

        public void ListenRadio()
        {
            if (IsOn == true)
            {
                Console.WriteLine("Listening to the Radio!");
            }
            else
            {
                Console.WriteLine("Radio is switch off, switch it on first.");
            }
        }
    }
}
