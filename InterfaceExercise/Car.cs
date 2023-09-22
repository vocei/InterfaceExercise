using System;

namespace InterfaceExercise
{
    public class Car : IVehicle, ICompany
    {
        public Car()
        { }

        public double EngineSize { get; set; } = 5.5;
        public string Model { get; set; } = "Corvette";
        public string Make { get; set; } = "Sport";
        public int SeatNum { get; set; } = 4;
        public int WheelNum { get; set; } = 4;
        public string CompanyName { get; set; } = "Chevy";
        public string Motto { get; set; } = "Chevy Runs Deep";
        public bool HasChangedGears { get; set; }

        public void Drive()
        {
            Console.WriteLine($"{GetType().Name} is in drive!");
        }

        public void Park()
        {
            {
                if (HasChangedGears == true)
                {
                    Console.WriteLine($"{GetType().Name} now is parked!");
                    HasChangedGears = false;
                }
                else
                {
                    Console.WriteLine($"{GetType().Name} can not park until we change gears!");

                }

            }

        }

        public void Reverse()

        {
            if (HasChangedGears == true)
            {
                Console.WriteLine($"{GetType().Name} is now in reverse!");
                HasChangedGears = false;
            }
            else
            {
                Console.WriteLine($"{GetType().Name} can not reverse until we step on the break and change gears!");

            }

        }

        public void ChangeGears(bool isChanged)
        {
            HasChangedGears = isChanged;
        }
    }
}
