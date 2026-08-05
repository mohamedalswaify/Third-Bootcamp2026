using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdConsoleApp.OOP_Level3.day6.Animals
{
    internal class Animal_Test
    {
        static void Mainn()
        {
            //Animal a1 = new Animal("Monkey", 8, "White");
            //Dog d2 = new Dog("dog", 6, "Black", "Husky");
            //Cat c3 = new Cat("cat", 5, "Yellow", "yes");

            //Console.WriteLine($"{d2.DisplayInfo()}, {d2.Bark()}");
            //Console.WriteLine($"{c3.DisplayInfo()}, {c3.Meow()}");

            IAnimal[] animals =
                { new Dog("dog", 6, "Black", "Husky"),
                  new Cat("cat", 5, "Yellow", "yes"),
                  new Dog("dog", 4, "Brown", "Labrador"),
                  new Cat("cat", 3, "White", "no"),
                  new Fish("fish", "Gold", true),
                  new Bird("bird", "Blue", true)

                };

            foreach (var animal in animals)
            {
                Console.WriteLine($"{animal.DisplayInfo()}");
                if (animal is Dog dog)
                {
                    Console.WriteLine(dog.Bark());
                }
                else if (animal is Cat cat)
                {
                    Console.WriteLine(cat.Meow());
                }
            }

                Console.ReadKey();

            // Interface IAnimal
            //method MakeSound(),DisplayInfo()

            //Class Fish  : IAnimal
            //Feilds: Name,Color,IsFreshWater
            //method DisplayInfo() , MakeSound()

            //Class Bird  : IAnimal
            //Feilds: Name,Color,CanFly
            //method DisplayInfo() , MakeSound()

            //Test Class Animal_Test
            //Create object and add  IAnimal with Fish and Bird objects inside the array of IAnimal and call the methods


        }
    }
}
