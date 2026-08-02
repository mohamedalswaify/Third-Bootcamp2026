using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdConsoleApp.OOP_Level3.day3
{
    internal class EmployeeTest
    {
        static void Main()
        {
            Employee e1 = new Employee("John", 30, 5000);
            EmployeeBase e2 = new EmployeeBase("Ali", 28, 6000, 500);
            EmployeeHour e3 = new EmployeeHour("Sara", 25, 1000, 10,50);



            Console.WriteLine($"{e1.DisplayEmployeeDetails()} Annual Salary: {e1.CalculateAnnualSalary()} SR");
            Console.WriteLine($"{e2.DisplayEmployeeDetails()} Annual Salary: {e2.CalculateAnnualSalary()} SR");
            Console.WriteLine($"{e3.DisplayEmployeeDetails()} Annual Salary: {e3.CalculateAnnualSalary()} SR");

         
            Console.ReadKey();
        }
    }
}
