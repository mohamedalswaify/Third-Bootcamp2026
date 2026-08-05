using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdConsoleApp.OOP_Level3.day6.accounts
{
    internal class Wallet : IAccount
    {
        public string Phone { get; set; }

        public Wallet(string phone)
        {
            Phone = phone;
        }

        public string DisplayAccount()
        {
            return $"Wallet Phone: {Phone}";
        }
    }
}
