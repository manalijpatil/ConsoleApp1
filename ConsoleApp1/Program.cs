using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public delegate void DisplayMessage();
    public class Program
    {
        static void ZeroBalanceMsg()
        {
            Console.WriteLine("You have zero balance");
        }
        static void InsufficientBalanceMsg()
        {
            Console.WriteLine("You have insufficient Balance");
        }
        static void LowBalanceMsg()
        {
            Console.WriteLine("You have low balance");
        }
        static void Main(string[] args)
        {
            Bank b = new Bank(0);
            b.ZeroBalance += new DisplayMessage(ZeroBalanceMsg);
            b.InsufficientBalance += new DisplayMessage(InsufficientBalanceMsg);
            b.LowBalance += new DisplayMessage(LowBalanceMsg);

            //b.Credit(500);
            b.Debit(2000);
        }
    }
}
