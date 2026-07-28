using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdConsoleApp.OOP_Level3.day
{
    internal class Room_Test
    {

        static void Mainn()
        {



            //double width =3;
            //double length = 4;
            //double area =width * length;

            //Console.WriteLine(area);

            //double width1 = 3;
            //double length1 = 4;
            //double area1 = width1 * length1;

            //Console.WriteLine(area1);

            //double area =  Get_Area(3, 4);
            //Console.WriteLine(area);


            //double area2 = Get_Area(2, 6);
            //Console.WriteLine(area2);

            Room r1 = new Room(3,4);

            double area = r1.Get_Area();

            Console.WriteLine(r1.width);
            Console.WriteLine(r1.length);
            Console.WriteLine(area);


            Room r2 = new Room(3, 5);

            double area1 = r2.Get_Area();
            Console.WriteLine(area1);


            Console.ReadKey();
        }
        static double Get_Area(double width ,double length)
        {
            double area = width * length;
            return area;

        }

        //Employee 
        // P = Name ,salary 
        //M= Get_Annaul  salary * 12

        //Employee_Test
        //Main Function 
        // Create object From Employee


    }
}
