using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdConsoleApp.OOP_Level3.day3
{
    public class EmployeeBase : Employee
    {

        public double Bouns {  get; set; }

        public EmployeeBase(string name, int age, double salary,double bouns) : base(name, age, salary)
        {

            Bouns = bouns;
        }


  
       
    }
}
