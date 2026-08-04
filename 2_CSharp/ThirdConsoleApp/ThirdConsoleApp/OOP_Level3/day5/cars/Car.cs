using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdConsoleApp.OOP_Level3.day5.cars
{
    public class Car : Vehicle
    {
        private int _number_ofDoors;
        public int Number_Of_Doors
        {
            get
            {
                return _number_ofDoors;
            }
            set
            {
                if (value >= 0)
                {
                    _number_ofDoors = value;
                }
                else
                {
                    Console.WriteLine("invalied number of door");
                }
            }
        }
        public Car(string brand, string model, double price, int number_of_doors) : base(brand, model, price)
        {

            Number_Of_Doors = number_of_doors;
        }
        public override string DisplayDetails()
        {
            return base.DisplayDetails() + $" Number Of Doors: {Number_Of_Doors}";
        }

        public string StartEngine()
        {
            return ("Car Engine Started");
        }
    }
}
