using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdConsoleApp.day4
{
    internal class List
    {
        static void Main()
        {

            //int[] numbers= { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            

            //for(int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(numbers[i]);

            //}


            //foreach (int item in numbers)
            //{ 
            //    Console.WriteLine(item);

            //}



            //string[] names = { "John", "Jane", "Bob", "Alice" };

            //foreach (string name in names)
            //{
            //    Console.WriteLine(name);
            //}

         

            //int[] numbers2 = new int[5];


            //numbers2[0] = 10;
            //numbers2[1] = 20;
            //numbers2[2] = 30;
            //numbers2[4] = 40;

            //foreach (int item in numbers2)
            //{
            //    Console.WriteLine(item);
            //}

            List<int> numbers3 = new List<int>();
            numbers3[0] = 5;

            numbers3.Add(10);
            numbers3.Add(20);
            numbers3.Add(30);
            numbers3.Add(40);

            foreach (int item in numbers3)
            {
                Console.WriteLine(item);
            }





            Console.ReadKey();
        }
    }
}
