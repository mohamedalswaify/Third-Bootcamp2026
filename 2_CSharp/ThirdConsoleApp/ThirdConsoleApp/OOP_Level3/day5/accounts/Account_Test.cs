using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdConsoleApp.OOP_Level3.day5.accounts
{
    internal class Account_Test
    {
        static void Main()
        {
            //BankAccount b1 = new BankAccount("8347467", "Ahmed", 2000);
            SavingsAccount b2 = new SavingsAccount("87654333", "Mohammed", 8000, 2);
            CurrentAccount b3 = new CurrentAccount("4563728", "Khalied", 9000, 5000);

            //Console.WriteLine($"{b1.DisplayAccount()} Deposit: {b1.Deposit(2000)}");
            Console.WriteLine($"{b2.DisplayAccount()} Total Rate: {b2.CalculateInterest()}");
            Console.WriteLine($" {b3.DisplayAccount()} With Draw: {b3.Withdraw(3000)}");














            Console.ReadKey();
        }
    }
}
