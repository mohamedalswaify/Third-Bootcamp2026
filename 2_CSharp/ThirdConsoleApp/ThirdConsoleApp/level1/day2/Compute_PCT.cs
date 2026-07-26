using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdConsoleApp.day2
{
    internal class Compute_PCT
    {

        static void Mainn(string[] args)
        {
            //Compute_PCT
            //student_name ="Ali";
            //mark= 30
            //full_mark= 50
            //pct = (mark / full_mark) * 100
            //Ali 30 50 70 %
                Console.Write("Enter your name:");
                string student_name = Console.ReadLine();

            Console.Write("Enter your mark:");
            double mark = double.Parse(Console.ReadLine());

            Console.Write("Enter your full mark:");
            int full_mark = int.Parse(Console.ReadLine());

            double pct = (mark / full_mark) * 100;
            Console.WriteLine("==========================");
            Console.WriteLine( "Student Name:" +student_name);
            Console.WriteLine("Mark:" + mark);
            Console.WriteLine("FullMark:" + full_mark);
            Console.WriteLine ("Your PCT:" + pct + "%");

        //pct >=85  Excellent
        //pct >=50  Pass
        //pct <50   Fail
        //pct >=65  Good
        //pct >=75  Very Good


            if(pct >= 85)
            {
                Console.WriteLine("Excellent");
            }

            else if(pct >= 75)
            {
                Console.WriteLine("Very Good");
            }

            else if (pct >= 65)
            {
                Console.WriteLine("Good");
            }
            else if (pct >= 50)
            {
                Console.WriteLine("Pass");
            }

            else
            {
                Console.WriteLine("Fail");
            }






            Console.ReadKey(true);
        }

    }
}
