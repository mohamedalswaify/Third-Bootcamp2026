using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdConsoleApp.OOP_Level3.day6.accounts
{
    public class SavingsAccount : BankAccount
    {
        private double InterestRate;

        public double interest_rate
        {
            get
            {
                return InterestRate;
            }
            set
            {
                if (value >= 0)
                {
                    InterestRate = value;
                }
                else
                {
                    Console.WriteLine("invalied Rate");
                }
            }
        }
        public SavingsAccount(string account_number, string owner_name, double balance, double interest_rate)
            : base(account_number, owner_name, balance)
        {
            InterestRate = interest_rate;
        }

        public override string DisplayAccount()
        {
            return $"Account Number: {AccountNumber}, Owner Name: {OwnerName}, Balance: {Balance}, Interest Rate: {InterestRate}";
        }
        public double CalculateInterest()
        {

            return Balance * InterestRate / 100;
        }
    }
}
