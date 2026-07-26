using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdConsoleApp.level2.day1.Functions_With_Prams
{
    internal class Calling_Functions
    {

        static void Main()
        {

            Functions functions = new Functions();

          //  functions.Compute_salary();



            //-------------------Compute Salary-----------
            //Input and Storage
            Console.Write("Enter your name:");
            string name = Console.ReadLine();

            Console.Write("Enter your salary:");
            double salary = double.Parse(Console.ReadLine());

            functions.Compute_salary2(name,salary);
            //------------------------------------------



            //-------------------Compute PCT-----------


            //------------------------------------------


            Console.ReadKey();
        }


    }
}
