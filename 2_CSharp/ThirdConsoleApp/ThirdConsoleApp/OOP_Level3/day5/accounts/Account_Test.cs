using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdConsoleApp.OOP_Level3.day5.accounts
{
    internal class Account_Test
    {
        static void Mainn()
        {
            //BankAccount b1 = new BankAccount("8347467", "Ahmed", 2000);
            //SavingsAccount b2 = new SavingsAccount("87654333", "Mohammed", 8000, 2);
            //CurrentAccount b3 = new CurrentAccount("4563728", "Khalied", 9000, 5000);

            //Console.WriteLine($"{b1.DisplayAccount()} Deposit: {b1.Deposit(2000)}");
            //Console.WriteLine($"{b2.DisplayAccount()} Total Rate: {b2.CalculateInterest()}");
            //Console.WriteLine($" {b3.DisplayAccount()} With Draw: {b3.Withdraw(3000)}");



            BankAccount[] accounts =
                { new SavingsAccount("87654333", "Mohammed", 8000, 2),
                  new CurrentAccount("4563728", "Khalied", 9000, 5000),
                  new SavingsAccount("1234567", "Ali", 10000, 3),
                  new CurrentAccount("9876543", "Sara", 7000, 3000)
                };


            foreach (var account in accounts)
            {
                Console.WriteLine($"{account.DisplayAccount()}");
            if(account is SavingsAccount savingsAccount)
                {
                    Console.WriteLine($"Total Rate: {savingsAccount.CalculateInterest()}");
                }
                else if (account is CurrentAccount currentAccount)
                {
                    Console.WriteLine($"With Draw: {currentAccount.Withdraw(3000)}");
                }

            }

            //Interface IAccount
            //method DisplayAccount() 

            //Class BankAccount implements IAccount

            //Class Wallet : IAccount
            //Felids:   Phone
            //method DisplayAccount()

            //Acoount_Test
            //Create an array of IAccount with 2 BankAccount and 2 Wallet







            Console.ReadKey();
        }
    }
}
