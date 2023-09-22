using System;

namespace InterfaceExercise
{
    public class SUV : IVehicle, ICompany
    {

        public SUV() { }
        public double EngineSize { get; set; } = 7.8;
        public string Model { get; set; } = "GNC";
        public string Make { get; set; } = "SUV";
        public int SeatNum { get; set; } = 8;
        public int WheelNum { get; set; } = 4;
        public string CompanyName { get; set; } = "GNC";
        public string Motto { get; set; } = "Live Well.";
        public bool HasChangedGears { get; set; }
        public bool HasFourWheelDrive { get; set; } = true;

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
