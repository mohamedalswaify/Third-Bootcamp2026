using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdConsoleApp.OOP_Level3.day
{
    public class Room
    {
        public double width;

        public double length;

        //ctor

        public Room( double w ,double l)
        {
            width = w;
            length = l;
            
        }

        public double Get_Area()
        {
            double area = width * length;
            return area;
        }

    }
}
