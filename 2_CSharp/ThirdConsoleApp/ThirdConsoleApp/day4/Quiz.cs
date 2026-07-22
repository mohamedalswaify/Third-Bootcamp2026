using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdConsoleApp.day4
{
    internal class Quiz
    {

        static void Mainn()
        {
            //What is 5 * 6 ?
            //30
            //print Correct or Incorrect

            Random rand = new Random();

            int num1 = rand.Next(1,11);
            int num2 = rand.Next(1, 11);
            Console.WriteLine($"What is {num1} * {num2} ?");
            int answer = Convert.ToInt32(Console.ReadLine());

            if (answer == num1* num2)
            {
                Console.WriteLine("Correct");
            }
            else
            {
                Console.WriteLine("Incorrect");
            }

            Console.ReadKey();

        }
    }
}
