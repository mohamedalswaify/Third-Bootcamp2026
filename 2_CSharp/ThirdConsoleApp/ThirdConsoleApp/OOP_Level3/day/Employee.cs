using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdConsoleApp.OOP_Level3.day
{
    public class Employee
    {
        //Employee 
        // P = Name ,salary 
        //M= Get_Annaul  salary * 12

        //Employee_Test
        //Main Function 
        // Create object From Employee


        public string Name;
        public double Salary;

        //ctor
        public Employee(string name ,double salary)
        {
            Name = name;
            Salary = salary;
            
        }


        public double Get_Annaul()
        {
            double annaul = Salary * 12;
            return annaul;

        }


        public string Get_Level(double annual)
        {
            if (annual > 12000)
            {return("High Salary");
            }
            else if (annual > 6000)
            {
                return ("Normal Salary");
            }

            else if (annual > 3000)
            {
                return ("Low Salary");
            }

            else
            {
                return ("Very Low Salary");
            }

        }


    }
}
