using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdConsoleApp.OOP_Level3.day4
{
    public abstract class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }

        private double _salary;
        public double Salary {
            get
            {
                return _salary;
            }
            set
            {
                if(value>=0)
                _salary = value;
                else
                    Console.WriteLine("Salary cannot be negative.");
            }
        }

        public Employee(string name, int age, double salary)
        {
            Name = name;
            Age = age;
            Salary = salary;
        }

        public virtual string DisplayEmployeeDetails()
        {
            return $" Welcome Name: {Name}, Age: {Age}, Salary: {Salary}";
        }

        public abstract double CalculateAnnualSalary();
     

    }
}
