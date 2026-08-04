using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdConsoleApp.OOP_Level3.day5.accounts
{
    public abstract class BankAccount
    {
        public string AccountNumber;
        public string OwnerName;
        private double _Balance;

        public double Balance
        {
            get
            {
                return _Balance;
            }
            set
            {
                if (value >= 0)
                {
                    _Balance = value;
                }
                else
                {
                    Console.WriteLine("Invalied balance");
                }
            }
                
        }
        public BankAccount(string account_number, string owner_name, double balance)
        {
            AccountNumber = account_number;
            OwnerName = owner_name;
            Balance = balance;
        }
        public abstract string DisplayAccount();

        public double Deposit(double amount)
        {
            Balance += amount;
            return Balance; ;
        }
    }
}
