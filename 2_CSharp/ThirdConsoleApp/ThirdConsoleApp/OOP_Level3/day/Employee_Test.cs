using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdConsoleApp.OOP_Level3.day
{
    internal class Employee_Test
    {

        //Patient  Pstient_Test
        static void Mainn()
        {

            Employee e1 = new Employee("Mohamed",1200);

            double annual = e1.Get_Annaul();
            string level = e1.Get_Level(annual);

                Console.WriteLine(e1.Name);
                Console.WriteLine(e1.Salary);
                Console.WriteLine(annual);
                Console.WriteLine(level);


            Console.ReadKey();
        }

        //Student     //Student_Test
    }
}
