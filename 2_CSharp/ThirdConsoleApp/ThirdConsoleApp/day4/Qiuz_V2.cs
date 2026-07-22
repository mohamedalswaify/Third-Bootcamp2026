using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdConsoleApp.day4
{
    internal class Qiuz_V2
    {

        static void Mainn()
        {


            for (int i = 1; i <= 10; i++)
            {


                Random rand = new Random();

                int num1 = rand.Next(1, 11);
                int num2 = rand.Next(1, 11);
                Console.WriteLine($"{i}.What is {num1} * {num2} ?");
                int answer = Convert.ToInt32(Console.ReadLine());

                if (answer == num1 * num2)
                {
                    Console.WriteLine("Correct");
                }
                else
                {
                    Console.WriteLine("Incorrect");
                }

            }



            Console.ReadKey();
        }
    }
}
