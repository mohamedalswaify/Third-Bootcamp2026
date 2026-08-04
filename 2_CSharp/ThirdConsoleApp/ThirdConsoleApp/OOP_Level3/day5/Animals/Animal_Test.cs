using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdConsoleApp.OOP_Level3.day5.Animals
{
    internal class Animal_Test
    {
        static void Main()
        {
            //Animal a1 = new Animal("Monkey", 8, "White");
            Dog d2 = new Dog("dog", 6, "Black", "Husky");
            Cat c3 = new Cat("cat", 5, "Yellow", "yes");

            Console.WriteLine($"{d2.DisplayInfo()}, {d2.Bark()}");
            Console.WriteLine($"{c3.DisplayInfo()}, {c3.Meow()}");




            Console.ReadKey();


        }
    }
}
