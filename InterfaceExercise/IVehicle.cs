﻿namespace InterfaceExercise
{
    public interface IVehicle 

    {
        public double EngineSize { get; set; }
        public string Model { get; set; }
        public string Make { get; set; }
        public int SeatNum { get; set; }
        public int WheelNum { get; set; }
        public bool HasChangedGears { get; set; }


        public void Drive();
        public void Reverse();
        public void Park();
        public void ChangeGears(bool isChanged);


    }
}
