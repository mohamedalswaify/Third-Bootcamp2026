using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdConsoleApp.OOP_Level3.day5.accounts
{
    public class CurrentAccount : BankAccount
    {
        private double OverdraftLimit;
        public double Overdraft_Limit
        {
            get
            {
                return OverdraftLimit;
            }
            set
            {
                if (value >= 0)
                {
                    OverdraftLimit = value;
                }
                else
                {
                    Console.WriteLine("invalied Limit");
                }
            }
        }
        public CurrentAccount(string account_number, string owner_name, double balance,
            double overdraft_limit)
            : base(account_number, owner_name, balance)
        {
            OverdraftLimit = overdraft_limit;
        }
        public override string DisplayAccount()
        {
            return $"Account Number: {AccountNumber}, Owner Name: {OwnerName}, Balance: {Balance}," +
                $" Over draft limit: {OverdraftLimit}";
        }
        public double Withdraw(double amount)
        {
            Balance -= amount;
            return Balance;
        }
    }
}
