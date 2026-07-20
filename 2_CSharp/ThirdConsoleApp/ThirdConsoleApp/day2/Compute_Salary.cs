using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdConsoleApp.day2
{
    internal class Compute_Salary
    {

        static void Mainn(string[] args)
        {
            //Input and Storage
            Console.Write("Enter your name:");
            string name = Console.ReadLine() ;

            Console.Write("Enter your salary:");
            double salary = double.Parse(Console.ReadLine()); 

            //Processing
            double annual = salary * 12;

            //Output
            Console.WriteLine(name);
            Console.WriteLine(salary);
            Console.WriteLine(annual);



            if(annual>12000)
            {
                Console.WriteLine("High Salary");
            }
            else if(annual>6000)
            {
                Console.WriteLine("Normal Salary");
            }

            else if (annual > 3000)
            {
                Console.WriteLine("Low Salary");
            }


            else
            {
                Console.WriteLine("Very Low Salary");
            }


            Console.ReadKey(true);
        }
    }
}
