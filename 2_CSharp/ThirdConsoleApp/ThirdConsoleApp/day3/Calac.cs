using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdConsoleApp.day3
{
    internal class Calac
    {

        static void Mainn()
        {
            //Calc 
            //Enter first number: 5
            //Enter second number: 10
            //Enter operation (+, -, *, /): +

            //Result: 15


            Console.Write("Enter first number: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");

            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter operation (1.+, 2.-, 3.*, 4./):");
            string operation = Console.ReadLine();
            if(operation=="+")
            {
                double sum = num1 + num2;
                Console.WriteLine("Sum: " + sum);

            }
            else if (operation == "-")
            {

                double difference = num1 - num2;
                Console.WriteLine("Difference: " + difference);
            }
            else if (operation == "*")
            {
                double product = num1 * num2;
                Console.WriteLine("Product: " + product);

            }
            else if (operation == "/")
            {
                double quotient = num1 / num2;

                Console.WriteLine("Quotient: " + quotient);
            }
            else
            {
                Console.WriteLine("Invalid operation");
            }


           

            





            Console.ReadKey();
        }
    }
}
