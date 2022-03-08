using System;

namespace OOP_Lesson2
{
   public class Program
    {
        static void Main(string[] args)
        {
            BankAccount a = new BankAccount();
            a.GetShow();
            BankAccount b = new BankAccount(4500M);
            b.GetShow();
            BankAccount c = new BankAccount(accountType.budget);
            c.GetShow();
            BankAccount d = new BankAccount(4500M, accountType.depositAccounts);
            d.GetShow();






        }
    }
}
