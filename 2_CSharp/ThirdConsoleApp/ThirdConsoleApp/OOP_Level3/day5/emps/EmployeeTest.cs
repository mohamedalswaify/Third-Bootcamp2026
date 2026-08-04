using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdConsoleApp.OOP_Level3.day5
{
    internal class EmployeeTest
    {
        static void Mainn()
        {
            //  Employee e1 = new Employee("John", 30, 1000);
            //EmployeeBase e2 = new EmployeeBase("Ali", 28, 1000, 500);
            //EmployeeHour e3 = new EmployeeHour("Sara", 25, 1000, 10,60);

            //Console.WriteLine($"{e1.DisplayEmployeeDetails()} Annual Salary: {e1.CalculateAnnualSalary()} SR");
            //Console.WriteLine($"{e2.DisplayEmployeeDetails()} Annual Salary: {e2.CalculateAnnualSalary()} SR");
            //Console.WriteLine($"{e3.DisplayEmployeeDetails()} Annual Salary: {e3.CalculateAnnualSalary()} SR");


            Employee[] employees =
                { new EmployeeBase("Ali", 28, 1000, 500),
                 new EmployeeHour("Sara", 25, 1000, 10,60),
                 new EmployeeBase("Ahmed", 30, 1500, 300),
                 new EmployeeHour("John", 35, 2000, 20,80)

                };


            foreach (var employee in employees)
            {
                Console.WriteLine($"{employee.DisplayEmployeeDetails()}, {employee.CalculateAnnualSalary()} ");

            }


                Console.ReadKey();
            }
        }
    }

