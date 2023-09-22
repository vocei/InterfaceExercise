using System;

namespace InterfaceExercise
{
    public class Truck : IVehicle, ICompany
    {

        public Truck() { }
        public double EngineSize { get; set; } = 8.8;
        public string Model { get; set; } = "RAM";
        public string Make { get; set; } = "Truck";
        public int SeatNum { get; set; } = 4;
        public int WheelNum { get; set; } = 4;
        public string CompanyName { get; set; } = "RAM";
        public string Motto { get; set; } = "Guts. Glory. Ram.";
        public bool HasChangedGears { get; set; }
        public bool HasFourWheelDrive { get; set; } 


        public void Drive()
        {
            Console.WriteLine($"{GetType().Name} is in drive!");
        }

        public void FourDrive()
        {
            if (HasFourWheelDrive == true)
            {
                Console.WriteLine($"{GetType().Name} is in  4 wheel drive!");

            }
            else
            {
                Console.WriteLine($"{GetType().Name} is in drive!");
            }
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
