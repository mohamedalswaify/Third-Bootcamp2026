using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdConsoleApp.day3
{
    internal class Check_day
    {
        static void Mainn(string[] args)
        {
            //Enter Your Day: 1
            //1 Sunday
            //2 Monday
            //3 Tuesday
            //4 Wednesday
            //5 Thursday
            //6 Friday
            //7 Saturday
            //Invalid day

            Console.Write("Enter Your Day: ");
            int day = Convert.ToInt32(Console.ReadLine());

            if (day == 1)
            {
                Console.WriteLine("Sunday");
            }
            else if (day == 2)
            {
                Console.WriteLine("Monday");
            }
            else if (day == 3)
            {
                Console.WriteLine("Tuesday");
            }
            else if (day == 4)
            {
                Console.WriteLine("Wednesday");
            }
            else if (day == 5)
            {
                Console.WriteLine("Thursday");
            }
            else if (day == 6)
            {
                Console.WriteLine("Friday");
            }
            else if (day == 7)
            {
                Console.WriteLine("Saturday");
            }
            else
            {
                Console.WriteLine("Invalid day");
            }
        }
    }
}
