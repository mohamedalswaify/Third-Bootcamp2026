using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdConsoleApp.OOP_Level3.day
{
    public class Student
    {
        public string Student_name;
        private double _Mark;

        public double Mark
        {
            get
            {
                return _Mark;
            }
            set
            {
                if (value >= 0)
                {
                    _Mark = value;
                }
                else
                {
                    Console.WriteLine("Invalid Mark");
                }
            }
        }




        private int _Full_mark;
        public int Full_mark
        {
            get
            {
                return _Full_mark;
            }
            set
            {
                if (value >= 0)
                {
                    _Full_mark = value;
                }
                else
                {
                    Console.WriteLine("Invalid Full_mark");
                }
            }
        }


        public Student(string student_name,double mark, int full_mark)
        {
            Student_name = student_name;
            Mark = mark;
            Full_mark = full_mark;
        }

        //public double get_Full_mark()
        //{
        //    return Full_mark;
        //}

        //public void set_Full_mark(int full_mark)
        //{
        //    if (full_mark >= 0)
        //    {
        //        Full_mark = full_mark;
        //    }
        //    else
        //    {
        //        Console.WriteLine("Invalid Full_mark");
        //    }

        //}


        //public double get_Mark()
        //{
        //    return Mark;
        //}

        //public void set_Mark(double mark)
        //{
        //    if (mark >= 0)
        //    {
        //        Mark = mark;
        //    }
        //    else
        //    {
        //        Console.WriteLine("Invalid Mark");
        //    }

        //}




        public double Get_Pct() {

            double pct = (_Mark / _Full_mark) * 100;
            return pct;
        }


        public string Get_Grade(double pct) {

            if (pct >= 85)
            {
               return("Excellent");
            }

            else if (pct >= 75)
            {
                return ("Very Good");
            }

            else if (pct >= 65)
            {
                return ("Good");
            }
            else if (pct >= 50)
            {
                return ("Pass");
            }

            else
            {
                return ("Fail");
            }


        }


    }
}
