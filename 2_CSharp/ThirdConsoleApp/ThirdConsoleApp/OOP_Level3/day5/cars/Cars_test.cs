using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdConsoleApp.OOP_Level3.day5.cars
{
    internal class Cars_test
    {
        static void Main()
        {

            //Vehicle v1 = new Vehicle("Ferrari", "2025", 200000);
            Car c2 = new Car("Toyota", "2026", 100000, 4);
            Motorcycle m3 = new Motorcycle("bmw", "2026", 5000, "Yes");



            Console.WriteLine( $" {c2.DisplayDetails()} ,{c2.StartEngine()}");
            Console.WriteLine($" {m3.DisplayDetails()} ,{m3.DoWheelie()}");




            Console.ReadKey();
        }
    }
}
