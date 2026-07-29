using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdConsoleApp.OOP_Level3.day2
{
    internal class Patient_test
    {
        static void Mainn()
        {
            Patient pat = new Patient("Rayan", 90, 166);

           // pat.Name = "";
            double BMI = pat.Get_BMI();
            string status = pat.Get_Status(BMI);


            Console.WriteLine(pat.Name);
            Console.WriteLine(pat.get_Weight());
            Console.WriteLine(pat.get_Height());
            Console.WriteLine(BMI);
            Console.WriteLine(status);

            Console.ReadKey();
        }
        }
    }

