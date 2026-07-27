using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ThirdConsoleApp.level2.day2.Functions_With_Prams
{
    internal class Fun
    {

        //----------------------Void and Return Functions----------------------
        public void Compute_PCT(string student_name, double mark, int full_mark)
        {
            double pct = (mark / full_mark) * 100;
            Console.WriteLine("==========================");
            Console.WriteLine("Student Name:" + student_name);
            Console.WriteLine("Mark:" + mark);
            Console.WriteLine("FullMark:" + full_mark);
            Console.WriteLine("Your PCT:" + pct + "%");
        }

        public void Compute_BMI(string patient_name, double weight, double height)
        {

            double BMI = weight / (height * height) * 10000;

            Console.WriteLine("==========================");
            Console.WriteLine("Patient Name:" + patient_name);
            Console.WriteLine("Weight:" + weight);
            Console.WriteLine("Height:" + height);
            Console.WriteLine("BMI:" + BMI);
        }

     

        public void Sum(int num1 ,int num2)
        {
            int res = num1 + num2;
            Console.WriteLine(res);
        }



        public int Sum2(int num1, int num2)
        {
            int res = num1 + num2;
            return(res);
        }


        public void Compute_salary2(string name, double salary)
        {
            double annual = salary * 12;
            Console.WriteLine(name);
            Console.WriteLine(salary);
            Console.WriteLine(annual);
        }

        public double Compute_salary3(string name, double salary)
        {
            double annual = salary * 12;
            return (annual);
        }

        public double Compute_PCT2(string student_name, double mark, int full_mark)
        {
            double pct = (mark / full_mark) * 100;
            return pct;
           
        }


        public double Compute_BMI2(string patient_name, double weight, double height)
        {

            double BMI = weight / (height * height) * 10000;
            return BMI;
            
        }

        public List<object> Compute_salary4(string name, double salary)
        {
            double annual = salary * 12;
            List<object> list = new List<object>(); 
            list.Add(name);
            list.Add(salary);
            list.Add(annual);

            return (list);
        }

        public List<object> Compute_PCT3(string student_name, double mark, int full_mark)
        {
            double pct = (mark / full_mark) * 100;
            string Grade = "";
            if (pct >= 85)
            {
                Grade=("Excellent");
            }

            else if (pct >= 75)
            {
                Grade = ("Very Good");
            }

            else if (pct >= 65)
            {
                Grade = ("Good");
            }
            else if (pct >= 50)
            {
                Grade = ("Pass");
            }

            else
            {
                Grade = ("Fail");
            }

            List<object> list = new List<object>();
            list.Add(student_name);
            list.Add(mark);
            list.Add(full_mark);
            list.Add(pct);
            list.Add(Grade);
            return (list);

        }

        public List<object> Compute_BMI3(string patient_name, double weight, double height)
        {

            double BMI = weight / (height * height) * 10000;
            string status = "";
            if (BMI >= 30)
            {
                status = ("Obese");
            }
            else if (BMI >= 25)
            {
                status = ("Overweight");
            }
            else if (BMI >= 18)
            {
                status = ("Normal Weight");
            }
            else
            {
                status = ("Underweight");
            }



            List<object> list = new List<object>();
            list.Add(patient_name);
            list.Add(weight);
            list.Add(height);
            list.Add(BMI);
            list.Add(status);
            return (list);

        }

    }
}
