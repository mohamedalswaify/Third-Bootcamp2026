using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdConsoleApp.level2.day1.task
{
    internal class Methods
    {

        public   static void Helllo()
        {
            Console.WriteLine("Welcome Mohamed Alswaify!");

        }
        public  void Sum()
        {
            Console.WriteLine(5 + 6);

        }

        public  void Compute_salary()
        {
            //Input and Storage
            Console.Write("Enter your name:");
            string name = Console.ReadLine();

            Console.Write("Enter your salary:");
            double salary = double.Parse(Console.ReadLine());

            //Processing
            double annual = salary * 12;

            //Output
            Console.WriteLine(name);
            Console.WriteLine(salary);
            Console.WriteLine(annual);



            if (annual > 12000)
            {
                Console.WriteLine("High Salary");
            }
            else if (annual > 6000)
            {
                Console.WriteLine("Normal Salary");
            }

            else if (annual > 3000)
            {
                Console.WriteLine("Low Salary");
            }


            else
            {
                Console.WriteLine("Very Low Salary");
            }


        }

        public static void Compute_PCT()
        {
            Console.Write("Enter your name:");
            string student_name = Console.ReadLine();

            Console.Write("Enter your mark:");
            double mark = double.Parse(Console.ReadLine());

            Console.Write("Enter your full mark:");
            int full_mark = int.Parse(Console.ReadLine());

            double pct = (mark / full_mark) * 100;
            Console.WriteLine("==========================");
            Console.WriteLine("Student Name:" + student_name);
            Console.WriteLine("Mark:" + mark);
            Console.WriteLine("FullMark:" + full_mark);
            Console.WriteLine("Your PCT:" + pct + "%");

            //pct >=85  Excellent
            //pct >=50  Pass
            //pct <50   Fail
            //pct >=65  Good
            //pct >=75  Very Good


            if (pct >= 85)
            {
                Console.WriteLine("Excellent");
            }

            else if (pct >= 75)
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




        }

        public static void Compute_BMI()
        {
            Console.Write("Enter Patient Name:");
            string patient_name = Console.ReadLine();

            Console.Write("Enter Patient Weight:");
            double weight = double.Parse(Console.ReadLine());

            Console.Write("Enter Patient Height:");
            double height = double.Parse(Console.ReadLine());


            double BMI = weight / (height * height) * 10000;

            Console.WriteLine("==========================");
            Console.WriteLine("Patient Name:" + patient_name);
            Console.WriteLine("Weight:" + weight);
            Console.WriteLine("Height:" + height);
            Console.WriteLine("BMI:" + BMI);


        }

    }
}
