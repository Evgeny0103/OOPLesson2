using System;

namespace OOP_Lesson2
{
   public class Program
    {
        static void Main(string[] args)
        {
            BankAccount a = new BankAccount();
            a.AccountNumber = 115116;
            a.Balance = 4300.00M;
            a.TypeOfBankAccount = accountType.calculated;
            a.GetShow();

        }
    }
}
