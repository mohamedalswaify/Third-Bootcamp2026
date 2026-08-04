using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdConsoleApp.OOP_Level3.day5.emps
{
    public class Freelancer : IEmployee
    {
        public string Name { get; set; }
        public double ProjectPrice { get; set; }

        public Freelancer(string name,double projectPrice)
        {
            Name = name;
            ProjectPrice = projectPrice;

        }

        public string DisplayEmployeeDetails()
        {
           return $" Freelancer Name: {Name}, ProjectPrice: {ProjectPrice}";
        }

        public double CalculateAnnualSalary()
        {
            return ProjectPrice * 12;
        }
    }
}
