using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OOPPractice
{
    public class Car : IVehicle,ICar2,Icar3
    {

        public new void Print()
        {
            base.Print();
            Console.WriteLine(Name + " " + VehicleId + "-contractor");

        }

        public void ChasisNo()
        {
            Console.WriteLine("43543k5h3kh523492");
        }

        public void Sound(string message)
        {
            Console.WriteLine($"Sound: {message}"); 

        }

        public void anything(string message)
        {
            Console.WriteLine(message);    
        }
    }
}
