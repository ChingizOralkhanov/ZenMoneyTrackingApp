using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZenMoney.Elements
{
    class Account
    {
        public string Name { get; set; }

        public int Amount { get; set; }

        private readonly string Password;

        public Account(string name, int amount, string password)
        {
            name = Name;
            amount = Amount;
            password = Password;
        }
        public void ChangeAmount (int amount)
        {
            amount = Amount;
        }

        public bool ValidatePassword(string password)
        {
            return password == Password;
        }
        public void DeleteAccount(string name)
        {
            if (name == Name)
            {   
                Name = string.Empty;
                Amount = 0;
            }
            else
            {
                Console.WriteLine($"Account with username {name} was not found or was deleted already");
            }
        }
        
        public void addIncome (int incomeAmount)
        {
            Amount += incomeAmount;
        }
        public void addExpenditures(int expendAmount)
        {
            Amount -= expendAmount;
        }


    }
}
