using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdConsoleApp.day3
{
    internal class Compute_BMI_V2
    {

        static void Mainn(string[] args)
        {

            Console.WriteLine("Enter your name: ");
             string name = Console.ReadLine();

            Console.WriteLine("Enter your weight in kilograms: ");
            double weight = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter your height in meters: ");
            double height = Convert.ToDouble(Console.ReadLine());

            double bmi = weight / (height * height)*10000;

            Console.WriteLine("Patient Name: " + name);
            Console.WriteLine("Your weight is: " + weight + " kg");
            Console.WriteLine("Your height is: " + height + " m");
            Console.WriteLine("Your BMI is:" +bmi);


            //BMI>=30  Obese
            //BMI>=18   <=25  Normal Weight
            //BMI<18  Underweight
            //BMI>=25  <=30  Overweight


            //>=30  Obese
            //>=25  Over weight
            //>=18 Normal Weight
            //<18 Underweight


            if (bmi >= 30)
            {
                Console.WriteLine("Obese");
            }
            else if (bmi >= 25 )
            {
                Console.WriteLine("Overweight");
            }
            else if (bmi >= 18)
            {
                Console.WriteLine("Normal Weight");
            }
            else
            {
                Console.WriteLine("Underweight");
            }















            Console.ReadKey(true);

        }
    }
}
