using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdConsoleApp.OOP_Level3.day6.Animals
{
    public class Bird : IAnimal
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public bool CanFly { get; set; }

        public Bird(string name, string color, bool canFly)
        {
            Name = name;
            Color = color;
            CanFly = canFly;
        }

        public string MakeSound()
        {
            return "Chirp chirp";
        }

        public string DisplayInfo()
        {
            return $"Bird: {Name}, Color: {Color}, Can Fly: {CanFly}";
        }
    }
}
