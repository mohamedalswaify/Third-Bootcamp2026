using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdConsoleApp.day3
{
    internal class Check_day_v2
    {
        static void Mainn(string[] args)
        {
            //Check_day_v2
            //Enter Your Day: 1
            //1 Workday
            //2 Workday
            //3 Workday
            //4 Workday
            //5 Workday
            //6 Weekend
            //7 Weekend
            //Invalid day



            Console.Write("Enter Your Day: ");
            int day = Convert.ToInt32(Console.ReadLine());

            if (day >= 1 && day<=5   )
            {
                Console.WriteLine("Workday");
            }
            else if (day == 6 || day == 7)
            {
                Console.WriteLine("Weekend");
            }
            else
            {
                Console.WriteLine("Invalid day");
            }
        }
    }
}
