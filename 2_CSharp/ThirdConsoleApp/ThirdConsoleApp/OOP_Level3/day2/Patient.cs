using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdConsoleApp.OOP_Level3.day2
{
    public class Patient
    {
        public string Name {  get;  set; }

        private double _weight;
        public double Weight {
            get
            {
                return _weight;
            }

            set
            {
                if (value >= 0)
                {
                    _weight = value;
                }
                else
                {
                    Console.WriteLine("Invalid Weight");
                }
            }
        }


        private double _height;
        public double Height {
            get
            {
                return _height;
            } 
            set
            {
                if (value >= 0)
                {
                    _height = value;
                }
                else
                {
                    Console.WriteLine("Invalid Height");
                }
            }
        }


        
          
        public Patient(string name, double weight, double height)
        {
            Name = name;
            Weight = weight;
            Height = height;
            //set_Weight(weight);
            //set_Height(height);
        }

        //public double get_Weight()
        //{
        //    return Weight;
        //}

        //public void set_Weight(double weight)
        //{
        //    if (weight >= 0 )
        //    {
        //        Weight = weight;
        //    }
        //    else
        //    {
        //        Console.WriteLine("Invalid Weight");
        //    }

        //}
        //public double get_Height()
        //{
        //    return Height;
        //}

        //public void set_Height(double height)
        //{
        //    if (height >= 0)
        //    {
        //        Height = height;
        //    }
        //    else
        //    {
        //        Console.WriteLine("Invalid Height");
        //    }

        //}



        public double Get_BMI()
        {
            double BMI = _weight / (_height * _height) * 10000;
            return BMI;
        }

        public string Get_Status(double BMI)
        {
            if (BMI >= 30)
            {
                return "Obese";
            }
            else if (BMI >= 25)
            {
                return "Overweight";
            }
            else if (BMI >= 18)
            {
                return "Normal Weight";
            }
            else
            {
                return "Underweight";
            }
        }
    }
}
