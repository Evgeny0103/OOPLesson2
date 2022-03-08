using System;

namespace OOP_Lesson2
{
   public class Program
    {
        static void Main(string[] args)
        {
           
            BankAccount d = new BankAccount(4500M, accountType.depositAccounts);
            d.GetShow();
            d.depositMoney(d);






        }
    }
}
