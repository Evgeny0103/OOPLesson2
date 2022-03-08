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
        private static int _accountNumber; // номер счета 
        private decimal _balance;  // Баланс 
        private accountType _typeOfBankAccount; // Тип банковского счета 


        public BankAccount() 
        {
            
        }
        public BankAccount( decimal balance)
        {
            _balance = balance;
            _accountNumber = SetAccountNumber();

        }
        public BankAccount( accountType typeOfBankAccount)
        {
            _typeOfBankAccount = typeOfBankAccount;
            _accountNumber = SetAccountNumber();

        }
        public BankAccount(decimal balance, accountType typeOfBankAccount)
        {
            _balance = balance;
            _typeOfBankAccount = typeOfBankAccount;
            _accountNumber = SetAccountNumber();

        }



        //   public int AccountNumber { get { return SetAccountNumber(_accountNumber); }  }
        //   public decimal Balance { get { return _balance; } set { _balance = value; } }
        //   public accountType TypeOfBankAccount { get { return _typeOfBankAccount; } set { _typeOfBankAccount = value; } }

           public void GetShow() // Метод вывода информации на экран 
           {
                Console.WriteLine("Номер счета " + _accountNumber + 
                   " " + "Баланс счета" + " " + _balance + " " + "Тип счета" + " " + _typeOfBankAccount);
          }


          public  int SetAccountNumber()
         {
             int result;
             Random r = new Random();
             result =  r.Next(100000, 999999);
             return result;
            

          }



    }


}
