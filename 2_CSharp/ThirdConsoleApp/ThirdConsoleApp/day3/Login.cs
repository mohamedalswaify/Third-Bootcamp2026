using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdConsoleApp.day3
{
    internal class Login
    {
        static void Mainn(string[] args)
        {

            Console.Write("Enter your username: ");
            string username = Console.ReadLine();


            Console.Write("Enter your password: ");
            string password = Console.ReadLine();


            if (username == "admin" && password == "1234")
            {
                Console.WriteLine("Login successful");
            }
            else
            {

                Console.WriteLine("Login failed");
            }

           
            Console.ReadKey();
        }
    }
}
