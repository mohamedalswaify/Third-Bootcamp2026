using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdConsoleApp.OOP_Level3.day
{
    internal class Student_Test
    {
        static void Mainn()
        {

            Student s1 = new Student("Ali", 35, 50);


            double pct = s1.Get_Pct();
            string grade = s1.Get_Grade(pct);
            Console.WriteLine(s1.Student_name);
            Console.WriteLine(s1.Mark);
            Console.WriteLine(s1.Full_mark);
            Console.WriteLine(pct);
            Console.WriteLine(grade);



            Console.ReadLine();
        }


    }
}
