using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdConsoleApp.OOP_Level3.day6.Animals
{
    public class Dog : Animal
    {
        public string Breed { get; set; }
        public Dog(string name, int age, string color, string breed) : base(name, age, color)
        {
            Breed = breed;
        }
        public override string DisplayInfo()
        {
            return base.DisplayInfo() + $" , Breed: {Breed}";
        }

        public  string DisplayInfo(string name)
        {
            return base.DisplayInfo() + $" , Breed: {Breed} and my name is {name}";

        }
        public string Bark()
        {
            return ("I am Class Dog");
        }

       
        public string Bark( string name)
        {
            return ($"I am Class Dog and my name is {name}");


        }

    }
}
