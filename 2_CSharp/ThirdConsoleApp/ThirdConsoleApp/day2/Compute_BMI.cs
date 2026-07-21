using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdConsoleApp.day2
{
    internal class Compute_BMI
    {

        static void Mainn(string[] args)
        {
            //Compute_BMI
            //Enter Patient Name: Ali
            //Enter Patient Weight: 70
            //Enter Patient Height: 175
            //BMI = weight / (height * height) * 10000

            //Patient Name: Ali
            //Weight: 70
            //Height: 175
            //BMI: 22.86

            Console.Write("Enter Patient Name:");
            string patient_name = Console.ReadLine();

            Console.Write("Enter Patient Weight:");
            double weight = double.Parse(Console.ReadLine());

            Console.Write("Enter Patient Height:");
            double height = double.Parse(Console.ReadLine());


            double BMI = weight / (height * height) * 10000;

            Console.WriteLine("==========================");
            Console.WriteLine("Patient Name:" +patient_name);
            Console.WriteLine("Weight:" + weight);
            Console.WriteLine("Height:" + height);
            Console.WriteLine("BMI:" + BMI);






            Console.ReadKey(true);
        }


    }
}
