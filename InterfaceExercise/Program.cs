using System;
using System.Collections.Generic;
using System.Xml;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var car = new Car();
            var truck = new Truck();
            var suv = new SUV();

            var vehicles = new List<IVehicle>() { car, truck, suv};

           
            foreach (var whip in vehicles) 
            {
                whip.Drive();
                whip.ChangeGears(true);
                whip.Reverse();
                whip.ChangeGears(false);
                whip.Park();
                
            }

            


        }
    }
}
