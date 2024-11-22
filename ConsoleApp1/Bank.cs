using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Bank
    {
        //Create a Bank a class, with Debit & Credit method
        //You can assign a default balance using constructor
        //Credit method will accept the amount that needs to be added in balance
        //Debit method will accept the amount that needs to be deducted from the balance.
        //If amount is greater than balance raise an event → insufficient balance
        //If balance is low (< 3000) raise an event low balance
        //If balance is zero then raise an event zero balance

        //event
        public event DisplayMessage ZeroBalance;
        public event DisplayMessage InsufficientBalance;
        public event DisplayMessage LowBalance;
        private double balance;
        public Bank(double balance)
        {
            this.balance = balance;
        }
        public void Debit(double amount)
        {
            if(balance==0)
            {
                ZeroBalance();
            }
            else if (amount > balance)
            {
                InsufficientBalance();
            }
            else if(balance<3000)
            {
                LowBalance();
            }
            else
            {
                balance -= amount;
                Console.WriteLine($"balance={balance}");
            }
        }

      
        public void Credit(double amount)
        {
            if(amount > 0)
            {
                balance += amount;
                Console.WriteLine($"Total Balance = {balance}");
            }

        }
    }
}
