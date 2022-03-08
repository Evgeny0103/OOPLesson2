using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lesson2
{
  public  enum accountType
    {
        current, // Текущий
        correspondent,  // Кореспондентский
        calculated, // Расчетный
        budget,  // Бюджетный
        correspondentsubAccounts, // Кореспондентский суб-счета
        trustManagement, // Доверительного управления 
        special, // Специальные 
        depositAccounts, // Счета по вкладам 

    }

   
    public class BankAccount
    {
        private int _accountNumber; // номер счета 
        private decimal _balance;  // Баланс 
        private accountType _typeOfBankAccount; // Тип банковского счета 

        public int AccountNumber { get { return _accountNumber; } set { _accountNumber = value; } }
        public decimal Balance { get { return _balance; } set { _balance = value; } }
        public accountType TypeOfBankAccount { get { return _typeOfBankAccount; } set { _typeOfBankAccount = value; } }

        public void GetShow() 
        {
            Console.WriteLine("Номер счета " + AccountNumber + 
                " " + "Баланс счета" + " " + Balance + " " + "Тип счета" + " " + TypeOfBankAccount);
        }





    }
}
