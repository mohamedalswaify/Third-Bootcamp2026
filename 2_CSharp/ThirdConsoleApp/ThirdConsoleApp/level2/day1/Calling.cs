using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThirdConsoleApp.level2.day1.task;

namespace ThirdConsoleApp.level2.day1
{
    internal class Calling
    {

        static void Mainn()
        {
            //object
          
            Methods methods = new Methods();

           

            Console.WriteLine("Choose System:");
            Console.WriteLine("1.System Welcome");
            Console.WriteLine("2.System Calc:");
            Console.WriteLine("3.System Employee");
            Console.WriteLine("4.System Student");
            Console.WriteLine("5.System Patient");
            Console.Write("Anwser:");
            int answer = int.Parse(Console.ReadLine());

            if (answer == 1)
            {
                Methods.Helllo();
            }
            else if (answer == 2)
            {
                methods.Sum();
            }
            else if (answer == 3)
            {

                methods. Compute_salary();
            }
            else if (answer == 4)
            {
                Methods.Compute_PCT();
            }
            else if (answer == 5)
            {
                Methods.Compute_BMI();
            }
            else
            {
                Console.WriteLine("Invalid System");

            }



            Console.ReadKey();
        }


       

    }
}
