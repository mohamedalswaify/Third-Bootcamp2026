using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdConsoleApp.OOP_Level3.day5.cars
{
    public class Drone : IVehicle
    {
        public string Model { get; set; }

        public Drone(string model)
        {
            Model = model;
        }

        public string DisplayDetails()
        {
            return $"Drone Model: {Model}";
        }
    }
}
