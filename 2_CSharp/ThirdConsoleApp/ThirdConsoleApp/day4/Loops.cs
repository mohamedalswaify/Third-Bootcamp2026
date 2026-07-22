using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdConsoleApp.day4
{
    internal class Loops
    {

        static void Mainn()
        {
         


            //for loop
            //for (int x= 1;x<=10;x+=1)
            //{
            //    Console.WriteLine(x);
            //   // Console.WriteLine("Hello");

            //}


            //for (int x = 100; x >= 10; x -= 10)
            //{
            //    Console.WriteLine(x);
            //}

            //int x = 100;
            //while (x >= 10)
            //{
            //    Console.WriteLine(x);
            //    x -= 10;
            //}


            int x = 100;
            do
            {
                Console.WriteLine(x);

                x -= 10;
            } while (x >= 10);







            Console.ReadKey();
        }

    }
}
