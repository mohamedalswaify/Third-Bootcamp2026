using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdConsoleApp.level2.day1
{
    internal class Task_Compute_Pct
    {
        static void Mainn()
        {

            List<string> names = new List<string>();
            List<double> pcts = new List<double>();

            for (int i = 1; i <= 3; i++) 
            {
                Console.Write("Enter your name:");
                string student_name = Console.ReadLine();

                Console.Write("Enter your mark:");
                double mark = double.Parse(Console.ReadLine());

                Console.Write("Enter your full mark:");
                int full_mark = int.Parse(Console.ReadLine());

                double pct = (mark / full_mark) * 100;

                names.Add(student_name);
                pcts.Add(pct);

                Console.WriteLine("==========================");
            }



            for (int i = 0; i < names.Count; i++)
            {
                Console.WriteLine($"Student name: {names[i]} and Pct: {pcts[i]}");
            }






            Console.ReadKey();
        }



    }
}
